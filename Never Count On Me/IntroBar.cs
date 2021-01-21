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
    public class IntroBar : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var pix = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            pix.ScaleVec(OsbEasing.Out, 719, 1052, 1, 1, 150, 1);
            pix.ScaleVec(1052, 6052, 150, 1, 225, 1);
            pix.Color(719, 1, 1, 1);
            pix.Fade(719, 22052, 1, 1);
            pix.Move(719, 320, 230);
            pix.Rotate(OsbEasing.Out, 6052, 6385, 0, Math.PI/2);
            pix.ScaleVec(OsbEasing.Out, 6052, 6082, 225, 1, 225, 10);
            pix.ScaleVec(OsbEasing.Out, 6082, 6385, 225, 10, 225, 1);
            pix.Move(OsbEasing.OutExpo, 6385, 7052, 320, 230, 420, 230);
            pix.ScaleVec(OsbEasing.Out, 6385, 6485, 225, 1, 225, 10);
            pix.ScaleVec(OsbEasing.Out, 6485, 7052, 225, 10, 225, 1);
 
            pix.Move(OsbEasing.OutExpo, 11385, 12052, 420, 230, 210, 230);
            pix.ScaleVec(OsbEasing.Out, 11385, 11485, 225, 1, 225, 15);
            pix.ScaleVec(OsbEasing.Out, 11485, 12052, 225, 15, 225, 1);

            pix.Rotate(OsbEasing.Out, 16719, 17052, Math.PI/2, 0);
            pix.ScaleVec(OsbEasing.Out, 16719, 16749, 225, 1, 225, 10);
            pix.ScaleVec(OsbEasing.Out, 16749, 17052, 225, 10, 225, 1);
            pix.Move(OsbEasing.Out, 16719, 17052, 210, 230, 320, 230);
            pix.Move(OsbEasing.Out, 17052, 17385, 320, 230, 320, 180);

            pix.ScaleVec(OsbEasing.Out, 17385, 17485, 225, 1, 225, 15);
            pix.ScaleVec(OsbEasing.Out, 17485, 18052, 225, 15, 225, 1);

            pix.Move(OsbEasing.OutExpo, 17385, 18052, 320, 180, 320, 320);

            //===============//

            pix.Move(OsbEasing.Out, 19385, 19719, 320, 320, 320, 240);
            pix.ScaleVec(OsbEasing.Out, 19385, 19719, 225, 1, 75, 75);
            pix.Rotate(OsbEasing.Out, 19552, 19885, 0, Math.PI/4);

            var pix1 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var pix2 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            OsbSprite[] subset1 = new OsbSprite[] {pix1, pix2};

            for(int i = 0; i < 2; i++){
                subset1[i].Fade(19885, 21719, 1, 1);
                subset1[i].ScaleVec(19885, 21052, 40, 40, 40, 40);
                subset1[i].Rotate(OsbEasing.OutExpo, 20052, 20385, 0, Math.PI/4);
            }

            pix1.Move(OsbEasing.Out, 19885, 20219, 320, 240, 470, 240);
            pix1.Move(OsbEasing.Out, 20219, 21219, 470, 240, 480, 240);
            pix2.Move(OsbEasing.Out,19885, 20219, 320, 240, 170, 240);
            pix2.Move(OsbEasing.Out,20219, 21219, 170, 240, 160, 240);

            var pix3 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var pix4 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            OsbSprite[] subset2 = new OsbSprite[] {pix3, pix4};

            for(int i = 0; i < 2; i++){
                subset2[i].Fade(20552, 21719, 1, 1);
                subset2[i].ScaleVec(20552, 20885, 20, 20, 20, 20);
                subset2[i].Rotate(OsbEasing.OutExpo, 20552, 20885, 0, Math.PI/4);
            }

            pix3.Move(OsbEasing.OutExpo, 20385, 20719, 470, 240, 570, 240);
            pix3.Move(20719, 21219, 570, 240, 575, 240);
            pix4.Move(OsbEasing.OutExpo,20385, 20719, 170, 240, 70, 240);
            pix4.Move(20719, 21219, 70, 240, 65, 240);

            pix3.ScaleVec(OsbEasing.In, 20885, 21052, 20, 20, 0, 0);
            pix4.ScaleVec(OsbEasing.In, 20885, 21052, 20, 20, 0, 0);

            pix1.ScaleVec(OsbEasing.In, 21052, 21219, 40, 40, 0, 0);
            pix2.ScaleVec(OsbEasing.In, 21052, 21219, 40, 40, 0, 0);

            pix.ScaleVec(OsbEasing.Out, 21219, 21385, 75, 75, 120, 120);
            pix.ScaleVec(OsbEasing.OutExpo, 21385,21719, 120, 120, 0, 0);
        }
    }
}
