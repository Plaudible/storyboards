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
    public class Bg : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bgsplit = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("sb/bg2.jpg", OsbOrigin.Centre);
            var vig = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            var split1 = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var split2 = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var blinder = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            bg.Scale(144231, (360.0 / 768)*1);
            bg.Fade(144231, 250564, 0.75, 0.75);
            bg.Fade(250564, 251064, 0.75, 0.35);
            bg.Fade(251064, 261231, 0.35, 0.35);
            bg.Fade(261231, 411731, 0.75, 0.75);
            bg.Fade(411731, 412064, 0.75, 0.35);
            bg.Fade(412064, 422564, 0.35, 0.35);
            bg.Fade(422564, 457064, 0.75, 0.75);
            bg.Fade(457064, 457564, 0.75, 0);

            bg2.Scale(0, (360.0 / 768)*1);
            bg2.Fade(0, 885, 0, 0.4);
            bg2.Fade(885, 111898, 0.4, 0.4);
            bg2.Scale(OsbEasing.InOutExpo, 111231, 111898, (360.0 / 768)*1, (360.0 / 768)*1.2);
            bg2.Scale(OsbEasing.Out, 111898, 112564, (360.0 / 768)*1.2 , (360.0 / 768)*0.9);
            bg2.Fade(111898, 112564, 0.4, 0);

            vig.Fade(0, 122564, 0.75, 0.75);
            vig.Scale(0, 0.70);

            blinder.Fade(1713, 2540, 0.25, 0);

            blinder.Fade(3575, 4402, 0.25, 0);
            blinder.Fade(4402, 4802, 0.1, 0);
            blinder.Fade(7092, 7920, 0.25, 0);
            blinder.Fade(10402, 11230, 0.25, 0);
            blinder.Fade(14126,14954, 0.25, 0);
            blinder.Fade(14954, 15454, 0.1, 0);
            blinder.Fade(15782, 16609, 0.25, 0);
            blinder.Fade(26747, 27575, 0.25, 0);
            blinder.Fade(68540, 69368, 0.25, 0);

            blinder.Fade(OsbEasing.In, 121564, 122564, 0, 0.5);
            blinder.Fade(OsbEasing.Out, 122564, 125231, 1, 0);

            //ALUCARD

            split1.Fade(122564, 133231, 1, 1);
            split1.Fade(133231, 133231, 0, 0);
            split2.Fade(122564, 133231, 1, 1);
            split2.Fade(133231, 133231, 0, 0);

            split1.Color(122564, 0, 0, 0);
            split2.Color(122564, 0, 0, 0);

            split1.Move(OsbEasing.Out, 122564, 123231, 0, 240, 320, -260);
            split2.Move(OsbEasing.Out, 122564, 123231, 320, 240, 320, 680);

            split1.Rotate(122564, 0.1);
            split2.Rotate(122564, 0.1);

            bgsplit.Fade(122574, 143898, 0.75, 0.75);
            bgsplit.Scale(122574, (360.0 / 768)*1.2);
            bgsplit.Rotate(122574, 0.2);
            bgsplit.Move(122574, 127898, 320, 150, 260, 140);

            split1.Rotate(OsbEasing.Out, 127898, 128231, 0.1, -0.1);
            split2.Rotate(OsbEasing.Out, 127898, 128231, 0.1, -0.1);
            split1.Move(OsbEasing.Out, 127898, 128231, 320, -260, 320, -240);
            split2.Move(OsbEasing.Out, 127898, 128231, 320, 680, 320, 700);

            bgsplit.Rotate(OsbEasing.Out, 127898, 128231, 0.2, 0);
            bgsplit.Move(OsbEasing.Out, 127898, 128231, 260, 140, 210, 350);
            bgsplit.Move(128231, 132731, 210, 350, 270, 340);

            blinder.Fade(127898, 129231, 0.75, 0);

            split1.Move(OsbEasing.In, 132898, 133314, 320, -240, 320, -840);
            split2.Move(OsbEasing.In, 132898, 133314, 320, 700, 320, 1300);

            bgsplit.Move(OsbEasing.InOutExpo, 132898,133564, 270, 340, 450, 300);
            bgsplit.Scale(OsbEasing.InOutExpo,  132898,133564, (360.0 / 768)*1.2, (360.0 / 768)*1.4);
            bgsplit.Rotate(OsbEasing.InOutExpo,  132898,133564, 0, -0.1);

            bgsplit.Move(133564, 143564, 450, 300, 400, 300);
            blinder.Fade(133231,134231, 0.75, 0);

            bgsplit.Move(OsbEasing.InOutExpo, 143564,144231, 400, 300, 320, 240);
            bgsplit.Scale(OsbEasing.InOutExpo,  143564,144231, (360.0 / 768)*1.4, (360.0 / 768)*1);
            bgsplit.Rotate(OsbEasing.InOutExpo,  143564,144231, -0.1, 0);

            blinder.Fade(143898,144898, 0.75, 0);

            bg.Scale(OsbEasing.InOutExpo, 175731, 176064, (360.0 / 768)*1, (360.0 / 768)*1.3);
            bg.Rotate(OsbEasing.InOutExpo, 175731, 176064, 0, 0.15);

            blinder.Fade(175898,176898, 0.75, 0);

            bg.Move(176064, 197064, 320, 240, 280, 240);

            blinder.Fade(165231,166231, 0.75, 0);

            bg.Scale(OsbEasing.InOutExpo, 197064, 197398, (360.0 / 768)*1.3, (360.0 / 768)*1);
            bg.Rotate(OsbEasing.InOutExpo, 197064, 197398, 0.15, 0); 
            bg.Move(OsbEasing.InOutExpo, 197064, 197398, 280, 240, 320, 240);

            blinder.Fade(207898,208898, 0.75, 0);

            blinder.Fade(261231,262231, 0.75, 0);

            blinder.Fade(283898,284898, 0.75, 0);

            blinder.Fade(229231,230231, 0.75, 0);

            bg.Scale(OsbEasing.InOutExpo, 229064, 229398, (360.0 / 768)*1, (360.0 / 768)*1.4);
            bg.Rotate(OsbEasing.InOutExpo, 229064, 229398, 0, 0.1);
            bg.Move(229398, 250398, 320, 240, 280, 240);

            bg.Scale(OsbEasing.InOutExpo, 250398, 250731, (360.0 / 768)*1.4, (360.0 / 768)*1);
            bg.Rotate(OsbEasing.InOutExpo, 250398, 250731, 0.1, 0); 
            bg.Move(OsbEasing.InOutExpo, 250398, 250731, 280, 240, 320, 240);

            bg.Scale(OsbEasing.InOutExpo, 261064, 261398, (360.0 / 768)*1, (360.0 / 768)*2);
            bg.Move(OsbEasing.InOutExpo, 261064, 261398, 320, 240, 220, 400);
            bg.Move(261398, 283731, 220, 400, 320, 400);
            bg.Scale(283898, (360.0 / 768)*1.8);
            bg.Move(283898, 294231, 200, 300, 200, 400);

            bg.Scale(OsbEasing.InOutExpo, 294231, 294898, (360.0 / 768)*1.8, (360.0 / 768)*1);
            bg.Move(OsbEasing.InOutExpo, 294231, 294898, 200, 400, 320, 240);

            blinder.Fade(294564,295564, 0.75, 0);

            blinder.Fade(315898,316898, 0.75, 0);

            blinder.Fade(347898,348898, 0.75, 0);

            bg.Scale(OsbEasing.InOutExpo, 390398, 390731, (360.0 / 768)*1, (360.0 / 768)*1.4);
            bg.Rotate(OsbEasing.InOutExpo, 390398, 390731, 0, 0.1);
            bg.Move(390731, 411731, 320, 240, 280, 240);

            bg.Scale(OsbEasing.InOutExpo, 411731, 412064, (360.0 / 768)*1.4, (360.0 / 768)*1);
            bg.Rotate(OsbEasing.InOutExpo, 411731, 412064, 0.1, 0); 
            bg.Move(OsbEasing.InOutExpo, 411731, 412064, 280, 240, 320, 240);

            blinder.Fade(422564,423564, 0.75, 0);

            bg.Scale(OsbEasing.InOutExpo, 422231, 422898, (360.0 / 768)*1, (360.0 / 768)*2);
            bg.Move(OsbEasing.InOutExpo, 422231, 422898, 320, 240, 220, 400);
            bg.Move(422898, 445231, 220, 400, 320, 400);
            bg.Scale(445231, (360.0 / 768)*1.8);
            bg.Move(445231, 455898, 200, 300, 200, 400);

            bg.Scale(OsbEasing.InOutExpo, 455898, 456231, (360.0 / 768)*1.8, (360.0 / 768)*1);
            bg.Move(OsbEasing.InOutExpo, 455898, 456231, 200, 400, 320, 240);

            blinder.Fade(445231,446231, 0.75, 0);
            blinder.Fade(455898,456898, 0.75, 0);
            blinder.Fade(379898,380898, 0.75, 0);
        }
    }
}
