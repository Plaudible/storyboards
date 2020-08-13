using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

namespace StorybrewScripts
{
    public class StarHitLight : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;

        [Configurable]
        public int BeatDivisor = 8;

        [Configurable]
        public int FadeTime = 200;

        [Configurable]
        public string SpritePath = "sb/glow.png";

        [Configurable]
        public double SpriteScale = 1;

        public override void Generate()
        {
            var hitobjectLayer = GetLayer("Foreground");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if ((StartTime != 0 || EndTime != 0) && 
                    (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime))
                    continue;

                var hSprite = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position);
                var hSprite2 = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position);
                var hSprite3 = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position);
                hSprite.ScaleVec(hitobject.StartTime,0.75,7);
                hSprite.Fade(OsbEasing.In, hitobject.StartTime, hitobject.EndTime + FadeTime, 1, 0);
                hSprite.Additive(hitobject.StartTime, hitobject.EndTime + FadeTime);
                hSprite2.ScaleVec(hitobject.StartTime,0.75,7);
                hSprite2.Fade(OsbEasing.In, hitobject.StartTime, hitobject.EndTime + FadeTime, 1, 0);
                hSprite2.Additive(hitobject.StartTime, hitobject.EndTime + FadeTime);
                hSprite2.Rotate(hitobject.StartTime, 1.5708);
                hSprite3.Fade(OsbEasing.In, hitobject.StartTime, hitobject.EndTime + FadeTime, 1, 0);
                hSprite3.Additive(hitobject.StartTime, hitobject.EndTime + FadeTime);
                //hSprite.Color(hitobject.StartTime, hitobject.Color);

                if (hitobject is OsuSlider)
                {
                    var timestep = Beatmap.GetTimingPointAt((int)hitobject.StartTime).BeatDuration / BeatDivisor;
                    var startTime = hitobject.StartTime;
                    while (true)
                    {
                        var endTime = startTime + timestep;

                        var complete = hitobject.EndTime - endTime < 5;
                        if (complete) endTime = hitobject.EndTime;

                        var startPosition = hSprite.PositionAt(startTime);
                        hSprite.ScaleVec(startTime,0.75,7);
                        hSprite.Move(startTime, endTime, startPosition, hitobject.PositionAtTime(endTime));
                        hSprite2.ScaleVec(startTime,0.75,7);
                        hSprite2.Move(startTime, endTime, startPosition, hitobject.PositionAtTime(endTime));
                        hSprite3.Move(startTime, endTime, startPosition, hitobject.PositionAtTime(endTime));

                        if (complete) break;
                        startTime += timestep;
                    }
                }
            }
        }
    }
}