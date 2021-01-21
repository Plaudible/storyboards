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
    public class BG : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg1 = layer.CreateSprite("07112915_bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("BGG.jpg", OsbOrigin.Centre);

            bg1.Fade(0,112125,0,0);
            bg2.Fade(0,112125,0,0);

            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);

            bgblur.Fade(719, 1385, 0, 0.6);
            bgblur.Fade(1385, 21219, 0.6, 0.6);
            bgblur.Scale(719, (360.0 / 768)*1);

            bgblur.Fade(21219, 21719, 0.6, 0);
        }
    }
}
