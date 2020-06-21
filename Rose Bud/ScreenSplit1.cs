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
    public class ScreenSplit1 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var block = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            block.Color(224714,0,0,0);
            block.Scale(224714, 0.75);
            block.MoveY(224714, 200);
            block.MoveX(OsbEasing.InOutExpo, 224795, 225120, -700, -200);
            block.Fade(224714, 242957, 1, 1);
            block.MoveX(OsbEasing.InOutExpo, 242876, 243282, -200, -700);
            
        }
    }
}
