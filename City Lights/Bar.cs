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
    public class Bar : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Main");
            var bar = layer.CreateSprite("sb/bar.png", OsbOrigin.Centre);
            //intro bar
            bar.Fade(0, 269, 0, 1);
            bar.Fade(269, 21268, 1, 1);
            bar.Scale(0, 0.5);
            bar.Rotate(0, 3.14159);
            bar.Move(0,-20,420);
            bar.Fade(21268, 24268, 1, 0);
            //post-chorus bar
            bar.Fade(72268, 73768, 0, 1);
            bar.Fade(73768, 95893, 1, 1);
            bar.Fade(95893, 96268, 1, 0);
            //post-breakdown bar
            bar.Fade(144268, 145768, 0, 1);
            bar.Fade(145768, 155893, 1, 1);
            bar.Fade(155893, 156268, 1, 0);
            //final bar
            bar.Fade(192268, 192456, 0, 1);
            bar.Fade(192456, 216268, 1, 1);
            bar.Fade(216268, 216456, 1, 0);
        }
    }
}
