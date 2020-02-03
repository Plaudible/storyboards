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
    public class Fade : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bgColor = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var white = layer.CreateSprite("sb/white.png",OsbOrigin.Centre);
            var black = layer.CreateSprite("sb/white.png",OsbOrigin.Centre);
            var black2 = layer.CreateSprite("sb/white.png",OsbOrigin.Centre);
            var inv = layer.CreateSprite("sb/inv.jpg", OsbOrigin.Centre);
            var bgZoom = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            var bgZoomColor = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            bgZoom.Scale(0, Math.Max(1366 / 1366, 768 / 768) * 0.625183);
            bgZoom.Fade(0,0,0,0);
            bgZoomColor.Scale(0, Math.Max(1366 / 1366, 768 / 768) * 0.625183);
            bgZoomColor.Fade(0,0,0,0);
            bg.Scale(0, Math.Max(1366 / 1366, 768 / 768) * 0.625183);
            bg.Fade(0,1700,0.25,0.25);
            bg.Fade(1700,5192,0,0);
            inv.Scale(1700, 600.0 / 720);
            inv.Rotate(1700,0.15);

            for(int i = 1700; i < 3478; i+=100){
                inv.Fade(i,(i+50),0.50,1);
            }
            inv.Fade(3478,3478,0,0);
            for(int i = 5192; i < 10335; i+=429){
                bg.Fade(i,(i+429),0.35,0.30);
            }
            bg.Fade(10335,15748,0.25,0.25);
            bg.Fade(15748,17192,0.25,0.2);

            bgColor.Scale(10355, Math.Max(1366 / 1366, 768 / 768) * 0.625183);
            bgColor.Color(10355,1,0,0);
            bgColor.Fade(15748,17192,0.35,0);
            for(int i = 10355; i < 15748; i+=429){
                bgColor.Fade(i,(i+429),0.45,0.30);
            }
            white.Fade(16335,17192,0,0.5);
            white.Fade(17192,17192,0.5,0);

            bg.Fade(17192,17492,0.25,0.01);
            bg.Fade(17492,17592,0.01,0.35);
            bg.Fade(17592,18157,0.35,0);

            bg.Fade(18478,18907,0.5,0.5);

            black.Fade(18478,18907,1,1);
            black.Scale(18478,3);
            black.Color(18478,0,0,0);
            black.Rotate(18478,0.15);
            black.MoveY(18478,18478,0,1360);

            black2.Fade(18478,18907,1,1);
            black2.Scale(18478,3);
            black2.Color(18478,0,0,0);
            black2.Rotate(18478,0.15);
            black2.MoveY(18478,18478,0,-220);

            black.MoveY(OsbEasing.Out,18478,18677,1460, 1560);
            black2.MoveY(OsbEasing.Out,18478,18677,-820,-920);

            bg.Fade(18907,32192,0.4,0.4);
            bg.Fade(32192,32192,0,0);
            bgColor.Fade(18907,19205,0,0.6);
            bgColor.Fade(19205,19335,0.6,0.6);
            black.MoveY(OsbEasing.Out,18907,19514,1560, 1760);
            black2.MoveY(OsbEasing.Out,18907,19514,-920,-1320);

            black.Fade(19514,19514,0,0);
            black2.Fade(19514,19514,0,0);

            for(int i = 19335; i < 32192; i+=429){
                bgColor.Fade(i,(i+250),0.4,0.6);
            }

            bgColor.Fade(32192,32407,0,0);
            bg.Fade(32835, 33907, 0,0.35);
            bg.Fade(33907, 39050, 0.35,0.35);
            bg.Fade(39050, 39478, 0.35,0);

            bg.Fade(46335,47835, 0, 0.35);
            bg.Fade(47835, 52978, 0.35,0.35);
            bg.Fade(52978, 52978, 0,0);
            bg.Fade(53621,54049, 0, 0.5);
            bg.Fade(53621,63478,0.5,0.5);
            bg.Fade(63478,63478,0,0);
            bgColor.Fade(53835,54157,0,0.5);
            bgColor.Fade(54157,63478,0.5,0.5);
            bgColor.Fade(63478,63478,0,0);
            bg.Fade(63692,65192,0,0.3);

            bg.Fade(65192,65192,0,0);
            bg.Fade(65192,66692,0.3,0);

            //bg.Fade(66692,66907,0.25,0.25);

            black.Fade(66692,66907,1,1);
            black.Scale(66692,3);
            black.Color(66692,0,0,0);
            black.Rotate(66692,0.15);
            black.MoveY(66692,66692,0,1360);

            black2.Fade(66692,66907,1,1);
            black2.Scale(66692,3);
            black2.Color(66692,0,0,0);
            black2.Rotate(66692,0.15);
            black2.MoveY(66692,66692,0,-220);

            black.MoveY(OsbEasing.Out,66692,66907,1460, 1560);
            black2.MoveY(OsbEasing.Out,66692,66907,-820,-920);

            bg.Fade(67014,67764,0,0.35);
            bg.Fade(67764,67871,0.35,0.4);
            bg.Fade(67871,68621,0.4,0.4);
            bgColor.Fade(67764,67871,0,0.6);
            bgColor.Fade(67871,68621,0.6,0.6);
            bg.Fade(68621,68621,0,0);
            bgColor.Fade(68621,68621,0,0);

            bg.Fade(68621,69478,0,0.35);
            bg.Fade(69478,69585,0.35,0.4);
            bg.Fade(69585,68621,0.4,0.4);
            bgColor.Fade(69478,69585,0,0.6);
            bgColor.Fade(69585,70335,0.6,0.6);
            bg.Fade(70335,70335,0,0);
            bgColor.Fade(70335,70335,0,0);

            bg.Fade(70335,71192,0,0.35);
            bg.Fade(71192,71300,0.35,0.4);
            bg.Fade(71300,71192,0.4,0.4);
            bgColor.Fade(71192,71300,0,0.6);
            bgColor.Fade(71300,72050,0.6,0.6);
            bg.Fade(72050,72050,0,0);
            bgColor.Fade(72050,72050,0,0);

            bg.Fade(72050,72907,0,0.35);
            bg.Fade(72907,73014,0.35,0.4);
            bg.Fade(73014,72907,0.4,0.4);
            bgColor.Fade(72907,73014,0,0.6);
            bgColor.Fade(73014,73764,0.6,0.6);
            bg.Fade(73764,73764,0,0);
            bgColor.Fade(73764,73764,0,0);

            bgColor.Fade(75478,75907,0,0.4);
            bg.Fade(75478,75907,0,0.1);

            bg.Fade(75907,85764,0.3,0.3);
            for(int i = 76335; i < 84907; i+=857){
                bgColor.Fade(i,i+857,0.6,0.4);
            }
            bg.Fade(85764,85764,0,0);

            bgZoom.Fade(87478,87692,0.3,0.2);
            bgZoom.Fade(87692,88335,0.3,0);

            bgZoom.MoveX(89192,89192,320,320);
            bgZoom.MoveY(89192,89192,220,220);
            bgZoom.Scale(89192, Math.Max(1366 / 1366, 768 / 768) * 0.7);
            bgZoom.Fade(89192,89407,0.3,0.2);
            bgZoom.Fade(89407,90050,0.3,0);

            bgZoom.MoveX(90907,90907,350,350);
            bgZoom.MoveY(90907,90907,200,200);
            bgZoom.Scale(90907, Math.Max(1366 / 1366, 768 / 768) * 0.8);
            bgZoom.Fade(90907,91121,0.30,0.20);
            bgZoom.Fade(91121,91764,0.30,0);

            bgZoom.MoveX(92621,92621,380,380);
            bgZoom.MoveY(92621,92621,180,180);
            bgZoom.Scale(92621, Math.Max(1366 / 1366, 768 / 768) * 0.9);
            bgZoom.Fade(92621,92835,0.30,0.20);
            bgZoom.Fade(92835,93478,0.30,0);

            bgZoom.MoveX(94335,94335,400,400);
            bgZoom.MoveY(94335,94335,160,160);
            bgZoom.Scale(94335, Math.Max(1366 / 1366, 768 / 768) * 1.1);
            bgZoom.Fade(94335,94550,0.30,0.20);
            bgZoom.Fade(94550,95192,0.30,0);

            bgZoom.MoveX(96050,96050,440,440);
            bgZoom.MoveY(96050,96050,120,120);
            bgZoom.Scale(96050, Math.Max(1366 / 1366, 768 / 768) * 1.3);
            bgZoom.Fade(96050,96264,0.30,0.20);
            bgZoom.Fade(96264,96907,0.30,0);

            bgZoom.MoveX(97764,97764,500,500);
            bgZoom.MoveY(97764,97764,60,60);
            bgZoom.Scale(97764, Math.Max(1366 / 1366, 768 / 768) * 1.5);
            bgZoom.Fade(97764,97978,0.10,0.05);
            bgZoom.Fade(97978,98621,0.10,0.05);
            bgZoomColor.Color(97764,1,0,0);
            bgZoomColor.MoveX(97764,97764,500,500);
            bgZoomColor.MoveY(97764,97764,60,60);
            bgZoomColor.Scale(97764, Math.Max(1366 / 1366, 768 / 768) * 1.5);
            bgZoomColor.Fade(97764,97978,0.30,0.20);
            bgZoomColor.Fade(97978,98621,0.30,0);

            for(int i = 99478; i < 101192; i+=100){
                inv.Fade(i,(i+50),0.50,1);
            }

            for(int i = 101192; i < 126907; i+=1715){
            bg.Fade(i,i+215,0.6,0.5);
            bg.Fade(i+215,i+858,0.6,0.3);
            bg.Fade(i+858,i+1715,0.3,0.3);
            }

            bg.Fade(126907,127121,0.6,0.5);
            bg.Fade(127121,127764,0.6,0.3);
            bg.Fade(127764,128621,0.3,0);
        }
    }
}
