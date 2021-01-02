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
    public class Lightning : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var l1 = layer.CreateSprite("sb/lightning/l1.png", OsbOrigin.Centre);
            var l2 = layer.CreateSprite("sb/lightning/l3.png", OsbOrigin.Centre);
            var l3 = layer.CreateSprite("sb/lightning/l6.png", OsbOrigin.Centre);
            var l4 = layer.CreateSprite("sb/lightning/l7.png", OsbOrigin.Centre);
            var l5 = layer.CreateSprite("sb/lightning/l5.png", OsbOrigin.Centre);

            l1.Move(1713, 180, 248);
            l1.Fade(1713, 2540, 0.25, 0);

            l2.Scale(3575, 1);
            l2.Move(3575, 20, 250);
            l2.Fade(3575, 4402, 0.25, 0);
            l2.Fade(4402, 4802, 0.1, 0);

            l3.Fade(7092, 7920, 0.25, 0);
            l3.Move(7292, 400, 180);

            l4.Fade(10402, 11230, 0.25, 0);
            l4.Move(10402, 600, 215);

            l5.Fade(14126,14954, 0.25, 0);
            l5.Move(14126, 300, 185);
            l5.Fade(14954, 15454, 0.1, 0);

            l2.Fade(15782, 16609, 0.25, 0);

            l3.Fade(26747, 27575, 0.25, 0);

            l4.Fade(68540, 69368, 0.25, 0);
        }
    }
}
