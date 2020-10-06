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
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var vig = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);

            bg.Scale(0, (360.0 / 768)*1.335);
            bg.Fade(0,325127,1,1);

            bg.Fade(325127, 325694, 1, 0);

            vig.Fade(0,325127, 0.5, 0.5);
            vig.Fade(325127, 325694, 0.5, 0.5);
            vig.Scale(0,(360.0 / 768)*1.5);
        }
    }
}
