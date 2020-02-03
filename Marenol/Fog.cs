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
    public class Fog : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("sb/Fog.png", OsbOrigin.Centre);
            bg.Scale(0, 480.0 / 768);
            bg.Fade(0,1700,0.25,0.25);
            bg.Fade(1700, 1764, 0.25, 1);
            bg.Fade(3478, 3520, 1, 1);
        }
    }
}
