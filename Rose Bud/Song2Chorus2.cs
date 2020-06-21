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
    public class Song2Chorus2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var layer2 = GetLayer("Foreground");
            var inner = layer2.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var outer = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var flash = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            
            flash.Scale(555785,5);
            flash.Fade(555785,556128, 0.25,0);
            flash.Fade(271498,271822, 0.25,0);
            flash.Fade(289660,289984, 0.25,0);
            inner.Fade(271336,271498,0,1);
            inner.Fade(271498,289660,1,1);
            inner.MoveX(271498, 200);
            inner.Scale(271498,0.50);

            outer.Fade(271336,271498,0,1);
            outer.Fade(271498,289660,1,1);
            outer.MoveX(271498, 200);
            outer.Scale(271498,0.5);
            outer.Color(271498,0.332,0.0585,0.6133);

            double spin = 0;
            for (int i = 271498; i <= 289660; i+=5){
                spin += 0.005;
                inner.Rotate(i, spin);
                outer.Rotate(i, -spin);
            }

            for (int i = 271498; i <= 289660; i+=325){
                inner.Scale(i, i+200, 0.55, 0.5);
                outer.Scale(i, i+200, 0.55, 0.5);
            }

            flash.Fade(574985,575328, 0.25,0);
        }
    }
}
