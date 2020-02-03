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
    public class Border : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Main");
		    //var border = layer.CreateSprite("sb/whiteHole.png",OsbOrigin.Centre);
            //border.Scale(19228, 600.0 / 720);
            //border.Fade(19228,37228,1,1);
        }
    }
}
