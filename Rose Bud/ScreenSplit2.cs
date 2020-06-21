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
    public class ScreenSplit2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var block = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            block.Color(271498,0,0,0);
            block.Scale(271498, 0.75);
            block.MoveY(271498, 200);
            block.MoveX(OsbEasing.InOutExpo, 271336, 271822, 1340, 840);
            block.Fade(271498, 242957, 1, 1);
            block.MoveX(OsbEasing.InOutExpo, 289498, 289984, 840, 1340);
            
        }
    }
}
