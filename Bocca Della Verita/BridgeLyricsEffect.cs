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
    public class BridgeLyricsEffect : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var letter1 = layer.CreateSprite("sb/f/30a2.png", OsbOrigin.Centre);
            var letter2 = layer.CreateSprite("sb/f/30a4.png", OsbOrigin.Centre);
            var letter11 = layer.CreateSprite("sb/f/30a2.png", OsbOrigin.Centre);
            var letter22 = layer.CreateSprite("sb/f/30a4.png", OsbOrigin.Centre);
            var letter111 = layer.CreateSprite("sb/f/30a2.png", OsbOrigin.Centre);
            var letter222 = layer.CreateSprite("sb/f/30a4.png", OsbOrigin.Centre);

            var letter3 = layer.CreateSprite("sb/f/30d8.png", OsbOrigin.Centre);
            var letter2222 = layer.CreateSprite("sb/f/30a4.png", OsbOrigin.Centre);
            var letter4 = layer.CreateSprite("sb/f/30c1.png", OsbOrigin.Centre);
            var letter5 = layer.CreateSprite("sb/f/30e5.png", OsbOrigin.Centre);
            var letter6 = layer.CreateSprite("sb/f/30fc.png", OsbOrigin.Centre);

            var letter7 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var letter77 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var letter777 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var letter7777 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var letter77777 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var blood1 = layer.CreateSprite("sb/b/blood-1.png", OsbOrigin.Centre);
            var blood2 = layer.CreateSprite("sb/b/blood-2.png", OsbOrigin.Centre);
            var blood3 = layer.CreateSprite("sb/b/blood-3.png", OsbOrigin.Centre);
            var blood4 = layer.CreateSprite("sb/b/blood-4.png", OsbOrigin.Centre);

            var letter777777 = layer.CreateSprite("sb/f/306a.png", OsbOrigin.Centre);
            var letter8 = layer.CreateSprite("sb/f/3093.png", OsbOrigin.Centre);
            var letter9 = layer.CreateSprite("sb/f/3067.png", OsbOrigin.Centre);
            var letter10 = layer.CreateSprite("sb/f/3059.png", OsbOrigin.Centre);
            var letter100 = layer.CreateSprite("sb/f/306e.png", OsbOrigin.Centre);

            // AI AI AI

            letter1.Fade(23412, 26235, 1, 1);
            letter1.Move(OsbEasing.Out, 23412, 23588, 40, 0, 40, 160);
            letter1.Move(23588, 26235, 40, 160, 40, 170);
            letter1.Scale(23412, 0.15);
            letter2.Fade(23412, 26235, 1, 1);
            letter2.Move(OsbEasing.Out, 23412, 23588, 70, 0, 70, 160);
            letter2.Move(23588, 26235, 70, 160, 70, 170);
            letter2.Scale(23412, 0.15);

            letter11.Fade(23765, 26235, 1, 1);
            letter11.Move(OsbEasing.Out, 23765, 23941, 280, 0, 280, 240);
            letter11.Move(23941, 26235, 280, 240, 280, 250);
            letter11.Scale(23765, 0.3);
            letter22.Fade(23765, 26235, 1, 1);
            letter22.Move(OsbEasing.Out, 23765, 23941, 320, 0, 320, 240);
            letter22.Move(23941, 26235, 320, 240, 320, 250);
            letter22.Scale(23765, 0.3);

            letter111.Fade(24118, 26235, 1, 1);
            letter111.Move(OsbEasing.Out, 24118, 24294, 520, 0, 520, 340);
            letter111.Move(24294, 26235, 520, 340, 520, 350);
            letter111.Scale(24118, 0.45);
            letter222.Fade(24118, 26235, 1, 1);
            letter222.Move(OsbEasing.Out, 24118, 24294, 580, 0, 580, 340);
            letter222.Move(24294, 26235, 580, 340, 580, 350);
            letter222.Scale(24118, 0.45);

            //HEICHU

            letter3.Fade(24294, 26235, 1, 1);
            letter3.Scale(24294, 0.6);
            letter3.Move(OsbEasing.Out, 24294, 24471, -180, 540, 180, 300);
            letter3.Move(24471, 26235, 180, 300, 188, 302);
            letter3.Rotate(24924, -0.15);

            letter2222.Fade(24294, 26235, 1, 1);
            letter2222.Scale(24294, 0.6);
            letter2222.Move(OsbEasing.Out, 24294, 24471, -180, 540, 250, 270);
            letter2222.Move(24471, 26235, 250, 270, 258, 272);
            letter2222.Rotate(24924, -0.15);

            letter4.Fade(24294, 26235, 1, 1);
            letter4.Scale(24294, 0.6);
            letter4.Move(OsbEasing.Out, 24294, 24471, -180, 540, 320, 240);
            letter4.Move(24471, 26235, 320, 240, 328, 242);
            letter4.Rotate(24924, -0.15);

            letter5.Fade(24294, 26235, 1, 1);
            letter5.Scale(24294, 0.6);
            letter5.Move(OsbEasing.Out, 24294, 24471, -180, 540, 390, 210);
            letter5.Move(24471, 26235, 390, 210, 398, 212);
            letter5.Rotate(24924, -0.15);
            
            letter6.Fade(24294, 26235, 1, 1);
            letter6.Scale(24294, 0.6);
            letter6.Move(OsbEasing.Out, 24294, 24471, -180, 540, 460, 180);
            letter6.Move(24471, 26235, 460, 180, 468, 182);
            letter6.Rotate(24924, -0.15);

            // NA NA NA NA NA
            blood1.Move(24823, 510, 150);
            blood1.Scale(24823, 0.5);
            blood1.Fade(24823, 25176, 0.5, 0);
            letter7.Fade(24823, 26235, 1, 1);
            letter7.Move(OsbEasing.Out, 24823, 25006, 800, 140, 680, 140);
            letter7.Move(24823, 26235, 680, 140, 670, 140);
            letter7.Scale(24823, 0.25);

            blood2.Move(25000, 0, 370);
            blood2.Scale(25000, 0.5);
            blood2.Fade(25000, 25353 , 0.5, 0);
            letter77.Fade(25000, 26235, 1, 1);
            letter77.Move(OsbEasing.Out, 25000, 25176, -120, 370, 0, 370);
            letter77.Move(25176, 26235, 0, 370, 10, 370);
            letter77.Scale(25000, 0.4); 

            blood3.Move(25176, 80, 120);
            blood3.Scale(25176, 0.5);
            blood3.Fade(25176, 25529 , 0.5, 0);
            letter777.Fade(25176, 26235, 1, 1);
            letter777.Move(OsbEasing.Out, 25176, 25353, 80, -60, 80, 120);
            letter777.Move(25353, 26235, 80, 120, 80, 130);
            letter777.Scale(25176, 0.75); 

            blood4.Move(25353, 380, 290);
            blood4.Scale(25353, 0.5);
            blood4.Fade(25353, 25706 , 0.5, 0);
            letter7777.Fade(25353, 26235, 1, 1);
            letter7777.Move(OsbEasing.Out, 25353, 25529, 380, 600, 380, 290);
            letter7777.Move(25529, 26235, 380, 290, 380, 280);
            letter7777.Scale(25353, 0.9); 

            //NANDESUNO
            letter77777.Fade(25529, 26235, 1, 1);
            letter77777.Scale(25529, 0.6);
            letter77777.Move(OsbEasing.Out, 25529, 25706, 260, -200, 260, 75);
            letter77777.Move(25706, 26235, 260, 75, 260, 85);
            letter8.Fade(25529, 26235, 1, 1);
            letter8.Scale(25529, 0.6);
            letter8.Move(OsbEasing.Out, 25529, 25706, 260, -200, 260, 160);
            letter8.Move(25706, 26235, 260, 160, 260, 170);
            letter9.Fade(25529, 26235, 1, 1);
            letter9.Scale(25529, 0.6);
            letter9.Move(OsbEasing.Out, 25529, 25706, 260, -200, 260, 245);
            letter9.Move(25706, 26235, 260, 245, 260, 255);
            letter10.Fade(25529, 26235, 1, 1);
            letter10.Scale(25529, 0.6);
            letter10.Move(OsbEasing.Out, 25529, 25706, 260, -200, 260, 330);
            letter10.Move(25706, 26235, 260, 330, 260, 340);
            letter100.Fade(25529, 26235, 1, 1);
            letter100.Scale(25529, 0.6);
            letter100.Move(OsbEasing.Out, 25529, 25706, 260, -200, 260, 405);
            letter100.Move(25706, 26235, 260, 405, 260, 415);

        }
    }
}
