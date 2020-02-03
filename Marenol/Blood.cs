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
    public class Blood : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var blood1 = layer.CreateSprite("sb/blood-2.png", OsbOrigin.Centre);
            var blood2 = layer.CreateSprite("sb/blood-1.png", OsbOrigin.Centre); 

            blood1.Scale(1700, 480.0 / 768);
            blood1.Move(1700,100,100);
            blood2.Scale(2621, 480.0 / 768);
            blood1.Fade(1700,2407,1,0);
            blood2.Fade(2621,3264,1,0);

            blood1.Fade(99478,100121,1,0);
            blood2.Fade(100335,100978,1,0);
            
        }
    }
}
