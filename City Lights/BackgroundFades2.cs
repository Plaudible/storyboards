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
    public class BackgroundFades2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Main");
            var bgpostchorus = layer.CreateSprite("31d58fd3ff358e8e5e47551a3bc0f9.jpg", OsbOrigin.Centre);
		    bgpostchorus.Fade(94768,96268, 0, 0.75);
            bgpostchorus.Scale(94768, (360.0 / 768)*1.2); 
            //BRIDGE
            bgpostchorus.Fade(96268, 108268, 1, 1);
            bgpostchorus.Scale(OsbEasing.InOutQuad, 95893, 96456, ((360.0 / 768)*1.2), (360.0 / 768) * 1.75);
            bgpostchorus.Rotate(OsbEasing.Out, 95893, 96456, 0, 0.2);
            bgpostchorus.MoveY(OsbEasing.InOutQuad, 95893, 96456, 230, 330);
            bgpostchorus.MoveX(94768, 320);
            bgpostchorus.MoveX(OsbEasing.InOutQuad, 95893, 96456, 320, 160);
            
            double xpos4 = 160;
            for(int i = 96456; i < 108268; i += 500){
                bgpostchorus.MoveX(i, i+500, xpos4, xpos4 + 4.6);
                xpos4 += 4.6;
            }

            for(int i = 108268; i < 118768; i += 500){
                bgpostchorus.MoveX(i, i+500, xpos4, xpos4 -4.6);
                xpos4 -= 4.6;
            }
            //bgpostchorus.Fade(118768,118768,0,0);

            //BREAKDOWN
            var bgBreakdown = layer.CreateSprite("sb/bg3.jpg", OsbOrigin.Centre);
            var vignette = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            bgBreakdown.Fade(120268,130675, 1,1);
            bgBreakdown.Fade(130675,131050, 1,0.5);
            bgBreakdown.Fade(131050,132268,0.5,0.5);
            bgBreakdown.Fade(132268,142768,1,1);
            bgBreakdown.Fade(142768,143050,1,0.5);
            bgBreakdown.Fade(143050,144268,0.5,0.5);
            bgBreakdown.Scale(120268, (360.0 / 768)*1.7); 
            vignette.Scale(130768, (360.0 / 768)*1.6); 
            vignette.Fade(130675,131050, 0, 0.5);
            vignette.Fade(131050,132268,0.5,0.5);


            double xpos = 318;
            double ypos = 230;
            double rot = 0;
            Random rand = new Random();
            for(double i = 120268; i <= 144268; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                bgBreakdown.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                bgBreakdown.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                bgBreakdown.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
            bgBreakdown.Fade(144268,144268,0,0);
            bgBreakdown.Scale(OsbEasing.InOutQuad, 143518, 144268, ((360.0 / 768)*1.7), (360.0 / 768) * 1.5);

            //POST-CHORUS
            var greyblur = layer.CreateSprite("sb/greyblur.jpg",OsbOrigin.Centre);
            var bgblur = layer.CreateSprite("sb/blur.jpg",OsbOrigin.Centre);
            greyblur.Scale(144268, (360.0 / 768)*1.2);
            greyblur.Fade(144268, 145768, 0, 0.75);
            greyblur.Fade(145768,149893, 0.75, 0.75);
            greyblur.Fade(149893,150268, 0.75, 0);
            bgblur.Scale(149893, (360.0 / 768)*1.2);
            bgblur.Fade(149893,150268, 0, 0.75);
            bgblur.Fade(150268,156268,0.75,0.75);
            bgblur.Fade(156268,156268,0,0);
            
            for(double i = 144268; i <= 150268; i += 750){
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

            for(double i = 150268; i <= 156268; i += 750){
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
            bgblur.Scale(OsbEasing.InOutQuad, 155518, 156268, ((360.0 / 768)*1.2), (360.0 / 768) * 1.75);
            bgblur.Rotate(OsbEasing.Out, 155518, 156268, 0, 0.2);
            bgblur.MoveY(OsbEasing.InOutQuad, 155518, 156268, ypos, 340);
            //FINAL CHORUS
            var bgchorus2 = layer.CreateSprite("31d58fd3ff358e8e5e47551a3bc0f9.jpg", OsbOrigin.Centre);
            bgchorus2.Fade(167518,168268,0.5,0.5);
            bgchorus2.Scale(167518, (360.0 / 768)*1.0); 
            bgchorus2.Scale(OsbEasing.InOutQuad, 168175, 168456, ((360.0 / 768)*1.0), (360.0 / 768) * 1.25);
            bgchorus2.Fade(168268,174175,1,1);
            bgchorus2.Fade(174175,174550,1,0.75);
            bgchorus2.Fade(174550,180268,0.75,0.75);
            bgchorus2.Fade(180268,186175,1,1);
            bgchorus2.Fade(186175,186550,1,0.75);
            bgchorus2.Fade(186550,191518,0.75,0.75);
            bgchorus2.Fade(191518,192268,0.75,0);

            Random rand3 = new Random();
            double xpos10 = 318;
            double ypos10 = 230;
            double rot10 = 0;
            for(double i = 168268; i < 192268; i += 750){
                double ran = rand.Next(-7,7);
                double ran2 = GetRandomDouble(rand3,-7,7);
                double ran3 = GetRandomDouble(rand3,-3,3);
                bgchorus2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos10, xpos10 + ran);
                bgchorus2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos10, ypos10 + ran2);
                bgchorus2.Rotate(OsbEasing.InOutQuad, i, i+750, rot10, rot10 + (ran3 / 200));
                xpos10 += ran;
                ypos10 += ran2;
                rot10 += (ran3 / 200);

            }
            var vignette2 = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette2.Fade(174175,174550,0,0.5);
            vignette2.Fade(174550,180268,0.5,0.5);
            vignette2.Scale(174175, (360.0 / 768)*1.6);

            var vignette3 = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette3.Fade(186175,186550,0,0.5);
            vignette3.Fade(186550,192268,0.5,0.5);
            vignette3.Scale(186175, (360.0 / 768)*1.6);

            var bgblurfinal = layer.CreateSprite("sb/blur.jpg", OsbOrigin.Centre);
            var bgblurgrayfinal = layer.CreateSprite("sb/greyblur.jpg", OsbOrigin.Centre);
            bgblurfinal.Fade(191518,192268,0,0.75);
            bgblurfinal.Scale(191518, (360.0 / 768)*1.2);

            for(double i = 191518; i < 204268; i += 750){
                double ran = rand.Next(-7,7);
                double ran2 = GetRandomDouble(rand3,-7,7);
                double ran3 = GetRandomDouble(rand3,-3,3);
                bgblurfinal.MoveX(OsbEasing.InOutQuad, i, i+750, xpos10, xpos10 + ran);
                bgblurfinal.MoveY(OsbEasing.InOutQuad, i, i+750, ypos10, ypos10 + ran2);
                bgblurfinal.Rotate(OsbEasing.InOutQuad, i, i+750, rot10, rot10 + (ran3 / 200));
                xpos10 += ran;
                ypos10 += ran2;
                rot10 += (ran3 / 200);

            }
            bgblurfinal.Fade(204268,214768,0.75,0);
            bgblurgrayfinal.Scale(203518, (360.0 / 768)*1.2);
            bgblurgrayfinal.Fade(203518,204268,0,0.5);
            bgblurgrayfinal.Fade(204268,216268,0.5,0.5);
            bgblurgrayfinal.Fade(216268,217768,0.5,0);
            for(double i = 204268; i < 217768; i += 750){
                double ran = rand.Next(-7,7);
                double ran2 = GetRandomDouble(rand3,-7,7);
                double ran3 = GetRandomDouble(rand3,-3,3);
                bgblurgrayfinal.MoveX(OsbEasing.InOutQuad, i, i+750, xpos10, xpos10 + ran);
                bgblurgrayfinal.MoveY(OsbEasing.InOutQuad, i, i+750, ypos10, ypos10 + ran2);
                bgblurgrayfinal.Rotate(OsbEasing.InOutQuad, i, i+750, rot10, rot10 + (ran3 / 200));
                xpos10 += ran;
                ypos10 += ran2;
                rot10 += (ran3 / 200);

            }
        }

        double GetRandomDouble(Random random, double min, double max)
        {
            return min + (random.NextDouble() * (max - min));
        }
    }
}
