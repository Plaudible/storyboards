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
    public class Sidebars : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public int BeatDivisor = 8;

        [Configurable]
        public int FadeTime = 200;

        [Configurable]
        public string SpritePath = "sb/glow.png";

        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bar1 = layer.CreateSprite(SpritePath, OsbOrigin.Centre);
            var bar2 = layer.CreateSprite(SpritePath, OsbOrigin.Centre);

            bar1.Fade(StartTime, EndTime, 1, 1);
            bar1.ScaleVec(StartTime, 1, 10);

            bar1.Rotate(StartTime, -1.3);

            bar1.Move(OsbEasing.OutExpo, StartTime, StartTime + 900, 0, 640, 120, 380);
        }
    }
}
