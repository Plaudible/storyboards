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
    public class ShapesIntro : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var c1 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
            var c2 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);

            c1.Fade(522, 4158, 1, 1);
            c2.Fade(522, 4158, 1, 1);

            c1.Scale(OsbEasing.OutExpo, 522, 749, 0,0.1);
            c2.Scale(OsbEasing.OutExpo, 522, 749, 0,0.1);
            c1.Scale(OsbEasing.OutExpo, 749, 1090, 0.1, 0.06);
            c2.Scale(OsbEasing.OutExpo, 749, 1090, 0.1, 0.06);
            c1.Move(OsbEasing.OutExpo, 749, 1090, 320, 240, 280, 240);
            c2.Move(OsbEasing.OutExpo, 749, 1090, 320, 240, 360, 240);

            var c3 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
            var c4 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);

            c3.Fade(1090, 4158, 1, 1);
            c4.Fade(1090, 4158, 1, 1);

            c3.Move(1090, 280, 240);
            c4.Move(1090, 360, 240);
            c3.Scale(1090, 0.06);
            c4.Scale(1090, 0.06);
            c1.Move(OsbEasing.OutExpo, 1090, 1431, 280, 240, 280, 200);
            c3.Move(OsbEasing.OutExpo, 1090, 1431, 280, 240, 280, 280);
            c2.Move(OsbEasing.OutExpo, 1090, 1431, 360, 240, 360, 200);
            c4.Move(OsbEasing.OutExpo, 1090, 1431, 360, 240, 360, 280);

            c1.Scale(OsbEasing.OutExpo, 1090, 1431, 0.06, 0.04);
            c2.Scale(OsbEasing.OutExpo, 1090, 1431, 0.06, 0.04);
            c3.Scale(OsbEasing.OutExpo, 1090, 1431, 0.06, 0.04);
            c4.Scale(OsbEasing.OutExpo, 1090, 1431, 0.06, 0.04);

            c1.Scale(OsbEasing.OutExpo, 1658, 1885, 0.04, 0.07);
            c2.Scale(OsbEasing.OutExpo, 1771, 1999, 0.04, 0.07);
            c3.Scale(OsbEasing.OutExpo, 1885, 2112, 0.04, 0.07);
            c4.Scale(OsbEasing.OutExpo, 1999, 2226, 0.04, 0.07);

            c1.Move(OsbEasing.OutExpo, 1658, 1885, 280, 200, 260, 180);
            c2.Move(OsbEasing.OutExpo, 1771, 1999, 360, 200, 380, 180);
            c3.Move(OsbEasing.OutExpo, 1885, 2112, 280, 280, 260, 300);
            c4.Move(OsbEasing.OutExpo, 1999, 2226, 360, 280, 380, 300);

            c1.Move(OsbEasing.OutExpo, 2453, 2681, 260, 180, 320, 160);
            c2.Move(OsbEasing.OutExpo, 2453, 2681, 380, 180, 400, 240);
            c3.Move(OsbEasing.OutExpo, 2453, 2681, 260, 300, 240, 240);
            c4.Move(OsbEasing.OutExpo, 2453, 2681, 380, 300, 320, 320);

            c1.Move(OsbEasing.OutExpo, 2794, 3022, 320, 160, 380, 180);
            c2.Move(OsbEasing.OutExpo, 2794, 3022, 400, 240, 380, 300);
            c3.Move(OsbEasing.OutExpo, 2794, 3022, 240, 240, 260, 180);
            c4.Move(OsbEasing.OutExpo, 2794, 3022, 320, 320, 260, 300);

            c1.Move(OsbEasing.OutExpo, 3590, 3817, 380, 180, 320, 240);
            c2.Move(OsbEasing.OutExpo, 3476, 3703, 380, 300, 320, 240);
            c3.Move(OsbEasing.OutExpo, 3362, 3590, 260, 180, 320, 240);
            c4.Move(OsbEasing.OutExpo, 3249, 3476, 260, 300, 320, 240);

            c4.Scale(OsbEasing.Out, 3249, 3703, 0.07, 0.1);

            c1.Scale(OsbEasing.InExpo, 3931, 4158, 0.07, 0);
            c2.Scale(OsbEasing.InExpo, 3931, 4158, 0.07, 0);
            c3.Scale(OsbEasing.InExpo, 3931, 4158, 0.07, 0);
            c4.Scale(OsbEasing.InExpo, 3931, 4158, 0.1, 0);

            //SQUARES
            var s1 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s2 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            s1.Fade(4158, 7794, 1, 1);
            s2.Fade(4158, 7794, 1, 1);

            s1.ScaleVec(OsbEasing.OutExpo, 4158, 4499, 0, 0, 70, 70);
            s2.ScaleVec(OsbEasing.OutExpo, 4158, 4499, 0, 0, 70, 70);
            s1.ScaleVec(OsbEasing.OutExpo, 4499, 4840, 70, 70, 30, 30);
            s2.ScaleVec(OsbEasing.OutExpo, 4499, 4840, 70, 70, 30, 30);
            s1.Move(OsbEasing.OutExpo, 4499, 4840, 320, 240, 280, 240);
            s2.Move(OsbEasing.OutExpo, 4499, 4840, 320, 240, 360, 240);
            
            var s3 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            var s4 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);

            s3.Fade(4840, 7794, 1, 1);
            s4.Fade(4840, 7794, 1, 1);

            s3.Move(4840, 280, 240);
            s4.Move(4840, 360, 240);
            s3.ScaleVec(4840, 20, 30);
            s4.ScaleVec(4840, 20, 30);
            s1.Move(OsbEasing.OutExpo, 4840, 5181, 280, 240, 280, 200);
            s3.Move(OsbEasing.OutExpo, 4840, 5181, 280, 240, 280, 280);
            s2.Move(OsbEasing.OutExpo, 4840, 5181, 360, 240, 360, 200);
            s4.Move(OsbEasing.OutExpo, 4840, 5181, 360, 240, 360, 280);

            s1.ScaleVec(OsbEasing.OutExpo, 4840, 5067, 30, 30, 20, 20);
            s2.ScaleVec(OsbEasing.OutExpo, 4840, 5067, 30, 30, 20, 20);
            s3.ScaleVec(OsbEasing.OutExpo, 4840, 5067, 30, 30, 20, 20);
            s4.ScaleVec(OsbEasing.OutExpo, 4840, 5067, 30, 30, 20, 20);

            s1.ScaleVec(OsbEasing.OutExpo, 5294, 5521, 20, 20, 40, 40);
            s2.ScaleVec(OsbEasing.OutExpo, 5408, 5635, 20, 20, 40, 40);
            s3.ScaleVec(OsbEasing.OutExpo, 5521, 5749, 20, 20, 40, 40);
            s4.ScaleVec(OsbEasing.OutExpo, 5635, 5862, 20, 20, 40, 40);

            s1.Move(OsbEasing.OutExpo, 5294, 5521, 280, 200, 260, 180);
            s2.Move(OsbEasing.OutExpo, 5408, 5635, 360, 200, 380, 180);
            s3.Move(OsbEasing.OutExpo, 5521, 5749, 280, 280, 260, 300);
            s4.Move(OsbEasing.OutExpo, 5635, 5862, 360, 280, 380, 300);

            s1.Move(OsbEasing.OutExpo, 5976, 6203, 260, 180, 320, 160);
            s2.Move(OsbEasing.OutExpo, 6090, 6317, 380, 180, 400, 240);
            s3.Move(OsbEasing.OutExpo, 6317, 6544, 260, 300, 240, 240);
            s4.Move(OsbEasing.OutExpo, 6544, 6771, 380, 300, 320, 320);

            s1.Move(OsbEasing.OutExpo, 6885, 7112, 320, 160, 320, 240);
            s4.Move(OsbEasing.OutExpo, 6885, 7112, 320, 320, 320, 240);

            s2.Move(OsbEasing.OutExpo, 6999, 7226, 400, 240, 320, 240);
            s3.Move(OsbEasing.OutExpo, 6999, 7226, 240, 240, 320, 240);
            s1.ScaleVec(OsbEasing.Out, 6999, 7226, 40, 40, 60, 60);
            
            s1.ScaleVec(OsbEasing.InExpo, 7226, 7340, 60, 60, 0, 0);
            s2.ScaleVec(OsbEasing.InExpo, 7226, 7340, 60, 60, 0, 0);
            s3.ScaleVec(OsbEasing.InExpo, 7226, 7340, 60, 60, 0, 0);
            s4.ScaleVec(OsbEasing.InExpo, 7226, 7340, 60, 60, 0, 0);

            var rs1 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            rs1.ScaleVec(7794, 30, 30);
            rs1.Move(7794, -160, 420);
            //ROLLING SQUARES
            for (int i = 7794; i <= 15067; i+=455){
                rs1.Rotate(i, i + 200, 0, 1.5708);
                rs1.Move(i, i+200, rs1.PositionAt(i).X, rs1.PositionAt(i).Y, rs1.PositionAt(i).X + 60, rs1.PositionAt(i).Y);
                var newbox = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
                newbox.Move(i, rs1.PositionAt(i).X, rs1.PositionAt(i).Y);
                newbox.Fade(i, i + 1500, 0.5, 0);
                newbox.ScaleVec(i, 30, 30);
            }

            var rs2 = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
            rs2.ScaleVec(7794, 30, 30);
            rs2.Move(7794, 800, 80);
            for (int i = 7794; i <= 15067; i+=455){
                rs2.Rotate(i, i + 200, 0, 1.5708);
                rs2.Move(i, i+200, rs2.PositionAt(i).X, rs2.PositionAt(i).Y, rs2.PositionAt(i).X - 60, rs2.PositionAt(i).Y);
                var newbox = layer.CreateSprite("sb/p.png", OsbOrigin.Centre);
                newbox.Move(i, rs2.PositionAt(i).X, rs2.PositionAt(i).Y);
                newbox.Fade(i, i + 1500, 0.5, 0);
                newbox.ScaleVec(i, 30, 30);
            }


            //SINEWAVE
            var sinewave = layer.CreateSprite("sb/sinewave.png", OsbOrigin.Centre);
            sinewaver(sinewave, 522, 15067);
            sinewaver(sinewave, 29612, 44158);
            sinewaver(sinewave, 73249, 88703);
            sinewaver(sinewave, 103248, 128703);
            sinewaver(sinewave, 170521, 174248);


            var sprite = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
            sprite.Scale(OsbEasing.OutExpo, 7794, 8022, 0, 0.04);
            var spritePos = new Vector2(320, 140);
            sprite.Scale(8022, 0.04);
            //CIRC credit Walavouchey
            sprite.StartLoopGroup(0, 2);
            sprite.MoveY(OsbEasing.InOutSine, 7794, 9794, spritePos.Y, spritePos.Y += 200);
            sprite.MoveY(OsbEasing.InOutSine, 9794, 11794, spritePos.Y, spritePos.Y -= 200);
            sprite.MoveX(OsbEasing.OutSine, 7794, 8794, spritePos.X, spritePos.X += 100);
            sprite.MoveX(OsbEasing.InOutSine, 8794, 10794, spritePos.X, spritePos.X -= 200);
            sprite.MoveX(OsbEasing.InSine, 10794, 11794, spritePos.X, spritePos.X += 100);
            sprite.EndGroup();

            var sprite2 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
            sprite2.Scale(OsbEasing.OutExpo, 7794, 8022, 0, 0.04);
            var spritePos2 = new Vector2(320, 340);
            sprite2.Scale(8022, 0.04);
            //CIRC credit Walavouchey
            sprite2.StartLoopGroup(0, 2);
            sprite2.MoveY(OsbEasing.InOutSine, 7794, 9794, spritePos2.Y, spritePos2.Y -= 200);
            sprite2.MoveY(OsbEasing.InOutSine, 9794, 11794, spritePos2.Y, spritePos2.Y += 200);
            sprite2.MoveX(OsbEasing.OutSine, 7794, 8794, spritePos2.X, spritePos2.X -= 100);
            sprite2.MoveX(OsbEasing.InOutSine, 8794, 10794, spritePos2.X, spritePos2.X += 200);
            sprite2.MoveX(OsbEasing.InSine, 10794, 11794, spritePos2.X, spritePos2.X -= 100);
            sprite2.EndGroup();
            
            sprite.Fade(7794, 15067, 1, 1);
            sprite.Fade(15067, 15067, 0, 0);
            sprite2.Fade(7794, 15067, 1, 1);
            sprite2.Fade(15067, 15067, 0, 0);

            //CROP
            var crop = layer.CreateSprite("sb/crop.png", OsbOrigin.Centre);
            crop.Scale(OsbEasing.OutExpo, 7794, 8249, 0, 0.12);
            crop.Fade(7794, 14726, 1, 1);
            crop.Fade(15067, 15067, 0, 0);

            //crop.Scale(OsbEasing.Out, 14612, 14726, 0.12, 0.13);
            crop.Scale(OsbEasing.InExpo, 14726, 15067, 0.12, (360.0 / 768)*1);
            crop.Move(OsbEasing.InExpo, 14726, 15067, 320, 240, 333, 240);

                //=======================================================================
            //BRIDGE
                crop.Scale(OsbEasing.OutExpo, 29612, 30067, (360.0 / 768)*1, 0.12);
                crop.Move(OsbEasing.OutExpo, 29612, 30067, 333, 240, 320, 240);
                crop.Fade(29612, 42794, 1, 1);
                crop.Scale(OsbEasing.In, 42226, 42794, 0.12, 0);

                var sprite3 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite3.Scale(OsbEasing.OutExpo, 29612, 30067, 0, 0.04);
                var spritePos3 = new Vector2(320, 340);
                sprite3.Scale(30067, 0.04);

                var sprite4 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite4.Scale(OsbEasing.OutExpo, 29612, 30067, 0, 0.04);
                var spritePos4 = new Vector2(320, 140);
                sprite4.Scale(30067, 0.04);

                sprite3.Fade(29612, 42794, 1, 1);
                sprite4.Fade(29612, 42794, 1, 1);

                sprite3.StartLoopGroup(0, 4);
                sprite3.MoveY(OsbEasing.InOutSine, 29612, 31612, spritePos3.Y, spritePos3.Y -= 200);
                sprite3.MoveY(OsbEasing.InOutSine, 31612, 33612, spritePos3.Y, spritePos3.Y += 200);
                sprite3.MoveX(OsbEasing.OutSine, 29612, 30612, spritePos3.X, spritePos3.X -= 100);
                sprite3.MoveX(OsbEasing.InOutSine, 30612, 32612, spritePos3.X, spritePos3.X += 200);
                sprite3.MoveX(OsbEasing.InSine, 32612, 33612, spritePos3.X, spritePos3.X -= 100);
                sprite3.EndGroup();

                sprite4.StartLoopGroup(0, 4);
                sprite4.MoveY(OsbEasing.InOutSine, 29612, 31612, spritePos4.Y, spritePos4.Y += 200);
                sprite4.MoveY(OsbEasing.InOutSine, 31612, 33612, spritePos4.Y, spritePos4.Y -= 200);
                sprite4.MoveX(OsbEasing.OutSine, 29612, 30612, spritePos4.X, spritePos4.X += 100);
                sprite4.MoveX(OsbEasing.InOutSine, 30612, 32612, spritePos4.X, spritePos4.X -= 200);
                sprite4.MoveX(OsbEasing.InSine, 32612, 33612, spritePos4.X, spritePos4.X += 100);
                sprite4.EndGroup();

                sprite3.Scale(OsbEasing.In, 42226, 42794, 0.04, 0);
                sprite4.Scale(OsbEasing.In, 42226, 42794, 0.04, 0);
                sprite3.Fade(42794, 42794, 0, 0);
                sprite4.Fade(42794, 42794, 0, 0);

                //POSTCHORUS
                crop.Scale(OsbEasing.OutExpo, 73249, 73704, (360.0 / 768)*1, 0.12);
                crop.Move(OsbEasing.OutExpo, 73249, 73704, 333, 240, 320, 240);
                crop.Fade(73249, 85976, 1, 1);
                crop.Scale(OsbEasing.In, 85522, 85976, 0.12, 0);

                var sprite5 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite5.Scale(OsbEasing.OutExpo, 73249, 73703, 0, 0.04);
                var spritePos5 = new Vector2(320, 340);
                sprite5.Scale(73703, 0.04);

                var sprite6 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite6.Scale(OsbEasing.OutExpo, 73249, 73703, 0, 0.04);
                var spritePos6 = new Vector2(320, 140);
                sprite6.Scale(73703, 0.04);

                sprite5.Fade(73249, 85976, 1, 1);
                sprite6.Fade(73249, 85976, 1, 1);

                sprite5.StartLoopGroup(0, 4);
                sprite5.MoveY(OsbEasing.InOutSine, 73249, 75249, spritePos3.Y, spritePos3.Y -= 200);
                sprite5.MoveY(OsbEasing.InOutSine, 75249, 77249, spritePos3.Y, spritePos3.Y += 200);
                sprite5.MoveX(OsbEasing.OutSine, 73249, 74249, spritePos3.X, spritePos3.X -= 100);
                sprite5.MoveX(OsbEasing.InOutSine, 74249, 76249, spritePos3.X, spritePos3.X += 200);
                sprite5.MoveX(OsbEasing.InSine, 76249, 77249, spritePos3.X, spritePos3.X -= 100);
                sprite5.EndGroup();

                sprite6.StartLoopGroup(0, 4);
                sprite6.MoveY(OsbEasing.InOutSine, 73249, 75249, spritePos4.Y, spritePos4.Y += 200);
                sprite6.MoveY(OsbEasing.InOutSine, 75249, 77249, spritePos4.Y, spritePos4.Y -= 200);
                sprite6.MoveX(OsbEasing.OutSine, 73249, 74249, spritePos4.X, spritePos4.X += 100);
                sprite6.MoveX(OsbEasing.InOutSine, 74249, 76249, spritePos4.X, spritePos4.X -= 200);
                sprite6.MoveX(OsbEasing.InSine, 76249, 77249, spritePos4.X, spritePos4.X += 100);
                sprite6.EndGroup();

                sprite5.Scale(OsbEasing.In, 85522, 85976, 0.04, 0);
                sprite6.Scale(OsbEasing.In, 85522, 85976, 0.04, 0);
                sprite5.Fade(85976, 85976, 0, 0);
                sprite6.Fade(85976, 85976, 0, 0);

                //POSTCHORUS2
                crop.Scale(OsbEasing.OutExpo, 103248, 103703, (360.0 / 768)*1, 0.12);
                crop.Move(OsbEasing.OutExpo, 103248, 103703, 333, 240, 320, 240);
                crop.Fade(103248, 114157, 1, 1);
                crop.Scale(OsbEasing.In, 113703, 114157, 0.12, 0);

                var sprite7 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite7.Scale(OsbEasing.OutExpo, 103248, 103703, 0, 0.04);
                var spritePos7 = new Vector2(320, 340);
                sprite7.Scale(103703, 0.04);

                var sprite8 = layer.CreateSprite("sb/c.png", OsbOrigin.Centre);
                sprite8.Scale(OsbEasing.OutExpo, 103248, 103703, 0, 0.04);
                var spritePos8 = new Vector2(320, 140);
                sprite8.Scale(103703, 0.04);

                sprite7.Fade(103248, 114157, 1, 1);
                sprite8.Fade(103248, 114157, 1, 1);

                sprite7.StartLoopGroup(0, 4);
                sprite7.MoveY(OsbEasing.InOutSine, 103248, 105248, spritePos7.Y, spritePos7.Y -= 200);
                sprite7.MoveY(OsbEasing.InOutSine, 105248, 107248, spritePos7.Y, spritePos7.Y += 200);
                sprite7.MoveX(OsbEasing.OutSine, 103248, 104248, spritePos7.X, spritePos7.X -= 100);
                sprite7.MoveX(OsbEasing.InOutSine, 104248, 106248, spritePos7.X, spritePos7.X += 200);
                sprite7.MoveX(OsbEasing.InSine, 106248, 107248, spritePos7.X, spritePos7.X -= 100);
                sprite7.EndGroup();

                sprite8.StartLoopGroup(0, 4);
                sprite8.MoveY(OsbEasing.InOutSine, 103248, 105248, spritePos4.Y, spritePos4.Y += 200);
                sprite8.MoveY(OsbEasing.InOutSine, 105248, 107248, spritePos4.Y, spritePos4.Y -= 200);
                sprite8.MoveX(OsbEasing.OutSine, 103248, 104248, spritePos4.X, spritePos4.X += 100);
                sprite8.MoveX(OsbEasing.InOutSine, 104248, 106248, spritePos4.X, spritePos4.X -= 200);
                sprite8.MoveX(OsbEasing.InSine, 106248, 107248, spritePos4.X, spritePos4.X += 100);
                sprite8.EndGroup();

                sprite7.Scale(OsbEasing.In, 113703, 114157, 0.04, 0);
                sprite8.Scale(OsbEasing.In, 113703, 114157, 0.04, 0);
                sprite7.Fade(114157, 114157, 0, 0);
                sprite8.Fade(114157, 114157, 0, 0);
                //ENDING
                crop.Scale(OsbEasing.OutExpo, 170521, 170975, (360.0 / 768)*1, 0.12);
                crop.Move(OsbEasing.OutExpo, 170521, 170975, 333, 240, 320, 240);
                crop.Fade(170521, 171657, 1, 1);
                crop.Scale(OsbEasing.InExpo, 171203, 171657, 0.12, 0);
        }


        public void sinewaver(OsbSprite wave, int startTime, int endTime){
            var layer = GetLayer("Main");
            OsbSprite wave2 = layer.CreateSprite("sb/sinewave.png", OsbOrigin.Centre);
            wave.Scale(startTime, 0.75);
            wave2.Scale(startTime, 0.75);
            wave.Fade(startTime, startTime, 0.5, 0.5);
            wave2.Fade(startTime, startTime, 0.5, 0.5);
            for (int i = startTime; i <= endTime - 200; i+= 1000){
                wave.Move(i, i+1000, -130, 240, 190, 240);
                wave2.Move(i, i+1000, 510, 240, 830, 240);
            }
            wave.Fade(endTime, endTime, 0, 0);
            wave2.Fade(endTime, endTime, 0, 0);

            if (endTime > 173703){
                wave.Fade(173248, 174157, 0.5, 0);
                wave2.Fade(173248, 174157, 0.5, 0);
            }
        }
    }
}
