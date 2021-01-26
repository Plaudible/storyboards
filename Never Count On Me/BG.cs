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
    public class BG : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg1 = layer.CreateSprite("07112915_bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("BGG.jpg", OsbOrigin.Centre);

            bg1.Fade(0,112125,0,0);
            bg2.Fade(0,112125,0,0);

            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);

            bgblur.Fade(719, 1385, 0, 0.6);
            bgblur.Fade(1385, 21219, 0.6, 0.6);
            bgblur.Scale(719, (360.0 / 768)*1);

            bgblur.Fade(21219, 21719, 0.6, 0);

            bgblur.Fade(22052, 22719, 0, 0.8);
            bgblur.Fade(22719, 42052, 0.8, 0.8);
            bgblur.Fade(42052,42052, 0, 0);
            bgblur.Rotate(719, 43052, 0, 0);

            var vig = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vig.Scale(22052, 0.7);
            vig.Fade(22052, 64719, 1, 1);

            var layer2 = GetLayer("Foreground");
            var cover = layer2.CreateSprite("sb/p.png");
            cover.ScaleVec(41385, 1366, 768);
            cover.Fade(41385, 42052, 1, 1);
            cover.Color(41385, 0, 0, 0);

            cover.Move(OsbEasing.In, 41385, 42052, -200, -300, 320, 240);
            cover.Rotate(41385, -0.266162711);

            bgblur.Fade(43052, 43385, 0.5, 0.8);
            bgblur.Fade(43385, 43719, 0.8, 0.75);
            bgblur.Fade(43719, 62052, 0.75, 0.75);
            bgblur.Fade(62052, 63385, 0.75, 0);
            bgblur.Scale(OsbEasing.Out, 43052, 43385, 0, (360.0 / 768)*1.15);
            bgblur.Rotate(OsbEasing.Out, 43052, 43385, 1, 0);
            bgblur.Scale(OsbEasing.OutExpo, 43385, 43719,(360.0 / 768)*1.15, (360.0 / 768)*1);

            var g1 = layer.CreateSprite("sb/bglitch/1.jpg", OsbOrigin.Centre);
            var g2 = layer.CreateSprite("sb/bglitch/2.jpg", OsbOrigin.Centre);
            var g3 = layer.CreateSprite("sb/bglitch/3.jpg", OsbOrigin.Centre);
            var g4 = layer.CreateSprite("sb/bglitch/4.jpg", OsbOrigin.Centre);
            var g5 = layer.CreateSprite("sb/bglitch/5.jpg", OsbOrigin.Centre);
            var g6 = layer.CreateSprite("sb/bglitch/6.jpg", OsbOrigin.Centre);
            var g7 = layer.CreateSprite("sb/bglitch/7.jpg", OsbOrigin.Centre);
            var g8 = layer.CreateSprite("sb/bglitch/8.jpg", OsbOrigin.Centre);

            OsbSprite[] glitch = new OsbSprite[] {g1, g2, g3, g4, g5, g6, g7, g8};

            glitchEffect(glitch, 53719, 8);
            glitchEffect(glitch, 54552, 2);
            glitchEffect(glitch, 55052, 1);

            glitchEffect(glitch, 55552, 4);
            glitchEffect(glitch, 56052, 2);
            glitchEffect(glitch, 56385, 3);

            glitchEffect(glitch, 56719, 4);
            glitchEffect(glitch, 57219, 1);
            glitchEffect(glitch, 57552, 2);

            glitchEffect(glitch, 58219, 6);
            glitchEffect(glitch, 58552, 3);
            glitchEffect(glitch, 59052, 8);

            glitchEffect(glitch, 59719, 3);
            glitchEffect(glitch, 60052, 7);
            glitchEffect(glitch, 60719, 9);
            glitchEffect(glitch, 61385, 3);
            glitchEffect(glitch, 61719, 5);
            glitchEffect(glitch, 62052, 16);
        }
        void glitchEffect(OsbSprite[] glitch, int startTime, int numGlitches){
            for (int i = startTime; i <= startTime + numGlitches * 42; i+=42){
                int glitchSelect = Random(0,8);
                glitch[glitchSelect].Fade(i, i + 42, 0.2, 0.2);
                glitch[glitchSelect].Fade(i+42, i + 42, 0,0);
                glitch[glitchSelect].Scale(i, (360.0 / 768)*1);

            }
        }
    }
}
