 using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class AAAAAARotation : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;
 
        [Configurable]
        public int EndTime = 10000;
        [Configurable]
        public int BarCount = 36;
        [Configurable]
        public float CircleRounds = 1;
        [Configurable]
        public Vector2 Position = new Vector2(-107, 240);
        [Configurable]
        public int CircleRadius = 100;
        [Configurable]
        public double Scale = 0.25;
        [Configurable]
        public bool isBlack = false;
        public override void Generate()
        {
            var circleStep = ((2 * Math.PI) / (BarCount)) * CircleRounds;
            var rotationDegree = (360 / BarCount) * (Math.PI / 180);
            var layer = GetLayer("Spectrum");
            var endTime = Math.Min(EndTime, (int)AudioDuration);
            var startTime = Math.Min(StartTime, endTime);
            double negativer = 1;
		    for (var i = 0; i < BarCount; i++)
            {
                float posX = Position.X + (CircleRadius * (float)Math.Cos(i * circleStep));
                float posY = Position.Y + (CircleRadius * (float)Math.Sin(i * circleStep));
                var bar = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
                if (isBlack){
                    bar.Color(startTime, 0, 0 ,0);
                    //negativer = -1;
                }
                //bar.Rotate(startTime, i * circleStep + (90 * Math.PI / 180));
                bar.Move(startTime, posX, posY);
                bar.Fade(startTime, startTime + 200, 0, 1);
                bar.Fade(endTime - 200, endTime, 1, 0);
                bar.Scale(startTime, Scale);
                //bar.Rotate(startTime, endTime, i * circleStep + (90 * Math.PI / 180), i * circleStep + (90 * Math.PI / 180) + 0.1);
                //bar.Move(startTime, endTime, posX, posY, Position.X + (CircleRadius * (float)Math.Cos((i + negativer) * circleStep)),Position.Y + (CircleRadius * (float)Math.Cos((i + negativer)* circleStep)));
                bar.Move(startTime, endTime, posX, posY, Position.X + (CircleRadius * (float)Math.Cos((i + negativer) * circleStep)),Position.Y + (CircleRadius * (float)Math.Cos((i + negativer)* circleStep)));
            }
        }
    }
}
