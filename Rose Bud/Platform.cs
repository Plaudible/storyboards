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
    public class Platform : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bar = layer.CreateSprite("sb/bf.png", OsbOrigin.Centre);
            bar.Scale(0, 0.75);
            bar.Rotate(OsbEasing.Out, 2289, 3039, 4.65, 4.71239);
            bar.MoveY(2289, 450);
            bar.MoveX(OsbEasing.Out, 2289, 3039, 50, 0);
            bar.Fade(2289, 3000, 0, 1);
            
            bar.Rotate(OsbEasing.InOutExpo,224633, 224957, 4.71239, 4.71239 + Math.PI);
            bar.MoveX(OsbEasing.InOutExpo, 224633, 224957, 0, 450);
            bar.MoveY(OsbEasing.InOutExpo, 224633, 224957, 450, 375);
            bar.Rotate(OsbEasing.InOutExpo,242876, 243282, 4.71239 + Math.PI, 4.71239);
            bar.MoveY(OsbEasing.InOutExpo, 242876, 243282, 375, 450);
            bar.MoveX(OsbEasing.InOutExpo, 242876, 243282, 450, 0);

            bar.MoveX(OsbEasing.InOutExpo, 271336, 271822, 0, 200);
            bar.Rotate(OsbEasing.InOutExpo,271336, 271822, 4.71239, 4.71239 + Math.PI);
            bar.MoveY(OsbEasing.InOutExpo, 271336, 271822, 450, 375);
            bar.MoveX(OsbEasing.InOutExpo, 289498, 289822, 200, 0);
            bar.Rotate(OsbEasing.InOutExpo,289498, 289822, 4.71239 + Math.PI, 4.71239);
            bar.MoveY(OsbEasing.InOutExpo, 289498, 289822, 375, 450);

            bar.MoveX(OsbEasing.InOutExpo, 325732, 326072, 0, 650);

            bar.MoveX(OsbEasing.InOutExpo, 397043, 397557, 650, 315);
            bar.Rotate(OsbEasing.InOutExpo,397043, 397557, 4.71239, 4.71239 + Math.PI);
            bar.MoveY(OsbEasing.InOutExpo, 397043, 397557, 450, 375);
            bar.MoveX(OsbEasing.InOutExpo, 416243, 416757, 315, 650);
            bar.Rotate(OsbEasing.InOutExpo,416243, 416757, 4.71239 + Math.PI, 4.71239);
            bar.MoveY(OsbEasing.InOutExpo, 416243, 416757, 375, 450);

            bar.MoveX(OsbEasing.InOutExpo, 555442, 555956, 650, 315);
            bar.Rotate(OsbEasing.InOutExpo,555442, 555956, 4.71239, 4.71239 + Math.PI);
            bar.MoveY(OsbEasing.InOutExpo, 555442, 555956, 450, 375);
            bar.MoveX(OsbEasing.InOutExpo, 574642, 575156, 315, 650);
            bar.Rotate(OsbEasing.InOutExpo,574642, 575156, 4.71239 + Math.PI, 4.71239);
            bar.MoveY(OsbEasing.InOutExpo, 574642, 575156, 375, 450);

            bar.Fade(679491, 679691, 1, 0); 
            
        }
    }
}
