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
    public class Square : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime;

        [Configurable]
        public int endTime;
        [Configurable]
        public int xPos;

        [Configurable]
        public int yPos;

        [Configurable]
        public int beatDivisor = 50;
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var r = layer.CreateSprite("sb/Clock/a1.png", OsbOrigin.Centre);
            var s1 = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var s2 = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);

            s1.Scale(startTime - 200, 0.65);
            s2.Scale(startTime - 200, 0.65);

            s1.Color(startTime - 200, 0.85, 0.1, 0.2);
            s1.Rotate(startTime - 200, endTime, 0, 5);
            s2.Rotate(startTime - 200, endTime, 0, -5);

            s1.Fade(startTime - 200, startTime + 200, 0, 1);
            s2.Fade(startTime - 200, startTime + 200, 0, 1);

            s1.Fade(startTime + 200, endTime - 200, 1, 1);
            s2.Fade(startTime + 200, endTime - 200, 1, 1);

            s1.Fade(endTime - 200, endTime + 200, 1, 0);
            s2.Fade(endTime - 200, endTime + 200, 1, 0);

            s1.Move(startTime - 200, xPos, yPos);
            s2.Move(startTime - 200, xPos, yPos);

            r.Fade(startTime - 200, startTime + 200, 0, 0.5);

            r.Fade(startTime + 200, endTime - 200, 0.5, 0.5);

            r.Fade(endTime - 200, endTime + 200, 0.5, 0);

            r.Move(startTime - 200, xPos, yPos);

            r.Rotate(startTime, endTime, 0, 2);

            for(int i = startTime; i <= endTime; i+= beatDivisor){
                s1.Scale(i, i + 100, 0.7, 0.65);
                s2.Scale(i, i+ 100, 0.7, 0.65);
            }

            int square = 0;
            for(double i = startTime; i <= endTime - 200; i+= (beatDivisor / 2)){
                var bar = layer.CreateSprite("sb/blinder.png", OsbOrigin.Centre);
                bar.Fade(i, i + beatDivisor, 1, 0);
                bar.ScaleVec(OsbEasing.Out, i, i + beatDivisor, 0.1, 0.005, 0.12, 0);
                bar.Move(i, xPos, yPos);
                if (square == 0){
                    bar.Rotate(i, s2.RotationAt(i));
                    double x = 100 * Math.Cos(s2.RotationAt(i) + 1.5708) + 150;
                    double y = 100 * Math.Sin(s2.RotationAt(i) + 1.5708) + 240;
                    bar.Move(OsbEasing.In, i, i + 150, xPos, yPos, x, y);
                    square = 1;
                }
                else if (square == 1){
                    bar.Rotate(i, s2.RotationAt(i) + 1.5708);
                    double x = 100 * Math.Cos(s2.RotationAt(i) + 3.1416) + 150;
                    double y = 100 * Math.Sin(s2.RotationAt(i) + 3.1416) + 240;
                    bar.Move(OsbEasing.Out, i, i + 150, xPos, yPos, x, y);
                    square = 2;
                }
                else if (square == 2){
                    bar.Rotate(i, s2.RotationAt(i));
                    double x = 100 * Math.Cos(s2.RotationAt(i) + 4.7124) + 150;
                    double y = 100 * Math.Sin(s2.RotationAt(i) + 4.7124) + 240;
                    bar.Move(OsbEasing.Out, i, i + 150, xPos, yPos, x, y);
                    square = 3;
                }
                else if (square == 3){
                    bar.Rotate(i, s2.RotationAt(i) + 1.5708);
                    double x = 100 * Math.Cos(s2.RotationAt(i)) + 150;
                    double y = 100 * Math.Sin(s2.RotationAt(i)) + 240;
                    bar.Move(OsbEasing.Out, i, i + 150, xPos, yPos, x, y);
                    square = 0;
                }
 
            }
        }
    }
}
