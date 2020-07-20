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
    
    public class HexagonTransitionBugged : StoryboardObjectGenerator
    {
        [Configurable]
        public string ImagePath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;
        public override void Generate()
        {
            var imgr = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgr2 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgr3 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgr4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgr5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);

            var imgb = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgb2 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgb3 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgb4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgb5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);

		    var img = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img2 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img3 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var img5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);

            var imgx = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgx2 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgx3 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgx4 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var imgx5 = GetLayer("").CreateSprite(ImagePath, OsbOrigin.Centre);
            var list = new[] {img, img2, img3, img4, img5}.ToList();
            var listReal = new[] {imgx, imgx2, imgx3, imgx4, imgx5}.ToList();

            int startPos = 80;
            for(int i = 0; i <= 4; i++){
                list[i].Move(StartTime, startPos, 264);
                list[i].Fade(0, 0, 0, 0);
                  startPos += 120;
            }

            for(int i = 0; i <= 4; i++){
                listReal[i].Fade(0, 0, 0, 0);
                listReal[i].ScaleVec(0, 0.25, 0.25);
            }

            int current = 0;
            for (int i = StartTime; i < StartTime + 310; i+= 75){
                if(current!=2){
                 list[current].Fade(i-100, 125080, 1, 1);
                }
                list[current].ScaleVec(OsbEasing.Out, i-100, i+100, 0, 0, 0.25, 0.25);
                list[current].Rotate(OsbEasing.Out, i-100, i+100, 0, 1.5708);
               if (current < 4)
                current++;
            }

            list[2].Fade(StartTime - 100, 125080, 1, 1);
            list[2].ScaleVec(OsbEasing.Out, 124630, 125080, 0.25, 0.25, 0.5, 0.5);
            //list[2].ScaleVec(OsbEasing.InExpo, 125080, 125380, 0.5, 0.5, 7.5, 7.5);
            //list[2].Fade(125080, 125380, 1,0.75);

            for (int i = 0; i < list.Count; i++){
                list[i].Rotate(OsbEasing.Out, 124630, 125380, 1.5708, 1.0472);
            }


            list[0].Move(OsbEasing.In, 124930, 125155, 80, 264, 80, 650);       
            list[1].Move(OsbEasing.In, 125005, 125230, 200, 264, 200, 650);
            list[3].Move(OsbEasing.In, 125080, 125305, 440, 264, 440, 650);    
            list[4].Move(OsbEasing.In, 125155, 125380, 560, 264, 560, 650);            

            Vector2 position1 = list[0].PositionAt(125080);
            double angle1 = list[0].RotationAt(125080);
            double posx1 = position1.X;
            double posy1 = position1.Y;

            Vector2 position2 = list[1].PositionAt(125080);
            double angle2 = list[1].RotationAt(125080);
            double posx2 = position2.X;
            double posy2 = position2.Y;

            Vector2 position3 = list[2].PositionAt(125080);
            double angle3 = list[2].RotationAt(125080);
            double posx3 = position3.X;
            double posy3 = position3.Y;

            Vector2 position4 = list[3].PositionAt(125080);
            double angle4 = list[3].RotationAt(125080);
            double posx4 = position4.X;
            double posy4 = position4.Y;

            Vector2 position5 = list[4].PositionAt(125080);
            double angle5 = list[4].RotationAt(125080);
            double posx5 = position5.X;
            double posy5 = position5.Y;

            list[0].Fade(125080,125380, 0, 0);
            listReal[0].Fade(125080, 125380, 1, 1);
            list[1].Fade(125080,125380, 0, 0);
            listReal[1].Fade(125080, 125380, 1, 1);
            //list[2].Fade(125080+150, 0);
            //listReal[2].Fade(125080+150, 125380, 1, 1);
            list[3].Fade(125080,125380, 0, 0);
            listReal[3].Fade(125080, 125380, 1, 1);
            list[4].Fade(125080,125380, 0, 0);
            listReal[4].Fade(125080, 125380, 1, 1);

            
            
            imgr.Fade(0, 0, 0, 0);
            imgr.ScaleVec(0, 0.25, 0.25);
            imgr2.Fade(0, 0, 0, 0);
            imgr2.ScaleVec(0, 0.25, 0.25);
            imgr3.Fade(0, 0, 0, 0);
            imgr3.ScaleVec(0, 0.25, 0.25);
            imgr4.Fade(0, 0, 0, 0);
            imgr4.ScaleVec(0, 0.25, 0.25);
            imgr5.Fade(0, 0, 0, 0);
            imgr5.ScaleVec(0, 0.25, 0.25);

            imgr.Color(0,0.8,0.06,0.223);
            imgr2.Color(0,0.8,0.06,0.223);
            imgr3.Color(0,0.8,0.06,0.223);
            imgr4.Color(0,0.8,0.06,0.223);
            imgr5.Color(0,0.8,0.06,0.223);
            

            imgb.Fade(0, 0, 0, 0);
            imgb.ScaleVec(0, 0.25, 0.25);
            imgb2.Fade(0, 0, 0, 0);
            imgb2.ScaleVec(0, 0.25, 0.25);
            imgb3.Fade(0, 0, 0, 0);
            imgb3.ScaleVec(0, 0.25, 0.25);
            imgb4.Fade(0, 0, 0, 0);
            imgb4.ScaleVec(0, 0.25, 0.25);
            imgb5.Fade(0, 0, 0, 0);
            imgb5.ScaleVec(0, 0.25, 0.25);

            imgb.Color(0,0.058,0.98,0.98);
            imgb2.Color(0,0.058,0.98,0.98);
            imgb3.Color(0,0.058,0.98,0.98);
            imgb4.Color(0,0.058,0.98,0.98);
            imgb5.Color(0,0.058,0.98,0.98);

            imgr.Fade(125080, 125380, 0.25, 0.25);
            imgr2.Fade(125080, 125380, 0.25, 0.25);
            imgr3.Fade(125080, 125380, 0.25, 0.25);
            imgr4.Fade(125080, 125380, 0.25, 0.25);
            imgr5.Fade(125080, 125380, 0.25, 0.25);
            
            imgb.Fade(125080, 125380, 0.25, 0.25);
            imgb2.Fade(125080, 125380, 0.25, 0.25);
            imgb3.Fade(125080, 125380, 0.25, 0.25);
            imgb4.Fade(125080, 125380, 0.25, 0.25);
            imgb5.Fade(125080, 125380, 0.25, 0.25);

            imgr3.ScaleVec(125080,0.5,0.5);
            imgb3.ScaleVec(125080,0.5,0.5);
            imgr3.Move(125080, posx3-5, posy3+2);
            imgb3.Move(125080, posx3+5, posy3-2);

            for(int i = 125080; i <= 125380; i+= 75){
                listReal[0].Move(i, i+75, posx1, posy1, posx1, posy1+20);
                imgr.Move(i, i+75, posx1-5, posy1+2, posx1-5, posy1+22);
                imgb.Move(i, i+75, posx1+5, posy1-2, posx1+5, posy1+18);
                listReal[1].Move(i, i+75, posx2, posy2, posx2, posy2+10);
                imgr2.Move(i, i+75, posx2-5, posy2+2, posx2-5, posy2+12);
                imgb2.Move(i, i+75, posx2+5, posy2-2, posx2+5, posy2+8);
                list[2].ScaleVec(i, i+75, 0.5, 0.5, 0.6, 0.6);
                imgr3.ScaleVec(i, i+75, 0.5, 0.5, 0.6, 0.6);
                imgb3.ScaleVec(i, i+75, 0.5, 0.5, 0.6, 0.6);
                listReal[3].Move(i, i+75, posx4, posy4, posx4, posy4+5);
                imgr4.Move(i, i+75, posx4-5, posy4+2, posx4-5, posy4+7);
                imgb4.Move(i, i+75, posx4+5, posy4-2, posx4+5, posy4+3);
                listReal[4].Move(i, i+75, posx5, posy5, posx5, posy5+1);
                imgr5.Move(i, i+75, posx5-5, posy5+2, posx5-5, posy5+3);
                imgb5.Move(i, i+75, posx5+5, posy5-2, posx5+5, posy5-1);
            }

            listReal[0].Fade(125380, 125380, 0, 0);
            listReal[1].Fade(125380, 125380, 0, 0);
            listReal[2].Fade(125380, 125380, 0, 0);
            listReal[3].Fade(125380, 125380, 0, 0);
            listReal[4].Fade(125380, 125380, 0, 0);
            imgr.Fade(125380, 125380, 0, 0);
            imgr2.Fade(125380, 125380, 0, 0);
            imgr3.Fade(125380, 125380, 0, 0);
            imgr4.Fade(125380, 125380, 0, 0);
            imgr5.Fade(125380, 125380, 0, 0);
            imgb.Fade(125380, 125380, 0, 0);
            imgb2.Fade(125380, 125380, 0, 0);
            imgb3.Fade(125380, 125380, 0, 0);
            imgb4.Fade(125380, 125380, 0, 0);
            imgb5.Fade(125380, 125380, 0, 0);

        }
    }
}
