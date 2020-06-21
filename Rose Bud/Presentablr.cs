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
    public class Presentablr : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("thumb-1920-654377.jpg", OsbOrigin.Centre);
            var bgMod = layer.CreateSprite("thumb-1920-654377.jpg", OsbOrigin.Centre);
            var bgMod2 = layer.CreateSprite("thumb-1920-654377.jpg", OsbOrigin.Centre);
            var flash = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            var bg2 = layer.CreateSprite("thumb-1920-654377.jpg", OsbOrigin.Centre);

            bg.Scale(0, 360.0 / 768);
            bg.Rotate(0,0);
            bg.MoveX(0,320);
            bg.MoveY(0,240);
            bg.Fade(0, 108039, 0.5, 0.5);
            flash.Scale(108039,5);
            flash.Fade(106539, 108039, 0,0.5);
            flash.Fade(108039, 109039, 0.5,0);
            bg.Fade(108039, 224795, 0.75, 0.75);

            bgMod.Fade(224795, 242957, 0.75, 0.75);
            bgMod.Scale(224795, (360.0 / 768)*1.35);
            bgMod.MoveX(224795, 555);
            bgMod.MoveY(224795, 250);
            bgMod.Rotate(224795,0.2);
            bg.Fade(224795, 224795, 0, 0);

            int xPos = 425;
            for(int i = 224795; i < 242857; i+=648){
                if(i >= 242957){
                    bgMod.Fade(0,0,0,0);
                }
                bgMod.MoveX(i, i+648, xPos, xPos + 3);
                xPos += 3;
            }

            bg.Fade(242857, 271498, 0.75, 0.75);

            bgMod2.Fade(271498, 289660, 0.75, 0.75);
            bgMod2.Fade(289660, 289660, 0, 0);
            bgMod2.Scale(271498, (360.0 / 768)*1.25);
            bgMod2.MoveX(271498, 250);
            bgMod2.MoveY(271498, 250);
            bgMod2.Rotate(271498,-0.2);
            bg.Fade(271498, 271498, 0, 0);

            xPos = 250;
            for(int i = 271498; i < 289660; i+=648){
                if(i >= 289660){
                    bgMod2.Fade(0,0,0,0);
                }
                bgMod2.MoveX(i, i+648, xPos, xPos - 3);
                xPos -= 3;
            }

            bg2.Scale(289660, 360.0 / 768);
            bg2.Rotate(289660,0);
            bg2.MoveX(289660,320);
            bg2.MoveY(289660,240);
            bg2.Fade(289660, 326072, 0.75, 0.75);

            flash.Fade(325732, 326071, 0,0.5);
            flash.Fade(326071, 326243, 0.5,0);
        }
    }
}
