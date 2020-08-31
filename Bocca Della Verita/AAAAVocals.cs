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
    public class AAAAVocals : StoryboardObjectGenerator
    {
        [Configurable]
         public int StartTime = 0;

         [Configurable]
        public int EndTime = 0;
        public override void Generate()
        {
		    var layer = GetLayer("Main");
		    var lyric = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric2 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric3 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric4 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric5 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric6 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric7 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);
            var lyric8 = layer.CreateSprite("sb/f/3042.png", OsbOrigin.Centre);

            var list = new[] {lyric, lyric2, lyric3, lyric4, lyric5, lyric6, lyric7, lyric8}.ToList();

            Random rand = new Random();
            int TimeBuffer = 0;

            foreach (var item in list){
                double randScale = rand.NextDouble() * (1 - 0.2) + 0.2;
                int randX = rand.Next(0, 740);
                int randY = rand.Next(100,400);
                if (TimeBuffer != 708){
                item.Scale(StartTime, randScale);
                item.Color(StartTime, 0, 0, 0);
                item.Fade(StartTime + TimeBuffer, StartTime + TimeBuffer + 400, 1, 1);
                item.Fade(StartTime + TimeBuffer + 400, StartTime + TimeBuffer + 600, 1, 0);
                item.Move(OsbEasing.Out, StartTime + TimeBuffer - 100, StartTime + TimeBuffer + 100, randX, 600, randX, randY);
                item.Move(StartTime + TimeBuffer + 200, StartTime + TimeBuffer + 600, randX, randY, randX, randY - 10);
                }
                TimeBuffer += 177;
            }
        }
    }
}
