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
    public class Screensplit : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("Foreground");
		    var square = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var blinder = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            blinder.Color(24268, 1, 1, 1);
            blinder.Fade(24268, 25768,0.50, 0);
            
            square.Color(23987, 0, 0, 0);
            square.Fade(23987, 36269, 1, 1);
            square.Scale(23987, 1);
            square.Rotate(23987, -0.4);
            square.MoveY(OsbEasing.Out, 23987, 24550, -320, -140);
            square.MoveX(23987, 0);

            square.Scale(OsbEasing.In, 35706, 36362, 1, 2);
            square.MoveY(OsbEasing.In, 35706, 36362, -140, 240);

            square.Fade(36269, 36269, 0, 0);
            square.Fade(46769, 48269, 1, 1 );
            blinder.Fade(45269, 46769,0,1);
            blinder.Fade(46769, 47143,0.75,0);

            //CHORUS
            var halfsplit1 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var halfsplit2 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            halfsplit1.Color(48269,0,0,0);
            halfsplit2.Color(48269,0,0,0);
            halfsplit1.Rotate(48269, 1.571);
            halfsplit2.Rotate(48269, 1.571);
            halfsplit1.Scale(48269,0.75);
            halfsplit2.Scale(48269,0.75);
            halfsplit1.Fade(48269,48831,1,1);
            halfsplit1.Fade(48831,48832,0,0);
            halfsplit2.Fade(48269,48831,1,1);
            halfsplit2.Fade(48831,48832,0,0);
            halfsplit1.MoveX(OsbEasing.Out,48269,48456,20,-250);
            halfsplit2.MoveX(OsbEasing.Out,48269,48456,590,900);
            halfsplit1.MoveY(OsbEasing.Out,48456,48643,50,-520);
            halfsplit2.MoveY(OsbEasing.Out,48456,48643,500,1000);
            blinder.Fade(48643,49393,0.75,0);

            var vignette = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette.Fade(OsbEasing.In,54175,54362, 0,0.5);
            vignette.Fade(OsbEasing.In,54550,54737, 0.5,0);
            vignette.Scale(54550, (360.0 / 768)*1.55);

            vignette.Fade(OsbEasing.In,60175,60362, 0,0.5);
            vignette.Fade(OsbEasing.In,60550,60737, 0.5,0);
            blinder.Fade(60643,61393,0.75,0);

            halfsplit1.Fade(71518,72268,1,1);
            halfsplit1.Fade(72268,73018,1,0);
            halfsplit2.Fade(71518,72268,1,1);
            halfsplit2.Fade(72268,73018,1,0);
            halfsplit1.MoveX(OsbEasing.Out,72081,72268,-250,30);
            halfsplit2.MoveX(OsbEasing.Out,72081,72268,900,606);
            halfsplit1.MoveY(OsbEasing.Out,71518,71800,-520,50);
            halfsplit2.MoveY(OsbEasing.Out,71800,72081,1000,500);

            //BUILDUP2
            var square2 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var square3 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            blinder.Fade(96268, 97393,0.50, 0);
            
            square2.Color(95987, 0, 0, 0);
            square2.Fade(95987, 108268, 1, 1);
            square2.Scale(95987, 1);
            square2.Rotate(95987, 0.4);
            square2.MoveY(OsbEasing.Out, 95987, 96550, 820, 620);
            square2.MoveX(95987, 0);
            square2.Scale(107987,1);
            //square2.Rotate(107987, 108550, 0.4, 0);
            square2.MoveY(OsbEasing.In, 107987, 108362, 620, 240);
            square2.MoveX(OsbEasing.In, 107987, 108362, 0, 320);
            square2.Fade(108643,108643, 0, 0);

            square3.Color(108362, 0, 0, 0);
            square3.Fade(108362, 118768, 1, 1);
            square3.Scale(OsbEasing.Out, 108362, 109018 ,2, 1);
            square3.Rotate(108362, -0.4);
            square3.MoveY(OsbEasing.Out, 108362, 108925, 620, -140);
            square3.MoveX(108362, 0);
            square3.Scale(OsbEasing.In, 118393, 118862 ,1, 2);
            square3.MoveY(OsbEasing.In, 118393, 118862, -140, 620);

            //BREAKDOWN
            blinder.Fade(120268, 121393,0.75, 0);
            blinder.Fade(132268,133393, 0.75, 0);

            var halfsplit3 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var halfsplit4 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            halfsplit3.MoveX(143518,-250);
            halfsplit4.MoveX(143518,900);
            halfsplit3.MoveY(143518,-520);
            halfsplit4.MoveY(143518,1000);
            halfsplit3.Color(143518,0,0,0);
            halfsplit4.Color(143518,0,0,0);
            halfsplit3.Rotate(143518, 1.571);
            halfsplit4.Rotate(143518, 1.571);
            halfsplit3.Scale(143518,0.75);
            halfsplit4.Scale(143518,0.75);
            halfsplit3.Fade(143518,144268,1,1);
            halfsplit3.Fade(144268,144268,1,0);
            halfsplit4.Fade(143518,144268,1,1);
            halfsplit4.Fade(144268,144268,1,0);
            halfsplit3.MoveX(OsbEasing.Out,144081,144268,-250,30);
            halfsplit4.MoveX(OsbEasing.Out,144081,144268,900,606);
            halfsplit3.MoveY(OsbEasing.Out,143518,143800,-520,50);
            halfsplit4.MoveY(OsbEasing.Out,143800,144081,1000,500);
            //PRECHORUS

            var square4 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            square4.Color(155518, 0, 0, 0);
            square4.Fade(155518, 36269, 1, 1);
            square4.Scale(155518, 1);
            square4.Rotate(155518, -0.4);
            square4.MoveY(OsbEasing.InOutQuad, 155518, 156268, -420, -50);
            square4.MoveX(155518, 0);
            square4.Scale(OsbEasing.In, 155518, 156268, 1, 2);

            //BUILDUP
            blinder.Fade(165268, 166768,0,1);
            blinder.Fade(166768, 167143,0.75,0);
            //CHORUS
            var halfsplit5 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            var halfsplit6 = layer.CreateSprite("sb/bigsquare.png", OsbOrigin.Centre);
            halfsplit5.MoveX(167425,30);
            halfsplit6.MoveX(167425,606);
            halfsplit5.MoveY(167425,50);
            halfsplit6.MoveY(167425,500);
            halfsplit5.Color(167425,0,0,0);
            halfsplit6.Color(167425,0,0,0);
            halfsplit5.Rotate(167425, 1.571);
            halfsplit6.Rotate(167425, 1.571);
            halfsplit5.Scale(167425,0.75);
            halfsplit6.Scale(167425,0.75);
            halfsplit5.Fade(167425,168175,1,1);
            halfsplit5.Fade(168175,168268,1,0);
            halfsplit6.Fade(167425,168175,1,1);
            halfsplit6.Fade(168175,168268,1,0);
            halfsplit5.MoveX(OsbEasing.Out,167425,167800,30,-250);
            halfsplit6.MoveX(OsbEasing.Out,167800,168081,606,900);
            halfsplit5.MoveY(OsbEasing.In,168081,168268,50,-520);
            halfsplit6.MoveY(OsbEasing.In,168081,168268,500,1000);

            blinder.Fade(168268, 169393,0.75,0);
            blinder.Fade(180268, 181393,0.75,0);
            blinder.Fade(192268, 193393,0.75,0);

        }

        

        
    }
}
