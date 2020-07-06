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
    public class Loading : StoryboardObjectGenerator
    {
        public override void Generate()
        {
		    var layer = GetLayer("Main");
            var square = layer.CreateSprite("sb/glow2.png",OsbOrigin.Centre);
            var load = layer.CreateSprite("sb/loading.png", OsbOrigin.Centre);
            var load2 = layer.CreateSprite("sb/loading2.png", OsbOrigin.Centre);
            var arc = layer.CreateSprite("sb/arc.png", OsbOrigin.Centre);
            var vignette = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette.Fade(36269, 37269, 0.5, 1);
            vignette.Fade(37269,46769, 1, 1);
            vignette.Scale(36269, (360.0 / 768)*1.55);

            square.Fade(36269, 37269, 0, 0.75);
            square.Fade(37269, 46769, 0.75, 0.75);
            square.Scale(36269, 0.36);

            double startRot = 0;
            for(int i = 36269; i <= 46769; i+= 200){
                square.Rotate(i, i+200, startRot, startRot + 0.2);
                startRot += 0.2;
            }

            load.Fade(36269, 37269, 0, 1);
            load.Fade(37269,46769, 1, 1);
            load.Scale(36269, 0.15);
            load2.Fade(36269, 37269, 0, 1);
            load2.Scale(36269, 0.20);
            load2.Fade(37269,46769, 1, 1);
            arc.Fade(36269, 37269, 0, 1);
            arc.Fade(37269,46769, 1, 1);
            arc.Scale(36269, 0.25);
            double startRot1 = 0;
            double startRot2 = 0;
            double startRot3 = 0;
            load.Color(36269, 1, 1, 1);
            load2.Color(36269, 1, 1, 1);
            arc.Color(36269, 0.678, 0.73, 0.78);

            for (int i = 36269; i <= 46769; i+= 200){
                if (i < 45269){
                    load.Rotate(i,i+200, startRot1, startRot1-0.8);
                    load2.Rotate(i,i+200, startRot2, startRot2+0.1);
                    arc.Rotate(i,i+200, startRot3, startRot3-0.1);
                    startRot1 -= 0.8;
                    startRot2 += 0.1;
                    startRot3 -= 0.1;
                }else{
                    load.Rotate(i,i+200, startRot1, startRot1*1.05);
                    load2.Rotate(i,i+200, startRot2, startRot2*1.15);
                    arc.Rotate(i,i+200, startRot3, startRot3*1.05);   
                    startRot1 *= 1.05;
                    startRot2 *= 1.15;
                    startRot3 *= 1.05;
                }
            }

            for (int i = 36269; i <= 46769; i+= (36643 - 36269)){
                arc.Scale(i, i+200, 0.30 ,0.25);
            }
            for (int i = 37206; i <= 42269; i+= (38706 - 37206)){
                arc.Scale(i, i+200, 0.30 ,0.25);
            }
            for (int i = 39081; i <= 45269; i+= (42081 - 39081)){
                arc.Scale(i, i+200, 0.30 ,0.25);
            }
            arc.Scale(43581, 43581+200, 0.3 ,0.25);

            //PRE-CHORUS2
            var square2 = layer.CreateSprite("sb/glow2.png",OsbOrigin.Centre);
            var load3 = layer.CreateSprite("sb/loading.png", OsbOrigin.Centre);
            var load4 = layer.CreateSprite("sb/loading2.png", OsbOrigin.Centre);
            var arc2 = layer.CreateSprite("sb/arc.png", OsbOrigin.Centre);
            var vignette2 = layer.CreateSprite("sb/vignette.png", OsbOrigin.Centre);
            vignette2.Fade(156268, 156643, 0.5, 1);
            vignette2.Fade(156643,166768, 1, 1);
            vignette2.Scale(156268, (360.0 / 768)*1.55);

            square2.Fade(156268, 156643, 0, 0.75);
            square2.Fade(156643, 166768, 0.75, 0.75);
            square2.Scale(156268, 0.36);

            load3.Fade(156268, 156643, 0, 1);
            load3.Fade(156643,166768, 1, 1);
            load3.Scale(156268, 0.15);
            load4.Fade(156268, 156643, 0, 1);
            load4.Scale(156268, 0.20);
            load4.Fade(156643,166768, 1, 1);
            arc2.Fade(156268, 156643, 0, 1);
            arc2.Fade(156643,166768, 1, 1);
            arc2.Scale(156268, 0.25);
            double startRot4 = 0;
            double startRot5 = 0;
            double startRot6 = 0;
            load3.Color(156268, 1, 1, 1);
            load4.Color(156268, 1, 1, 1);
            arc2.Color(156268, 0.678, 0.73, 0.78);

            for (int i = 156268; i <= 166768; i+= 200){
                if (i < 165268){
                    load3.Rotate(i,i+200, startRot4, startRot4-0.8);
                    load4.Rotate(i,i+200, startRot5, startRot5+0.1);
                    arc2.Rotate(i,i+200, startRot6, startRot6-0.1);
                    startRot4 -= 0.8;
                    startRot5 += 0.1;
                    startRot6 -= 0.1;
                }else{
                    load3.Rotate(i,i+200, startRot4, startRot4*1.05);
                    load4.Rotate(i,i+200, startRot5, startRot5*1.15);
                    arc2.Rotate(i,i+200, startRot6, startRot6*1.05);   
                    startRot4 *= 1.05;
                    startRot5 *= 1.15;
                    startRot6 *= 1.05;
                }
            }

            for (int i = 156268; i <= 166768; i+= (156643 - 156268)){
                arc2.Scale(i, i+200, 0.30 ,0.25);
            }
            for (int i = 157206; i <= 162268; i+= (158706 - 157206)){
                arc2.Scale(i, i+200, 0.30 ,0.25);
            }
            for (int i = 159268; i <= 165268; i+= (42081 - 39081)){
                arc2.Scale(i, i+200, 0.30 ,0.25);
            }
            arc2.Scale(165081, 165081+200, 0.3 ,0.25);

            arc2.Fade(166768,166768,0,0);
            load3.Fade(166768,166768,0,0);
            load4.Fade(166768,166768,0,0);
        }
    }
}
