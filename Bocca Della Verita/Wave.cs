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
    public class Wave : StoryboardObjectGenerator
    {
        [Configurable]
        public string SpritePath = "SB/sprite.png";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 100;

        [Configurable]
        public int TimeBetweenSprites = 100;

        [Configurable]
        public double BeatDivisor = 1;

        [Configurable]
        public int FadeIn = 10;

        [Configurable]
        public int FadeOut = 90;

        [Configurable]
        public double SpriteScale;

        [Configurable]
        public OsbEasing Easing;

        [Configurable]
        public Color4 Color = Color4.Black;

        [Configurable]
        public Vector2 StartRange = new Vector2(-107, 0);

        [Configurable]
        public Vector2 EndRange = new Vector2(747, 120);

        public override void Generate()
        {
            var lag = Beatmap.GetTimingPointAt(StartTime).BeatDuration / BeatDivisor;
            for (int i = StartTime; i <= Math.Min(EndTime, FadeOut); i += TimeBetweenSprites)
            {
                int fadein = Math.Max(i, FadeIn);
                int fadeout = Math.Min(FadeOut, EndTime);
                var dot = GetLayer("").CreateSprite(SpritePath, OsbOrigin.Centre);
                dot.Scale(i, i + lag / 2, SpriteScale * 0.25, SpriteScale);
                dot.Scale(i + (lag / 2), i + lag, SpriteScale, SpriteScale * 0.25);
                dot.MoveY(i, i + lag, StartRange.Y, EndRange.Y);
                dot.MoveX(OsbEasing.InOutSine, 0, lag / 4, StartRange.X, EndRange.X);
                dot.MoveX(OsbEasing.InOutSine, lag / 4, lag / 2, EndRange.X, StartRange.X);
                dot.Color(i, Color.R, Color.G, Color.B);
                dot.Fade(fadein, fadein + 50, 0, Color.A);
                dot.Fade(fadeout, fadeout + 50, Color.A, 0);
                dot.StartLoopGroup(i, 2);
                dot.EndGroup();
            }
        }
    }
}
