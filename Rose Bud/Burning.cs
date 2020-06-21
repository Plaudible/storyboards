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
    public class Burning : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Main");
            var gear1 = layer.CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var gear2 = layer.CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var gear3 = layer.CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var gear4 = layer.CreateSprite("sb/g/g4.png", OsbOrigin.Centre);
            var gear5 = layer.CreateSprite("sb/g/g5.png", OsbOrigin.Centre);
            var gear6 = layer.CreateSprite("sb/g/g6.png", OsbOrigin.Centre);
            var flash = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            var alert = layer.CreateSprite("alert.png", OsbOrigin.Centre);
		    
            alert.MoveX(502985, 0);
            alert.MoveY(502985, 0);
            alert.Fade(502985,512585,1,1);
            for (int i = 502985; i < 512585; i += 1200){
                alert.Fade(i, i+600, 0, 1);
                alert.Fade(i, i+600, 1, 0);
            }
            //GEARS
            
            gear1.Fade(471271,475443,0,0.5);
            gear1.Fade(475443,512585,0.5,0.5);
            gear1.Scale(471271,0.2);
            gear1.MoveX(471271, 715);
            gear1.MoveY(471271, 55);
            gear1.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear1.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear1.Color(502985, 1, 0, 0);

            gear2.Fade(471271,475443,0,0.5);
            gear2.Fade(475271,512585,0.5,0.5);
            gear2.Scale(471271,0.2);
            gear2.MoveX(471271, 543);
            gear2.MoveY(471271, 50);
            gear2.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear2.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear2.Color(502985, 1, 0, 0);

            gear6.Fade(471271,475443,0,0.5);
            gear6.Fade(475443,512585,0.5,0.5);
            gear6.Scale(471271,0.2);
            gear6.MoveX(397214, 750);
            gear6.MoveY(397214, 200);
            gear6.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear6.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear6.Color(502985, 1, 0, 0);

            gear3.Fade(471271,475443,0,0.5);
            gear3.Fade(475443,512585,0.5,0.5);
            gear3.Scale(471271,0.2);
            gear3.MoveX(471271, -110);
            gear3.MoveY(471271, 270);
            gear3.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear3.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear3.Color(502985, 1, 0, 0);

            gear4.Fade(471271,475443,0,0.5);
            gear4.Fade(475443,512585,0.5,0.5);
            gear4.Scale(471271,0.2);
            gear4.MoveX(471271, -60);
            gear4.MoveY(471271, 400);
            gear4.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear4.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear4.Color(502985, 1, 0, 0);

            gear5.Fade(471271,475443,0,0.5);
            gear5.Fade(475443,512585,0.5,0.5);
            gear5.Scale(471271,0.2);
            gear5.MoveX(471271, 130);
            gear5.MoveY(471271, 450);
            gear5.Color(471271, 500243, 1, 1, 1, 1, 1, 1);
            gear5.Color(500243, 502985, 1, 1, 1, 1, 0, 0);
            gear5.Color(502985, 1, 0, 0);

            double spin = 0.001;
            double spininc = 0.00007;
            for (int i = 471271; i < 500243; i+=20){
                if (i < 498243){
                    spininc += 0.00007;
                    spin += spininc;
                    gear1.Rotate(i, spin);
                    gear2.Rotate(i, -spin);
                    gear3.Rotate(i, -spin);
                    gear4.Rotate(i, spin);
                    gear5.Rotate(i, -spin);
                    gear6.Rotate(i, -spin);
                }else{
                    spininc -= 0.00095;
                    spin += spininc;
                    gear1.Rotate(i, spin);
                    gear2.Rotate(i, -spin);
                    gear3.Rotate(i, -spin);
                    gear4.Rotate(i, spin);
                    gear5.Rotate(i, -spin);
                    gear6.Rotate(i, -spin);
                }
            }
            

            double spin2 = 0;
            for (int i = 502985; i <= 512585; i+=5){
                gear1.MoveX(i, 715);
                gear1.MoveY(i, 55);
                gear2.MoveX(i, 543);
                gear2.MoveY(i, 50);
                gear6.MoveX(i, 750);
                gear6.MoveY(i, 200);
                gear3.MoveX(i, -110);
                gear3.MoveY(i, 270);
                gear4.MoveX(i, -60);
                gear4.MoveY(i, 400);
                gear5.MoveX(i, 130);
                gear5.MoveY(i, 450);
                spin2 += 0.05;
                gear1.Rotate(i, spin2);
                gear1.MoveX(i, 715+Random(0,5));
                gear1.MoveY(i, 55+Random(0,5));
                gear2.Rotate(i, -spin2);
                gear2.MoveX(i, 543+Random(0,5));
                gear2.MoveY(i, 50+Random(0,5));
                gear3.Rotate(i, -spin2);
                gear3.MoveX(i, -110+Random(0,5));
                gear3.MoveY(i, 270+Random(0,5));
                gear4.Rotate(i, spin2);
                gear4.MoveX(i, -60+Random(0,5));
                gear4.MoveY(i, 400+Random(0,5));
                gear5.Rotate(i, -spin2);
                gear5.MoveX(i, 130+Random(0,5));
                gear5.MoveY(i, 450+Random(0,5));
                gear6.Rotate(i, -spin2);
                gear6.MoveX(i, 750+Random(0,5));
                gear6.MoveY(i, 200+Random(0,5));
            }
        }
    }
}
