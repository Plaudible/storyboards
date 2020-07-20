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
    public class Gears : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var bggear1 = GetLayer("").CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var bggear11 = GetLayer("").CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var bggear111 = GetLayer("").CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var bggear4 = GetLayer("").CreateSprite("sb/g/g4.png", OsbOrigin.Centre);
            var bggear44 = GetLayer("").CreateSprite("sb/g/g4.png", OsbOrigin.Centre);
            var bggear3 = GetLayer("").CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var bggear33 = GetLayer("").CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var bggear2 = GetLayer("").CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var bggear22 = GetLayer("").CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var bggear6 = GetLayer("").CreateSprite("sb/g/g6.png", OsbOrigin.Centre);
            var bggear66 = GetLayer("").CreateSprite("sb/g/g6.png", OsbOrigin.Centre);
            var bggear5 = GetLayer("").CreateSprite("sb/g/g5.png", OsbOrigin.Centre);
		    var gear1 = GetLayer("").CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var gear11 = GetLayer("").CreateSprite("sb/g/g1.png", OsbOrigin.Centre);
            var gear2 = GetLayer("").CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var gear22 = GetLayer("").CreateSprite("sb/g/g2.png", OsbOrigin.Centre);
            var gear3 = GetLayer("").CreateSprite("sb/g/g3.png", OsbOrigin.Centre);
            var gear4 = GetLayer("").CreateSprite("sb/g/g4.png", OsbOrigin.Centre);
            var gear5 = GetLayer("").CreateSprite("sb/g/g5.png", OsbOrigin.Centre);
            var gear6 = GetLayer("").CreateSprite("sb/g/g6.png", OsbOrigin.Centre);

            bggear33.Fade(48580, 87580, 0.5, 0.5);
            bggear33.Scale(48580, 0.45);
            bggear33.Move(48580, -100, 85);
            bggear33.Rotate(48580, 87580, 0, 20);


            bggear44.Fade(48580, 87580, 0.5, 0.5);
            bggear44.Scale(48580, 0.15);
            bggear44.Move(48580, 100,10);
            bggear44.Rotate(48580, 87580, 0, 20);

            bggear22.Fade(48580, 87580, 0.5, 0.5);
            bggear22.Scale(48580, 0.2);
            bggear22.Move(48580, 55,150);
            bggear22.Rotate(48580, 87580, 0, -20);

            bggear66.Fade(48580, 87580, 0.5, 0.5);
            bggear66.Scale(48580, 0.2);
            bggear66.Move(48580, -90,420);
            bggear66.Rotate(48580, 87580, 0, -20);
            
            bggear111.Fade(48580, 87580, 0.5, 0.5);
            bggear111.Scale(48580, 0.15);
            bggear111.Move(48580, 45, 410);
            bggear111.Rotate(48580, 87580, 0, -20);
            
            bggear5.Fade(48580, 87580, 0.5, 0.5);
            bggear5.Scale(48580, 0.2);
            bggear5.Move(48580, -60, 275);
            bggear5.Rotate(48580, 87580, 0, 20);

            bggear11.Fade(48580, 87580, 0.5, 0.5);
            bggear11.Scale(48580, 0.15);
            bggear11.Move(48580, 560,30);
            bggear11.Rotate(48580, 87580, 0, 20);
            
            bggear3.Fade(48580, 87580, 0.5, 0.5);
            bggear3.Scale(48580, 0.3);
            bggear3.Move(48580, 700,20);
            bggear3.Rotate(48580, 87580, 0, 20);
            
            bggear6.Fade(48580, 87580, 0.5, 0.5);
            bggear6.Scale(48580, 0.2);
            bggear6.Move(48580, 575,440);
            bggear6.Rotate(48580, 87580, 0, -20);

            gear1.Fade(48580, 87580, 0.75, 0.75);
            gear1.Scale(48580, 0.2);
            gear1.Move(48580, 680, 430);
            gear1.Rotate(48580, 87580, 0, 20);

            bggear1.Fade(48580, 87580, 0.5, 0.5);
            bggear1.Scale(48580, 0.2);
            bggear1.Move(48580, 660, 320);
            bggear1.Rotate(48580, 87580, 0, 20);

            gear2.Fade(48580, 87580, 0.75, 0.75);
            gear2.Scale(48580, 0.2);
            gear2.Move(48580, 720,260);
            gear2.Rotate(48580, 87580, 0, -20);

            bggear2.Fade(48580, 87580, 0.5, 0.5);
            bggear2.Scale(48580, 0.2);
            bggear2.Move(48580, 700,425);
            bggear2.Rotate(48580, 87580, 0, -20);

            gear3.Fade(48580, 87580, 0.75, 0.75);
            gear3.Scale(48580, 0.2);
            gear3.Move(48580, -90,210);
            gear3.Rotate(48580, 87580, 0, -20);

            gear4.Fade(48580, 87580, 0.75, 0.75);
            gear4.Scale(48580, 0.2);
            gear4.Move(48580, -50,75);
            gear4.Rotate(48580, 87580, 0, 20);

            bggear4.Fade(48580, 87580, 0.5, 0.5);
            bggear4.Scale(48580, 0.2);
            bggear4.Move(48580, 658,178);
            bggear4.Rotate(48580, 87580, 0, -20);

            gear5.Fade(48580, 87580, 0.75, 0.75);
            gear5.Scale(48580, 0.2);
            gear5.Move(48580, 690, 55);
            gear5.Rotate(48580, 87580, 0, -20);

            gear6.Fade(48580, 87580, 0.75, 0.75);
            gear6.Scale(48580, 0.2);
            gear6.Move(48580, 620,185);
            gear6.Rotate(48580, 87580, 0, 20);
            
            gear22.Fade(48580, 87580, 0.75, 0.75);
            gear22.Scale(48580, 0.2);
            gear22.Move(48580, -60,430);
            gear22.Rotate(48580, 87580, 0, -20);

            gear11.Fade(48580, 87580, 0.75, 0.75);
            gear11.Scale(48580, 0.2);
            gear11.Move(48580, 30,280);
            gear11.Rotate(48580, 87580, 0, 20);

            //ENDING
            bggear1.Fade(87580, 87580, 0, 0);
            bggear11.Fade(87580, 87580, 0, 0);
            bggear111.Fade(87580, 87580, 0, 0);
            bggear4.Fade(87580, 87580, 0, 0);
            bggear44.Fade(87580, 87580, 0, 0);
            bggear3.Fade(87580, 87580, 0, 0);
            bggear33.Fade(87580, 87580, 0, 0);
            bggear2.Fade(87580, 87580, 0, 0);
            bggear22.Fade(87580, 87580, 0, 0);
            bggear6.Fade(87580, 87580, 0, 0);
            bggear66.Fade(87580, 87580, 0, 0);
            bggear5.Fade(87580, 87580, 0, 0);
            gear1.Fade(87580, 87580, 0, 0);
            gear11.Fade(87580, 87580, 0, 0);
            gear2.Fade(87580, 87580, 0, 0);
            gear22.Fade(87580, 87580, 0, 0);
            gear3.Fade(87580, 87580, 0, 0);
            gear4.Fade(87580, 87580, 0, 0);
            gear5.Fade(87580, 87580, 0, 0);
            gear6.Fade(87580, 87580, 0, 0);

            bggear1.Fade(125380, 144580, 0.5, 0.5);
            bggear11.Fade(125380, 144580, 0.5, 0.5);
            bggear111.Fade(125380, 144580, 0.5, 0.5);
            bggear4.Fade(125380, 144580, 0.5, 0.5);
            bggear44.Fade(125380, 144580, 0.5, 0.5);
            bggear3.Fade(125380, 144580, 0.5, 0.5);
            bggear33.Fade(125380, 144580, 0.5, 0.5);
            bggear2.Fade(125380, 144580, 0.5, 0.5);
            bggear22.Fade(125380, 144580, 0.5, 0.5);
            bggear6.Fade(125380, 144580, 0.5, 0.5);
            bggear66.Fade(125380, 144580, 0.5, 0.5);
            bggear5.Fade(125380, 144580, 0.5, 0.5);
            gear1.Fade(125380, 144580, 0.75, 0.75);
            gear11.Fade(125380, 144580, 0.75, 0.75);
            gear2.Fade(125380, 144580, 0.75, 0.75);
            gear22.Fade(125380, 144580, 0.75, 0.75);
            gear3.Fade(125380, 144580, 0.75, 0.75);
            gear4.Fade(125380, 144580, 0.75, 0.75);
            gear5.Fade(125380, 144580, 0.75, 0.75);
            gear6.Fade(125380, 144580, 0.75, 0.75);

            bggear1.Rotate(125380, 144580, 0, 40);
            bggear11.Rotate(125380, 144580, 0, 40);
            bggear111.Rotate(125380, 144580, 0, -40);
            bggear4.Rotate(125380, 144580, 0, -40);
            bggear44.Rotate(125380, 144580, 0, 40);
            bggear3.Rotate(125380, 144580, 0, 40);
            bggear33.Rotate(125380, 144580, 0, 40);
            bggear2.Rotate(125380, 144580, 0, -40);
            bggear22.Rotate(125380, 144580, 0, -40);
            bggear6.Rotate(125380, 144580, 0, -40);
            bggear66.Rotate(125380, 144580, 0, -40);
            bggear5.Rotate(125380, 144580, 0, 40);
            gear1.Rotate(125380, 144580, 0, 40);
            gear11.Rotate(125380, 144580, 0, 40);
            gear2.Rotate(125380, 144580, 0, -40);
            gear22.Rotate(125380, 144580, 0, -40);
            gear3.Rotate(125380, 144580, 0, -40);
            gear4.Rotate(125380, 144580, 0, 40);
            gear5.Rotate(125380, 144580, 0, -40);
            gear6.Rotate(125380, 144580, 0, 40);


            
        }
    }
}
