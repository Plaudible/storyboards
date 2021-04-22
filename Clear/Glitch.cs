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
    
    public class Glitch : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        public override void Generate()
        {
            var layer = GetLayer("Main");
            var gbg1 = layer.CreateSprite("sb/glitch/g1.jpg", OsbOrigin.Centre);
            var gbg2 = layer.CreateSprite("sb/glitch/g2.jpg", OsbOrigin.Centre);
            var gbg3 = layer.CreateSprite("sb/glitch/g3.jpg", OsbOrigin.Centre);
            var gbg4 = layer.CreateSprite("sb/glitch/g4.jpg", OsbOrigin.Centre);
            var gbg5 = layer.CreateSprite("sb/glitch/g5.jpg", OsbOrigin.Centre);
            var gbg6 = layer.CreateSprite("sb/glitch/g6.jpg", OsbOrigin.Centre);
            var gbg7 = layer.CreateSprite("sb/glitch/g7.jpg", OsbOrigin.Centre);
            var gbg8 = layer.CreateSprite("sb/glitch/g8.jpg", OsbOrigin.Centre);
            var gbg9 = layer.CreateSprite("sb/glitch/g9.jpg", OsbOrigin.Centre);
            var gbg10 = layer.CreateSprite("sb/glitch/g10.jpg", OsbOrigin.Centre);

            gbg1.Scale(StartTime, (360.0 / 768)*1);
            gbg1.Fade(StartTime, StartTime + 40, 1, 1); 
            gbg1.Fade(StartTime + 40, StartTime + 40, 0, 0);   

            gbg2.Scale(StartTime + 40, (360.0 / 768)*1);
            gbg2.Fade(StartTime + 40, StartTime + 80, 1, 1); 
            gbg2.Fade(StartTime + 80, StartTime + 80, 0, 0);   

            gbg3.Scale(StartTime + 80, (360.0 / 768)*1);
            gbg3.Fade(StartTime + 80, StartTime + 120, 1, 1); 
            gbg3.Fade(StartTime + 120, StartTime + 120, 0, 0); 

            gbg4.Scale(StartTime + 120, (360.0 / 768)*1);
            gbg4.Fade(StartTime + 120, StartTime + 160, 1, 1); 
            gbg4.Fade(StartTime + 160, StartTime + 160, 0, 0); 
            
            gbg5.Scale(StartTime + 160, (360.0 / 768)*1);
            gbg5.Fade(StartTime + 160, StartTime + 200, 1, 1); 
            gbg5.Fade(StartTime + 200, StartTime + 200, 0, 0); 

            gbg6.Scale(StartTime + 200, (360.0 / 768)*1);
            gbg6.Fade(StartTime + 200, StartTime + 240, 1, 1); 
            gbg6.Fade(StartTime + 240, StartTime + 240, 0, 0); 

            gbg7.Scale(StartTime + 240, (360.0 / 768)*1);
            gbg7.Fade(StartTime + 240, StartTime + 280, 1, 1); 
            gbg7.Fade(StartTime + 280, StartTime + 280, 0, 0); 

            gbg8.Scale(StartTime + 280, (360.0 / 768)*1);
            gbg8.Fade(StartTime + 280, StartTime + 320, 1, 1); 
            gbg8.Fade(StartTime + 320, StartTime + 320, 0, 0); 

            gbg9.Scale(StartTime + 320, (360.0 / 768)*1);
            gbg9.Fade(StartTime + 320, StartTime + 360, 1, 1); 
            gbg9.Fade(StartTime + 360, StartTime + 360, 0, 0); 

            gbg10.Scale(StartTime + 360, (360.0 / 768)*1);
            gbg10.Fade(StartTime + 360, StartTime + 400, 1, 1); 
            gbg10.Fade(StartTime + 400, StartTime + 400, 0, 0); 
        }
    }
}
