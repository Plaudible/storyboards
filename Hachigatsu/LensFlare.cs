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
    
    public class LensFlare : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        [Configurable] 
        public int EndTime = 0;
        public override void Generate()
        {
		    var flare = GetLayer("").CreateSprite("sb/flare.png", OsbOrigin.Centre);
            flare.Fade(StartTime, EndTime, 0.25, 0.25);
            flare.Scale(StartTime, 0.5);
            flare.Rotate(StartTime, 0.5);
            flare.Move(StartTime, 205, 185);
            flare.Rotate(StartTime, StartTime+19091, 0.5, 0.75);
            flare.Move(StartTime, StartTime + 19364, 205, 185, 180, 145);

            flare.Scale(OsbEasing.Out, StartTime+19091, StartTime + 19364, 0.5, 0.55);
            flare.Rotate(OsbEasing.Out, StartTime+19091, StartTime + 19364, 0.75, 0.85);
            flare.Scale(OsbEasing.InOutExpo, StartTime + 19364, StartTime + 19774, 0.55, 0.5);
            flare.Rotate(OsbEasing.InOutExpo, StartTime + 19364, StartTime + 19774, 0.85, 0.65);
            flare.Move(OsbEasing.InOutExpo, StartTime + 19364, StartTime + 19774, 180, 145, 140, 160);
            flare.Fade(EndTime, EndTime, 0, 0);
        }
    }
}
