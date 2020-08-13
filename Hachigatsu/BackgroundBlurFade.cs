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
    public class BackgroundBlurFade : StoryboardObjectGenerator
    {
        [Configurable]
        public string BackgroundPath = "";
        public override void Generate()
        {
            var bitmap = GetMapsetBitmap(BackgroundPath);
		    var bg = GetLayer("").CreateSprite(BackgroundPath, OsbOrigin.Centre);
            var bgclosed = GetLayer("").CreateSprite("sb/eyes.jpg", OsbOrigin.Centre);
            var bgblur = GetLayer("").CreateSprite("sb/bgblur.jpg", OsbOrigin.Centre);
            var blinder = GetLayer("Foreground").CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var transition1 = GetLayer("").CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var transition2 = GetLayer("").CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            bg.Fade(0,0,0,0);

            bgclosed.Scale(2763, 480.0f / bitmap.Height);
            bgblur.Scale(0, 480.0f / bitmap.Height);
            
            bgblur.Fade(0, 2763, 0.75, 0.75);
            bgblur.Fade(2763, 2763, 0, 0);
            blinder.Fade(2763, 3582, 1, 0);
            bgclosed.Fade(2763, 20218, 1, 1);
            blinder.Fade(11491, 12309, 0.75, 0);
            bgclosed.Fade(20218,22127, 1, 0);
            blinder.Fade(20218, 21036, 0.75, 0);

            bgblur.Fade(20218,22127, 0, 0.75);
            bgblur.Fade(22127, 41218, 0.75, 0.75);

            //BUILDUP 1

            bgblur.Fade(41218, 41218, 0, 0);

            bgblur.Fade(41218, 41763, 0.75, 0);
            bgclosed.Fade(41218, 41763, 0, 1);

            blinder.Fade(42036, 42854, 1, 0);

            bgclosed.Fade(41763, 61400, 1, 1);
            bgclosed.Rotate(OsbEasing.InOutExpo, 41763, 42309, 0, 0.15);
            bgclosed.Scale(OsbEasing.InOutExpo, 41763, 42309, 480.0f / bitmap.Height, 1.4*(480.0f / bitmap.Height));
            Vector2 currentPos = bgclosed.PositionAt(41763);
            bgclosed.Move(OsbEasing.InOutExpo, 41763, 42309, currentPos.X, currentPos.Y, 450, 270);
            bgclosed.Move(42309, 61400, 450, 270, 350, 250);

            bgclosed.Fade(61400, 61400, 0, 0);
            bg.Fade(61400, 61400, 1, 1);
            bg.Fade(61400, 107491, 1, 1);
            bg.Rotate(61400, 0.15);
            bg.Scale(61127, 2*(480.0f / bitmap.Height));
            bg.Move(61400, 350, 250);
            bgclosed.Scale(OsbEasing.Out, 61127,61400, 1.4*(480.0f / bitmap.Height), 2*(480.0f / bitmap.Height));
            bg.Scale(OsbEasing.InOutExpo, 61400, 61809, 2*(480.0f / bitmap.Height), (480.0f / bitmap.Height));
            bg.Rotate(OsbEasing.InOutExpo, 61400, 61809, 0.15, 0);
            bg.Move(OsbEasing.InOutExpo, 61400, 61809, 350, 250, currentPos.X, currentPos.Y);
            
            blinder.Fade(61673, 62491, 1, 0);

            blinder.Fade(90036, 90854, 1, 0);

            blinder.Fade(107491, 108309, 0.75, 0);

            //POST CHORUS

            bgclosed.Scale(107491, 480.0f / bitmap.Height);
            bgclosed.Rotate(107491, 0);
            bgclosed.Move(107491, currentPos.X, currentPos.Y);
            bgclosed.Fade(107491,109400, 1, 0);
            bg.Fade(107491, 107491, 0, 0);
            bgblur.Fade(107491,109400, 0, 0.75);
            bgblur.Fade(109400,128491, 0.75, 0.75);

            //BUILDUP 2

            bgblur.Fade(128491, 129036, 0.75, 0);
            bgclosed.Fade(128491, 129036, 0, 1);


            bgclosed.Fade(129036, 148673, 1, 1);
            bgclosed.Rotate(OsbEasing.InOutExpo, 129036, 129582, 0, 0.15);
            bgclosed.Scale(OsbEasing.InOutExpo, 129036, 129582, 480.0f / bitmap.Height, 1.4*(480.0f / bitmap.Height));
            bgclosed.Move(OsbEasing.InOutExpo, 129036, 129582, currentPos.X, currentPos.Y, 450, 270);
            bgclosed.Move(129582, 148673, 450, 270, 350, 250);

            bgclosed.Fade(148673, 148673, 0, 0);
            bg.Fade(148673, 148673, 1, 1);
            bg.Fade(148673, 181673, 1, 1);
            bg.Rotate(148673, 0.15);
            bg.Scale(148400, 2*(480.0f / bitmap.Height));
            bg.Move(148673, 350, 250);
            bgclosed.Scale(OsbEasing.Out, 148400,148673, 1.4*(480.0f / bitmap.Height), 2*(480.0f / bitmap.Height));
            bg.Scale(OsbEasing.InOutExpo, 148673, 149082, 2*(480.0f / bitmap.Height), (480.0f / bitmap.Height));
            bg.Rotate(OsbEasing.InOutExpo, 148673, 149082, 0.15, 0);
            bg.Move(OsbEasing.InOutExpo, 148673, 149082, 350, 250, currentPos.X, currentPos.Y);
            
            blinder.Fade(61673, 62491, 1, 0);

            blinder.Fade(90036, 90854, 1, 0);

            blinder.Fade(98763, 99582, 0.75, 0);

            blinder.Fade(107491, 108309, 0.75, 0);

            blinder.Fade(129309, 130127, 1, 0);

            blinder.Fade(148945, 149763, 1, 0);

            blinder.Fade(181673, 182491, 0.75, 0);

            blinder.Fade(201445, 202263, 0.75, 0);

            bgblur.Fade(181673, 201309, 0.75, 0.75);
            bgblur.Fade(201309, 202945, 1, 0.75);
            bgblur.Fade(202945, 203491, 0.75, 0);

            blinder.Fade(210036, 210854, 0.75, 0);
            bg.Fade(181673, 181673, 0, 0);
            bg.Scale(210036, 211673, 1.4*(480.0f / bitmap.Height), 1.25*(480.0f / bitmap.Height));
            bg.Move(210036, 212218, 300, 230, currentPos.X, currentPos.Y);
            bg.Fade(210036, 211673, 1, 1);
            bg.Fade(211673, 212218, 1, 0);

            bgclosed.Fade(211673, 212218, 0, 0.75);
            bgclosed.Scale(211673, 480.0f / bitmap.Height);
            bgclosed.Move(210036, 212218, 300, 230, currentPos.X, currentPos.Y);
            bgclosed.Rotate(211673, 0);
            bgclosed.Fade(212218, 213036, 0.75, 0);

            bg.Scale(OsbEasing.Out, 211673, 212354, 1.25*(480.0f / bitmap.Height), 480.0f/bitmap.Height);
            bgclosed.Scale(OsbEasing.Out, 211673, 212354, 1.25*(480.0f / bitmap.Height), 480.0f/bitmap.Height);

            bgblur.Fade(212218, 213036, 0, 0.75);
            bgblur.Fade(213036, 218763, 0.75, 0.75);

            //FINAL CHORUS

            bgclosed.Fade(220400, 220945, 1, 1);
            transition1.Color(220400, 0, 0, 0);
            transition2.Color(220400, 0, 0, 0);
            transition1.Fade(220400, 220945, 1, 1);
            transition2.Fade(220400, 220945, 1, 1);
            transition1.Rotate(220400, 0.25);
            transition1.Move(OsbEasing.InOutExpo, 220263, 220945, 60, 580, 60, 700);
            transition2.Rotate(220400, 0.25);
            transition2.Move(OsbEasing.InOutExpo , 220263, 220945, 180, -140, 180, -260);

            blinder.Fade(220945, 221763, 1, 0);
            blinder.Fade(238400, 239218, 0.75, 0);
            blinder.Fade(255854, 256673, 0.75, 0);
            bg.Fade(220945,270036, 1, 1);
        }
    }
}
