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
    public class BackgroundCity : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var bg = layer.CreateSprite("sb/bg2.jpg", OsbOrigin.Centre);
            bg.Scale(36269, (360.0 / 768)*1.4);
            bg.Fade(36269,36643,0,0.75);
            bg.Fade(36643, 45269, 0.75, 0.75);

            double ypos = 125;
            for(int i = 36269; i <= 46769; i += 500){
                bg.MoveY(i, i+500, ypos, ypos + 4.6);
                ypos += 4.6;
            }
            bg.Fade(45269, 46769, 0.75, 0);
            //pre-chorus2
            var bg2 = layer.CreateSprite("sb/bg2.jpg", OsbOrigin.Centre);
            bg2.Scale(156268, (360.0 / 768)*1.4);
            bg2.Fade(156268,156643,0,0.75);
            bg2.Fade(156643, 165268, 0.75, 0.75);

            double ypos2 = 125;
            for(int i = 156268; i <= 166768; i += 500){
                bg2.MoveY(i, i+500, ypos2, ypos2 + 4.6);
                ypos2 += 4.6;
            }
            bg2.Fade(165268, 166768, 0.75, 0);
            
        }
    }
}
