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
    public class RebootWarning : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime;

        [Configurable]
        public int EndTime;
        public override void Generate()
        {
            var layer = GetLayer("Main");
            var warning1 = layer.CreateSprite("sb/warning.png", OsbOrigin.Centre);
            var warning2 = layer.CreateSprite("sb/warning.png", OsbOrigin.Centre);

            warning1.Move(43385, 90, 210);
            warning2.Move(43385, 545, 210);
            warning1.Scale(43385, 0.05);
            warning2.Scale(43385, 0.05);

            warning1.Color(43385, 0.6, 0 ,0);
            warning2.Color(43385, 0.6, 0, 0);

            for(int i = StartTime; i<= EndTime; i+= 1334){
                warning1.Fade(i, i+667,0, 0.5);
                warning2.Fade(i, i+667, 0, 0.5);
                warning1.Fade(i+667, i+1334, 0.5, 0);
                warning2.Fade(i+667, i+1334, 0.5, 0);
                
            }

            warning1.Move(54052, 200, 210);
            warning2.Move(54052, 440, 210);

            var ring = layer.CreateSprite("sb/ring.png", OsbOrigin.Centre);
            ring.Fade(43385, 62719, 1, 1);
            ring.Scale(43385, 0.2);
            ring.Rotate(43385, 63385, 0, 10);
            ring.Move(43385, 320, 300);
            ring.Fade(62719, 63385, 1, 0);
        }
    }
}
