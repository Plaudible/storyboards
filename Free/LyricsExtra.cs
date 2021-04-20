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
    public class LyricsExtra : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var l1 = layer.CreateSprite("sb/f/extras/1/3084.png", OsbOrigin.Centre);
            l1.Fade(29158, 29612, 1, 1);
            l1.Scale(29158, 0.9);
            l1.MoveY(OsbEasing.OutExpo, 29271, 29612, 540, 240);

            var clap = layer.CreateSprite("sb/f/extras/1/_009.png", OsbOrigin.Centre);
            var your = layer.CreateSprite("sb/f/extras/1/_00a.png", OsbOrigin.Centre);
            var hands = layer.CreateSprite("sb/f/extras/1/_00b.png", OsbOrigin.Centre);
            clap.Fade(OsbEasing.OutExpo, 32340, 33135, 1, 1);
            clap.Fade(OsbEasing.OutExpo, 33145, 33892, 1, 0);
            clap.Scale(33145, 0.8);

            your.Fade(OsbEasing.OutExpo, 32681, 33135, 1, 1);
            your.Fade(OsbEasing.OutExpo, 33145, 33892, 1, 0);
            your.Scale(33145, 0.8);
            
            hands.Fade(OsbEasing.OutExpo, 33021, 33135, 1, 1);
            hands.Fade(OsbEasing.OutExpo, 33145, 33892, 1, 0);
            hands.Scale(33145, 0.8);

            clap.Move(OsbEasing.OutExpo, 32340, 33892, -200, 240, 120, 240);
            your.Move(OsbEasing.OutExpo, 32681, 33892, 840, 240, 480, 240);
            hands.Move(OsbEasing.OutExpo, 33021, 33892, 320, 440, 320, 360);

            //CHORUS
            var how = layer.CreateSprite("sb/f/extras/2/_003.png", OsbOrigin.Centre);
            var about = layer.CreateSprite("sb/f/extras/2/_004.png", OsbOrigin.Centre);
            var you = layer.CreateSprite("sb/f/extras/2/_005.png", OsbOrigin.Centre);
            how.Scale(50749, 0.6);
            how.Fade(50749, 51431, 1, 1);

            about.Scale(50976, 0.5);
            about.Fade(50976, 51431, 1, 1);

            you.Scale(51203, 0.4);
            you.Fade(51203, 51431, 1, 1);

            how.Move(OsbEasing.OutExpo, 50749, 50976, 320, 500, 320, 200);
            about.Move(OsbEasing.OutExpo, 50976, 51203, 520, 500, 520, 280);
            you.Move(OsbEasing.OutExpo, 51203, 51431, 320, 500, 320, 360);

            how.Fade(51431, 51431, 0, 0);
            about.Fade(51431, 51431, 0, 0);
            you.Fade(51431, 51431, 0, 0);

            //POSTCHORUS
            var i = layer.CreateSprite("sb/f/extras/2/0049.png", OsbOrigin.Centre);
            var wa = layer.CreateSprite("sb/f/extras/2/_000.png", OsbOrigin.Centre);
            var nna = layer.CreateSprite("sb/f/extras/2/_001.png", OsbOrigin.Centre);
            var get = layer.CreateSprite("sb/f/extras/2/_002.png", OsbOrigin.Centre);

            i.Scale(72567, 0.6);
            i.Fade(72567, 73249, 1, 1);

            wa.Scale(72794, 0.6);
            wa.Fade(72794, 73249, 1, 1);
            nna.Scale(72908, 0.6);
            nna.Fade(72908, 73249, 1, 1);

            get.Scale(73022, 0.6);
            get.Fade(73022, 73249, 1, 1);

            i.Move(OsbEasing.OutExpo, 72567, 72794, 180, 500, 180, 228);
            wa.Move(OsbEasing.OutExpo, 72794, 73022, 290, 500, 290, 240);
            nna.Move(OsbEasing.OutExpo, 72908, 73022, 430, 500, 430, 240);
            get.Move(OsbEasing.OutExpo, 73022, 73135, 340, 500, 340, 340);

            i.Rotate(OsbEasing.In, 73022, 73249, 0, -0.2);
            i.Move(OsbEasing.In, 73022, 73249, 180, 228, 60, 320);
            wa.Rotate(OsbEasing.In, 73022, 73249, 0, -0.2);
            wa.Move(OsbEasing.InExpo, 73022, 73249, 290, 240, 290, 310);
            nna.Rotate(OsbEasing.In, 73022, 73249, 0, -0.2);
            nna.Move(OsbEasing.InExpo, 73022, 73249, 430, 240, 865, 200);
            get.Rotate(OsbEasing.In, 73022, 73249, -0.05, -0.1);
            get.Move(OsbEasing.InExpo, 73135, 73249, 340, 340, 380, 2000);

            i.Scale(OsbEasing.InExpo, 73022,73249, 0.6, 2.5);
            wa.Scale(OsbEasing.InExpo, 73022,73249, 0.6, 2.5);
            nna.Scale(OsbEasing.InExpo, 73022,73249, 0.6, 2.5);
            get.Scale(OsbEasing.InExpo, 73022,73249, 0.6, 2.5);

            i.Fade(73249, 73249, 0, 0);
            wa.Fade(73249, 73249, 0, 0);
            nna.Fade(73249, 73249, 0, 0);

            //final
            var ill = layer.CreateSprite("sb/f/extras/3/_003.png", OsbOrigin.Centre);
            var be = layer.CreateSprite("sb/f/extras/3/_004.png", OsbOrigin.Centre);
            var back = layer.CreateSprite("sb/f/extras/3/_005.png", OsbOrigin.Centre);
            ill.Scale(95293, 0.6);
            ill.Fade(95293, 95975, 1, 1);

            be.Scale(95521, 0.5);
            be.Fade(95521, 95975, 1, 1);

            back.Scale(95748, 0.4);
            back.Fade(95748, 95975, 1, 1);

            ill.Move(OsbEasing.OutExpo, 95293, 95521, 320, 500, 320, 200);
            be.Move(OsbEasing.OutExpo, 95521, 95748, 520, 500, 520, 280);
            back.Move(OsbEasing.OutExpo, 95748, 95975, 320, 500, 320, 360);

             how.Scale(135293, 0.6);
            how.Fade(135293, 135975, 1, 1);

            about.Scale(135521, 0.5);
            about.Fade(135521, 135975, 1, 1);

            you.Scale(135748, 0.4);
            you.Fade(135748, 135975, 1, 1);

            how.Move(OsbEasing.OutExpo, 135293, 135521, 320, 500, 320, 200);
            about.Move(OsbEasing.OutExpo, 135521, 135748, 520, 500, 520, 280);
            you.Move(OsbEasing.OutExpo, 135748, 135975, 320, 500, 320, 360);
            you.Fade(135975, 135975, 0, 0);

            var im = layer.CreateSprite("sb/f/extras/3/_009.png", OsbOrigin.Centre);
            var with = layer.CreateSprite("sb/f/extras/3/_00a.png", OsbOrigin.Centre);
            var you2 = layer.CreateSprite("sb/f/extras/3/_00b.png", OsbOrigin.Centre);

            im.Scale(149839, 0.6);
            im.Fade(149839, 150521, 1, 1);

            with.Scale(150066, 0.5);
            with.Fade(150066, 150521, 1, 1);

            you2.Scale(150293, 0.4);
            you2.Fade(150293, 150521, 1, 1);

            im.Move(OsbEasing.OutExpo, 149839, 150066, 320, 500, 320, 200);
            with.Move(OsbEasing.OutExpo, 150066, 150293, 520, 500, 520, 280);
            you2.Move(OsbEasing.OutExpo, 150293, 150521, 320, 500, 320, 360);

            i.Scale(142566, 0.6);
            i.Fade(142566, 143248, 1, 1);

            wa.Scale(142793, 0.5);
            wa.Fade(142793, 143248, 1, 1);

            nna.Scale(143021, 0.5);
            nna.Fade(143021, 143248, 1, 1);

            i.Move(OsbEasing.OutExpo, 142566, 142793, 220, 500, 220, 200);
            wa.Move(OsbEasing.OutExpo, 142793, 143021, 420, 500, 420, 280);
            nna.Move(OsbEasing.OutExpo, 143021, 143248, 535, 500, 535, 258);
        }
    }
}
 