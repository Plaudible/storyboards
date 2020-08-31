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
    public class Blinder : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Main");
		    var blinder = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var transition = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var transition2 = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var transition3 = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            var transition4 = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
            blinder.Fade(823, 1882, 0.75, 0);

            transition.Color(11765, 0, 0, 0);
            transition.Fade(11765, 12118, 1, 1);
            transition.Scale(11765, 1.1);
            transition.Rotate(11765, 0.5);
            transition.MoveY(OsbEasing.In, 11765, 12118, 1200, 200);
            transition.MoveX(11765, 180);
            transition.Fade(12118, 12118, 0, 0);

            transition.Fade(22882, 23412, 1, 1);
            transition.MoveY(OsbEasing.In, 22882, 23412, 1200, 200);
            transition.MoveX(22882, 180);
            transition.Fade(23412,23412, 0, 0);

            blinder.Fade(26235, 27294, 0.75, 0);    
            blinder.Fade(60118, 61176 , 0.75, 0);     

            transition.Fade(22882, 23412, 1, 1);
            transition.MoveY(OsbEasing.In, 22882, 23412, 1200, 200);
            transition.MoveX(22882, 180);
            transition.Fade(23412,23412, 0, 0);

            transition.Fade(71059, 71412, 1, 1);
            transition.MoveY(OsbEasing.In, 71059, 71412, 1200, 200);
            transition.MoveX(71059, 180);
            transition.Fade(71412,71412, 0, 0);

            transition.Fade(82176, 82706, 1, 1);
            transition.MoveY(OsbEasing.In, 82176, 82706, 1200, 200);
            transition.MoveX(82176, 180);
            transition.Fade(82706,82706, 0, 0);

            blinder.Fade(100000, 101059 , 0.75, 0); 

            transition2.Rotate(104235, -1.075398);
            transition2.Color(104235, 0,0,0);
            transition2.ScaleVec(OsbEasing.In, 104235, 105294, 0, 1.5, 1, 1.5);
            transition2.Fade(104235, 105294, 1, 1);

            blinder.Fade(105294, 106353 , 0.75, 0); 

            transition.Fade(116235, 116588, 1, 1);
            transition.MoveY(OsbEasing.In, 116235, 116588, 1200, 200);
            transition.MoveX(116235, 180);
            transition.Fade(116588,116588, 0, 0);

            transition.Fade(127529, 127882, 1, 1);
            transition.MoveY(OsbEasing.In, 127529, 127882, 1200, 200);
            transition.MoveX(127529, 180);
            transition.Fade(127882,127882, 0, 0);

            blinder.Fade(127882, 128941 , 0.75, 0); 
            blinder.Fade(150823, 151882 , 0.75, 0); 

            transition3.Rotate(150294, -1.075398);
            transition3.Color(150294, 0,0,0);
            transition3.Scale(150294, 1.1);
            transition3.Fade(150294, 151000, 1, 1);
            transition3.MoveY(OsbEasing.Out, 150294, 150735, 1600, 1000);
            transition3.MoveY(OsbEasing.In, 150735, 151000, 1000, 1600);
            transition3.MoveX(150294, -300);
            transition3.Fade(151000,151000, 0, 0);

            transition4.Rotate(150294, -1.075398);
            transition4.Fade(150294, 151000, 1, 1);
            transition4.Color(150294, 0,0,0);
            transition4.Scale(150294, 1.1);
            transition4.MoveY(OsbEasing.Out, 150294, 150735, -1200, -600);
            transition4.MoveY(OsbEasing.In, 150735, 151000, -600, -1200);
            transition4.MoveX(150294, 800);
            transition4.Fade(151000,151000, 0, 0);

            transition.Fade(175529, 175882, 1, 1);
            transition.MoveY(OsbEasing.In, 175529, 175882, 1200, 200);
            transition.MoveX(175529, 180);
            transition.Fade(175882,175882, 0, 0);

            transition.Fade(198118,198471, 1, 1);
            transition.MoveY(OsbEasing.In, 198118, 198471, 1200, 200);
            transition.MoveX(198118, 180);
            transition.Fade(198471,198471, 0, 0);
        }
    }
}
