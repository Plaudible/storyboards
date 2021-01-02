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
    public class Gears : StoryboardObjectGenerator
    {
        [Configurable]
        public int startTime;

        [Configurable]
        public int endTime;

        [Configurable]
        public int startXrange;

        [Configurable]
        public int endXrange;

        [Configurable]
        public int startYrange;

        [Configurable]
        public int endYrange;

        [Configurable]
        public double red = 0.01;

        [Configurable]
        public double green = 0.01;

        [Configurable]
        public double blue = 0.01;

        public override void Generate()
        {

            var layer = GetLayer("Main");
            var rand = new Random();
            var ring1 = layer.CreateSprite("sb/clock/a1.png", OsbOrigin.Centre);

            double deltaY = 0;

		    OsbSprite[] dust = new OsbSprite[50];
            for (int i = 0; i<= 49; i++){
                int rotation = 0;
                dust[i] = layer.CreateSprite("sb/g/g"+Random(1,6).ToString()+".png", OsbOrigin.Centre);
                dust[i].Fade(startTime, startTime + 800, 0,1);
                dust[i].Fade(startTime + 800, endTime - 800, 1,1);
                dust[i].Fade(OsbEasing.In, endTime - 800, endTime - 200, 1,0);
                dust[i].Color(startTime, red, green, blue);
                dust[i].Scale(startTime, Random(0.08, 0.2));
                var posX = rand.Next(startXrange,endXrange);
                var posY = rand.Next(startYrange,endYrange) + deltaY;
                rotation = Random(-1, 1);

                if (rotation < 0){
                    dust[i].Rotate(startTime, endTime, 0, -2);
                }else{
                    dust[i].Rotate(startTime, endTime, 0, 2);
                }

                if (dust[i].PositionAt(startTime).Y < 240){
                    deltaY += -0.1;
                }else{
                    deltaY += 0.1;
                }
                dust[i].Move(startTime, posX, posY);
                blue += 0.007;
                green += 0.007;
                red += 0.007;
                
            } 
        }
    }
}
