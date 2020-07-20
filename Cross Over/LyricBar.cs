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
    public class LyricBar : StoryboardObjectGenerator
    {
        [Configurable]
        public string ImagePath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;
        public override void Generate()
        {
		    var img = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            img.Fade(StartTime, EndTime, 1, 1);
            img.MoveY(OsbEasing.Out, StartTime - 200, StartTime + 200, 700, 440);
            img.Rotate(StartTime, 1.57);
            img.ScaleVec(OsbEasing.Out, StartTime, StartTime + 300, 0, 1, 0.04, 3);
            img.ScaleVec(OsbEasing.In, StartTime + 300, EndTime, 0.04, 3, 0.02, 4);

            

            
        }
    }
}
