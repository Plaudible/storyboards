using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;
using System;

namespace StorybrewScripts
{
    public class Vignette : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";

        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public double Opacity = 0.2;

        public override void Generate()
        {
            //DEFAULT
            var ogbg = GetLayer("Main").CreateSprite("Alice.(SINoALICE).full.2792424.jpg", OsbOrigin.Centre);
            ogbg.Fade(0,0,0,0);

            if (BackgroundPath == "") BackgroundPath = Beatmap.BackgroundPath ?? string.Empty;
            if (StartTime == EndTime) EndTime = (int)(Beatmap.HitObjects.LastOrDefault()?.EndTime ?? AudioDuration);

            var bitmap = GetMapsetBitmap(BackgroundPath);
            var bg = GetLayer("Foreground").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.Scale(StartTime, 480.0f / bitmap.Height* 1.05);
            bg.Fade(StartTime - 500, StartTime, 0, 1);
            bg.Fade(StartTime, EndTime, 1, 1);
        }

        double GetRandomDouble(Random random, double min, double max)
        {
            return min + (random.NextDouble() * (max - min));
        }
    }
}
