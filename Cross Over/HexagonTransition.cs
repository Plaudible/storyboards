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
    
    public class HexagonTransition : StoryboardObjectGenerator
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
            var img3 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var list = new[] {img, img2, img3, img4, img5}.ToList();

            int startPos = 80;
            for(int i = 0; i <= 4; i++){
                list[i].Move(StartTime, startPos, 264);
                list[i].Fade(0, 0, 0, 0);
                  startPos += 120;
            }

            int current = 0;
            for (int i = StartTime; i < StartTime + 310; i+= 75){
                if(current!=2){
                 list[current].Fade(i-100, EndTime, 1, 1);
                }
                list[current].ScaleVec(OsbEasing.Out, i-100, i+100, 0, 0, 0.25, 0.25);
                list[current].Rotate(OsbEasing.Out, i-100, i+100, 0, 1.5708);
               if (current < 4)
                current++;
            }

            list[2].Fade(StartTime - 100, 9880, 1, 1);
            list[2].ScaleVec(OsbEasing.Out, 9430, 9880, 0.25, 0.25, 0.5, 0.5);
            list[2].ScaleVec(OsbEasing.InExpo, 9880, 10180, 0.5, 0.5, 7.5, 7.5);
            list[2].Fade(9880, 10180, 1,0.75);

            for (int i = 0; i < list.Count; i++){
                list[i].Rotate(OsbEasing.Out, 9430, 9630, 1.5708, 1.0472);
            }

            int current3 = 0;
            for (int i = StartTime + 900; i < StartTime + 900 + 310; i+= 75){
                Vector2 currentPosition = list[current3].PositionAt(i);
                double currentX = currentPosition.X;
                list[current3].Move(OsbEasing.In, i-200, i+100, currentX, 264, currentX, 650);           
               if (current3 < 4)
                current3++;
               if (current3 == 2){
                current3++;
               }
               

            }

        }
    }
}
