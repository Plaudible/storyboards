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
    public class Background : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
		    var bg = layer.CreateSprite("1547097.jpg", OsbOrigin.Centre);
            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var radial = layer.CreateSprite("sb/radial.png", OsbOrigin.Centre);
            bg.Fade(0, 0, 0, 0);
            bg.Scale(0, (360.0 / 768));
            
            bgblur.Fade(0, 22901, 0.75, 0.75);
            bgblur.Scale(0, (360.0 / 768));
            bgblur.Scale(OsbEasing.Out, 7424, 7663, (360.0 / 768), (360.0 / 768)*1.2);

            bgblur.Scale(OsbEasing.In, 20996, 22901, (360.0 / 768)*1.2, (360.0 / 768)*1);

            bgblur.Fade(22901, 23377, 0.75, 0);
            bg.Fade(22901, 23377, 0, 0.9);

            bgblur.Scale(OsbEasing.InOutSine, 22901, 23377, (360.0 / 768), (360.0 / 768)*1.5);
            bg.Scale(OsbEasing.InOutSine,22901, 23377, (360.0 / 768), (360.0 / 768)*1.5);
            bgblur.Move(OsbEasing.InOutSine, 22901, 23377, 320, 240, 260, 350);
            bg.Move(OsbEasing.InOutSine, 22901, 23377, 320, 240, 260, 350);
            bg.Fade(23377, 38139, 0.9, 0.9);
            bg.Move(23377, 36234, 260, 350, 420, 350);
            bg.Fade(38139, 52901, 0.9, 0.9);

            bg.Move(OsbEasing.InOutSine, 36234, 38139, 420, 350, 320, 240);
            bg.Scale(OsbEasing.InOutSine, 36234, 38139 , (360.0 / 768)*1.5, (360.0 / 768));

            //postchorus1
            bg.Fade(52901, 53615, 0.9, 0);
            bgblur.Fade(52901, 53615, 0, 0.75);
            bgblur.Scale(52901, (360.0 / 768));
            bgblur.Move(52901, 320, 240);
            bgblur.Fade(53615,83853, 0.75, 0.75);
            bgblur.Scale(OsbEasing.Out, 68615, 68972, (360.0 / 768), (360.0 / 768)*1.2);
            bgblur.Fade(83853, 83853, 0, 0);
            bgblur.Scale(OsbEasing.InOutExpo, 82901 , 83853, (360.0 / 768)*1.2, (360.0 / 768)*1);

            bg.Fade(83853, 97186, 0.9, 0.9);
            bg.Fade(97186, 99091, 0.9, 0);
            bgblur.Fade(97186, 99091, 0, 0.75);
            bgblur.Scale(97186, (360.0 / 768));
            bgblur.Fade(99091, 112424, 0.75, 0.75);
            bgblur.Fade(112424, 114329, 0.75, 0);
            bg.Fade(112424, 114329, 0, 0.75);
            bg.Fade(114329, 129567, 0.9, 0.9);
            bg.Fade(129567, 131472, 0.9, 0);
            bgblur.Fade(129567, 131472, 0, 0.75);
            bgblur.Fade(131472, 134297, 0.75, 0.75);
        }
    }
}
