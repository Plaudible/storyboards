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
    public class Song2ChorusTwo : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var layer2 = GetLayer("Foreground");
            var inner = layer2.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var outer = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var gear1 = layer.CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var gear2 = layer.CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var gear3 = layer.CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var gear4 = layer.CreateSprite("sb/g/g4.png", OsbOrigin.Centre);
            var gear5 = layer.CreateSprite("sb/g/g5.png", OsbOrigin.Centre);
            var gear6 = layer.CreateSprite("sb/g/g6.png", OsbOrigin.Centre);
            var flash = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            
            //SQUARES

            inner.Fade(555614,555785,0,1);
            inner.Fade(555785,574985,1,1);
            inner.MoveX(224795, 315);
            inner.Scale(224795,0.50);

            outer.Fade(555614,555785,0,1);
            outer.Fade(555785,574985,1,1);
            outer.MoveX(555614, 315);
            outer.Scale(555614,0.5);
            outer.Color(555614,0.332,0.0585,0.6133);

            double spin = 0;
            for (int i = 555614; i <= 574985; i+=5){
                spin += 0.005;
                inner.Rotate(i, spin);
                outer.Rotate(i, -spin);
            }

            for (int i = 555785; i <= 574985; i+=343){
                inner.Scale(i, i+200, 0.55, 0.5);
                outer.Scale(i, i+200, 0.55, 0.5);
            }

            flash.Scale(555785,5);
            flash.Fade(555785,397729, 0.25,0);

            flash.Fade(574985,416929, 0.25,0);

            //GEARS
            
            gear1.Fade(555614,555785,0,0.5);
            gear1.Fade(555785,574985,0.5,0.5);
            gear1.Scale(555614,0.2);
            gear1.MoveX(555614, 715);
            gear1.MoveY(555614, 55);

            gear2.Fade(555614,555785,0,0.5);
            gear2.Fade(555614,574985,0.5,0.5);
            gear2.Scale(555614,0.2);
            gear2.MoveX(555614, 543);
            gear2.MoveY(555614, 50);
            
            gear6.Fade(555614,555856,0,0.5);
            gear6.Fade(555785,574985,0.5,0.5);
            gear6.Scale(555614,0.2);
            gear6.MoveX(397214, 750);
            gear6.MoveY(397214, 200);

            gear3.Fade(555614,555785,0,0.5);
            gear3.Fade(555785,574985,0.5,0.5);
            gear3.Scale(555614,0.2);
            gear3.MoveX(555614, -110);
            gear3.MoveY(555614, 270);

            gear4.Fade(555614,555785,0,0.5);
            gear4.Fade(555785,574985,0.5,0.5);
            gear4.Scale(555614,0.2);
            gear4.MoveX(555614, -60);
            gear4.MoveY(555614, 400);

            gear5.Fade(555614,555785,0,0.5);
            gear5.Fade(555785,574985,0.5,0.5);
            gear5.Scale(555614,0.2);
            gear5.MoveX(555614, 130);
            gear5.MoveY(555614, 450);

            double spin2 = 0;
            for (int i = 555614; i <= 574985; i+=5){
                spin2 += 0.003;
                gear1.Rotate(i, spin2);
                gear2.Rotate(i, -spin2);
                gear3.Rotate(i, -spin2);
                gear4.Rotate(i, spin2);
                gear5.Rotate(i, -spin2);
                gear6.Rotate(i, -spin2);
            }
            
        }
    }
}
