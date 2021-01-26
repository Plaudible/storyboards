using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;

namespace StorybrewScripts
{
    public class BridgeHitObjectHighlight : StoryboardObjectGenerator
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
            var hitobjectLayer = GetLayer("");
            foreach (var hitobject in Beatmap.HitObjects)
            {
                if ((StartTime != 0 || EndTime != 0) && 
                    (hitobject.StartTime < StartTime - 5 || EndTime - 5 <= hitobject.StartTime))
                    continue;
                
                if (hitobject.StartTime == 22718 || hitobject.StartTime == 24052 || hitobject.StartTime == 25385 || hitobject.StartTime == 26718 || hitobject.StartTime == 28052 || hitobject.StartTime == 29385 || hitobject.StartTime == 30718 || hitobject.StartTime == 31218 || hitobject.StartTime == 32052 || hitobject.StartTime == 33385 || hitobject.StartTime == 34718 || hitobject.StartTime == 36052 || hitobject.StartTime == 37385 || hitobject.StartTime == 38718 || hitobject.StartTime == 40052 || hitobject.EndTime == 22718 || hitobject.EndTime == 24052 || hitobject.EndTime == 25385 || hitobject.EndTime == 26718 || hitobject.EndTime == 28052 || hitobject.EndTime == 29385 || hitobject.EndTime == 30718 || hitobject.EndTime == 31218 || hitobject.EndTime == 32052 || hitobject.EndTime == 33385 || hitobject.EndTime == 34718 || hitobject.EndTime == 36052 || hitobject.EndTime == 37385 || hitobject.EndTime == 38718 || hitobject.EndTime == 40052){
                var hSprite = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position);
                var hSprite2 = hitobjectLayer.CreateSprite(SpritePath, OsbOrigin.Centre, hitobject.Position);
                hSprite.Scale(OsbEasing.OutExpo, hitobject.StartTime, hitobject.EndTime + FadeTime, 0, 1);
                hSprite.Fade(OsbEasing.In, hitobject.StartTime, hitobject.EndTime + FadeTime, 1, 0);

                hSprite2.Scale(OsbEasing.Out, hitobject.StartTime, hitobject.EndTime + FadeTime, 0, 0.85);
                hSprite2.Fade(OsbEasing.In, hitobject.StartTime, hitobject.EndTime + FadeTime, 1, 0);
                }

            }
        }
    }
}
