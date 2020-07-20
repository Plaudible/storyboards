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
    
    public class SquareTransition : StoryboardObjectGenerator
    {
        [Configurable]
        public string ImagePath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;
        public override void Generate()
        {
		    var img = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img2 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img3 = GetLayer("").CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var img4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var list = new[] {img, img2, img4, img5}.ToList();

            int startPos = 80;
            for(int i = 0; i <= 3; i++){
                list[i].Move(StartTime, startPos, 264);
                list[i].Fade(0, 0, 0, 0);
                if(startPos < 200 || startPos > 320){
                  startPos += 120;
                }else{
                  startPos +=240;
                }
            }

            int current = 0;
            for (int i = StartTime; i < StartTime + 310; i+= 75){
                list[current].Fade(i-100, EndTime, 1, 1);
                list[current].ScaleVec(OsbEasing.Out, i-100, i+100, 0, 0, 1, 1);
                list[current].Rotate(OsbEasing.Out, i-100, i+100, 0, 1.5708);
               if (current < 3)
                current++;
            }

            for(int i = 0; i <= 3; i++){ 
                 list[i].ScaleVec(OsbEasing.Out, 9430, 9730, 1, 1, 2, 2);
                 list[i].ScaleVec(OsbEasing.In, 9730, 10180, 2, 2, 2.5, 2.5);
            } 

            img3.ScaleVec(OsbEasing.Out, 9205, 9355, 0, 0, 0.05, 0.0875);
            //img3.Rotate(OsbEasing.Out, 9205, 9355, 1.5708, 0);
            img3.Move(9205, 320, 264);
            img3.Fade(9205, 10180, 1, 1);

        }
    }
}
