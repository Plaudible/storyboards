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
    public class Song1Chorus : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var layer2 = GetLayer("Foreground");
            var inner = layer2.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var outer = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
            var flash = layer.CreateSprite("sb/square.png", OsbOrigin.Centre);
            
            flash.Scale(224795,5);
            flash.Fade(224795,225120, 0.25,0);

            inner.Fade(224633,224795,0,1);
            inner.Fade(224957,242957,1,1);
            inner.MoveX(224795, 450);
            inner.Scale(224795,0.50);

            outer.Fade(224633,224795,0,1);
            outer.Fade(224957,242957,1,1);
            outer.MoveX(224795, 450);
            outer.Scale(224795,0.5);
            outer.Color(224795,0.332,0.0585,0.6133);

            double spin = 0;
            for (int i = 224795; i <= 242957; i+=5){
                spin += 0.005;
                inner.Rotate(i, spin);
                outer.Rotate(i, -spin);
            }

            for (int i = 224957; i <= 242957; i+=325){
                inner.Scale(i, i+200, 0.55, 0.5);
                outer.Scale(i, i+200, 0.55, 0.5);
            }

            inner.Scale(227390, 227590, 0.55, 0.5);
            outer.Scale(227390, 227590, 0.55, 0.5);

            inner.Scale(229984, 230184, 0.55, 0.5);
            outer.Scale(229984, 230184, 0.55, 0.5);

            inner.Scale(232579, 232779, 0.55, 0.5);
            outer.Scale(232579, 232779, 0.55, 0.5);

            inner.Scale(235174, 235374, 0.55, 0.5);
            outer.Scale(235174, 235374, 0.55, 0.5);

            inner.Scale(237768, 237968, 0.55, 0.5);
            outer.Scale(237768, 237968, 0.55, 0.5);

            inner.Scale(240363, 240563, 0.55, 0.5);
            outer.Scale(240363, 240563, 0.55, 0.5);

            flash.Fade(242957,243282, 0.25,0);

            flash.Fade(502985,503585, 0.25,0);
            flash.Fade(512585,513271, 0.25,0);
        }
    }
}
