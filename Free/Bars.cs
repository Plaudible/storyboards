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
    public class Bars : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime;

        [Configurable]
        public int EndTime;
        public override void Generate()
        {
            Random rnd = new Random();
            var layer = GetLayer("Main");
            var b1 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b2 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b3 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b4 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b5 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b6 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b7 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b8 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b9 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);
            var b0 = layer.CreateSprite("sb/sbar.png", OsbOrigin.Centre);

            OsbSprite[] list = new OsbSprite [10] {b1, b2, b3, b4, b5, b6, b7, b8, b9, b0}; 
            double scaler = 0.05;
            double fader = 1;
		    for (int i = 0; i <= 9; i++){
                scaler += 0.3;
                fader -= 0.08;
                list[i].ScaleVec(StartTime, EndTime, scaler, 10, scaler, 10);
                list[i].Fade(StartTime, fader);
                list[i].MoveX(StartTime, rnd.Next(-80, 160));
                for (int j = StartTime; j <= EndTime; j+= 1818){
                    if(list[i].PositionAt(j).X > -100 && list[i].PositionAt(j).X < 180){
                        list[i].MoveX(j, j+ 1818, list[i].PositionAt(j).X, list[i].PositionAt(j).X + rnd.Next(-30,30));
                    }else{
                        list[i].MoveX(j, j+ 1818, list[i].PositionAt(j).X, rnd.Next(-100, 180));
                    }
                }
                list[i].Fade(EndTime, EndTime, 0, 0);
            }
            
        }
    }
}
