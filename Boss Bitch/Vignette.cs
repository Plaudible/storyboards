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
    public class Vignette : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
		    var vig = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            var blinder = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);

            vig.Fade(0, 134327, 1, 1);
            vig.Scale(0, 0.70);

            blinder.Fade(38139,39567, 0.75, 0);
            blinder.Fade(83853,85282, 0.75, 0);
            blinder.Fade(114329,115758, 0.75, 0);
        }
    }
}
