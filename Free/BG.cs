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
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var plainbg = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);

            bg.Fade(0, 15067, 0, 0);
            plainbg.Fade(OsbEasing.InExpo, 0, 587, 0, 1);
            plainbg.Fade(587,15067,1,1);
            plainbg.Color(0, 0.672, 0.8176, 0.8804);
            plainbg.Scale(OsbEasing.InExpo, 0, 522, (360.0 / 768)*1, (360.0 / 768)*1.42);
            plainbg.Scale(522,15067, (360.0 / 768)*1.42, (360.0 / 768)*1.42);

            bg.Fade(15067,29612, 1, 1);
            bg.Scale(15067, (360.0 / 768)*1);

            var layer2 = GetLayer("Foreground");
            var blinder = layer2.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var vignette = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette.Fade(0, 174157, 0.6, 0.6);
            vignette.Scale(0, 0.75);
            blinder.Fade(15067, 15976, 0.75, 0);
            blinder.Fade(15976, 15976, 0, 0);

            bg.Scale(OsbEasing.OutExpo, 15067, 15522, (360.0 / 768)*1, (360.0 / 768)*1.2);
            bg.Move(15067, 29158, 320, 240, 440, 240);

            bg.Scale(OsbEasing.In, 29158, 29612, (360.0 / 768)*1.2, (360.0 / 768)*1.0);
            bg.Move(OsbEasing.Out, 29158, 29612, 440, 240, 320, 240);
            bg.Fade(29612,29612, 0, 0); 
            plainbg.Fade(15067, 15067, 0, 0);
            plainbg.Fade(29612, 43817, 1, 1); 

            blinder.Fade(29612, 30521, 0.75, 0);
            blinder.Fade(30521, 30521, 0, 0);

            plainbg.Fade(OsbEasing.InExpo, 43817, 44385, 1, 0);
            bg2.Fade(44158, 73249, 1, 1);
            bg2.Scale(OsbEasing.OutExpo, 44158, 44612, (360.0 / 768)*1.50, (360.0 / 768)*1.2);

            blinder.Fade(44158, 45067, 0.75, 0);
            blinder.Fade(45067, 45067 , 0, 0);

            //CHORUS
            bg2.Move(44158, 72794, 320, 240, 440, 240);
            bg2.Scale(OsbEasing.OutExpo, 58703, 59158,(360.0 / 768)*1.2, (360.0 / 768)*1);

            blinder.Fade(58703, 59612, 0.75, 0);
            blinder.Fade(59612, 59612 , 0, 0);

            blinder.Fade(51431, 52340, 0.75, 0);
            blinder.Fade(52340, 52340 , 0, 0);

            //POSTCHORUS1
            bg2.Scale(OsbEasing.Out, 72575,72794, (360.0 / 768)*1, (360.0 / 768)*1.5);
            bg2.Scale(OsbEasing.InExpo, 72794, 73249, (360.0 / 768)*1.5, (360.0 / 768)*1.0);
            bg2.Move(OsbEasing.Out, 72794, 73249, 440, 240, 320, 240);
            bg2.Rotate(OsbEasing.Out, 72567, 72908, 0, 0.2);
            bg2.Rotate(OsbEasing.In, 73022, 73249, 0.2, 0);
            bg2.Fade(73249, 73249, 0, 0);

            plainbg.Fade(73249, 88703, 1, 1);
            plainbg.Scale(73249, 1);
            plainbg.Fade(88703, 88703, 0, 0);

            blinder.Fade(73249, 74158, 0.75, 0);
            blinder.Fade(74158, 74158 , 0, 0);

            //CHORUS2
            bg2.Fade(73249, 73249, 0, 0);
            bg2.Fade(88703, 103248, 1, 1);
            bg2.Scale(OsbEasing.OutExpo, 88703, 89157,(360.0 / 768)*1.5, (360.0 / 768)*1.2);
            bg2.Move(88703, 102793, 320, 240, 440, 240);

            blinder.Fade(88703, 89612, 0.75, 0);
            blinder.Fade(89612, 89612 , 0, 0);

            //POSTCHORUS2
            bg2.Scale(OsbEasing.In, 102793, 103248, (360.0 / 768)*1.2, (360.0 / 768)*1.0);
            bg2.Move(OsbEasing.Out, 102793, 103248, 440, 240, 320, 240);
            bg2.Fade(103248, 103248, 0 ,0); 
 
            plainbg.Fade(103248, 128703, 1, 1);
            plainbg.Fade(128703, 128703, 0, 0);
            //CHORUS3
            blinder.Fade(128703, 129612, 0.75, 0);
            blinder.Fade(129612, 129612 , 0, 0);

            blinder.Fade(143248, 144157, 0.75, 0);
            blinder.Fade(144157, 144157 , 0, 0);

            blinder.Fade(135975, 136884, 0.75, 0);
            blinder.Fade(136884, 136884 , 0, 0);

            blinder.Fade(150521, 151430, 0.75, 0);
            blinder.Fade(151430, 151430 , 0, 0);

            blinder.Fade(157793, 158703, 0.75, 0);
            blinder.Fade(158703, 158703 , 0, 0);

            blinder.Fade(95975, 96884, 0.75, 0);
            blinder.Fade(96884, 96884 , 0, 0);

            bg2.Fade(128703, 170521, 1, 1);
            bg2.Scale(OsbEasing.OutExpo, 128703, 129157,(360.0 / 768)*1.5, (360.0 / 768)*1.2);
            bg2.Move(128703, 170066, 320, 240, 440, 240);
            bg2.Rotate(OsbEasing.Out,142793, 143248, 0, 0.2);
            bg2.Scale(OsbEasing.Out, 142793, 143248,(360.0 / 768)*1.2, (360.0 / 768)*1.5);
            bg2.Rotate(OsbEasing.OutExpo,143248, 143703, 0.2, 0);
            bg2.Scale(OsbEasing.OutExpo, 143248, 143703,(360.0 / 768)*1.5, (360.0 / 768)*1.2);
            bg2.Scale(OsbEasing.OutExpo, 157793, 158248, (360.0 / 768)*1.2, (360.0 / 768)*1.0);
            bg2.Scale(OsbEasing.Out, 170066,170293, (360.0 / 768)*1, (360.0 / 768)*1.3);
            bg2.Scale(OsbEasing.InExpo, 170293, 170521, (360.0 / 768)*1.3, (360.0 / 768)*1.0);
            bg2.Rotate(OsbEasing.Out, 170066,170293, 0, -0.2);
            bg2.Rotate(OsbEasing.In, 170293, 170521, -0.2, 0);
            bg2.Move(OsbEasing.Out, 170066, 170521, 440, 240, 320, 240);
            bg2.Fade(170521, 170521, 0, 0);

            plainbg.Fade(170521,172339, 1, 1);
            plainbg.Fade(172339, 174248, 1, 0);

        }
    }
}
