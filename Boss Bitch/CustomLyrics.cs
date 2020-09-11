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
    public class CustomLyrics : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
		    var y = layer.CreateSprite("sb/f/0079.png", OsbOrigin.Centre);
            var u = layer.CreateSprite("sb/f/0075.png", OsbOrigin.Centre);
            var h = layer.CreateSprite("sb/f/0068.png", OsbOrigin.Centre);
            var d = layer.CreateSprite("sb/f/0064.png", OsbOrigin.Centre);
            var r = layer.CreateSprite("sb/f/0072.png", OsbOrigin.Centre);
            var o = layer.CreateSprite("sb/f/006f.png", OsbOrigin.Centre);
            var p = layer.CreateSprite("sb/f/0070.png", OsbOrigin.Centre);

            y.Fade(7424, 7782, 1, 1);
            u.Fade(7424, 7782, 1, 1);
            h.Fade(7424, 7782, 1, 1);
            y.Fade(7782, 7982, 1, 0);
            u.Fade(7782, 7982, 1, 0);
            h.Fade(7782, 7982, 1, 0);
            
            y.Move(7424, 265, 100);
            u.Move(7424, 315, 100);
            h.Move(7424, 365, 100);

            y.Scale(OsbEasing.Out, 7424, 7782, 0, 1);
            u.Scale(OsbEasing.Out, 7424, 7782, 0, 1);
            h.Scale(OsbEasing.Out, 7424, 7782, 0, 1);

            d.Fade(67901, 68139, 1, 1);
            r.Fade(67901, 68139, 1, 1);
            o.Fade(67901, 68139, 1, 1);
            p.Fade(67901, 68139, 1, 1);
            d.Fade(68139, 68615, 1, 0);
            r.Fade(68139, 68615, 1, 0);
            o.Fade(68139, 68615, 1, 0);
            p.Fade(68139, 68615, 1, 0);

            d.Scale(OsbEasing.Out, 67901, 68139, 0, 1);
            r.Scale(OsbEasing.Out, 67901, 68139, 0, 1);
            o.Scale(OsbEasing.Out, 67901, 68139, 0, 1);
            p.Scale(OsbEasing.Out, 67901, 68139, 0, 1);

            d.Move(67901, 245, 100);
            r.Move(67901, 295, 100);
            o.Move(67901, 345, 100);
            p.Move(67901, 395, 100);
        }
    }
}
