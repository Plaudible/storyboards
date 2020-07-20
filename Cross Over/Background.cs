using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System.Linq;
using System;

namespace StorybrewScripts
{
    public class Background : StoryboardObjectGenerator
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
            var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            bg.Scale(StartTime, 480.0f / bitmap.Height* 1.2);
            bg.Fade(StartTime - 500, StartTime, 0, Opacity);
            bg.Fade(EndTime, EndTime, 0, 0);

            double xpos = 318;
            double ypos = 230;
            double rot = 0;
            Random rand = new Random();

            for(int i = StartTime; i <= EndTime; i += 750){
                double ran = GetRandomDouble(rand,-4,4);
                double ran2 = GetRandomDouble(rand,-4,4);
                double ran3 = GetRandomDouble(rand,-2,2);
                bg.MoveX(OsbEasing.InOutQuad, i, i+750, xpos, xpos + ran);
                bg.MoveY(OsbEasing.InOutQuad, i, i+750, ypos, ypos + ran2);
                bg.Rotate(OsbEasing.InOutQuad, i, i+750, rot, rot + (ran3 / 200));
                xpos += ran;
                ypos += ran2;
                rot += (ran3 / 200);

            }
        }

        double GetRandomDouble(Random random, double min, double max)
        {
            return min + (random.NextDouble() * (max - min));
        }
    }
}
