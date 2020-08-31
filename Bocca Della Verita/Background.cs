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
		    var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg3 = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg4 = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var bgblur2 = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var bgalt = layer.CreateSprite("sb/bgalt.jpg", OsbOrigin.Centre);
            var bgalthead = layer.CreateSprite("sb/bgalthead.png", OsbOrigin.Centre);
            var vignette = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            
            bg.Fade(0, 0, 0, 0);
            bgblur.Scale(823, (360.0 / 768*1.2));
            bgblur.Fade(823, 1882, 1, 0.75);
            bgblur.Fade(1882, 12118, 0.75, 0.75);
            bgblur.MoveY(823, 12118, 200, 240);
            bgblur.MoveX(823, 320);
            bgblur.Scale(OsbEasing.In, 11765, 12118, (360.0 / 768*1.2), (360.0 / 768*1.5));
            bgblur.Fade(12118, 12118, 0, 0);

            bgalt.Scale(12118, (360.0 / 768*1.0));
            bgalt.Fade(12118, 12471, 0, 0.8);
            bgalt.Fade(12471, 23412, 0.8, 0.8);
            bgalthead.Scale(12118, (360.0 / 768*1.0));
            bgalthead.Fade(12118, 12471, 0, 0.8);
            bgalthead.Fade(12471, 23412, 0.8, 0.8);

            for(int i = 12118; i < 22412; i += 1411){
                bgalthead.Rotate(i + 529, i+ 579, 0, 0.2);
                bgalthead.Rotate(i+579, i+629, 0.2, 0);
                bgalthead.Rotate(i + 705, i+ 755, 0, 0.2);
                bgalthead.Rotate(i+755, i+805, 0.2, 0);
                bgalthead.Rotate(i + 1411, i + 1461, 0, -0.2);
                bgalthead.Rotate(i + 1461, i+ 1511, -0.2, 0);
            }
            bgalthead.Fade(23412, 23412, 0, 0);
            bgalt.Fade(23412, 23412, 0, 0);

            vignette.Fade(12118, 23412, 1, 1);
            vignette.Scale(12118, (360.0 / 768)*1.5);
            vignette.Fade(23412, 23412, 0, 0);
            //BRIDGE 1
            bgblur.Fade(26235, 27294, 0, 0.75);
            bgblur.Fade(27294 ,71412, 0.75, 0.75);
            bgblur.Scale(26235, (360.0 / 768));
            bgblur.Move(26235, 320, 240);
            bgblur.Fade(48823, 60118, 0.75, 0);
            bg.Fade(48823, 60118, 0, 0.75);
            bg.Scale(48823, (360.0 / 768));
            bg.Fade(60118, 71412, 0.9, 0.9);
            bg.Move(59765, 60294, 320, 240, 320, 240);
            bg.Scale(OsbEasing.InOutExpo, 59941, 60294, (360.0 / 768), (360.0 / 768)*1.4);
            bg.Rotate(OsbEasing.InOutExpo, 59941, 60294, 0, 0.15);
            bg.Move(60294, 71412, 320, 240, 280, 260);
            //CHORUS 1

            //POSTCHORUS1
            bgalt.Fade(71412, 71765, 0, 0.8);
            bgalt.Fade(71765, 82706, 0.8, 0.8);
            bgalthead.Fade(71412, 71765, 0, 0.8);
            bgalthead.Fade(71765, 82706, 0.8, 0.8);

            for(int i = 71412; i < 82706; i += 1411){
                bgalthead.Rotate(i + 529, i+ 579, 0, 0.2);
                bgalthead.Rotate(i+579, i+629, 0.2, 0);
                bgalthead.Rotate(i + 705, i+ 755, 0, 0.2);
                bgalthead.Rotate(i+755, i+805, 0.2, 0);
                bgalthead.Rotate(i + 1411, i + 1461, 0, -0.2);
                bgalthead.Rotate(i + 1461, i+ 1511, -0.2, 0);
            }
            bgalt.Fade(82706, 82706, 0, 0);
            bgalthead.Fade(82706, 82706, 0, 0);

            vignette.Fade(71412, 82706, 1, 1);
            vignette.Fade(82706, 82706, 0, 0);
            //BRIDGE 2
            bgblur.Fade(82706, 83059, 0, 0.75);
            bgblur.Fade(83059 ,98941, 0.75, 0.75);
            bgblur.Fade(98941, 99647, 0.75, 0);
            bg2.Fade(98941, 99647, 0, 0.75);
            bg2.Scale(98941, 360.0 / 768);
            //PRECHORUS 2
            bgblur.Rotate(OsbEasing.InOutExpo, 98941, 99647, 0, 0.25);
            bg2.Rotate(OsbEasing.InOutExpo, 98941, 99647, 0, 0.25);
            bgblur.Scale(OsbEasing.InOutExpo, 98941, 99647, 360.0 / 768, (360.0/768)*1.5);
            bg2.Scale(OsbEasing.InOutExpo, 98941, 99647, 360.0 / 768, (360.0/768)*1.5);
            bg2.Fade(99647, 100000, 0.3, 0.2);
            bg2.Fade(100000, 105294, 0.75, 0.75);
            bg2.Scale(OsbEasing.Out, 99647, 100000, (360.0/768)*1.5, (360.0/768)*1.35);
            bg2.MoveX(100000, 105294, 320, 305);
            bg2.Rotate(OsbEasing.InOutSine, 102471, 104235, 0.25, 0);
            bg2.Scale(OsbEasing.InOutSine, 102471, 104235, (360.0/768)*1.35, (360.0/768)*1.1);
            //CHORUS 2
            bg3.Fade(105294, 116588, 1, 1);
            bg3.Scale(105294, 0.65);
            bg3.Rotate(105294, 0.15);
            bg3.Move(105294,116588, 450, 240, 360, 240);

            //POSTCHORUS2
            //POSTCHORUS1
            bgalt.Fade(116588, 116941, 0, 0.8);
            bgalt.Fade(116941, 127882, 0.8, 0.8);
            bgalthead.Fade(116588, 116941, 0, 0.8);
            bgalthead.Fade(116941, 127882, 0.8, 0.8);

            for(int i = 116588; i < 127882; i += 1411){
                bgalthead.Rotate(i + 529, i+ 579, 0, 0.2);
                bgalthead.Rotate(i+579, i+629, 0.2, 0);
                bgalthead.Rotate(i + 705, i+ 755, 0, 0.2);
                bgalthead.Rotate(i+755, i+805, 0.2, 0);
                bgalthead.Rotate(i + 1411, i + 1461, 0, -0.2);
                bgalthead.Rotate(i + 1461, i+ 1511, -0.2, 0);
            }
            bgalt.Fade(127882, 127882, 0, 0);
            bgalthead.Fade(127882, 127882, 0, 0);
            vignette.Fade(116588, 127882, 1, 1);
            vignette.Fade(127882, 127882, 0, 0);

            bgblur2.Fade(127882, 139176, 0.75, 0.75);
            bgblur2.Scale(127882, (360.0 / 768)*1.2);
            bgblur2.Scale(OsbEasing.InOutExpo, 139000, 139529, (360.0 / 768)*1.2, (360.0 / 768)*1.0);
            bgblur2.Fade(139000, 139529, 0.75, 0.5);
            bgblur2.Fade(139529, 149059, 0.5, 0.5);
            bgblur2.Fade(149059, 150471, 0.5, 0);
            //CHORUS 3
            bg4.Scale(149059, (360.0 / 768*1.0));
            bg4.Fade(149059, 150471, 0, 0.75);
            bg4.Fade(150471, 150823, 0.75, 0.25);
            bg4.Fade(150823, 175882, 0.9, 0.9);
            bg4.Scale(OsbEasing.InOutExpo, 150735, 151000, (360.0 / 768*1.0), (360.0 / 768*1.35));
            bg4.Rotate(OsbEasing.InOutExpo, 150735, 151000, 0, 0.15);
            bg4.Move(OsbEasing.InOutExpo, 150735, 151000, 320, 240, 160, 240);
            bg4.Move(151000, 175882, 160, 240, 320, 240);
            //ENDING
            bgalt.Fade(175882, 176235, 0, 0.8);
            bgalt.Fade(176235, 198471, 0.8, 0.8);
            bgalthead.Fade(175882, 176235, 0, 0.8);
            bgalthead.Fade(176235, 198471, 0.8, 0.8);

            for(int i = 175882; i < 198471; i += 1411){
                bgalthead.Rotate(i + 529, i+ 579, 0, 0.2);
                bgalthead.Rotate(i+579, i+629, 0.2, 0);
                bgalthead.Rotate(i + 705, i+ 755, 0, 0.2);
                bgalthead.Rotate(i+755, i+805, 0.2, 0);
                bgalthead.Rotate(i + 1411, i + 1461, 0, -0.2);
                bgalthead.Rotate(i + 1461, i+ 1511, -0.2, 0);
            }
            bgalthead.Fade(198471, 198471, 0, 0);
            vignette.Fade(175882, 198471, 1, 1);
            vignette.Fade(198471, 198471, 0, 0);
        }
    }
}
