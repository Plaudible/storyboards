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
    public class BreakdownSquare : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Foreground");
            var square2 = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var square = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            
            square2.Scale(120268,0.5);
            square2.Color(120268,1,0.722,0.766);
            double startRot = 0;
            double startRot2 = 0;
            square.Scale(120268,0.5);
            for(int i = 120268; i <= 142768; i+= 200){
                square.Rotate(i, i+200, startRot, startRot + 0.2);
                square2.Rotate(i, i+200, startRot2, startRot2 - 0.2);
                startRot += 0.2;
                startRot2 -= 0.2;
            }

            for(int i = 120268; i < 122268; i+=1500){
                square.Scale(i,i+150,0.55,0.5);
                square2.Scale(i,i+150,0.55,0.5);
                square.Scale(i+282,i+432,0.55,0.5);
                square2.Scale(i+282,i+432,0.55,0.5);
                square.Scale(i+564,i+714,0.55,0.5);
                square2.Scale(i+564,i+714,0.55,0.5);

                square.Scale(i+750,i+850,0.55,0.5);
                square2.Scale(i+750,i+850,0.55,0.5);
                square.Scale(i+938,i+1038,0.55,0.5);
                square2.Scale(i+938,i+1038,0.55,0.5);
                square.Scale(i+1125,i+1225,0.55,0.5);
                square2.Scale(i+1125,i+1225,0.55,0.5);
            }
            square.Scale(123456,123456+150,0.55,0.5);
            square.Scale(123737,123737+150,0.55,0.5);
            square2.Scale(123456,123456+150,0.55,0.5);
            square2.Scale(123737,123737+150,0.55,0.5);
            square.Scale(124018,124018+150,0.55,0.5);
            square.Scale(124206,124206+150,0.55,0.5);
            square.Scale(124393,124393+150,0.55,0.5);
            square2.Scale(124018,124018+150,0.55,0.5);
            square2.Scale(124206,124206+150,0.55,0.5);
            square2.Scale(124393,124393+150,0.55,0.5);

            for(int i = 124768; i < 129268; i+=1500){
                square.Scale(i,i+150,0.55,0.5);
                square2.Scale(i,i+150,0.55,0.5);
                square.Scale(i+282,i+432,0.55,0.5);
                square2.Scale(i+282,i+432,0.55,0.5);
                square.Scale(i+564,i+714,0.55,0.5);
                square2.Scale(i+564,i+714,0.55,0.5);

                square.Scale(i+750,i+850,0.55,0.5);
                square2.Scale(i+750,i+850,0.55,0.5);
                square.Scale(i+938,i+1038,0.55,0.5);
                square2.Scale(i+938,i+1038,0.55,0.5);
                square.Scale(i+1125,i+1225,0.55,0.5);
                square2.Scale(i+1125,i+1225,0.55,0.5);
            }

            square.Scale(129456,129456+150,0.55,0.5);
            square.Scale(129737,129737+150,0.55,0.5);
            square2.Scale(129456,129456+150,0.55,0.5);
            square2.Scale(129737,129737+150,0.55,0.5);
            square.Scale(130018,130018+150,0.55,0.5);
            square.Scale(130206,130206+150,0.55,0.5);
            square.Scale(130393,130393+150,0.55,0.5);
            square2.Scale(130018,130018+150,0.55,0.5);
            square2.Scale(130206,130206+150,0.55,0.5);
            square2.Scale(130393,130393+150,0.55,0.5);

            square.Scale(130768,130768+150,0.55,0.5);
            square2.Scale(130768,130768+150,0.55,0.5);
            square.Scale(131143,131143+150,0.55,0.5);
            square.Scale(131518,131518+150,0.55,0.5);
            square.Scale(131331,131331+150,0.55,0.5);
            square.Scale(131800,131800+150,0.55,0.5);
            square2.Scale(131143,131143+150,0.55,0.5);
            square2.Scale(131518,131518+150,0.55,0.5);
            square2.Scale(131331,131331+150,0.55,0.5);
            square2.Scale(131800,131800+150,0.55,0.5);

        for(int i = 132268; i < 141268; i+=3000){
                square.Scale(i,i+150,0.55,0.5);
                square.Scale(i+282, i+432, 0.55, 0.5);
                square.Scale(i+564,i+714,0.55,0.5);
                square.Scale(i+844,i+994,0.55,0.5);
                square.Scale(i+1125,i+1275,0.55,0.5);
                square.Scale(i+1407,i+1557,0.55,0.5);
                square.Scale(i+1688,i+1838,0.55,0.5);
                square.Scale(i+1969,i+2119,0.55,0.5);
                square.Scale(i+2250,i+2400,0.55,0.5);
                square.Scale(i+2438,i+2588,0.55,0.5);
                square.Scale(i+2625,i+2775,0.55,0.5);
                square.Scale(i+2813,i+2963,0.55,0.5);

                square2.Scale(i,i+150,0.55,0.5);
                square2.Scale(i+282, i+432, 0.55, 0.5);
                square2.Scale(i+564,i+714,0.55,0.5);
                square2.Scale(i+844,i+994,0.55,0.5);
                square2.Scale(i+1125,i+1275,0.55,0.5);
                square2.Scale(i+1407,i+1557,0.55,0.5);
                square2.Scale(i+1688,i+1838,0.55,0.5);
                square2.Scale(i+1969,i+2119,0.55,0.5);
                square2.Scale(i+2250,i+2400,0.55,0.5);
                square2.Scale(i+2438,i+2588,0.55,0.5);
                square2.Scale(i+2625,i+2775,0.55,0.5);
                square2.Scale(i+2813,i+2963,0.55,0.5);

            }
            square.Scale(141268,141268+150,0.55,0.5);
            square.Scale(141550,141550+150,0.55,0.5);
            square.Scale(141831,141831+150,0.55,0.5);
            square.Scale(142112,142112+150,0.55,0.5);
            square.Scale(142393,142393+150,0.55,0.5);
            square.Scale(142581,142581+150,0.55,0.5);
            square2.Scale(141268,141268+150,0.55,0.5);
            square2.Scale(141550,141550+150,0.55,0.5);
            square2.Scale(141831,141831+150,0.55,0.5);
            square2.Scale(142112,142112+150,0.55,0.5);
            square2.Scale(142393,142393+150,0.55,0.5);
            square2.Scale(142581,142581+150,0.55,0.5);

            square.Fade(142581,142768, 1, 0);
            square2.Fade(142581,142768, 1, 0);
        }

    }
}
