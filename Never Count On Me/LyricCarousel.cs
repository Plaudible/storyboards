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
    public class LyricCarousel : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Foreground");

            var mPlaudible = layer.CreateSprite("sb/f/mappers/_000.png", OsbOrigin.CentreLeft);
            var gPlaudible = layer.CreateSprite("sb/f/mappers/glow/_000.png", OsbOrigin.CentreLeft);
            var mBrowiec = layer.CreateSprite("sb/f/mappers/_001.png", OsbOrigin.CentreLeft);
            var gBrowiec = layer.CreateSprite("sb/f/mappers/glow/_001.png", OsbOrigin.CentreLeft);
            var mNhawak = layer.CreateSprite("sb/f/mappers/_002.png", OsbOrigin.CentreLeft);
            var gNhawak = layer.CreateSprite("sb/f/mappers/glow/_002.png", OsbOrigin.CentreLeft);
            var mYamicchi = layer.CreateSprite("sb/f/mappers/_003.png", OsbOrigin.CentreLeft);
            var gYamicchi = layer.CreateSprite("sb/f/mappers/glow/_003.png", OsbOrigin.CentreLeft);
            OsbSprite[] mappers = new OsbSprite[] {mPlaudible, mBrowiec, mNhawak, mYamicchi};
            OsbSprite[] glow = new OsbSprite[] {gPlaudible, gBrowiec, gNhawak, gYamicchi};

            int StartTime = 6719;

            for(int i = 0; i < 4; i++){
                mappers[i].Scale(StartTime, 0.35);
                glow[i].Scale(StartTime, 0.35);
                mappers[i].Fade(StartTime, StartTime + 1500, 0, 1);
                mappers[i].Fade(StartTime + 1500, StartTime + 3000, 1, 0);
                glow[i].Fade(StartTime, StartTime + 1500, 0, 1);
                glow[i].Fade(StartTime + 1500, StartTime + 3000, 1, 0);
                mappers[i].Move(StartTime, StartTime + 3000, 435, 325, 435, 175);
                glow[i].Move(StartTime, StartTime + 3000, 432, 325, 432, 175);
                StartTime += 667;
            } //6719, 11385, 667

            var sHokichi = layer.CreateSprite("sb/f/storyboarders/_001.png", OsbOrigin.CentreRight);
            var sPlaudible = layer.CreateSprite("sb/f/storyboarders/_000.png", OsbOrigin.CentreRight);
            var sgHokichi = layer.CreateSprite("sb/f/storyboarders/glow/_001.png", OsbOrigin.CentreRight);
            var sgPlaudible = layer.CreateSprite("sb/f/storyboarders/glow/_000.png", OsbOrigin.CentreRight);
            
            int StartTime2 = 12052;

            OsbSprite[] storyboarders = new OsbSprite[] {sPlaudible, sHokichi};
            OsbSprite[] sglow = new OsbSprite[] {sgPlaudible, sgHokichi};

            for(int i = 0; i < 2; i++){
                storyboarders[i].Scale(StartTime, 0.35);
                sglow[i].Scale(StartTime, 0.35);
                storyboarders[i].Fade(StartTime2, StartTime2 + 1500, 0, 1);
                storyboarders[i].Fade(StartTime2 + 1500, StartTime2 + 3000, 1, 0);
                sglow[i].Fade(StartTime2, StartTime2 + 1500, 0, 1);
                sglow[i].Fade(StartTime2 + 1500, StartTime2 + 3000, 1, 0);
                storyboarders[i].Move(StartTime2, StartTime2 + 3000, 195, 325, 195, 175);
                sglow[i].Move(StartTime2, StartTime2 + 3000, 198, 325, 198, 175);
                StartTime2 += 667;
            } //6719, 11385, 667
        }   

    }
}
