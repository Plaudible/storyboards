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
    public class Arrow : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var a = layer.CreateSprite("sb/arrow.png", OsbOrigin.Centre);

            a.Fade(18621, 19209, 0.8, 0.8);
            a.Fade(19209, 19209, 0, 0);
            a.Scale(18621, 0.5);
            a.Rotate(18621, -0.2);
            a.Color(18621, 1,1,1);
            a.Move(OsbEasing.OutExpo, 18621, 18915, -200, 200, 300, 100);
            a.Move(OsbEasing.In, 18915, 19209, 300, 100, 800, 0);

            a.Fade(20091, 21268, 0.8, 0.8);
            a.Fade(21268, 21268, 0, 0);
            a.Move(OsbEasing.OutExpo, 20091, 20974, -30, 540, -30, 260);
            a.Move(OsbEasing.InExpo, 20974, 21268, -30, 260, -30, -200);
            a.Rotate(20091, -1.5708);

            a.Fade(25680, 26121, 0.8, 0.8);
            a.Fade(26121, 26121, 0, 0);
            a.Rotate(25680, 1.5708 - 0.2);
            a.Move(OsbEasing.InExpo, 25680, 26121, -110, -50, 30, 540);

            a.Fade(28327, 31268, 0.8, 0.8);
            a.Fade(31268, 31268, 0, 0);
            a.Rotate(28327, -0.2);

            a.Move(OsbEasing.OutExpo, 28327, 28621, -200, 200, 330, 94);
            a.Move(OsbEasing.InExpo,30680, 31268, 400, -50, 400 + 850, -50 - 180);
            a.Color(28327, 0.631, 0.929, 0.894);

            a.Scale(OsbEasing.InOutExpo, 29209, 29650, 0.5, 1);
            a.Move(OsbEasing.InOutExpo, 29209, 29650, 330, 94, 400, -50);

            var a2 = layer.CreateSprite("sb/arrow.png", OsbOrigin.Centre);
            a2.Fade(29503, 31268, 0.8, 0.8);
            a2.Fade(31268, 31268, 0, 0);
            a2.Scale(29503, 0.5);
            a2.Rotate(29503, 0.2 + (1.5708 * 2));
            a2.Color(29503, 0.992, 0.247, 0.573);
            a2.Move(OsbEasing.OutExpo, 29503, 29797, 760, 320, 280, 222);
            a2.Move(OsbEasing.InExpo, 30680, 31268, 280, 222, -320, 222 - 125);

            a.Fade(32886, 35680, 0.8, 0.8);
            a.Fade(35680, 35680, 0, 0);
            a.Rotate(32886, -0.2 - 1.5708 * 3);
            a.Move(OsbEasing.InOutExpo, 32886, 33327, -40, -60, 15, 230);
            a.Scale(32886, 0.5);
            a.Color(32886, 0.992, 0.247, 0.573);
            a.Move(33327, 35239, 15, 230, 20, 250);
            a.Move(OsbEasing.InExpo, 35239, 35680, 20, 250, 125, 750);

            a.Fade(35680, 35974, 0.8, 0);
            a.Fade(35974, 35974, 0, 0);
            a.Move(OsbEasing.OutExpo, 35680, 35974, 200, 160, 400, 160);
            a.Scale(35680, 0.5);
            a.Color(35680, 0.992, 0.247, 0.573);
            a.Rotate(35680, 0);

            a.Fade(35974, 36268, 0.8, 0);
            a.Fade(36268, 36268, 0, 0);
            a.Move(OsbEasing.OutExpo, 35974, 36268, 650, 320, 450, 320);
            a.Scale(35974, 0.5);
            a.Color(35974, 0.631, 0.929, 0.894);
            a.Rotate(35974, 1.5704 * 2);

            a.Fade(38033, 40386, 0.8, 0.8);
            a.Fade(40386, 40386, 0, 0);
            a.Move(OsbEasing.OutExpo, 38033, 38327, 65, 500, 25, 300);
            a.Scale(38033, 0.5);
            a.Color(38033, 0.992, 0.247, 0.573);
            a.Rotate(38033, -0.2 - 1.5704);
            
            a.Move(OsbEasing.OutExpo, 38621, 38915, 25, 300, 130, 425);
            a.Rotate(OsbEasing.OutExpo, 38621, 38915, -0.2 - 1.5704, 0.2 - (1.5704 * 2));
            a.Scale(OsbEasing.OutExpo, 38621,38915, 0.5, 0.75);
            a.Move(OsbEasing.InExpo, 39797, 40239, 130, 425, 130 - 650, 425 - 130);

            a.Fade(40533, 42739, 0.8, 0.8);
            a.Fade(42739, 42739, 0, 0);
            a.Move(OsbEasing.OutExpo, 40533, 40827, 390, 520, 410, 415);
            a.Scale(40533, 0.5);
            a.Color(40533, 0.992, 0.247, 0.573);
            a.Rotate(40533, 0.2 - 1.5704);

            a2.Fade(41268, 42739, 0.8, 0.8);
            a2.Fade(42739, 42739, 0, 0);
            a2.Move(OsbEasing.OutExpo, 41268, 41562, 720, 390, 505, 348);
            a2.Scale(41268, 0.5);
            a2.Rotate(41268, 0.2 + (1.5708 * 2));
            a2.Color(41268, 0.631, 0.929, 0.894);

            a2.Move(OsbEasing.InExpo, 42150, 42739, 505, 348, 505 - 800, 348 - 160);
            a.Move(OsbEasing.InExpo, 42150, 42739, 410, 415, 410 + 125, 415 - 600);

            a.Fade(42739, 44650, 0.8, 0.8);
            a.Fade(44650, 44650, 0, 0);
            a.Move(OsbEasing.OutExpo, 42739, 43033, 20, -150, 70, 150);
            a.Scale(42739, 0.5);
            a.Color(42739, 0.992, 0.247, 0.573);
            a.Rotate(42739, -0.2 - (1.5704 * 3));

            a2.Fade(43327, 44650, 0.8, 0.8);
            a2.Fade(44650, 44650, 0, 0);
            a2.Move(OsbEasing.OutExpo, 43327, 43621, 645, 690, 595, 320);
            a2.Scale(43327, 0.5);
            a2.Rotate(43327, -0.2 + (1.5708 * 3));
            a2.Color(43327, 0.631, 0.929, 0.894);

            a.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2 - (1.5704 * 3), 0.2 - (1.5704 * 3));
            a.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            a.Move(OsbEasing.InExpo, 44209, 44650, 70, 150, -160, 40);

            a2.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2 + (1.5704 * 3), 0.2 + (1.5704 * 3));
            a2.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            a2.Move(OsbEasing.InExpo, 44209, 44650, 595, 320, 945, 350);

            a2.Fade(45239, 47150, 0.8, 0.8);
            a2.Fade(47150, 47150, 0, 0);
            a2.Move(OsbEasing.OutExpo, 45239, 45533, 320, -100, 320, 100);
            a2.Scale(45239, 0.5);
            a2.Rotate(45239, 1.5708);
            a2.Color(45239, 0.631, 0.929, 0.894);

            a2.Move(OsbEasing.InExpo, 46709, 47150, 320, 100, 320, 500);
        }
    }
}
