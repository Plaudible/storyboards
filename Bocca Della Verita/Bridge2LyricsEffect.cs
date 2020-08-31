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
    public class Bridge2LyricsEffect : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var letter1 = layer.CreateSprite("sb/f/3092.png", OsbOrigin.Centre);
            var letter2 = layer.CreateSprite("sb/f/706b.png", OsbOrigin.Centre);
            var letter3 = layer.CreateSprite("sb/f/50b7.png", OsbOrigin.Centre);
            var letter4 = layer.CreateSprite("sb/f/3055.png", OsbOrigin.Centre);
            var letter5 = layer.CreateSprite("sb/f/305b.png", OsbOrigin.Centre);
            var letter6 = layer.CreateSprite("sb/f/308b.png", OsbOrigin.Centre);
            var blood1 = layer.CreateSprite("sb/b/blood-1.png", OsbOrigin.Centre);
            var blood2 = layer.CreateSprite("sb/b/blood-2.png", OsbOrigin.Centre);
            var blood3 = layer.CreateSprite("sb/b/blood-3.png", OsbOrigin.Centre);
            var blood4 = layer.CreateSprite("sb/b/blood-4.png", OsbOrigin.Centre);
            var blood5 = layer.CreateSprite("sb/b/blood-1.png", OsbOrigin.Centre);
            var blood6 = layer.CreateSprite("sb/b/blood-2.png", OsbOrigin.Centre);
            
            letter1.Fade(98941, 99647, 1, 1);
            letter1.Move(98941, 50, 100);
            blood1.Fade(98941, 99647, 0.5, 0);
            blood1.Scale(98941, 0.25);
            blood1.Move(98941, 50,100);
            letter2.Fade(99059, 99647, 1, 1);
            letter2.Move(99059, 400, 350);
            blood2.Fade(99059, 99647, 0.5, 0);
            blood2.Scale(99059, 0.35);
            blood2.Move(99059, 400, 350);
            letter3.Fade(99176, 99647, 1, 1);
            letter3.Move(99176, 600, 120);
            blood3.Fade(99176, 99647, 0.5, 0);
            blood3.Scale(99176, 0.55);
            blood3.Move(99176, 600, 120);
            letter4.Fade(99294, 99647, 1, 1);
            letter4.Move(99294, 131, 295);
            blood4.Fade(99294, 99647, 0.5, 0);
            blood4.Scale(99294, 0.70);
            blood4.Move(99294, 131, 295);
            letter5.Fade(99412, 99647, 1, 1);
            letter5.Move(99412, 290, 70);
            blood5.Fade(99412, 99647, 0.5, 0);
            blood5.Scale(99412, 0.85);
            blood5.Move(99412, 290, 70);
            letter6.Fade(99529, 99647, 1, 1);
            letter6.Move(99529, 590, 400);
            blood6.Fade(99529, 99647, 0.5, 0);
            blood6.Scale(99529, 0.85);
            blood6.Move(99529, 590, 400);

            letter1.Scale(OsbEasing.Out, 98941, 99059, 0, 0.25);
            letter1.Move(98941, 99647, 50, 100, 50, 95);
            letter2.Scale(OsbEasing.Out,99059, 99176, 0, 0.36);
            letter2.Move(99059, 99647, 400, 350, 400, 345);
            letter3.Scale(OsbEasing.Out,99176, 99294, 0, 0.57);
            letter3.Move(99176, 99647, 600, 120, 600, 115);
            letter4.Scale(OsbEasing.Out,99294, 99412, 0, 0.88);
            letter4.Move(99294, 99647, 131, 295, 131, 290);
            letter5.Scale(OsbEasing.Out,99412, 99529, 0, 1);
            letter5.Move(99412, 99647, 290, 70, 290, 65);
            letter6.Scale(OsbEasing.Out,99529, 99647, 0, 1.2);
            letter6.Move(99529, 99647, 590, 400, 590, 395);


        }
    }
}
