using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

namespace StorybrewScripts
{
    public class Mask : StoryboardObjectGenerator
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
        public bool Additive = true;

        [Configurable]
        public bool Colorize = false;

        [Configurable]
        public string SpritePath = "sb/glow.png";

        [Configurable]
        public double SpriteScale = 1;

        public override void Generate()
        {
            var hitobjectLayer = GetLayer("");
            OsuHitObject prevObject = null;
            
            var hSprite = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre);
            hSprite.Scale(StartTime, SpriteScale);
            hSprite.Fade(OsbEasing.In, StartTime - 200, StartTime + 200, 0, 1);
            hSprite.Fade(OsbEasing.In, EndTime, EndTime + 5, 1, 1);
            hSprite.Scale(OsbEasing.In, EndTime - 300, EndTime, 1, 3);
            if(Additive) hSprite.Additive(StartTime, EndTime + FadeTime);
            
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if ((StartTime != 0 || EndTime != 0) && 
                    (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime))
                    continue;
                
                if(prevObject != null)
                {
                    hSprite.Move(OsbEasing.InOutSine, prevObject.EndTime, hitobject.StartTime, prevObject.PositionAtTime(prevObject.EndTime), hitobject.PositionAtTime(hitobject.StartTime));
                    if(Colorize) hSprite.Color(prevObject.EndTime, hitobject.StartTime, prevObject.Color, hitobject.Color);
                }

                else
                {
                    if(Colorize) hSprite.Color(hitobject.StartTime, hitobject.Color);
                }


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
                        hSprite.Move(startTime, endTime, startPosition, hitobject.PositionAtTime(endTime));

                        if (complete) break;
                        startTime += timestep;
                    }
                }
                prevObject = hitobject;
            }
        }
    }
}
