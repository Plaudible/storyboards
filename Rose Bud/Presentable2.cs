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
    public class Presentable2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("sb/thumb-1920-654376.jpg", OsbOrigin.Centre);
            var bgMod = layer.CreateSprite("sb/thumb-1920-654376.jpg", OsbOrigin.Centre);
            var bgMod2 = layer.CreateSprite("sb/thumb-1920-654376.jpg", OsbOrigin.Centre);
            var bgMod3 = layer.CreateSprite("sb/thumb-1920-654376.jpg", OsbOrigin.Centre);
            bg.Scale(326071, 360.0 / 768);
            bg.Rotate(326071,0);
            bg.MoveX(326071,320);
            bg.MoveY(326071,240);
            bg.Fade(326071, 397386, 0.75, 0.75);
            bg.Fade(397386, 397386, 0,0 );
            bgMod.Scale(397386, (360.0 / 768)*1.45);
            bgMod.Rotate(397386,0.20);

            int xPos = 320;
            for(int i = 397386; i < 416586; i+=343){
                if(i >= 416386){
                    bgMod.Fade(0,0,0,0);
                }
                bgMod.MoveX(i, i+343, xPos, xPos - 3);
                xPos -= 3;
            }
            bgMod.Fade(397386, 416586, 0.75, 0.75);
            bg.Fade(416586, 499843, 0.75, 0.75);
            bg.Fade(499843, 500243, 0.75, 0.25);
            bg.Fade(500243, 502985, 0.25, 0.25);
            bg.Fade(502985, 512585, 0, 0); 
            bg.Fade(512585, 555785, 0.75, 0.75);
            bg.Fade(555785, 555785, 0, 0);
            bgMod2.Scale(397386, (360.0 / 768)*1.45);
            bgMod2.Rotate(397386,0.20);

            xPos = 175;
            for(int i = 555785; i < 574985; i+=343){
                if(i >= 416386){
                    bgMod2.Fade(0,0,0,0);
                }
                bgMod2.MoveX(i, i+343, xPos, xPos + 3);
                xPos += 3;
            }
            bgMod2.Fade(555785, 574985, 0.75, 0.75); 

            bg.Fade(574985, 679691, 0.75, 0.75);
            bg.Fade(679691, 695690, 0.75, 0);

            bgMod3.Scale(502985, (360.0 / 768));

            for(int i = 502985; i < 512585; i+=1200){
                if(i >= 512585){
                    bgMod3.Fade(0,0,0,0);
                }
                bgMod3.Color(OsbEasing.Out, i, i+600, 1, 1, 1, 0.9, 0.5, 0.5);
                bgMod3.Color(OsbEasing.In, i+600, i+1200, 0.9, 0.5, 0.5, 1, 1, 1);
            }
            bgMod3.Fade(502985, 512585, 0.75, 0.75);
        }

    }
}
