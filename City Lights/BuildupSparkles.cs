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
    public class BuildupSparkles : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            Random rand = new Random();
            Sparkle(rand, 113, 180);
            Sparkle(rand, 60, 75);
            Sparkle(rand, 572, -11);
            Sparkle(rand, 365, 93);
            Sparkle(rand, 357, 310);
            Sparkle(rand, 558, 160);
            Sparkle(rand, 45, 142);
            Sparkle(rand, 223, 380);
            Sparkle(rand, 215, 238);
            Sparkle(rand, 176,190);
            Sparkle(rand, 571,36);
            Sparkle(rand, 213,-50);
            Sparkle(rand, 400,244); 
            Sparkle(rand, 494,88);
            Sparkle(rand, 420,150);
            Sparkle(rand, 329, 210);

            Sparkle2(rand, 113, 180);
            Sparkle2(rand, 60, 75);
            Sparkle2(rand, 572, -11);
            Sparkle2(rand, 365, 93);
            Sparkle2(rand, 357, 310);
            Sparkle2(rand, 558, 160);
            Sparkle2(rand, 45, 142);
            Sparkle2(rand, 223, 380);
            Sparkle2(rand, 215, 238);
            Sparkle2(rand, 176,190);
            Sparkle2(rand, 571,36);
            Sparkle2(rand, 213,-50);
            Sparkle2(rand, 400,244); 
            Sparkle2(rand, 494,88);
            Sparkle2(rand, 420,150);
            Sparkle2(rand, 329, 210);


        }
        public void Sparkle(Random rand, double xpos, double ypos){
            var layer = GetLayer("Foreground");
            var sparkle = layer.CreateSprite("sb/twinkle"+(rand.Next(1,6))+".png", OsbOrigin.Centre);
            sparkle.Scale(36269, 0.25);
            sparkle.Fade(36269, 36643, 0, 0.5);
            sparkle.Fade(36643, 46769, 0.5, 0.5);
            sparkle.MoveX(36269, xpos);

            double yrot = 0;
            for(int i = 36269; i <= 46769; i += 500){
                sparkle.MoveY(i, i+500, ypos, ypos + 4.6);
                sparkle.Rotate(i, i+500, yrot, yrot + 0.3);
                ypos += 4.6;
                yrot += 0.3;
            }
        }

        public void Sparkle2(Random rand, double xpos, double ypos){
            var layer = GetLayer("Foreground");
            var sparkle = layer.CreateSprite("sb/twinkle"+(rand.Next(1,6))+".png", OsbOrigin.Centre);
            sparkle.Scale(156268, 0.25);
            sparkle.Fade(156268, 156643, 0, 0.5);
            sparkle.Fade(156643, 166768, 0.5, 0.5);
            sparkle.MoveX(156268, xpos);

            double yrot = 0;
            for(int i = 156268; i < 166768; i += 500){
                sparkle.MoveY(i, i+500, ypos, ypos + 4.6);
                sparkle.Rotate(i, i+500, yrot, yrot + 0.3);
                ypos += 4.6;
                yrot += 0.3;
            }
        }
    }
}
