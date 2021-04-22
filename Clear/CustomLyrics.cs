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
            var words = layer.CreateSprite("sb/f/_000.png", OsbOrigin.Centre);
            var fall = layer.CreateSprite("sb/f/_001.png", OsbOrigin.Centre);
            var outo = layer.CreateSprite("sb/f/_002.png", OsbOrigin.Centre);
            var of = layer.CreateSprite("sb/f/_003.png", OsbOrigin.Centre);
            var my = layer.CreateSprite("sb/f/_004.png", OsbOrigin.Centre);
            var mouth = layer.CreateSprite("sb/f/_005.png", OsbOrigin.Centre);

            words.Scale(OsbEasing.OutExpo, 9797, 10092, 0, 0.5);
            words.Fade(9797,10680, 1, 1);
            words.Move(OsbEasing.OutExpo, 10092,10386,320,240, 240, 240);
            words.Move(OsbEasing.InExpo, 10386, 10680, 240, 240, 240, 0);
            words.Color(9797, 0.95, 0.77, 0.85);

            fall.Fade(10092, 11856, 1, 1);
            fall.Scale(OsbEasing.OutExpo, 10092, 10239, 0, 0.5);
            fall.Move(10092, 380, 240);
            fall.Move(OsbEasing.InExpo, 10092, 10680, 380, 240, 380, 360);
            fall.Rotate(OsbEasing.In, 10092, 10680, 0, 0.2);
            fall.Scale(OsbEasing.InExpo, 10239, 10680, 0.5, 1.5);
            fall.Move(OsbEasing.OutExpo, 10680, 10974, 380, 360, 380, 370);

            outo.Fade(10680, 11856, 1, 1);
            outo.Rotate(10680, -1.3708);
            outo.Scale(OsbEasing.OutExpo, 10680, 10974, 0, 0.5);
            outo.Move(10680, 545, 406);

            of.Fade(10876, 11856, 1, 1);
            of.Rotate(10876, -1.3708);
            of.Scale(OsbEasing.OutExpo, 10876, 11072, 0, 0.5);
            of.Move(10876, 562, 325);

            my.Fade(11072, 14209, 1, 1);
            my.Rotate(11072, -1.3708);
            my.Scale(OsbEasing.OutExpo, 11072, 11464, 0, 0.5);
            my.Move(11072, 576, 252);

            mouth.Fade(11268, 14209, 1, 1);
            mouth.Rotate(11268, -1.3708);
            mouth.Scale(OsbEasing.OutExpo, 11268, 11464, 0, 0.5);
            mouth.Move(11268, 598, 138);
            mouth.Color(11268, 0.95, 0.77, 0.85);

            mouth.Move(OsbEasing.InOutExpo, 11562,12297, 598, 138, 320, 240);
            mouth.Scale(OsbEasing.InOutExpo, 11562,12297, 0.5, 1);
            my.Move(OsbEasing.InOutExpo, 11562,12297, 576, 252, 275, 460);
            my.Scale(OsbEasing.InOutExpo, 11562,12297, 0.5, 1);
            of.Move(OsbEasing.InOutExpo, 11562,12297, 563, 325, 250, 580);
            of.Scale(OsbEasing.InOutExpo, 11562,12297, 0.5, 1);
            outo.Move(OsbEasing.InOutExpo, 11562,12297, 545, 406, 225, 700);
            outo.Scale(OsbEasing.InOutExpo, 11562,12297, 0.5, 1);
            fall.Move(OsbEasing.InOutExpo, 11562,12297, 380, 370, -40, 720);
            fall.Scale(OsbEasing.InOutExpo, 11562,12297, 1.5, 2);

            var they = layer.CreateSprite("sb/f/_006.png", OsbOrigin.Centre);
            var drift = layer.CreateSprite("sb/f/_007.png", OsbOrigin.Centre);
            var to = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);
            var the = layer.CreateSprite("sb/f/_009.png", OsbOrigin.Centre);
            var ground = layer.CreateSprite("sb/f/_00a.png", OsbOrigin.Centre);
            var and = layer.CreateSprite("sb/f/_00b.png", OsbOrigin.Centre);
            var dont = layer.CreateSprite("sb/f/_00c.png", OsbOrigin.Centre);
            var make = layer.CreateSprite("sb/f/_00d.png", OsbOrigin.Centre);
            var a = layer.CreateSprite("sb/f/0061.png", OsbOrigin.Centre);
            var sound = layer.CreateSprite("sb/f/_00e.png", OsbOrigin.Centre);

            they.Fade(11562, 14209, 1, 1);
            they.Scale(OsbEasing.InOutExpo, 11562,12297, 0, 0.5);
            they.Rotate(11562, 0.2);
            they.Move(OsbEasing.InOutExpo, 11562,12297, 650, 90, 440, 135);

            drift.Fade(11856, 14209, 1, 1);
            drift.Move(OsbEasing.OutExpo, 11856, 12444, 800, 224, 436, 182);
            drift.Rotate(11856, 0.2);
            drift.Scale(OsbEasing.OutExpo, 11856, 12150, 0, 0.5);
            drift.Color(11856, 0.95, 0.77, 0.85);

            to.Fade(12150, 14209, 1, 1);
            to.Move(12150, 398, 226);
            to.Rotate(12150, 0.2);
            to.Scale(OsbEasing.OutExpo, 12150, 12444, 0, 0.5);

            the.Fade(12297, 14209, 1, 1);
            the.Move(12297, 396, 276);
            the.Rotate(12297, 0.2);
            the.Scale(OsbEasing.OutExpo, 12297, 12592, 0, 0.5);

            ground.Fade(12444, 14209, 1, 1);
            ground.Move(12444, 432, 332);
            ground.Rotate(12444, 0.2);
            ground.Scale(OsbEasing.OutExpo, 12444, 12739, 0, 0.5);
            ground.Color(12444, 0.95, 0.77, 0.85);

            drift.Scale(OsbEasing.InExpo, 12739, 13033, 0.5, 0);
            to.Scale(OsbEasing.InExpo, 12739, 13033, 0.5, 0);
            the.Scale(OsbEasing.InExpo, 12739, 13033, 0.5, 0);
            ground.Scale(OsbEasing.InExpo, 12739, 13033, 0.5, 0);

            and.Fade(12739, 14209, 1, 1);
            and.Move(12739, 440, 85);
            and.Rotate(12739, 0.2);
            and.Scale(OsbEasing.OutExpo, 12739, 13033, 0, 0.5);

            dont.Fade(13033, 14209, 1, 1);
            dont.Move(13033, 443, 185);
            dont.Rotate(13033, 0.2);
            dont.Scale(OsbEasing.OutExpo, 13033, 13327, 0, 0.5);
            dont.Color(13033, 0.95, 0.77, 0.85);

            make.Fade(13327, 14209, 1, 1);
            make.Move(13327, 428, 232);
            make.Rotate(13327, 0.2);
            make.Scale(OsbEasing.OutExpo, 13327, 13621, 0, 0.5);

            a.Fade(13474, 14209, 1, 1);
            a.Move(13474, 374, 272);
            a.Rotate(13474, 0.2);
            a.Scale(OsbEasing.OutExpo, 13474, 13768, 0, 0.5);  

            sound.Fade(13621, 14209, 1, 1);
            sound.Move(13621, 420, 334);
            sound.Rotate(13621, 0.2);
            sound.Scale(OsbEasing.OutExpo, 13621, 13915, 0, 0.5);
            sound.Color(13621, 0.95, 0.77, 0.85);

            mouth.Scale(OsbEasing.InExpo, 13915, 14356, 1, 50);
            mouth.Move(OsbEasing.InExpo, 13915, 14356, 320, 240, 320, 800);
            mouth.Fade(14209, 14356, 1, 0);

            my.Scale(OsbEasing.In, 13915, 14503, 1, 3);
            my.Move(OsbEasing.In, 13915, 14203, 275, 460, 250, 800);

            make.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            make.Move(OsbEasing.InExpo, 13915, 14356, 428, 232, 5000, 900);

            a.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            a.Move(OsbEasing.InExpo, 13915, 14356, 374, 272, 3600, 2400);

            sound.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            sound.Move(OsbEasing.InExpo, 13915, 14356, 420, 334, 5600, 4600);

            dont.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            dont.Move(OsbEasing.InExpo, 13915, 14356, 443, 185, 6000, -1000);

            they.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            they.Move(OsbEasing.InExpo, 13915, 14356, 440, 135, 6000, -3000);

            and.Scale(OsbEasing.InExpo, 13915, 14356, 0.5, 20);
            and.Move(OsbEasing.InExpo, 13915, 14356, 440, 85, 6000, -5000);

            make.Fade(14246, 14246, 0, 0);
            a.Fade(14246, 14246, 0, 0);
            sound.Fade(14246, 14246, 0, 0);
            dont.Fade(14246, 14246, 0, 0);
            they.Fade(14246, 14246, 0, 0);
            and.Fade(14246, 14246, 0, 0);

            var ill = layer.CreateSprite("sb/f/_00f.png", OsbOrigin.Centre);
            var ttry = layer.CreateSprite("sb/f/_010.png", OsbOrigin.Centre);
            var to2 = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);
            var assemble = layer.CreateSprite("sb/f/_011.png", OsbOrigin.Centre);
            var gear = layer.CreateSprite("sb/gear.png", OsbOrigin.Centre);
            var them = layer.CreateSprite("sb/f/_012.png", OsbOrigin.Centre);
            var back = layer.CreateSprite("sb/f/_013.png", OsbOrigin.Centre);
            var a2 = layer.CreateSprite("sb/f/_0061.png", OsbOrigin.Centre);
            var place = layer.CreateSprite("sb/f/_014.png", OsbOrigin.Centre);

            ill.Fade(14503, 18621, 1, 1);
            ill.Scale(OsbEasing.OutExpo, 14503, 14797, 0, 0.5);
            ill.Rotate(14503, -0.2);
            ill.Move(14503, 120, 200);

            ttry.Fade(14797, 18621, 1, 1);
            ttry.Scale(OsbEasing.OutExpo, 14797, 15092, 0, 0.5);
            ttry.Rotate(14797, -0.2);
            ttry.Move(14797, 205, 184);

            ill.Rotate(OsbEasing.InOutExpo, 14944, 15533, -0.2, -1.7707971);
            ttry.Rotate(OsbEasing.InOutExpo, 14944, 15533, -0.2, -1.7707971);
            ill.Move(OsbEasing.InOutExpo, 14944, 15533, 120, 200, 80, 340);
            ttry.Move(OsbEasing.InOutExpo, 14944, 15533, 205, 184, 50, 180);
            ill.Scale(OsbEasing.InOutExpo, 15092, 15533, 0.5, 1);
            ttry.Scale(OsbEasing.InOutExpo, 15092, 15533, 0.5, 1);

            to2.Fade(15239, 18621, 1, 1);
            to2.Rotate(15239, -0.2);
            to2.Scale(OsbEasing.OutExpo, 15239, 15533, 0, 0.5);
            to2.Move(15239, 165, 375);

            assemble.Fade(15386, 18621, 1, 1);
            assemble.Rotate(15386, -0.2);
            assemble.Scale(OsbEasing.OutExpo, 15386, 15680, 0, 0.5);
            assemble.Move(15386, 223, 315);
            assemble.Color(15386, 0.95, 0.77, 0.85);
            gear.Fade(15386, 18621, 1, 1);
            gear.Rotate(15386, 18621, -0.2, 3);
            gear.Scale(OsbEasing.OutExpo, 15386, 15680, 0, 0.075);
            gear.Move(15386, 345, 291);

            them.Fade(15827, 18621, 1, 1);
            them.Rotate(15827, -0.2);
            them.Scale(OsbEasing.OutExpo, 15827, 16121, 0, 0.5);
            them.Move(15827, 168, 275);

            back.Fade(15974, 18621, 1, 1);
            back.Rotate(15974, -0.2);
            back.Scale(OsbEasing.OutExpo, 15974, 16268, 0, 0.5);
            back.Move(15974, 160, 222);

            the.Fade(16415, 18621, 1, 1);
            the.Rotate(16415, -0.2);
            the.Scale(OsbEasing.OutExpo, 16415, 16709, 0, 0.5);
            the.Move(15974, 245, 358);

            place.Fade(16562, 18621, 1, 1);
            place.Rotate(16562, -0.2);
            place.Scale(OsbEasing.OutExpo, 16562, 16856, 0, 0.5);
            place.Move(16562, 365, 333);
            place.Color(16562, 0.95, 0.77, 0.85);

            var inn = layer.CreateSprite("sb/f/_015.png", OsbOrigin.Centre);
            var my2 = layer.CreateSprite("sb/f/_004.png", OsbOrigin.Centre);
            var head = layer.CreateSprite("sb/f/_016.png", OsbOrigin.Centre);
            var but = layer.CreateSprite("sb/f/_017.png", OsbOrigin.Centre);
            var i = layer.CreateSprite("sb/f/0069.png", OsbOrigin.Centre);
            var feel = layer.CreateSprite("sb/f/_018.png", OsbOrigin.Centre);
            var that = layer.CreateSprite("sb/f/_019.png", OsbOrigin.Centre);
            var lack = layer.CreateSprite("sb/f/_01a.png", OsbOrigin.Centre);

            inn.Fade(16856, 18621, 1, 1);
            inn.Rotate(16856, -0.2);
            inn.Scale(OsbEasing.OutExpo, 16856, 17150, 0, 0.5);
            inn.Move(16856, 167, 425);

            my2.Fade(17003, 18621, 1, 1);
            my2.Rotate(17003, -0.2);
            my2.Scale(OsbEasing.OutExpo, 17003, 17150, 0, 0.5);
            my2.Move(17003, 235, 412);

            head.Fade(17150, 18621, 1, 1);
            head.Rotate(17150, -0.2);
            head.Scale(OsbEasing.OutExpo, 17150, 17444, 0, 0.5);
            head.Move(17150, 330, 392);
            head.Color(17150, 0.95, 0.77, 0.85);

            but.Fade(17444, 18621, 1, 1);
            but.Rotate(17444, 0.2);
            but.Scale(OsbEasing.OutExpo, 17444, 17739, 0, 0.5);
            but.Move(17444, 440, 160);

            i.Fade(17591, 18621, 1, 1);
            i.Rotate(17591, 0.2);
            i.Scale(OsbEasing.OutExpo, 17591, 17886, 0, 0.5);
            i.Move(17591, 498, 172);

            feel.Fade(17739, 18621, 1, 1);
            feel.Rotate(17739, 0.2);
            feel.Scale(OsbEasing.OutExpo, 17739, 18033, 0, 0.5);
            feel.Move(17739, 572, 187);
            feel.Color(17739, 0.95, 0.77, 0.85);

            that.Fade(18033, 18621, 1, 1);
            that.Rotate(18033, 0.2);
            that.Scale(OsbEasing.OutExpo, 18033, 18327, 0, 0.5);
            that.Move(18033, 552, 134);

            lack.Fade(18327, 18621, 1, 1);
            lack.Rotate(18327, 0.2);
            lack.Scale(OsbEasing.OutExpo, 18327, 18621, 0, 0.5);
            lack.Move(18327, 537, 227);
            lack.Color(18327, 0.95, 0.77, 0.85);

            ill.Fade(18621, 18915, 1, 0);
            ttry.Fade(18621, 18915, 1, 0);
            to2.Fade(18621, 18915, 1, 0);
            assemble.Fade(18621, 18915, 1, 0);
            them.Fade(18621, 18915, 1, 0);
            back.Fade(18621, 18915, 1, 0);
            gear.Fade(18621, 18915, 1, 0);
            the.Fade(18621, 18915, 1, 0);
            place.Fade(18621, 18915, 1, 0);
            inn.Fade(18621, 18915, 1, 0);
            my2.Fade(18621, 18915, 1, 0);
            head.Fade(18621, 18915, 1, 0);
            but.Fade(18621, 18915, 1, 0);
            i.Fade(18621, 18915, 1, 0);
            feel.Fade(18621, 18915, 1, 0);
            that.Fade(18621, 18915, 1, 0);
            lack.Fade(18621, 18915, 1, 0);

            var the2 = layer.CreateSprite("sb/f/_009.png", OsbOrigin.Centre);
            var proper = layer.CreateSprite("sb/f/_01b.png", OsbOrigin.Centre);
            var speak = layer.CreateSprite("sb/f/_01c.png", OsbOrigin.Centre);
            var that2 = layer.CreateSprite("sb/f/_019.png", OsbOrigin.Centre);
            var i2 = layer.CreateSprite("sb/f/0069.png", OsbOrigin.Centre);
            var need = layer.CreateSprite("sb/f/_01d.png", OsbOrigin.Centre);

            the2.Fade(19209, 21268, 1, 1);
            the2.Scale(OsbEasing.OutExpo, 19209, 19503, 0, 0.5);
            the2.Move(19209, 320, 240);
            the2.Color(19209, 0.95, 0.77, 0.85);

            the2.Rotate(OsbEasing.OutExpo, 19503, 19797, 0, -1.5707963);
            the2.Scale(OsbEasing.OutExpo, 19503, 19797, 0.5, 1);
            the2.Move(OsbEasing.OutExpo, 19503, 19797, 320, 240, 200, 240);
            proper.Fade(19503, 21268, 1, 1);
            proper.Scale(OsbEasing.OutExpo, 19503, 19797, 0, 0.5);
            proper.Move(19503, 320, 240);

            the2.Rotate(OsbEasing.OutExpo, 20091, 20386, -1.5707963, -1.5707963 * 2);
            the2.Scale(OsbEasing.OutExpo, 20091, 20386, 1, 2);
            the2.Move(OsbEasing.OutExpo, 20091, 20386, 200, 240, 200, 470);
            proper.Rotate(OsbEasing.OutExpo, 20091, 20386, 0, -1.5707963);
            proper.Scale(OsbEasing.OutExpo, 20091, 20386, 0.5, 1);
            proper.Move(OsbEasing.OutExpo, 20091, 20386, 320, 240, 200, 240);

            speak.Fade(20091, 21268, 1, 1);
            speak.Scale(OsbEasing.OutExpo, 20091, 20386, 0, 0.5);
            speak.Move(20091, 320, 240);
            speak.Color(20091, 0.95, 0.77, 0.85);

            that2.Fade(20288, 21268, 1, 1);
            that2.Scale(OsbEasing.OutExpo, 20288, 20680, 0, 0.5);
            that2.Move(20288, 450, 240);

            i2.Fade(20484, 21268, 1, 1);
            i2.Scale(OsbEasing.OutExpo, 20484, 20876, 0, 0.5);
            i2.Move(20484, 524, 240);

            need.Fade(20680, 21268, 1, 1);
            need.Scale(OsbEasing.OutExpo, 20680, 20974, 0, 0.5);
            need.Move(20680, 595, 240);

            the2.Move(OsbEasing.InExpo, 20974, 21268, 200, 470, 200, -630);
            proper.Move(OsbEasing.InExpo, 20974, 21268, 200, 240, 200, -760);
            speak.Move(OsbEasing.InExpo, 20974, 21268, 320, 240, 320, -760);
            that2.Move(OsbEasing.InExpo, 20974, 21268, 450, 240, 450, -760);
            i2.Move(OsbEasing.InExpo, 20974, 21268, 524, 240, 524, -760);
            need.Move(OsbEasing.InExpo, 20974, 21268, 595, 240, 595, -760);

            var to3 = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);
            var narrate = layer.CreateSprite("sb/f/_01e.png", OsbOrigin.Centre);
            var the3 = layer.CreateSprite("sb/f/_009.png", OsbOrigin.Centre);
            var scene = layer.CreateSprite("sb/f/_01f.png", OsbOrigin.Centre);
            var tell = layer.CreateSprite("sb/f/_020.png", OsbOrigin.Centre);
            var you = layer.CreateSprite("sb/f/_021.png", OsbOrigin.Centre);
            var these = layer.CreateSprite("sb/f/_022.png", OsbOrigin.Centre);
            var things = layer.CreateSprite("sb/f/_023.png", OsbOrigin.Centre);

            to3.Fade(21121, 23621, 1, 1);
            to3.Scale(OsbEasing.OutExpo, 21121, 21415, 0, 0.5);
            to3.Move(OsbEasing.OutExpo, 21121, 21562, 120, 1240, 120, 240);

            narrate.Fade(OsbEasing.Out, 21268, 21562, 0, 1);
            narrate.Fade(21562, 22003, 1, 1);
            narrate.Fade(OsbEasing.In, 22003, 22297, 1, 0);
            narrate.Scale(21268, 0.5);
            narrate.Move(OsbEasing.OutExpo, 21268, 21562, 260, 200, 260, 240);
            narrate.Move(OsbEasing.InExpo, 22003, 22297, 260, 240, 260, 280);
            narrate.Color(21268, 0.95, 0.77, 0.85);

            the3.Fade(OsbEasing.Out, 21268, 21562, 0, 1);
            the3.Fade(21562, 22003, 1, 1);
            the3.Fade(OsbEasing.In, 22003, 22297, 1, 0);
            the3.Scale(21268, 0.5);
            the3.Move(OsbEasing.OutExpo, 21268, 21562, 410, 200, 410, 240);
            the3.Move(OsbEasing.InExpo, 22003, 22297, 410, 240, 410, 280);

            scene.Fade(OsbEasing.Out, 21268, 21562, 0, 1);
            scene.Fade(21562, 22003, 1, 1);
            scene.Fade(OsbEasing.In, 22003, 22297, 1, 0);
            scene.Scale(21268, 0.5);
            scene.Move(OsbEasing.OutExpo, 21268, 21562, 533, 200, 533, 240); 
            scene.Move(OsbEasing.InExpo, 22003, 22297, 533, 240, 533, 280);
            scene.Color(21268, 0.95, 0.77, 0.85);

            tell.Fade(OsbEasing.Out, 22297, 22591, 0, 1);
            tell.Fade(22591, 23327, 1, 1);
            tell.Fade(OsbEasing.In, 23327, 23621, 1, 0);
            tell.Scale(22297, 0.5);
            tell.Move(OsbEasing.OutExpo, 22297, 22591, 210, 200, 210, 240);
            tell.Move(OsbEasing.InExpo, 23327, 23621, 210, 240, 210, 280);
            tell.Color(22297, 0.95, 0.77, 0.85);

            you.Fade(OsbEasing.Out, 22297, 22591, 0, 1);
            you.Fade(22591, 23327, 1, 1);
            you.Fade(OsbEasing.In, 23327, 23621, 1, 0);
            you.Scale(22297, 0.5);
            you.Move(OsbEasing.OutExpo, 22297, 22591, 315, 200, 315, 240);
            you.Move(OsbEasing.InExpo, 23327, 23621, 315, 240, 315, 280);

            these.Fade(OsbEasing.Out, 22297, 22591, 0, 1);
            these.Fade(22591, 23327, 1, 1);
            these.Fade(OsbEasing.In, 23327, 23621, 1, 0);
            these.Scale(22297, 0.5);
            these.Move(OsbEasing.OutExpo, 22297, 22591, 435, 200, 435, 240);
            these.Move(OsbEasing.InExpo, 23327, 23621, 435, 240, 435, 280);

            things.Fade(OsbEasing.Out, 22297, 22591, 0, 1);
            things.Fade(22591, 23327, 1, 1);
            things.Fade(OsbEasing.In, 23327, 23621, 1, 0);
            things.Scale(22297, 0.5);
            things.Move(OsbEasing.OutExpo, 22297, 22591, 585, 200, 585, 240);
            things.Move(OsbEasing.InExpo, 23327, 23621, 585, 240, 585, 280);
            things.Color(22297, 0.95, 0.77, 0.85);

            to3.Scale(OsbEasing.InExpo, 23327, 23621, 0.5, 0);

            var the4 = layer.CreateSprite("sb/f/_009.png", OsbOrigin.Centre);
            var proper2 = layer.CreateSprite("sb/f/_01b.png", OsbOrigin.Centre);
            var place2 = layer.CreateSprite("sb/f/_014.png", OsbOrigin.Centre);
            var forr = layer.CreateSprite("sb/f/_024.png", OsbOrigin.Centre);
            var my3 = layer.CreateSprite("sb/f/_004.png", OsbOrigin.Centre);
            var thoughts = layer.CreateSprite("sb/f/_025.png", OsbOrigin.Centre);

            the4.Fade(23915, 25974, 1, 1);
            the4.Scale(OsbEasing.OutExpo, 23915, 24209, 0, 0.5);
            the4.Rotate(23915, -0.2);
            the4.Color(23915, 0.95, 0.77, 0.85);
            the4.Move(23915, 200, 180);

            the4.Scale(OsbEasing.OutExpo, 24209, 24503, 0.5, 1);
            the4.Move(OsbEasing.OutExpo, 24209, 24503, 200, 180, 180, 120);
            proper2.Fade(24209, 25974, 1, 1);
            proper2.Scale(OsbEasing.OutExpo, 24209, 24503, 0, 0.5);
            proper2.Move(24209, 200, 180);
            proper2.Rotate(23915, -0.2);

            the4.Scale(OsbEasing.OutExpo, 24797, 25091, 1, 2);
            the4.Move(OsbEasing.OutExpo, 24797, 25091, 180, 120, 150, 0);
            proper2.Scale(OsbEasing.OutExpo, 24797, 25091, 0.5, 1);
            proper2.Move(OsbEasing.OutExpo, 24797, 25091, 200, 180, 180, 120);

            place.Fade(24797, 25974, 1, 1);
            place.Scale(OsbEasing.OutExpo, 24797, 25091, 0, 0.5);
            place.Rotate(24797, -0.2);
            place.Color(24797, 0.95, 0.77, 0.85);
            place.Move(24797, 200, 180);

            forr.Fade(24993, 25974, 1, 1);
            forr.Scale(OsbEasing.OutExpo, 24993, 25386, 0, 0.5);
            forr.Rotate(24993, -0.2);
            forr.Move(24993, 322, 156);

            my3.Fade(25190, 25974, 1, 1);
            my3.Scale(OsbEasing.OutExpo, 25190, 25582, 0, 0.5);
            my3.Rotate(25190, -0.2);
            my3.Move(25190, 408, 140);
            
            thoughts.Fade(25386, 25974, 1, 1);
            thoughts.Scale(OsbEasing.OutExpo, 25386, 25680, 0, 0.5);
            thoughts.Rotate(25386, -0.2);
            thoughts.Move(25386, 560, 109);
            thoughts.Color(25386, 0.95, 0.77, 0.85);

            the4.Move(OsbEasing.InExpo, 25680, 26121, 150, 0, 400, 1000);
            proper2.Move(OsbEasing.InExpo, 25680, 26121, 180, 120, 430, 1120);
            place.Move(OsbEasing.InExpo, 25680, 26121, 200, 180, 450, 1180);
            forr.Move(OsbEasing.InExpo, 25680, 26121, 322, 156, 322 + 250, 1156);
            my3.Move(OsbEasing.InExpo, 25680, 26121, 408, 140, 408 + 250, 1140);
            thoughts.Move(OsbEasing.InExpo, 25680, 26121, 560, 109, 560 + 250, 1109);

            var i3 = layer.CreateSprite("sb/f/0069.png", OsbOrigin.Centre);
            var know = layer.CreateSprite("sb/f/_026.png", OsbOrigin.Centre);
            var that3 = layer.CreateSprite("sb/f/_019.png", OsbOrigin.Centre);
            var im = layer.CreateSprite("sb/f/_027.png", OsbOrigin.Centre);
            var not = layer.CreateSprite("sb/f/_028.png", OsbOrigin.Centre);

            var you2 = layer.CreateSprite("sb/f/_021.png", OsbOrigin.Centre);
            var know2 = layer.CreateSprite("sb/f/_026.png", OsbOrigin.Centre);
            var that4 = layer.CreateSprite("sb/f/_019.png", OsbOrigin.Centre);
            var im2 = layer.CreateSprite("sb/f/_027.png", OsbOrigin.Centre);
            var not2 = layer.CreateSprite("sb/f/_028.png", OsbOrigin.Centre);

            i3.Fade(25827, 28327, 1, 1);
            i3.Scale(OsbEasing.OutExpo, 25827, 26121, 0, 0.5);
            i3.Rotate(25827, 0.2);
            i3.Move(25827, 340, 80);

            know.Fade(25974, 28327, 1, 1);
            know.Scale(OsbEasing.OutExpo, 25974, 26268, 0, 0.5);
            know.Rotate(25974, 0.2);
            know.Move(25974, 425, 97);
            know.Color(25974, 0.95, 0.77, 0.85);

            that3.Fade(26268, 28327, 1, 1);
            that3.Scale(OsbEasing.OutExpo, 26268, 26562, 0, 0.5);
            that3.Rotate(26268, 0.2);
            that3.Move(26268, 555, 124);

            im.Fade(26415, 28327, 1, 1);
            im.Scale(OsbEasing.OutExpo, 26415, 26709, 0, 0.5);
            im.Rotate(26415, 0.2);
            im.Move(26415, 352, 130);

            not.Fade(26562, 28327, 1, 1);
            not.Scale(OsbEasing.OutExpo, 26562, 26856, 0, 0.5);
            not.Rotate(26562, 0.2);
            not.Move(26562, 440, 148);

            i3.Move(OsbEasing.InOutExpo, 26856, 27444, 340, 80, 0, 120);
            i3.Rotate(OsbEasing.InOutExpo, 26856, 27444, 0.2, -0.2);
            i3.Scale(OsbEasing.InOutExpo, 26856, 27444, 0.5, 1);

            know.Move(OsbEasing.InOutExpo, 26856, 27444, 425, 97, 180, 83);
            know.Rotate(OsbEasing.InOutExpo, 26856, 27444, 0.2, -0.2);
            know.Scale(OsbEasing.InOutExpo, 26856, 27444, 0.5, 1);

            that3.Move(OsbEasing.InOutExpo, 26856, 27444, 555, 124, 450, 28);
            that3.Rotate(OsbEasing.InOutExpo, 26856, 27444, 0.2, -0.2);
            that3.Scale(OsbEasing.InOutExpo, 26856, 27444, 0.5, 1);

            im.Move(OsbEasing.InOutExpo, 26856, 27444, 352, 130, 62, 205);
            im.Rotate(OsbEasing.InOutExpo, 26856, 27444, 0.2, -0.2);
            im.Scale(OsbEasing.InOutExpo, 26856, 27444, 0.5, 1);

            not.Move(OsbEasing.InOutExpo, 26856, 27444, 440, 148, 235, 168);
            not.Rotate(OsbEasing.InOutExpo, 26856, 27444, 0.2, -0.2);
            not.Scale(OsbEasing.InOutExpo, 26856, 27444, 0.5, 1);

            you2.Fade(26856, 28327, 1, 1);
            you2.Scale(OsbEasing.OutExpo, 27003, 27297, 0, 0.5);
            you2.Rotate(OsbEasing.InOutExpo, 27003,  27444, 1.5707971, 1.370795557);
            you2.Move(OsbEasing.InOutExpo, 26856, 27444, 500, 180, 400, 150);
            
            know2.Fade(27150, 28327, 1, 1);
            know2.Scale(OsbEasing.OutExpo, 27150, 27444, 0, 0.5);
            know2.Rotate(27150, 1.370795557);
            know2.Move(27150, 428, 273);
            know2.Color(27150, 0.95, 0.77, 0.85);

            that4.Fade(27346, 28327, 1, 1);
            that4.Scale(OsbEasing.OutExpo, 27346, 27739, 0, 0.5);
            that4.Rotate(27346, 1.370795557);
            that4.Move(27346, 455, 405);

            im2.Fade(27542, 28327, 1, 1);
            im2.Scale(OsbEasing.OutExpo, 27542, 27935, 0, 0.5);
            im2.Rotate(27542, 1.370795557);
            im2.Move(27542, 347, 145);

            not2.Fade(27886, 28327, 1, 1);
            not2.Scale(OsbEasing.OutExpo, 27886, 28180, 0, 0.5);
            not2.Rotate(27886, 1.370795557);
            not2.Move(27886, 365, 232);

            //BREAKDOWN
            //=================================================
            var hard = layer.CreateSprite("sb/f/_029.png", OsbOrigin.Centre);
            var to4 = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);
            var read = layer.CreateSprite("sb/f/_02a.png", OsbOrigin.Centre);
            var and2 = layer.CreateSprite("sb/f/_00b.png", OsbOrigin.Centre);
            var hard2 = layer.CreateSprite("sb/f/_029.png", OsbOrigin.Centre);
            var to5 = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);
            var speak2 = layer.CreateSprite("sb/f/_01c.png", OsbOrigin.Centre);
            var to6 = layer.CreateSprite("sb/f/_008.png", OsbOrigin.Centre);

            hard.Fade(28327, 31268, 1, 1);
            hard.Scale(OsbEasing.OutExpo, 28327, 28621, 0, 0.5);
            hard.Rotate(28327, -0.2);
            hard.Move(28327, 175, 125);

            to4.Fade(28768, 31268, 1, 1);
            to4.Scale(OsbEasing.OutExpo,28768, 29062, 0, 0.5);
            to4.Rotate(28768, -0.2);
            to4.Move(28768, 160, 175);

            read.Fade(28915, 31268, 1, 1);
            read.Scale(OsbEasing.OutExpo,28915, 29209, 0, 0.5);
            read.Rotate(28915, -0.2);
            read.Move(28915, 250, 155);
            read.Color(28915, 0.631, 0.929, 0.894);

            and2.Fade(29209, 31268, 1, 1);
            and2.Rotate(29209, -0.2);

            hard.Scale(OsbEasing.InOutExpo, 29209, 29650, 0.5, 1.5);
            hard.Move(OsbEasing.InOutExpo,29209, 29650, 175, 125, 0, 25);
            to4.Scale(OsbEasing.InOutExpo, 29209, 29650, 0.5, 1.5);
            to4.Move(OsbEasing.InOutExpo,29209, 29650, 160, 175, -50, 164);
            read.Scale(OsbEasing.InOutExpo, 29209, 29650, 0.5, 1.5);
            read.Move(OsbEasing.InOutExpo,29209, 29650, 250, 155, 220, 105);
            and2.Move(OsbEasing.InOutExpo,29209, 29650, 181, 216, 8, 280);
            and2.Scale(OsbEasing.InOutExpo, 29209, 29650, 0, 1.5);

            hard.Move(OsbEasing.InExpo, 30680, 31268, 0, 25, 850, 25 - 180);
            to4.Move(OsbEasing.InExpo, 30680, 31268, -50, 164, 800, 164 - 180);
            read.Move(OsbEasing.InExpo, 30680, 31268, 220, 105, 220 + 850, 105 - 180);
            and2.Move(OsbEasing.InExpo, 30680, 31268, 8, 280, 858, 100);

            hard2.Fade(29503, 31268, 1, 1);
            hard2.Scale(OsbEasing.OutExpo, 29356, 29797, 0, 0.5);
            hard2.Rotate(29503, 0.2);
            hard2.Move(29503, 410, 250);

            to5.Fade(29944, 31268, 1, 1);
            to5.Scale(OsbEasing.OutExpo,29944, 30239, 0, 0.5);
            to5.Rotate(29944, 0.2);
            to5.Move(29944, 376, 290);

            speak2.Fade(30091, 31268, 1, 1);
            speak2.Scale(OsbEasing.OutExpo,30091, 30386, 0, 0.5);
            speak2.Rotate(30091, 0.2);
            speak2.Move(30091, 482, 311);
            speak2.Color(30091, 0.992, 0.247, 0.573);

            to6.Fade(30386, 31268, 1, 1);
            to6.Scale(OsbEasing.OutExpo,30386, 30680, 0, 0.5);
            to6.Rotate(30386, 0.2);
            to6.Move(30386, 366, 335);

            hard2.Move(OsbEasing.InExpo, 30680, 31268, 410, 250, 410 - 600, 250 - 125);
            to5.Move(OsbEasing.InExpo, 30680, 31268, 376, 290, 376 - 600, 290 - 125);
            speak2.Move(OsbEasing.InExpo, 30680, 31268, 482, 311, 482 - 600, 311 - 125);
            to6.Move(OsbEasing.InExpo, 30680, 31268, 366, 335, 366 - 600, 335 - 125);

            var but2 = layer.CreateSprite("sb/f/_017.png", OsbOrigin.Centre);
            var dont2 = layer.CreateSprite("sb/f/_00c.png", OsbOrigin.Centre);
            var take = layer.CreateSprite("sb/f/_02b.png", OsbOrigin.Centre);
            var my4 = layer.CreateSprite("sb/f/_004.png", OsbOrigin.Centre);
            var word = layer.CreateSprite("sb/f/_02c.png", OsbOrigin.Centre);
            var cause= layer.CreateSprite("sb/f/_02d.png", OsbOrigin.Centre); 

            but2.Fade(30827, 33327, 1, 1);
            but2.Scale(OsbEasing.OutExpo,30386, 31121, 0, 0.5);
            but2.Rotate(30827, -0.2);
            but2.Move(OsbEasing.OutExpo, 30827, 31121, 480, 540 + 24, 430, 130 + 250);

            dont2.Fade(30827, 33327, 1, 1);
            dont2.Scale(OsbEasing.OutExpo,30386, 31121, 0, 0.5);
            dont2.Rotate(30827, -0.2);
            dont2.Move(OsbEasing.OutExpo, 30827, 31121, 595, 540, 545, 106 + 250);

            take.Fade(31268, 33327, 1, 1);
            take.Scale(OsbEasing.OutExpo,31268, 31562, 0, 1);
            take.Rotate(31268, -0.2);
            take.Move(31268, 223, 361);

            my4.Fade(31562, 35680, 1, 1);
            my4.Scale(OsbEasing.OutExpo,31562, 31856, 0, 0.5);
            my4.Rotate(31562, -0.2 + 1.5703);
            my4.Move(31562, 353, 337);

            word.Fade(31856, 35680, 1, 1);
            word.Scale(OsbEasing.OutExpo,31856, 32150, 0, 1);
            word.Rotate(31856, -0.2);
            word.Move(OsbEasing.OutExpo, 31856, 32150, 565, 540, 500, 305);
            word.Color(31856, 0.992, 0.247, 0.573);

            take.Rotate(OsbEasing.OutExpo, 32444, 32886, -0.2, 0.2);
            take.Scale(OsbEasing.OutExpo, 32444, 32886, 1, 1.2);
            take.Move(OsbEasing.OutExpo, 32444, 32886, 223, 361, 150, 220);

            my4.Rotate(OsbEasing.OutExpo, 32444, 32886, -0.2 + 1.5703, 0.2 + 1.5703);
            my4.Scale(OsbEasing.OutExpo, 32444, 32886, 0.5, 0.6);
            my4.Move(OsbEasing.OutExpo, 32444, 32886, 353, 337, 300, 252);

            word.Rotate(OsbEasing.OutExpo, 32444, 32886, -0.2, 0.2);
            word.Scale(OsbEasing.OutExpo, 32444, 32886, 1, 1.2);
            word.Move(OsbEasing.OutExpo, 32444, 32886, 500, 305, 473, 284);

            but2.Rotate(OsbEasing.OutExpo, 32444, 32886, -0.2, 0.2);
            but2.Scale(OsbEasing.OutExpo, 32444, 32886, 0.5, 0.6);
            but2.Move(OsbEasing.OutExpo, 32444, 32886, 430, 380, 365, 325);

            dont2.Rotate(OsbEasing.OutExpo, 32444, 32886, -0.2, 0.2);
            dont2.Scale(OsbEasing.OutExpo, 32444, 32886, 0.5, 0.6);
            dont2.Move(OsbEasing.OutExpo, 32444, 32886, 545, 356, 500, 352);

            cause.Fade(32444, 35680, 1, 1);
            cause.Scale(OsbEasing.OutExpo,32444, 32739, 0, 0.5);
            cause.Rotate(32444, 0.2 - 1.5703);
            cause.Move(32444, 360, 150);

            cause.Scale(OsbEasing.InOutExpo, 32886, 33327, 0.5, 1.25);
            cause.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2 - 1.5703, -0.2 - 1.5703);
            cause.Move(OsbEasing.InOutExpo, 32886, 33327, 360, 150, 200, 280);

            word.Scale(OsbEasing.InOutExpo, 32886, 33327, 1.2, 1.7);
            word.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2, -0.2);
            word.Move(OsbEasing.InOutExpo, 32886, 33327, 473, 284, 420, 475);

            my4.Scale(OsbEasing.InOutExpo, 32886, 33327, 0.6, 0.9);
            my4.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2 + 1.5703, -0.2 + 1.5703);
            my4.Move(OsbEasing.InOutExpo, 32886, 33327, 300, 252, 160, 515);

            take.Scale(OsbEasing.InOutExpo, 32886, 33327, 1.2, 1.7);
            take.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2, -0.2);
            take.Move(OsbEasing.InOutExpo, 32886, 33327, 150, 220, -80, 570);

            but2.Scale(OsbEasing.InOutExpo, 32886, 33327, 0.6, 0.9);
            but2.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2, -0.2);
            but2.Move(OsbEasing.InOutExpo, 32886, 33327, 365, 325, 280, 570);

            dont2.Scale(OsbEasing.InOutExpo, 32886, 33327, 0.6, 0.9);
            dont2.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2, -0.2);
            dont2.Move(OsbEasing.InOutExpo, 32886, 33327, 500, 352, 450, 560);

            var im3 = layer.CreateSprite("sb/f/_027.png", OsbOrigin.Centre); 
            var honestly = layer.CreateSprite("sb/f/_02e.png", OsbOrigin.Centre); 
            var so = layer.CreateSprite("sb/f/_02f.png", OsbOrigin.Centre); 
            var bored = layer.CreateSprite("sb/f/_030.png", OsbOrigin.Centre); 
            var of2 = layer.CreateSprite("sb/f/_003.png", OsbOrigin.Centre); 
            var being = layer.CreateSprite("sb/f/_031.png", OsbOrigin.Centre); 

            im3.Fade(32886, 35680, 1, 1);
            im3.Scale(OsbEasing.Out,32886, 33327, 0, 0.5);
            im3.Rotate(32886, 0.2);
            im3.Move(32886, 405, 102);
            im3.Move(OsbEasing.InOutExpo, 32886, 33327, 408, 102, 245, 120);
            im3.Rotate(OsbEasing.InOutExpo, 32886, 33327, 0.2, -0.2);

            honestly.Fade(33033, 35680, 1, 1);
            honestly.Scale(OsbEasing.OutExpo,33033, 33327, 0, 0.5);
            honestly.Rotate(OsbEasing.OutExpo, 33033, 33327, 0.2, -0.2);
            honestly.Move(33033, 395, 89);
            honestly.Color(33033, 0.631, 0.929, 0.894);

            so.Fade(33915, 35680, 1, 1);
            so.Scale(OsbEasing.OutExpo,33915, 34209, 0, 0.5);
            so.Rotate(33915, -0.2);
            so.Move(33915, 257, 167);

            bored.Fade(34209, 35680, 1, 1);
            bored.Scale(OsbEasing.OutExpo,34209, 34503, 0, 0.5);
            bored.Rotate(34209, -0.2);
            bored.Move(34209, 365, 144);

            of.Fade(34650,35680, 1, 1);
            of.Scale(OsbEasing.OutExpo,34650, 34944, 0, 0.5);
            of.Rotate(34650, -0.2);
            of.Move(34650, 266, 215);

            being.Fade(34797, 35680, 1, 1);
            being.Scale(OsbEasing.OutExpo,34797, 35091, 0, 0.5);
            being.Rotate(34797, -0.2);
            being.Move(34797, 366, 194);

            im3.Move(OsbEasing.InExpo, 35239, 35680, 245, 120, 245 + 105, 120 + 500);
            honestly.Move(OsbEasing.InExpo, 35239, 35680, 395, 89, 395 + 105, 89 + 500);
            so.Move(OsbEasing.InExpo, 35239, 35680,257, 167, 257 + 105, 167 + 500);
            bored.Move(OsbEasing.InExpo, 35239, 35680, 365, 144, 365 + 105, 144 + 500);
            of.Move(OsbEasing.InExpo, 35239, 35680,266, 215, 266 + 105, 215 + 500);
            being.Move(OsbEasing.InExpo, 35239, 35680, 366, 194, 366 + 105, 194 + 500);
            cause.Move(OsbEasing.InExpo, 35239, 35680, 200, 280, 200 + 105, 280 + 500);
            word.Move(OsbEasing.InExpo, 35239, 35680, 420, 475, 420 + 105, 475 + 500);
            my4.Move(OsbEasing.InExpo, 35239, 35680, 160, 515, 160 + 105, 515 + 500);

            var misunderstood = layer.CreateSprite("sb/f/_032.png", OsbOrigin.Centre);
            var im4 = layer.CreateSprite("sb/f/_027.png", OsbOrigin.Centre);
            var not3 = layer.CreateSprite("sb/f/_028.png", OsbOrigin.Centre); 

            misunderstood.Fade(35680,38033, 1, 1);
            misunderstood.Scale(OsbEasing.OutExpo,35680, 35974, 0, 0.5);
            
            misunderstood.Move(OsbEasing.OutExpo, 35680, 35974, -200, 240, 520, 240);
            misunderstood.Color(35680, 35974, 1, 1, 1,0.992, 0.247, 0.574);
            misunderstood.Move(OsbEasing.OutExpo, 35974, 36268, 520, 240, 320, 240);
            misunderstood.Color(35974, 36268, 0.992, 0.247, 0.574, 0.631, 0.929, 0.894);

            misunderstood.Scale(OsbEasing.OutExpo, 36268, 36562, 0.5, 0.4);
            misunderstood.Rotate(OsbEasing.OutExpo, 36268, 36562, 0, -0.2);

            misunderstood.Scale(OsbEasing.OutExpo, 36562, 36856, 0.4, 0.75);
            misunderstood.Rotate(OsbEasing.OutExpo, 36562, 36856, -0.2, 0.2);
            misunderstood.Color(36562, 36856, 0.631, 0.929, 0.894,0.992, 0.247, 0.574);

            im4.Fade(37150, 38033, 1, 1);
            im4.Scale(OsbEasing.OutExpo,37150, 37444, 0, 0.5);
            im4.Rotate(37150, 0.2);
            im4.Move(37150, 110, 145);

            not3.Fade(37444, 38033, 1, 1);
            not3.Scale(OsbEasing.OutExpo,37444, 37739, 0, 0.5);
            not3.Rotate(37444, 0.2);
            not3.Move(37444, 195, 162);

            misunderstood.Scale(OsbEasing.InExpo, 37739, 38180, 0.75, 0);
            misunderstood.Rotate(OsbEasing.InExpo, 37739, 38180, 0.2, 0);

            im4.Scale(OsbEasing.InExpo, 37739, 38180, 0.5, 0);
            im4.Rotate(OsbEasing.InExpo, 37739, 38180, 0.2, 0);
            im4.Move(OsbEasing.InExpo, 37739, 38180, 110, 145, 320, 240);

            not3.Scale(OsbEasing.InExpo, 37739, 38180, 0.5, 0);
            not3.Rotate(OsbEasing.InExpo, 37739, 38180, 0.2, 0);
            not3.Move(OsbEasing.InExpo, 37739, 38180, 195, 162, 320, 240);

            var so2 = layer.CreateSprite("sb/f/_02f.png", OsbOrigin.Centre);
            var clear = layer.CreateSprite("sb/f/_033.png", OsbOrigin.Centre);
            var and3 = layer.CreateSprite("sb/f/_00b.png", OsbOrigin.Centre);
            var transparent = layer.CreateSprite("sb/f/_034.png", OsbOrigin.Centre);
            var ill2 = layer.CreateSprite("sb/f/_00f.png", OsbOrigin.Centre);
            var try2 = layer.CreateSprite("sb/f/_010.png", OsbOrigin.Centre);

            so2.Fade(38033, 40386, 1, 1);
            so2.Scale(OsbEasing.OutExpo,38033, 38327, 0, 0.5);
            so2.Rotate(38033, -0.2);
            so2.Move(OsbEasing.OutExpo, 38033, 38327, 150, 485, 110, 285);

            clear.Fade(38327, 40386, 1, 1);
            clear.Scale(OsbEasing.OutExpo,38327, 38621, 0, 0.5);
            clear.Rotate(38327, -0.2);
            clear.Move(38327,  215, 263);
            clear.Color(38327, 0.992, 0.247, 0.574);

            so2.Move(OsbEasing.OutExpo, 38621, 39062, 110, 285, 160, 300);
            so2.Rotate(OsbEasing.OutExpo, 38621, 39062, -0.2, 0.2 - 1.5704);
            so2.Scale(OsbEasing.OutExpo, 38621,39062, 0.5, 0.75);

            clear.Move(OsbEasing.OutExpo, 38621, 39062, 215, 263, 195, 143);
            clear.Rotate(OsbEasing.OutExpo, 38621, 39062, -0.2, 0.2 - 1.5704);
            clear.Scale(OsbEasing.OutExpo, 38621,39062, 0.5, 0.75);

            and3.Fade(38621, 40386, 1, 1);
            and3.Scale(OsbEasing.OutExpo,38621, 38915, 0, 0.5);
            and3.Rotate(38621, 0.2);
            and3.Move(38621, 290, 80);

            transparent.Fade(OsbEasing.Out, 38915, 40386, 0, 1);
            transparent.Scale(OsbEasing.OutExpo,38915, 39209, 0, 0.5);
            transparent.Rotate(38915, 0.2);
            transparent.Move(38915, 380, 145);
            transparent.Color(38915, 0.631, 0.929, 0.894);

            ill2.Fade(OsbEasing.OutExpo, 39797, 40386, 0, 1);
            ill2.Scale(OsbEasing.OutExpo,39797, 40091, 0, 0.5);
            ill2.Rotate(39797, 0.2);
            ill2.Move(39797, 267, 169);

            so2.Move(OsbEasing.InExpo, 39797, 40239, 160, 300, 160 - 650, 300- 130);
            clear.Move(OsbEasing.InExpo, 39797, 40239, 195, 143, 195 - 650, 143 - 130);
            and3.Move(OsbEasing.InExpo, 39797, 40239, 290, 80, 290 - 650, 80 - 130);
            transparent.Move(OsbEasing.InExpo, 39797, 40239, 380, 145, 380 - 650, 145 - 130);
            ill2.Move(OsbEasing.InExpo, 39797, 40239, 267, 169, 267 - 650, 169 - 130);
            
            try2.Fade(40091, 42739, 1, 1);
            try2.Scale(OsbEasing.OutExpo,40091, 40386, 0, 0.75);
            try2.Rotate(40091, 0.2);
            try2.Move(OsbEasing.OutExpo, 40091, 40386, 320 + 650, 240 + 130, 320, 240);

            try2.Scale(OsbEasing.InExpo, 40386, 40680, 0.75, 1.25);
            try2.Scale(OsbEasing.OutExpo, 40680, 40974, 1.25, 1.30);

            var but3 = layer.CreateSprite("sb/f/_017.png", OsbOrigin.Centre);
            var i4 = layer.CreateSprite("sb/f/0069.png", OsbOrigin.Centre);
            var cant = layer.CreateSprite("sb/f/_036.png", OsbOrigin.Centre);
            var promise = layer.CreateSprite("sb/f/_037.png", OsbOrigin.Centre);
            var it = layer.CreateSprite("sb/f/_038.png", OsbOrigin.Centre);

            but3.Fade(40533, 42739, 1, 1);
            but3.Scale(OsbEasing.OutExpo,40533, 40974, 0, 0.5);
            but3.Rotate(40533, 0.2 - 1.5703);
            but3.Move(40533, 442, 265);
            but3.Color(40533, 0.992, 0.247, 0.574);

            i4.Fade(40680, 42739, 1, 1);
            i4.Scale(OsbEasing.OutExpo,40533, 40974, 0, 0.5);
            i4.Rotate(40680, 0.2 - 1.5703);
            i4.Move(40680, 454, 210);

            cant.Fade(40974, 42739, 1, 1);
            cant.Scale(OsbEasing.OutExpo,40974, 41268, 0, 0.5);
            cant.Rotate(40974, 0.2 - 1.5703);
            cant.Move(40974, 471, 128);

            promise.Fade(41268, 42739, 1, 1);
            promise.Scale(OsbEasing.OutExpo,41268, 41562, 0, 0.5);
            promise.Rotate(41268, 0.2);
            promise.Move(41268, 305, 306);
            promise.Color(41268, 0.631, 0.929, 0.894);

            it.Fade(41709, 42739, 1, 1);
            it.Scale(OsbEasing.OutExpo,41709, 42003, 0, 0.5);
            it.Rotate(41709, 0.2);
            it.Move(41709, 425, 330);

            but3.Move(OsbEasing.InExpo, 42150, 42739, 442, 265, 442 + 125, 265 - 600);
            i4.Move(OsbEasing.InExpo, 42150, 42739, 454, 210, 454 + 125, 210 - 600);
            cant.Move(OsbEasing.InExpo, 42150, 42739, 471, 128, 471 + 125, 128 - 600);
            try2.Move(OsbEasing.InExpo, 42150, 42739, 320, 240, 320 - 800, 240 - 160);
            promise.Move(OsbEasing.InExpo, 42150, 42739, 305, 306, 305 - 800, 306 - 160);
            it.Move(OsbEasing.InExpo, 42150, 42739, 425, 330, 425 - 800, 330 - 160);

            var so3 = layer.CreateSprite("sb/f/_02f.png", OsbOrigin.Centre);
            var dark = layer.CreateSprite("sb/f/_039.png", OsbOrigin.Centre);
            var but4 = layer.CreateSprite("sb/f/_017.png", OsbOrigin.Centre);
            var delicate = layer.CreateSprite("sb/f/_03a.png", OsbOrigin.Centre);
            var well = layer.CreateSprite("sb/f/_035.png", OsbOrigin.Centre);
            var im5 = layer.CreateSprite("sb/f/_027.png", OsbOrigin.Centre);
            var rough = layer.CreateSprite("sb/f/_03b.png", OsbOrigin.Centre);
            var around = layer.CreateSprite("sb/f/_03c.png", OsbOrigin.Centre);
            var the5 = layer.CreateSprite("sb/f/_009.png", OsbOrigin.Centre);
            var edges = layer.CreateSprite("sb/f/_03d.png", OsbOrigin.Centre);
            var and4 = layer.CreateSprite("sb/f/_00b.png", OsbOrigin.Centre);

            so3.Fade(42739, 44650, 1, 1);
            so3.Scale(OsbEasing.OutExpo,42739, 43033, 0, 0.5);
            so3.Rotate(42739, -0.2);
            so3.Move(OsbEasing.OutExpo, 42739, 43033, 0, 0, 60, 250);

            dark.Fade(43033, 44650, 1, 1);
            dark.Scale(OsbEasing.OutExpo,43033, 43327, 0, 0.5);
            dark.Rotate(43033, -0.2);
            dark.Move(43033, 95, 286);
            dark.Color(43033, 43621, 1, 1, 1, 0, 0 ,0);

            but4.Fade(43327, 44650, 1, 1);
            but4.Scale(OsbEasing.OutExpo,43327, 43621, 0, 0.5);
            but4.Rotate(43327, -0.2);
            but4.Move(OsbEasing.OutExpo, 43327, 43621, 560, 500, 520, 250);

            delicate.Fade(43621, 44650, 1, 1);
            delicate.Scale(OsbEasing.OutExpo,43621, 43915, 0, 0.5);
            delicate.Rotate(43621, -0.2);
            delicate.Move(43621, 565, 195);
            delicate.Color(43621, 0.992, 0.247, 0.574);

            so3.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2, 0.2);
            dark.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2, 0.2);
            so3.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            dark.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            so3.Move(OsbEasing.InExpo, 44209, 44650, 60, 250, -200, 200);
            dark.Move(OsbEasing.InExpo, 44209, 44650, 95, 286, -150, 286);

            but4.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2, 0.2);
            delicate.Rotate(OsbEasing.InExpo, 44209, 44650, -0.2, 0.2);
            but4.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            delicate.Scale(OsbEasing.InExpo, 44209, 44650, 0.5, 1);
            but4.Move(OsbEasing.InExpo, 44209, 44650, 520, 250, 840, 200);
            delicate.Move(OsbEasing.InExpo, 44209, 44650, 565, 195, 965, 100);

            well.Fade(44503, 47150, 1, 1);
            well.Scale(OsbEasing.OutExpo,44503, 44797, 0, 0.5);
            //well.Rotate(44503, -0.2);
            well.Move(44503, 270, 240);

            im5.Fade(44503, 47150, 1, 1);
            im5.Scale(OsbEasing.OutExpo,44503, 44797, 0, 0.5);
            //well.Rotate(44503, -0.2);
            im5.Move(44503, 370, 240);

            rough.Fade(44797, 47150, 1, 1);
            rough.Scale(OsbEasing.OutExpo,44797, 45091, 0, 0.75);
            rough.Move(44797, 310, 250);
            rough.Color(44797, 0.992, 0.247, 0.574);

            well.Move(OsbEasing.OutExpo, 44797, 45091, 270, 240, 270, 200);
            im5.Move(OsbEasing.OutExpo, 44797, 45091, 370, 240, 370, 200);
            
            well.Scale(OsbEasing.InExpo, 45091, 45386, 0.5, 0.75);
            im5.Scale(OsbEasing.InExpo,45091, 45386, 0.5, 0.75);
            rough.Scale(OsbEasing.InExpo,45091, 45386, 0.75, 1.1);
            well.Move(OsbEasing.InExpo, 45091, 45386, 270, 200, 250, 190);
            im5.Move(OsbEasing.InExpo, 45091, 45386, 370, 200, 400, 190);
            rough.Move(OsbEasing.InExpo, 45091, 45386, 310, 250, 310, 270);

            around.Fade(45239, 47150, 1, 1);
            around.Scale(OsbEasing.OutExpo,45239, 45533, 0, 0.5);
            around.Rotate(45239, 1.5704);
            around.Move(45239, 495, 218);
            around.Color(45239, 0.631, 0.929, 0.894);

            the5.Fade(45827, 47150, 1, 1);
            the5.Scale(OsbEasing.OutExpo,45827, 46121, 0, 0.5);
            the5.Move(45827, 395, 345);

            edges.Fade(45974, 47150, 1, 1);
            edges.Scale(OsbEasing.OutExpo,45974, 46268, 0, 0.5);
            edges.Move(45974, 510, 345);

            and4.Fade(46415, 47150, 1, 1);
            and4.Scale(OsbEasing.OutExpo,46415, 46709, 0, 0.5);
            and4.Move(46415, 399, 390);

            well.Move(OsbEasing.InExpo, 46709, 47150, 250, 190, 250, 590);
            im5.Move(OsbEasing.InExpo, 46709, 47150, 400, 190, 400, 590);
            rough.Move(OsbEasing.InExpo, 46709, 47150, 310, 270, 310, 670);

            around.Move(OsbEasing.InExpo, 46709, 47150, 495, 218, 495, 618);
            the5.Move(OsbEasing.InExpo, 46709, 47150, 395, 345, 395, 745);
            edges.Move(OsbEasing.InExpo, 46709, 47150, 510, 345, 510, 745);
            and4.Move(OsbEasing.InExpo, 46709, 47150, 399, 390, 399, 790);
        }
    }
}
