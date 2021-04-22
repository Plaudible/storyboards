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
            var plainbg = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var vig = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            var blinder = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);

            vig.Fade(0, 79503, 0.7, 0.7);
            vig.Scale(0, 0.67);

            bg.Fade(0,0,0,0);

            plainbg.Fade(OsbEasing.Out, 0, 500, 0, 1);
            plainbg.Color(0, 0.631, 0.929, 0.894);
            plainbg.Fade(500, 28915, 1, 1);
            plainbg.ScaleVec(0, 1366, 768);
            plainbg.Fade(28915, 28915, 0, 0);

            bgblur.Scale(OsbEasing.OutExpo, 28327, 28915, 0,  (360.0 / 768)*1.2);
            bgblur.Move(28327, 46709, 240, 240, 400, 240);
            bgblur.Scale(28915, (360.0 / 768)*1.2);
            bgblur.Scale(OsbEasing.InOutExpo, 29209, 29650, (360.0 / 768)*1.2, (360.0 / 768)*1.5);
            bgblur.Scale(OsbEasing.InOutExpo, 30680,31268, (360.0 / 768)*1.5, (360.0 / 768)*1.2);
            bgblur.Fade(28327, 56562, 1, 1);

            bgblur.Rotate(OsbEasing.OutExpo, 32444, 32886, 0, 0.1);
            bgblur.Scale(OsbEasing.OutExpo, 32444, 32886, (360.0 / 768)*1.2, (360.0 / 768)*1.3);

            bgblur.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.1, 0);
            bgblur.Scale(OsbEasing.InOutExpo, 32886, 33327, (360.0 / 768)*1.3, (360.0 / 768)*1.5);

            bgblur.Scale(OsbEasing.InOutExpo, 35239, 36121, (360.0 / 768)*1.5, (360.0 / 768)*1.2);

            bgblur.Rotate(OsbEasing.OutExpo, 36268, 36562, 0, -0.1);
            bgblur.Scale(OsbEasing.OutExpo, 36268, 36562, (360.0 / 768)*1.2, (360.0 / 768)*1.1);
            bgblur.Rotate(OsbEasing.OutExpo, 36562, 36856, -0.1, 0.1);
            bgblur.Scale(OsbEasing.OutExpo, 36562, 36856, (360.0 / 768)*1.1, (360.0 / 768)*1.5);

            bgblur.Rotate(OsbEasing.InOutExpo, 37739, 38404, 0.1, 0);
            bgblur.Scale(OsbEasing.InOutExpo, 37739, 38404, (360.0 / 768)*1.5, (360.0 / 768)*1.2);

            bgblur.Rotate(OsbEasing.OutExpo, 38621, 39062, 0, -0.1);
            bgblur.Scale(OsbEasing.OutExpo,  38621, 39062, (360.0 / 768)*1.2, (360.0 / 768)*1.3);
            bgblur.Scale(OsbEasing.InOutExpo,  40386, 40900, (360.0 / 768)*1.3, (360.0 / 768)*1.5);

            bgblur.Rotate(OsbEasing.InOutExpo, 42150, 42739, -0.1, 0);
            bgblur.Scale(OsbEasing.InOutExpo,  42150, 42739, (360.0 / 768)*1.5, (360.0 / 768)*1.2);

            bgblur.Rotate(OsbEasing.InOutExpo, 44209,45091, 0, 0.1);
            bgblur.Scale(OsbEasing.InOutExpo,  44209, 45091, (360.0 / 768)*1.2, (360.0 / 768)*1.4);
            bgblur.Scale(OsbEasing.InExpo,  45091, 45386, (360.0 / 768)*1.4, (360.0 / 768)*1.5);

            bgblur.Scale(OsbEasing.InOutExpo, 46709, 47739, (360.0 / 768)*1.5, (360.0 / 768));
            bgblur.Move(OsbEasing.InOutExpo, 46709, 47739, 400, 240, 320, 240);
            bgblur.Rotate(OsbEasing.InOutExpo, 46709, 47739, 0.1, 0);

            blinder.Fade(56562, 57739, 0.75, 0);
            blinder.Fade(57739, 57739, 0, 0);

            blinder.Fade(28327, 28915, 0.75, 0);
            blinder.Fade(28915, 28915, 0, 0);

            bg.Scale(47739, 360.0 / 768);
            bg.Fade(47739, 47739, 0, 0);
            bg.Fade(56962, 61268, 1, 1);
            bg.Fade(61268, 61268, 0, 0);

            bg.Fade(61668, 65974, 1, 1);
            bg.Fade(65974, 65974, 0, 0);

            bg.Fade(66374, 70680, 1, 1);
            bg.Fade(70680, 70680, 0, 0);

            bg.Fade(71080, 75386, 1, 1);
            bg.Fade(75386, 75386, 0, 0);

            bg.Fade(75386, 76562, 1, 0);

            var sinewave = layer.CreateSprite("sb/sinewave.png", OsbOrigin.Centre);
            sinewaver(sinewave, 0, 75386);
        }

        public void sinewaver(OsbSprite wave, int startTime, int endTime){
            var layer = GetLayer("Main");
            OsbSprite wave2 = layer.CreateSprite("sb/sinewave.png", OsbOrigin.Centre);
            wave.Scale(startTime, 0.75);
            wave2.Scale(startTime, 0.75);
            wave.Fade(startTime, startTime, 0.5, 0.5);
            wave2.Fade(startTime, startTime, 0.5, 0.5);
            for (int i = startTime; i <= endTime - 200; i+= 1000){
                wave.Move(i, i+1000, -130, 240, 190, 240);
                wave2.Move(i, i+1000, 510, 240, 830, 240);
            }
            wave.Fade(endTime, endTime, 0, 0);
            wave2.Fade(endTime, endTime, 0, 0);

            if (endTime > 173703){
                wave.Fade(173248, 174157, 0.5, 0);
                wave2.Fade(173248, 174157, 0.5, 0);
            }
        }
    }
}
