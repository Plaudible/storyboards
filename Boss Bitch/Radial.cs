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
    public class Radial : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var radial = layer.CreateSprite("sb/radial.png", OsbOrigin.Centre);

            radial.Fade(7424, 22901, 1, 1);
            radial.Scale(OsbEasing.Out, 7424, 7782, 0, 0.6);
            radial.Rotate(OsbEasing.Out, 7424, 7782, -1, 0);
            radial.Scale(7782, 0.6);

            for(int i = 8139; i <= 22901; i += 476)
            {
                radial.Scale(i, i+100, 0.57, 0.6);
                radial.Scale(i+100, i+276, 0.6, 0.61);
            }
            radial.Fade(22901, 22901, 0, 0);

            radial.Scale(OsbEasing.In, 22424, 22901, 0.6, 0);
            radial.Rotate(OsbEasing.In, 22424, 22901, 0, 1);

            //breakdown
            radial.Fade(68377, 83853, 1, 1);
            radial.Scale(OsbEasing.Out, 68377, 68734, 0, 0.6);
            radial.Rotate(OsbEasing.Out, 68377, 68734, -1, 0);
            for(int i = 68615; i <= 83853; i += 476)
            {
                radial.Scale(i, i+100, 0.57, 0.6);
                radial.Scale(i+100, i+276, 0.6, 0.61);
            }
            radial.Fade(83853, 83853, 0, 0);

            radial.Scale(OsbEasing.In,83139,83853, 0.6, 0);
            radial.Rotate(OsbEasing.In, 83139, 83853, 0, 1);
        }

        
    }
}
