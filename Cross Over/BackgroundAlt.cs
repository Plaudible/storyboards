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
    public class BackgroundAlt : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";
        public override void Generate()
        {

		    var bitmap = GetMapsetBitmap(BackgroundPath);
            var bgblur = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            var blinder = GetLayer("Foreground").CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);

            blinder.Fade(10180, 11080, 1, 0);

            bgblur.Scale(10180, 480.0f / bitmap.Height* 1.2);
            
            double xpos = 318;
            double ypos = 230;
            double rot = 0;
            Random rand = new Random();

            var bgglitch1 = GetLayer("").CreateSprite("sb/blurglitch/blurglitch1.jpg", OsbOrigin.Centre);
            var bgglitch2 = GetLayer("").CreateSprite("sb/blurglitch/blurglitch2.jpg", OsbOrigin.Centre);
            var bgglitch3 = GetLayer("").CreateSprite("sb/blurglitch/blurglitch3.jpg", OsbOrigin.Centre);
            var bgglitch4 = GetLayer("").CreateSprite("sb/blurglitch/blurglitch4.jpg", OsbOrigin.Centre);
            bgglitch1.Scale(19780, 480.0f / bitmap.Height* 1.4);
            bgglitch2.Scale(19855, 480.0f / bitmap.Height* 1.7);
            bgglitch3.Scale(19930, 480.0f / bitmap.Height* 1.5);
            bgglitch4.Scale(20005, 480.0f / bitmap.Height* 1.4);
            bgglitch1.Fade(19780,19855,1,1);
            bgglitch1.Fade(19855,19855,0,0);
            bgglitch2.Fade(19855,19930,1,1);
            bgglitch2.Fade(19930,19930,0,0);
            bgglitch3.Fade(19930,20005,1,1);
            bgglitch3.Fade(20005,20005,0,0);
            bgglitch4.Fade(20005,20080,1,1);
            bgglitch4.Fade(20080,20080,0,0);

            bgblur.Move(10180, 320, 240);
            bgblur.Fade(10180, 19780, 0.8, 0.8);
            bgblur.Fade(19780, 19980, 0.8, 0.5);
            bgblur.Fade(19880, 20380, 0.5, 0.5);
            bgblur.Fade(20380, 29380, 0.8, 0.8);
            blinder.Fade(20380, 21280, 0.75, 0);

            bgblur.Fade(29380, 29680, 0.8, 0.75);
            bgblur.Fade(29680, 47980, 0.75, 0.75);
            bgblur.Fade(47980, 48280, 0.75,0);
            blinder.Fade(29380, 30280, 0.75, 0);

            bgblur.Scale(10180, (360.0 / 768)*1);
            for(int i = 10180; i <= 48580; i += 750){
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

            var bg = GetLayer("Main").CreateSprite("Alice.(SINoALICE).full.2792424.jpg", OsbOrigin.Centre);
            bg.Scale(47980,(360.0 / 768)*1);
            Vector2 blurposition = bgblur.PositionAt(47980);
            double blurangle = bgblur.RotationAt(47980);
            double blurposx = blurposition.X;
            double blurposy = blurposition.Y;
            bg.Fade(47980, 48280, 0, 0.75);
            bg.Fade(48280, 48580, 0.75, 0.75);
            bg.Fade(48580, 86980, 0.8, 0.8);
            bg.Fade(86980, 86980, 0, 0);
            bg.Move(47980, blurposx, blurposy);
            bg.Rotate(47980, blurangle); 
            
            bg.Move(OsbEasing.InOutExpo, 48130, 48880, blurposx, blurposy, 420, 360);
            bg.Scale(OsbEasing.InOutExpo, 48130, 48880, (360.0 / 768)*1, (360.0 / 768)*1.5);
            bg.Rotate(OsbEasing.InOutExpo, 48130, 48880, blurangle, blurangle - 0.25);
            blinder.Fade(48580, 49480, 1, 0);

            bg.Move(48880, 67780, 420, 360, 520, 360);

            Vector2 bgposition = bg.PositionAt(47980);
            double bgangle = bg.RotationAt(47980);
            double bgposx = bgposition.X;
            double bgposy = bgposition.Y;
            blinder.Fade(58180, 59080, 0.75, 0);
            blinder.Fade(67780, 68680, 1, 0);
            bg.Move(67780, 86980, bgposx + 150, 240, bgposx + 150, 440);
            bg.Rotate(67780, bgangle); 
            blinder.Fade(77380, 78280, 0.75, 0);

            Vector2 bgposition2 = bg.PositionAt(86905);
            double bgangle2 = bg.RotationAt(86905);
;           double bgposx2 = bgposition2.X;
            double bgposy2 = bgposition2.Y;

            var bgglitch11 = GetLayer("").CreateSprite("sb/glitch/glitch1.jpg", OsbOrigin.Centre);
            var bgglitch22 = GetLayer("").CreateSprite("sb/glitch/glitch2.jpg", OsbOrigin.Centre);
            var bgglitch33 = GetLayer("").CreateSprite("sb/glitch/glitch3.jpg", OsbOrigin.Centre);
            var bgglitch44 = GetLayer("").CreateSprite("sb/glitch/glitch4.jpg", OsbOrigin.Centre);
            bgglitch11.Scale(86980, (360.0 / 768)*1.75);
            bgglitch22.Scale(87055, (360.0 / 768)*2.0);
            bgglitch33.Scale(87130, (360.0 / 768)*1.9);
            bgglitch44.Scale(87205, (360.0 / 768)*1.75);

            bgglitch11.Move(86980,bgposx2,bgposy2);
            bgglitch22.Move(87055,bgposx2,bgposy2);
            bgglitch33.Move(87130,bgposx2,bgposy2);
            bgglitch44.Move(87205,bgposx2,bgposy2);

            bgglitch11.Rotate(86980, bgangle2); 
            bgglitch22.Rotate(87055, bgangle2); 
            bgglitch33.Rotate(87130, bgangle2); 
            bgglitch44.Rotate(87205, bgangle2); 

            bgglitch11.Fade(86980, 87055, 0.8, 0.8);
            bgglitch11.Fade(87055, 87055, 0, 0);
            bgglitch22.Fade(87055, 87130, 0.8, 0.8);
            bgglitch22.Fade(87130, 87130, 0, 0);
            bgglitch33.Fade(87130, 87205, 0.8, 0.8);
            bgglitch33.Fade(87205, 87205, 0, 0);
            bgglitch44.Fade(87205, 87280, 0.8, 0.8);
            bgglitch44.Fade(87280, 87280, 0, 0);
            bg.Fade(87280, 87580, 0.8, 0);
            bgblur.Move(87280, bgposx2, bgposy2);
            bgblur.Scale(87280,(360.0 / 768)*1.5);
            bgblur.Fade(87280, 87580, 0, 0.75);
            blinder.Fade(87580, 88480, 1, 0);

            bg.Move(OsbEasing.InOutExpo, 87280, 87880, bgposx2, bgposy2, 320, 240);
            bg.Scale(OsbEasing.InOutExpo, 87280, 87880, (360.0 / 768)*1.5, (360.0 / 768)*1);

            bgblur.Move(OsbEasing.InOutExpo, 87280, 87880, blurposx, blurposy, 320, 240);
            bgblur.Scale(OsbEasing.InOutExpo, 87280, 87880, (360.0 / 768)*1.5, (360.0 / 768)*1);

            for(int i = 87580; i <= 125380; i += 750){
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

            blinder.Fade(106180, 107080, 0.75, 0);
            bgblur.Fade(124480, 124780, 0.75, 1);

            bgglitch1.Fade(125080,125155,1,1);
            bgglitch1.Fade(125155,125155,0,0);
            bgglitch2.Fade(125155,125230,1,1);
            bgglitch2.Fade(125230,125230,0,0);
            bgglitch3.Fade(125230,125305,1,1);
            bgglitch3.Fade(125305,125305,0,0);
            bgglitch4.Fade(125305,125380,1,1);
            bgglitch4.Fade(125380,125380,0,0);

            bgblur.Fade(125380, 125380, 0 ,0);
            var bg2 = GetLayer("Main").CreateSprite("Alice.(SINoALICE).full.2792424.jpg", OsbOrigin.Centre);
            bg2.Scale(125380, (360.0 / 768)*1);
            blinder.Fade(125380, 126280, 1, 0);
            bg2.Fade(125380, 144580, 0.85, 0.85);

            for(int i = 125380; i <= 144580; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                bg2.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                bg2.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                bg2.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
            bg2.Fade(144580, 144580, 0, 0);
            blinder.Fade(144580, 145180, 0.75, 0);
        }
        double GetRandomDouble(Random random, double min, double max)
        {
            return min + (random.NextDouble() * (max - min));
        }
        
    }
}
