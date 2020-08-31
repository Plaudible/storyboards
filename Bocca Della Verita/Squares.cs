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
    public class Squares : StoryboardObjectGenerator
    {
        [Configurable]
         public int StartTime = 0;

         [Configurable]
        public int EndTime = 0;

        public override void Generate()
        {
            var layer = GetLayer("Main");

		    var square1 = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            var square2 = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            var square3 = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);


            square1.Fade(StartTime, EndTime, 0.5,0.5);
            square1.Scale(StartTime, 0.05);
            square1.Color(StartTime, 0.295, 0, 0.51);
            square1.Rotate(StartTime, EndTime, 0, 10);
            square1.Move(StartTime, 560, 140);

            square2.Fade(StartTime, EndTime, 0.5,0.5);
            square2.Scale(StartTime, 0.12);
            square2.Color(StartTime, 0.295, 0, 0.51);
            square2.Rotate(StartTime, EndTime, 0, 10);
            square2.Move(StartTime, 560, 200);

            square3.Fade(StartTime, EndTime, 0.5,0.5);
            square3.Scale(StartTime, 0.20);
            square3.Color(StartTime, 0.295, 0, 0.51);
            square3.Rotate(StartTime, EndTime, 0, 10);
            square3.Move(StartTime, 560, 312);

            square1.Fade(EndTime, EndTime, 0, 0);
            square2.Fade(EndTime, EndTime, 0, 0);
            square3.Fade(EndTime, EndTime, 0, 0);
        }
    }
}
