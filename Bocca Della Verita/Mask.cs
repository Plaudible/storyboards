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
    public class Mask : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var glow = layer.CreateSprite("sb/bgglow.png", OsbOrigin.Centre);
            var mask = layer.CreateSprite("sb/mask.png", OsbOrigin.Centre);
            var mask2 = layer.CreateSprite("sb/mask.png", OsbOrigin.Centre);

            glow.Scale(60118, 7);
            glow.Rotate(60118, 71412, 0, 5);
            glow.Fade(60118, 71412, 0.25, 0.25);
            glow.Color(60118, 0.295, 0, 0.51);
            glow.Fade(71412, 71412, 0, 0);

            mask.Fade(60118, 60118, 0, 0);
            mask.Fade(60118, 71412, 1, 1);
            mask.Scale(OsbEasing.InOutExpo, 59941, 60294, (360.0 / 768), (360.0 / 768)*1.4);
            mask.Rotate(OsbEasing.InOutExpo, 59941, 60294, 0, 0.15);
            mask.Move(60118, 320, 240);
            mask.Move(60294, 71412, 320, 240, 280, 260);
            mask.Fade(71412, 71412, 0, 0);

            //CHORUS 1
            mask.Scale(105294, 0.65);
            mask.Rotate(105294, 0.15);
            mask.Fade(105294, 116588, 1, 1);
            mask.Move(105294,116588, 450, 240, 360, 240);
            glow.Rotate(105294, 116588, 0, 5);
            glow.Fade(105294, 116588, 0.25, 0.25);
            glow.Fade(116588, 116588, 0, 0);

            //CHORUS 2
            glow.Rotate(150823, 175882, 0, 10);
            glow.Fade(150823, 175882, 0.25, 0.25);
            mask2.Scale(149059, (360.0 / 768*1.0));
            mask2.Fade(149059, 150471, 0, 0.1);
            mask2.Fade(150471, 150823, 0.1, 0.1);
            mask2.Fade(150823, 175882, 0.9, 0.9);
            mask2.Scale(OsbEasing.InOutExpo, 150735, 151000, (360.0 / 768*1.0), (360.0 / 768*1.35));
            mask2.Rotate(OsbEasing.InOutExpo, 150735, 151000, 0, 0.15);
            mask2.Move(OsbEasing.InOutExpo, 150735, 151000, 320, 240, 160, 240);
            mask2.Move(151000, 175882, 160, 240, 320, 240);

        }
    }
}
