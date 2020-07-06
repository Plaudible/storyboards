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
    public class BackgroundFades : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("31d58fd3ff358e8e5e47551a3bc0f9.jpg", OsbOrigin.Centre);
            var bgpostchorus = layer.CreateSprite("31d58fd3ff358e8e5e47551a3bc0f9.jpg", OsbOrigin.Centre);
            var bgblur = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var bgblur2 = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var greyblur = layer.CreateSprite("sb/greyblur.jpg",OsbOrigin.Centre);
            var greyblur2 = layer.CreateSprite("sb/greyblur.jpg",OsbOrigin.Centre);
            //FADE DOKI BG
            var bgdoki = layer.CreateSprite("bg.jpg", OsbOrigin.Centre);
            bgdoki.Fade(0,219481,0,0);
            //INTRO BLUR
            greyblur.Scale(12269, (360.0 / 768)*1.2);
            greyblur.Fade(0, 10769, 0.75, 0.75);
            greyblur.Fade(10769,12269, 0.75, 0);
            bgblur.Scale(12269, (360.0 / 768)*1.2);
            bgblur.Fade(10769,12269, 0, 0.75);
            bgblur.Fade(12269, 22768, 0.75, 0.75);
            bgblur.Fade(22768, 24643, 0.75, 0);

            double xpos = 318;
            double ypos = 230;
            double rot = 0;
            Random rand = new Random();

            for(double i = 0; i <= 12269; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                greyblur.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                greyblur.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                greyblur.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }

            for(double i = 12269; i <= 24643; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                bgblur.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                bgblur.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                bgblur.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
            //BUILDUP
            bg.Fade(22768, 24643, 0, 1);
            bg.Scale(22768, (360.0 / 768)*1.2);
            bg.MoveX(22768, 318);
            bg.MoveY(22768, 230);
            bg.Fade(24268, 24643, 1, 1);
            bg.Scale(OsbEasing.InOutQuad, 23987, 24550, ((360.0 / 768)*1.2), (360.0 / 768) * 1.75);
            bg.Rotate(OsbEasing.Out, 23987, 24550, 0, 0.2);
            bg.MoveY(OsbEasing.InOutQuad, 23987, 24550, 230, 340);
            
            double xpos2 = 318;
            for(int i = 24268; i < 36269; i += 500){
                bg.MoveX(i, i+500, xpos2, xpos2 - 4.6);
                xpos2 -= 4.6;
            }
            bg.Scale(OsbEasing.In, 35519, 36269, ((360.0 / 768) * 1.75), (360.0 / 768) * 2.5);
            bg.Rotate(OsbEasing.In, 35519, 36269, 0.2, 0);

            bg.Fade(24643, 36269, 1, 1);
            bg.Fade(36270, 36270, 0, 0);
            //CHORUS
            var bg2 = layer.CreateSprite("31d58fd3ff358e8e5e47551a3bc0f9.jpg", OsbOrigin.Centre);
            bg2.Scale(48269, (360.0 / 768));
            //bg2.Move(48269, 318, 230);
            bg2.Fade(48269, 48643, 0.5, 0.5);
            bg2.Fade(48643, 54175, 1, 1);
            bg2.Fade(OsbEasing.In,54175,54362, 1,0.5);
            bg2.Fade(OsbEasing.In,54550,54737, 0.5,1);
            bg2.Fade(54737,60269,1,1);
            bg2.Scale(OsbEasing.InOutQuad, 48550, 48831, ((360.0 / 768)*1.0), (360.0 / 768) * 1.25);

            var arc = layer.CreateSprite("sb/arc.png", OsbOrigin.Centre);
            var arccenter = layer.CreateSprite("sb/glow2.png",OsbOrigin.Centre);
            arc.Fade(48643, 48831, 0, 1);
            arc.Fade(48831,60069, 1, 1);
            arc.Fade(60069,60269, 1, 0);
            arc.Scale(48643, 0.25);
            arccenter.Fade(48643, 48831, 0, 0.75);
            arccenter.Fade(48831,60069, 0.75, 0.75);
            arccenter.Fade(60069,60269, 0.75, 0);
            arccenter.Scale(48643, 0.36);

            arc.Fade(60643, 60831, 0, 1);
            arc.Fade(60831,70581, 1, 1);
            arc.Fade(70581,70768, 1, 0);
            arccenter.Fade(60643, 60831, 0, 0.75);
            arccenter.Fade(60831,70581, 0.75, 0.75);
            arccenter.Fade(70581,70768, 0.75, 0);
            Random rand3 = new Random();
            double xpos3 = 318;
            double ypos3 = 230;
            double rot3 = 0;
            double startRot3 = 0;
             for (int i = 48643; i <= 60269; i+= 200){
                    arc.Rotate(i,i+200, startRot3, startRot3-0.1);
                    startRot3 -= 0.1;
             }

             for (int i = 60643; i <= 70768; i+= 200){
                    arc.Rotate(i,i+200, startRot3, startRot3-0.1);
                    startRot3 -= 0.1;
             }
            for(double i = 48643; i < 60260; i += 750){
                double ran = rand.Next(-7,7);
                double ran2 = GetRandomDouble(rand3,-7,7);
                double ran3 = GetRandomDouble(rand3,-3,3);
                bg2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos3, xpos3 + ran);
                bg2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos3, ypos3 + ran2);
                bg2.Rotate(OsbEasing.InOutQuad, i, i+750, rot3, rot3 + (ran3 / 200));
                xpos3 += ran;
                ypos3 += ran2;
                rot3 += (ran3 / 200);

            }
            bg2.Fade(72268, 72268, 0, 0);
            for(double i = 60643; i <= 72268; i += 750){
                double ran = rand.Next(-7,7);
                double ran2 = GetRandomDouble(rand3,-7,7);
                double ran3 = GetRandomDouble(rand3,-3,3);
                bg2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos3, xpos3 + ran);
                bg2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos3, ypos3 + ran2);
                bg2.Rotate(OsbEasing.InOutQuad, i, i+750, rot3, rot3 + (ran3 / 200));
                xpos3 += ran;
                ypos3 += ran2;
                rot3 += (ran3 / 200);

            }
            bg2.Fade(OsbEasing.In,60175,60362, 1,0.5);
            bg2.Fade(OsbEasing.In,60550,60737, 0.5,1);
            bg2.Fade(60737,66175,1,1);
            bg2.Fade(OsbEasing.In,66175,66362, 1,0.5);
            bg2.Fade(OsbEasing.In,66550,66737, 0.5,1);
            bg2.Fade(OsbEasing.In,70675,70862, 1,0.5);
            bg2.Fade(OsbEasing.In,70862,72268, 0.5,0.5);
            bg2.Scale(OsbEasing.InOutQuad, 71518, 72268, ((360.0 / 768)*1.25), (360.0 / 768) * 1.1);
            
            //POST-CHORUS
            greyblur2.Scale(72268, (360.0 / 768)*1.2);
            greyblur2.Fade(72268, 73768, 0, 0.75);
            greyblur2.Fade(73768,84268, 0.75, 0.75);
            greyblur2.Fade(84268,96268, 0.75, 0);

            for(double i = 72268; i <= 95893; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                greyblur2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                greyblur2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                greyblur2.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }

            for(double i = 72268; i <= 95893; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                greyblur2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                greyblur2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                greyblur2.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
            bgblur2.Scale(84268, (360.0 / 768)*1.2);
            bgblur2.Fade(84268,94768, 0,0.75);
            for(double i = 84268; i <= 95893; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                bgblur2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                bgblur2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                bgblur2.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
            bgblur2.Fade(94768,96268, 0.75,0);
        }

        double GetRandomDouble(Random random, double min, double max)
        {
            return min + (random.NextDouble() * (max - min));
        }
        
    }
}
