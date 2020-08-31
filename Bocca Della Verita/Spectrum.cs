using OpenTK;
using StorybrewCommon.Animations;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using System;
 
namespace StorybrewScripts
{
    /// <summary>
    /// An example of a circle spectrum effect.
    /// </summary>
    public class Spectrum : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;
 
        [Configurable]
        public int EndTime = 10000;
 
        [Configurable]
        public Vector2 Position = new Vector2(-107, 240);
 
        [Configurable]
        public float Width = 20;
 
        [Configurable]
        public int BeatDivisor = 4;
 
        [Configurable]
        public int BarCount = 36;
 
        [Configurable]
        public int CircleRadius = 100;
 
        [Configurable]
        public float CircleRounds = 1;
 
        [Configurable]
        public string SpritePath = "sb/bar.png";
 
        [Configurable]
        public OsbOrigin SpriteOrigin = OsbOrigin.Centre;
 
        [Configurable]
        public Vector2 Scale = new Vector2(1, 200);
 
        [Configurable]
        public int LogScale = 600;
 
        [Configurable]
        public double Tolerance = 0.2;
 
        [Configurable]
        public int CommandDecimals = 1;
 
        [Configurable]
        public float MinimalHeight = 0.05f;
 
        [Configurable]
        public OsbEasing FftEasing = OsbEasing.InExpo;
 
 
        public override void Generate()
        {
            var endTime = Math.Min(EndTime, (int)AudioDuration);
            var startTime = Math.Min(StartTime, endTime);
            var bitmap = GetMapsetBitmap(SpritePath);
 
            var heightKeyframes = new KeyframedValue<float>[BarCount];
            for (var i = 0; i < BarCount; i++)
                heightKeyframes[i] = new KeyframedValue<float>(null);
 
            var fftTimeStep = Beatmap.GetTimingPointAt(startTime).BeatDuration / BeatDivisor;
            var fftOffset = fftTimeStep * 0.2;
            for (var time = (double)startTime; time < endTime; time += fftTimeStep)
            {
                var fft = GetFft(time + fftOffset, BarCount, null, FftEasing);
                for (var i = 0; i < BarCount; i++)
                {
                    var height = (float)Math.Log10(1 + fft[i] * LogScale) * Scale.Y / bitmap.Height;
                    if (height < MinimalHeight) height = MinimalHeight;
 
                    heightKeyframes[i].Add(time, height);
                }
            }
 
            var layer = GetLayer("Spectrum");
            var barWidth = Width / BarCount;
            var circleStep = ((2 * Math.PI) / (BarCount)) * CircleRounds;
            var rotationDegree = (360 / BarCount) * (Math.PI / 180);
 
            for (var i = 0; i < BarCount; i++)
            {
                var keyframes = heightKeyframes[i];
                float posX = Position.X + (CircleRadius * (float)Math.Cos(i * circleStep));
                float posY = Position.Y + (CircleRadius * (float)Math.Sin(i * circleStep));
 
                keyframes.Simplify1dKeyframes(Tolerance, h => h);
 
                var bar = layer.CreateSprite(SpritePath, SpriteOrigin);
                bar.Color(startTime, 0.295, 0, 0.51);
                bar.Additive(startTime, endTime);
                bar.Rotate(startTime, i * circleStep + (90 * Math.PI / 180));
                bar.Move(startTime, posX, posY);
                bar.Fade(endTime - 200, endTime, 1, 0);
 
                var scaleX = Scale.X * barWidth / bitmap.Width;
                scaleX = (float)Math.Floor(scaleX * 10) / 10.0f;
 
                var hasScale = false;
                keyframes.ForEachPair(
                    (start, end) =>
                    {
                        hasScale = true;
                        bar.ScaleVec(start.Time, end.Time,
                            scaleX, start.Value,
                            scaleX, end.Value);
                    },
                    MinimalHeight,
                    s => (float)Math.Round(s, CommandDecimals)
                );
                if (!hasScale) bar.ScaleVec(startTime, scaleX, MinimalHeight);
            }
        }
    }
}