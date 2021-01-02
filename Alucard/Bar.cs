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
    public class Bar : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bar = layer.CreateSprite("sb/bf.png", OsbOrigin.Centre);
            
            bar.Fade(0,885, 0, 1);
            bar.Rotate(0, -1.5708);
            bar.Move(0, 40, 400);
            bar.Scale(0, 0.75);
            bar.Fade(885,111898, 1, 1);
            bar.Fade(111898, 112231, 1, 0);

            bar.Move(133231, 580, 400);
            bar.Fade(133231, 457064, 1, 1);
            bar.Fade(457064, 457564, 1, 0);
        }
    }
}
