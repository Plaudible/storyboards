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
    
    public class Bubbling : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        public override void Generate()
        {
		    var layer = GetLayer("Main");
            int x = 0;
            for (int i = 0; i <= 4; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Move(StartTime + x, Random(0, 641), Random(40, 441));
                c.Scale(OsbEasing.Out, StartTime + x, StartTime + x + 300, 0, 0.5);
                c.Fade(StartTime + x, StartTime + x + 400, 1, 0);
                x += 147;
            }
        }
    }
}
