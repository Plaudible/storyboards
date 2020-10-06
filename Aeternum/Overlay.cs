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
    public class Overlay : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            bg.Color(275328, 0, 0, 0);
            bg2.Color(288328, 1, 1, 1);
            bg2.ScaleVec(288328, 35, 5);
            bg.Fade(275328, 275928, 0,1);
            bg.Fade(275928,288328, 1, 1);
            bg2.Fade(288328, 289528, 0.5, 0);
        }
    }
}
