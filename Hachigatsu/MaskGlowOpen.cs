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
    public class MaskGlowOpen : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime;

        [Configurable]
        public int EndTime;
        public override void Generate()
        {
            var sunlight = GetLayer("").CreateSprite("sb/sunlight.png", OsbOrigin.Centre);
            var sunglow = GetLayer("").CreateSprite("sb/sunglow.png", OsbOrigin.Centre);
            var sunglow2 = GetLayer("").CreateSprite("sb/sunglow2.png", OsbOrigin.Centre);
            var flare = GetLayer("").CreateSprite("sb/flare.png", OsbOrigin.Centre);
            var mask = GetLayer("").CreateSprite("sb/mask.png", OsbOrigin.Centre);

            sunlight.Fade(0, 0);
            sunglow.Fade(0, 0);
            mask.Fade(0, 0);

            sunlight.Fade(StartTime, EndTime, 1, 1);
            sunglow.Fade(StartTime, EndTime, 1, 1);
            mask.Fade(StartTime, EndTime, 1, 1);
            flare.Fade(StartTime, EndTime, 0.25, 0.25);

            mask.Scale(StartTime, 0.445);
            mask.MoveY(StartTime, 329);
            mask.MoveX(StartTime, 325);

            sunlight.MoveX(StartTime, 475);
            sunlight.MoveY(StartTime, 320);
            sunlight.Scale(StartTime, 1.3);

            sunglow.MoveX(StartTime, 370);
            sunglow.MoveY(StartTime, 310);
            sunglow.ScaleVec(StartTime, 2.5, 2.5);
            sunglow.Rotate(StartTime, EndTime, 0, 1);
            sunglow2.MoveX(StartTime, 370);
            sunglow2.MoveY(StartTime, 310);
            sunglow2.ScaleVec(StartTime, 2, 2);
            sunglow2.Rotate(StartTime, EndTime, 0, -1);

            flare.Scale(StartTime, 0.5);
            flare.Move(StartTime, 140, 160);
            flare.Rotate(StartTime, 0.65);

            for(int i = StartTime; i <= EndTime; i+=1091){
                sunglow.ScaleVec(i - 1091, i - 540, 1.9, 1.9, 2, 2);
                sunglow.ScaleVec(i - 540, i, 2, 2, 1.9, 1.9);
            }
        }
    }
}
