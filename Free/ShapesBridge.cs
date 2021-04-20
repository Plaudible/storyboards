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
    public class ShapesBridge : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var s1 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s2 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            s1.Fade(73249, 74499, 1, 1);
            s1.ScaleVec(73249, 30, 30);
            s1.Move(OsbEasing.OutExpo, 73249, 73590, 0, 0, 0, 90);
            s1.Rotate(OsbEasing.Out, 73249, 73590, 0, 1.5708);
            s1.Move(OsbEasing.OutExpo, 73590, 73931, 0, 90, 650, 90);
            s1.Rotate(OsbEasing.Out, 73590, 73931, 0, 1.5708);
            s1.Move(OsbEasing.OutExpo, 73931, 74272, 650, 90, 650, 390);
            s1.Rotate(OsbEasing.Out, 73931, 74272, 0, 1.5708);
            s1.Move(OsbEasing.OutExpo, 74272, 74499, 650, 390, 760, 390);
            s1.Rotate(OsbEasing.Out, 74272, 74499, 0, 1.5708);
            s1.Fade(74499, 74499, 0, 0);

            s2.Fade(73249, 74499, 1, 1);
            s2.ScaleVec(73249, 30, 30);
            s2.Move(OsbEasing.OutExpo, 73249, 73590, 650, 500, 650, 390);
            s2.Rotate(OsbEasing.Out, 73249, 73590, 0, -1.5708);
            s2.Move(OsbEasing.OutExpo, 73590, 73931, 650, 390, 0, 390);
            s2.Rotate(OsbEasing.Out, 73590, 73931, 0, -1.5708);
            s2.Move(OsbEasing.OutExpo, 73931, 74272, 0, 390, 0, 90);
            s2.Rotate(OsbEasing.Out, 73931, 74272, 0, -1.5708);
            s2.Move(OsbEasing.OutExpo, 74272, 74499, 0, 90, -120, 90);
            s2.Rotate(OsbEasing.Out, 74272, 74499, 0, -1.5708);
            s2.Fade(74499, 74499, 0, 0);

            int startTime1 = 74499;
            int startY = 120;
            for(int i = 0; i < 5; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Scale(startTime1, 0.05);
                c.Move(OsbEasing.OutExpo, startTime1, startTime1 + 226, -110, startY, 20, startY);
                c.Move(OsbEasing.In, startTime1 + 226, startTime1 + 552, 20, startY, -110, startY);
                startY += 60;
                startTime1 += 113;
            }

            startTime1 = 74499;
            startY = 360;
            for(int i = 0; i < 5; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Scale(startTime1, 0.05);
                c.Move(OsbEasing.OutExpo, startTime1, startTime1 + 226, 750, startY, 620, startY);
                c.Move(OsbEasing.In, startTime1 + 226, startTime1 + 552, 620, startY, 750, startY);
                startY -= 60;
                startTime1 += 113;
            }

            int startTime2 = 76885;
            int startX = 120;
            int startY2 = 240;
            for(int i = 0; i < 5; i++){
                var s = layer.CreateSprite("sb/star.png", OsbOrigin.Centre);
                s.Scale(startTime1, 0.9);
                s.Move(OsbEasing.Out, startTime2, startTime2 + 452, startX, 500, startX, startY2);
                s.Move(OsbEasing.In, startTime2 + 452, startTime2 + 1024, startX, startY2, startX, 500);
                s.Rotate(OsbEasing.OutExpo, startTime2, startTime2 + 2048, 0, Random(1,6));
                startX += 100;
                if (i == 0){
                    startY2 -= 60;
                }
                if (i == 1){
                    startY2 -= 25;
                }
                if (i == 2){
                    startY2 += 25;
                }
                if (i == 3){
                    startY2 += 60;
                }
                startTime2 += 113;
            }

            var s3 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s4 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            s3.Fade(75294, 76772, 1, 1);
            s3.ScaleVec(75294, 30, 30);
            s3.Move(OsbEasing.OutExpo, 75294, 75635, 760, 390, 650, 390); 
            s3.Rotate(OsbEasing.Out, 75294, 75635, 0, 1.5708);
            s3.Move(OsbEasing.OutExpo, 75635, 75976, 650, 390, 650, 90); 
            s3.Rotate(OsbEasing.Out, 75635, 75976, 0, 1.5708);
            s3.Move(OsbEasing.OutExpo, 75976, 76317, 650, 90, 0, 90);
            s3.Rotate(OsbEasing.Out, 75976, 76317, 0, 1.5708);
            s3.Move(OsbEasing.OutExpo, 76317,76544, 0, 90, 0, -20);
            s3.Rotate(OsbEasing.Out, 76317, 76544, 0, 1.5708);
            s3.Move(OsbEasing.OutExpo, 76544,76772, 0, -20, 0, 240);
            s3.Rotate(OsbEasing.Out, 76544, 76772, 0, 1.5708);
            s3.ScaleVec(OsbEasing.In, 76544, 76772, 30, 30, 0, 0);

            s4.Fade(75294, 76772, 1, 1);
            s4.ScaleVec(75294, 30, 30);
            s4.Move(OsbEasing.OutExpo, 75294, 75635, -120, 90, 0, 90); 
            s4.Rotate(OsbEasing.Out, 75294, 75635, 0, 1.5708);
            s4.Move(OsbEasing.OutExpo, 75635, 75976, 0, 90, 0, 390); 
            s4.Rotate(OsbEasing.Out, 75635, 75976, 0, 1.5708);
            s4.Move(OsbEasing.OutExpo, 75976, 76317, 0, 390, 650, 390);
            s4.Rotate(OsbEasing.Out, 75976, 76317, 0, 1.5708);
            s4.Move(OsbEasing.OutExpo, 76317,76544, 650, 390, 650, 500);
            s4.Rotate(OsbEasing.Out, 76317, 76544, 0, 1.5708);
            s4.Move(OsbEasing.OutExpo, 76544,76772, 650, 500, 650, 240);
            s4.Rotate(OsbEasing.Out, 76544, 76772, 0, 1.5708);
            s4.ScaleVec(OsbEasing.In, 76544, 76772, 30, 30, 0, 0);

            var s5 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s6 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            s5.ScaleVec(77453, 30, 30);
            s6.ScaleVec(77453, 30, 30);

            s5.Fade(77453, 77908, 1, 1);
            s6.Fade(77453, 77908, 1, 1);
            s5.Move(OsbEasing.OutExpo, 77453, 77681, -120, 240, 30, 240);
            s6.Move(OsbEasing.OutExpo, 77453, 77681, 780, 240, 650, 240);
            s5.Move(OsbEasing.OutExpo, 77681, 77908, 30, 240, -120, 240);
            s6.Move(OsbEasing.OutExpo, 77681, 77908, 650, 240, 780, 240);
            s5.Rotate(OsbEasing.Out, 77453, 77681, 0, 1.5708);
            s5.Rotate(OsbEasing.Out, 77681, 77908, 0, 1.5708);
            s6.Rotate(OsbEasing.Out, 77453, 77681, 0, 1.5708);
            s6.Rotate(OsbEasing.Out, 77681, 77908, 0, 1.5708);

            int startTime3 = 78022;
            int startX2 = 120;
            for(int i = 0; i < 5; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Scale(startTime1, 0.05);
                c.Move(OsbEasing.Out, startTime3, startTime3 + 452, startX2, -20, startX2, 100);
                c.Move(OsbEasing.In, startTime3 + 452, startTime3 + 1024, startX2, 100, startX2, -20);
                startTime3 += 113;
                startX2 += 100;
            }

            int angle = 0;
            int startTime4 = 78703;
            int timeBuffer = 0;
            for(int i = 0; i < 12; i++){
                var c = layer.CreateSprite("sb/star.png", OsbOrigin.Centre);
                c.Scale(startTime1, 1);

                double x = 320 + 190 * Math.Cos(angle * Math.PI / 180);
                double y = 240 + 190 * Math.Sin(angle * Math.PI / 180);

                c.Move(OsbEasing.Out, startTime4 + timeBuffer, timeBuffer + startTime4 + 1250, 320, 240, x, y);
                c.Scale(OsbEasing.In, startTime4 + timeBuffer, timeBuffer + startTime4 + 1250, 1, 0);
                c.Rotate(OsbEasing.OutExpo, startTime4 + timeBuffer, timeBuffer + startTime4 + 2048, 0, Random(1,6));
                angle+=45;
                timeBuffer += 113;
            };

            int startTime5 = 80522;
            timeBuffer = 0;
            for(int i = 0; i < 12; i++){
                var c = layer.CreateSprite("sb/star.png", OsbOrigin.Centre);
                c.Scale(startTime1, 1);

                double x = 320 + 190 * Math.Cos(angle * Math.PI / 180);
                double y = 240 + 190 * Math.Sin(angle * Math.PI / 180);

                c.Move(OsbEasing.Out, startTime5 + timeBuffer, timeBuffer + startTime5 + 1250, 320, 240, x, y);
                c.Scale(OsbEasing.In, startTime5 + timeBuffer, timeBuffer + startTime5 + 1250, 1, 0);
                c.Rotate(OsbEasing.OutExpo, startTime5 + timeBuffer, timeBuffer + startTime5 + 2048, 0, Random(1,6));
                angle-=45;
                timeBuffer += 113;
            }

            int startTime6 = 82340;
            timeBuffer = 0;
            for(int i = 0; i < 8; i++){
                var c = layer.CreateSprite("sb/star.png", OsbOrigin.Centre);
                c.Scale(startTime1, 1);

                double x = 320 + 190 * Math.Cos(angle * Math.PI / 180);
                double y = 240 + 190 * Math.Sin(angle * Math.PI / 180);

                c.Move(OsbEasing.Out, startTime6 + timeBuffer, timeBuffer + startTime6 + 1250, 320, 240, x, y);
                c.Scale(OsbEasing.In, startTime6 + timeBuffer, timeBuffer + startTime6 + 1250, 1, 0);
                c.Rotate(OsbEasing.OutExpo, startTime6 + timeBuffer, timeBuffer + startTime6 + 2048, 0, Random(1,6));
                angle+=90;
                timeBuffer += 113;
            }

            startTime1 = 83249;
            startY = 120;
            for(int i = 0; i < 5; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Scale(startTime1, 0.05);
                c.Move(OsbEasing.OutExpo, startTime1, startTime1 + 226, -110, startY, 20, startY);
                c.Move(OsbEasing.In, startTime1 + 226, startTime1 + 552, 20, startY, -110, startY);
                startY += 60;
                startTime1 += 113;
            }

            startTime1 = 83249;
            startY = 360;
            for(int i = 0; i < 5; i++){
                var c = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                c.Scale(startTime1, 0.05);
                c.Move(OsbEasing.OutExpo, startTime1, startTime1 + 226, 750, startY, 620, startY);
                c.Move(OsbEasing.In, startTime1 + 226, startTime1 + 552, 620, startY, 750, startY);
                startY -= 60;
                startTime1 += 113;
            }

            var s10 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            s10.ScaleVec(85067, 30, 30);
            s10.Move(OsbEasing.OutExpo, 85067, 85294, 320, 500, 320, 380);

            var s11 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            s11.ScaleVec(85067, 30, 30);
            s11.Move(OsbEasing.OutExpo, 85067, 85294, 320, -20, 320, 100);

            var s12 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s13 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            s12.ScaleVec(85294, 20, 20);
            s13.ScaleVec(85294, 20, 20);

            s10.ScaleVec(OsbEasing.OutExpo, 85294, 85522, 30, 30, 20, 20);
            s11.ScaleVec(OsbEasing.OutExpo, 85294, 85522, 30, 30, 20, 20);

            s10.Move(OsbEasing.OutExpo, 85294, 85522, 320, 380, 180, 380);
            s12.Move(OsbEasing.OutExpo, 85294, 85522, 320, 380, 460, 380);

            s11.Move(OsbEasing.OutExpo, 85294, 85522, 320, 100, 180, 100);
            s13.Move(OsbEasing.OutExpo, 85294, 85522, 320, 100, 460, 100);

            s10.ScaleVec(OsbEasing.In, 85522, 85749, 20, 20, 0, 0);
            s11.ScaleVec(OsbEasing.In, 85635, 85862, 20, 20, 0, 0);
            s12.ScaleVec(OsbEasing.In, 85749, 85976, 20, 20, 0, 0);
            s13.ScaleVec(OsbEasing.In, 85862, 86090, 20, 20, 0, 0);

            int startTime7 = 108703;
            timeBuffer = 0;
            for(int i = 1; i < 45; i++){
                var c = layer.CreateSprite("sb/star.png", OsbOrigin.Centre);
                c.Scale(startTime7, 1);

                double x = 320 + 190 * Math.Cos(angle * Math.PI / 180);
                double y = 240 + 190 * Math.Sin(angle * Math.PI / 180);

                c.Move(OsbEasing.OutQuint, startTime7 + timeBuffer, timeBuffer + startTime7 + 1250, 320, 240, x, y);
                c.Scale(OsbEasing.In, startTime7 + timeBuffer, timeBuffer + startTime7 + 1250, 1, 0);
                c.Rotate(OsbEasing.OutExpo, startTime7 + timeBuffer, timeBuffer + startTime7 + 2048, 0, Random(1,6));
                angle+=90;
                if (i % 4 == 0) {
                    timeBuffer += 454;
                }
            }
        }
    }
}
