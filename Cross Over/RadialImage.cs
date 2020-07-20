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
    public class RadialImage : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var rad = GetLayer("").CreateSprite("sb/radial.png", OsbOrigin.Centre);
            var radred = GetLayer("").CreateSprite("sb/radial.png", OsbOrigin.Centre);
            var radblue = GetLayer("").CreateSprite("sb/radial.png", OsbOrigin.Centre);
            rad.Fade(10180, 29380, 1, 1);
            rad.Fade(29380, 29380, 0, 0);
            rad.Scale(10180, 0.33);

            rad.Fade(87580, 106180, 1, 1);
            rad.Fade(106180, 106180, 0, 0);

            rad.Fade(125380, 144580, 1, 1);
            rad.Fade(144580, 144580, 0, 0);
        }
    }
}
