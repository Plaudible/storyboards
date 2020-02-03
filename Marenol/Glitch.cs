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
    public class Glitch : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            
            var glitch1 = layer.CreateSprite("sb/glitch1.png", OsbOrigin.Centre);
            var glitch2 = layer.CreateSprite("sb/glitch2.png", OsbOrigin.Centre);
            var glitch3 = layer.CreateSprite("sb/glitch3.png", OsbOrigin.Centre);
            var glitch1Color = layer.CreateSprite("sb/glitch1.png", OsbOrigin.Centre);
            var glitch2Color = layer.CreateSprite("sb/glitch2.png", OsbOrigin.Centre);
            var glitch3Color = layer.CreateSprite("sb/glitch3.png", OsbOrigin.Centre);
            glitch1.Scale(32192, 0.9);
            glitch2.Scale(32407, 0.8);
            glitch3.Scale(32514, 1.1);
            glitch1.Fade(32192,32514,0.6,0.6);
            glitch2.Fade(32407,32514,0.6,0.6);
            glitch3.Fade(32514,32621,0.6,0.6);
            glitch2.Rotate(32407,0.15);
            glitch3.Rotate(32514,0.4);

            glitch1.Fade(32621,32621,0,0);
            glitch2.Fade(32621,32621,0,0);
            glitch3.Fade(32621,32621,0,0);
            Random rnd = new Random();
            for(int i = 32192; i < 32514; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1.MoveX(i,i+5,320, 310-randomthing);
                glitch1.MoveY(i,i+5,220, 210-randomthing);
            }
            for(int i = 32407; i < 32514; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch2.MoveX(i,i+5,320, 310-randomthing);
                glitch2.MoveY(i,i+5,220, 210-randomthing);
            }
            for(int i = 32514; i < 32621; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch3.MoveX(i,i+5,320, 310-randomthing);
                glitch3.MoveY(i,i+5,220, 210-randomthing);
            }
            glitch1.Fade(34121,34335,0.6,0.6);
            glitch1.Scale(34121, 0.9);
            glitch1.Rotate(34121,-0.2);
            for(int i = 34121; i < 34335; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1.MoveX(i,i+5,320, 310-randomthing);
                glitch1.MoveY(i,i+5,220, 210-randomthing);
            }

            glitch1.Fade(34335,34335,0,0);
            glitch1Color.Fade(39478,39478,0.6,0.6);
            glitch1Color.Scale(39478, 0.9);
            glitch1Color.Rotate(39478,0.2);
            glitch1Color.Color(39478,1,0.34,0.34);
            for(int i = 39478; i < 42907; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1Color.MoveX(i,i+5,320, 319-randomthing);
                glitch1Color.MoveY(i,i+5,250, 249-randomthing);
            }
            glitch2Color.Color(42907,1,0.34,0.34);
            glitch2Color.Scale(42907, 1.3);
            glitch2Color.Rotate(42907,0.2);
            glitch3Color.Color(42907,1,0.34,0.34);
            glitch3Color.Scale(42907, 1.1);
            glitch3Color.Rotate(42907,0.2);
            for(int i = 42907; i < 44621; i+=10){
                int randomthing = rnd.Next(1,3);
                if (randomthing == 1){
                glitch1Color.Fade(i,i+5,0.75,0.75);
                glitch1Color.MoveX(i,i+5,320, 319-randomthing);
                glitch1Color.MoveY(i,i+5,250, 249-randomthing);
                glitch1Color.Fade(i+5,i+5,0,0);
                }
                if (randomthing == 2){
                glitch2Color.Fade(i,i+5,0.75,0.75);
                glitch2Color.MoveX(i,i+5,320, 319-randomthing);
                glitch2Color.MoveY(i,i+5,250, 249-randomthing);
                glitch2Color.Fade(i+5,i+5,0,0);
                }
                if (randomthing == 3){
                glitch3Color.Fade(i,i+5,0.75,0.75);
                glitch3Color.MoveX(i,i+5,320, 319-randomthing);
                glitch3Color.MoveY(i,i+5,250, 249-randomthing);
                glitch3Color.Fade(i+5,i+5,0,0);
                }
            }
            glitch1.Fade(52978,53192,0.6,0.6);
            glitch1.Scale(34121, 0.8);
            glitch1.Rotate(34121,-0.15);
            for(int i = 52978; i < 53192; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1.MoveX(i,i+5,320, 310-randomthing);
                glitch1.MoveY(i,i+5,220, 210-randomthing);
            }

            glitch1.Fade(53192,53192,0,0);
            glitch1.Fade(65192,66050,0.5,0);
            for(int i = 65192; i < 66050; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1.MoveX(i,i+5,320, 310-randomthing);
                glitch1.MoveY(i,i+5,220, 210-randomthing);
            }
            glitch2.Rotate(66050,-0.4);
            glitch2.Scale(66050, 1.1);
            glitch2.Fade(66050,66585,0.4,0);
            for(int i = 66050; i < 66585; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch2.MoveX(i,i+5,320, 310-randomthing);
                glitch2.MoveY(i,i+5,220, 210-randomthing);
            }
            glitch3.Rotate(66478,0.6);
            glitch3.Fade(66478,66692,0.3,0);
            glitch3.Scale(66478, 1.1);
            for(int i = 66478; i < 66692; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch3.MoveX(i,i+5,320, 310-randomthing);
                glitch3.MoveY(i,i+5,220, 210-randomthing);
            }

            glitch1.Fade(66692,66907,0.6,0.6);
            glitch1.Fade(66907,66907,0,0);
            glitch1.Fade(87264,87478,0.6,0.6);
            for(int i = 87264; i < 87478; i+=10){
                int randomthing = rnd.Next(-3,3);
                glitch1.MoveX(i,i+5,320, 310-randomthing);
                glitch1.MoveY(i,i+5,220, 210-randomthing);
            }
        }
    }
}
