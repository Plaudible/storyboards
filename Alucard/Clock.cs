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
    public class Clock : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var center = layer.CreateSprite("sb/clock/crest.png", OsbOrigin.Centre);
            var hand1 = layer.CreateSprite("sb/clock/m1.png", OsbOrigin.BottomCentre);
            var hand2 = layer.CreateSprite("sb/clock/m2.png",OsbOrigin.BottomCentre);
            var nob = layer.CreateSprite("sb/glow.png",OsbOrigin.Centre);
            
            center.Fade(23230, 36471, 0, 0.75);
            center.Fade(36471, 122564, 0.75, 0.75);
            center.Move(33161, 40, 130);
            center.Scale(33161, 0.5);

            hand1.Fade(23230, 36471, 0, 0.75);
            hand1.Fade(36471, 122564, 0.75, 0.75);
            hand1.Move(33161, 40, 130);
            hand1.Scale(33161, 0.25);

            hand2.Fade(23230, 36471, 0, 0.75);
            hand2.Fade(36471, 122564, 0.75, 0.75);
            hand2.Move(33161, 40, 130);
            hand2.Scale(33161, 0.25);
            hand2.Fade(122564, 122564, 0, 0);

            nob.Fade(23230, 36471, 0, 1);
            nob.Fade(36471, 122564 , 1, 1);
            nob.Move(33161, 40, 130);
            nob.Scale(33161, 0.6);

            tick(23230, 122564, hand1);
            tock(23230, 122564, hand2);

            var ring1 = layer.CreateSprite("sb/clock/a1.png", OsbOrigin.Centre);

            ring1.Fade(23230, 36471, 0, 0.5);
            ring1.Fade(36471, 122564, 0.5, 0.5);
            ring1.Move(33161, 40, 130);
            ring1.Scale(33161, 0.75);
            ring1.Rotate(23230, 122564, 0, 10);

            center.Move(OsbEasing.InOutExpo, 111231, 112064, 40, 130, 320, 240);
            hand1.Move(OsbEasing.InOutExpo, 111231, 112064, 40, 130, 320, 240);
            hand2.Move(OsbEasing.InOutExpo, 111231, 112064, 40, 130, 320, 240);
            nob.Move(OsbEasing.InOutExpo, 111231, 112064, 40, 130, 320, 240);
            ring1.Move(OsbEasing.InOutExpo, 111231, 112064, 40, 130, 322, 240);

            center.Scale(OsbEasing.Out, 111898, 112564, 0.5, 0);
            hand1.Scale(OsbEasing.Out, 111898, 112564, 0.25, 0);
            hand2.Scale(OsbEasing.Out, 111898, 112564, 0.25, 0);
            nob.Scale(OsbEasing.Out, 111898, 112564, 0.6, 0);
            ring1.Scale(OsbEasing.Out, 111898, 112564, 0.75, 0);
        }

        public void tick(int startTime, int endTime, OsbSprite hand1){
            double rotation = 0;
                for(int i = startTime; i <= 79814; i += 414){
                    hand1.Rotate(i, i+20, rotation, (Math.PI / 180) * 6 + rotation);
                    rotation += (Math.PI / 180) * 6;
                }
                for(int i = 79814; i <= endTime; i += 334){
                    hand1.Rotate(i, i+20, rotation, (Math.PI / 180) * 6 + rotation);
                    rotation += (Math.PI / 180) * 6;
                }
        }
        public void tock(int startTime, int endTime, OsbSprite hand2){
            double rotation = 0;
                for(int i = startTime; i <= endTime; i += 24840){
                    hand2.Rotate(i, i+24840, rotation, (Math.PI / 180) * 30 + rotation);
                    rotation += (Math.PI / 180) * 30;
                }
        }
    }
}
