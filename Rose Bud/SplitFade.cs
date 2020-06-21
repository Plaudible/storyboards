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
    public class SplitFade : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var fade = layer.CreateSprite("sb/fade.png", OsbOrigin.Centre);
            var fade2 = layer.CreateSprite("sb/fade.png", OsbOrigin.Centre);
            
            fade.Scale(108039, 1);
            fade.MoveX(108039, 950);
            fade.MoveY(108039, 200);
            fade.Fade(108039, 110309, 0.5, 0.5);
            fade.Fade(110309, 110633, 0.5, 0);

            fade.MoveX(110633, -350);
            fade.Fade(110633, 110795, 0, 0.50);
            fade.Fade(110795, 113066, 0.50, 0.50);
            fade.Fade(113066, 113228, 0.50, 0);
            
            fade.MoveX(113228, 950);
            fade.Fade(113066, 113390, 0, 0.50);
            fade.Fade(113390, 115660, 0.50, 0.50);
            fade.Fade(115660, 115822, 0.50, 0);

            fade.MoveX(115822, -350);
            fade.Fade(115660, 115984, 0, 0.50);
            fade.Fade(115984, 118255, 0.50, 0.50);
            fade.Fade(118255, 118579, 0.50, 0);

            fade.MoveX(310093, 150);
            fade.MoveY(310093, 600);
            fade.Fade(310093, 310417, 0, 0.50);
            fade.Fade(310417, 315281, 0.50, 0.50);
            fade.Fade(315281, 315606, 0.50, 0);

            fade2.MoveY(315444, -100);
            fade2.Fade(315281, 315606, 0, 0.50);
            fade2.Fade(315606, 320471, 0.50, 0.50);
            fade2.Fade(320471, 320802, 0.50, 0);
        }
    }
}
