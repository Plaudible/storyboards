using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class SquareMove : StoryboardObjectGenerator
    {
        [Configurable]
        public int StartTime = 0;

        [Configurable]
        public int EndTime = 0;
        public override void Generate()
        {
            Random rnd = new Random();
		    var layer = GetLayer("Main");
            var layer2 = GetLayer("Foreground");

            var box = layer2.CreateSprite("sb/box.png", OsbOrigin.Centre);
            
            OsbSprite[] boxes = new OsbSprite[61];

            box.Fade(114157, 128021, 1, 1);
            box.Scale(OsbEasing.OutExpo, 114157,114612, 0, 0.6);
            box.Color(114157, 0.5, 0.5, 0.9);

            int timeBuffer = 0;
            int lastval = 0;
            for (int i = 0; i <= 60; i++){
            
                int direction = rnd.Next(1, 4);
                if (lastval == 3 && direction == 1){
                    direction = 2;
                }
                if (lastval == 1 && direction == 3){
                    direction = 2;
                }

                var boxExtra = layer.CreateSprite("sb/box.png", OsbOrigin.Centre);
                boxExtra.Scale(StartTime + timeBuffer, 0.6);
                boxes[i] = boxExtra;

                if (direction == 1){
                    boxExtra.Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, box.PositionAt(StartTime + timeBuffer).X, box.PositionAt(StartTime + timeBuffer).Y , box.PositionAt(StartTime + timeBuffer).X, box.PositionAt(StartTime + timeBuffer).Y + 150);
                }
                if (direction == 2){
                    boxExtra.Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, box.PositionAt(StartTime + timeBuffer).X, box.PositionAt(StartTime + timeBuffer).Y , box.PositionAt(StartTime + timeBuffer).X - 150, box.PositionAt(StartTime + timeBuffer).Y);
                }
                if (direction == 3){
                    boxExtra.Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, box.PositionAt(StartTime + timeBuffer).X, box.PositionAt(StartTime + timeBuffer).Y , box.PositionAt(StartTime + timeBuffer).X, box.PositionAt(StartTime + timeBuffer).Y - 150);
                }

                if (i >= 1){
                    if (direction == 1){
                        boxes[i-1].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-1].PositionAt(StartTime + timeBuffer).X, boxes[i-1].PositionAt(StartTime + timeBuffer).Y , boxes[i-1].PositionAt(StartTime + timeBuffer).X, boxes[i-1].PositionAt(StartTime + timeBuffer).Y + 150);
                    }
                    if (direction == 2){
                        boxes[i-1].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-1].PositionAt(StartTime + timeBuffer).X, boxes[i-1].PositionAt(StartTime + timeBuffer).Y , boxes[i-1].PositionAt(StartTime + timeBuffer).X - 150, boxes[i-1].PositionAt(StartTime + timeBuffer).Y);
                    }
                    if (direction == 3){
                        boxes[i-1].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-1].PositionAt(StartTime + timeBuffer).X, boxes[i-1].PositionAt(StartTime + timeBuffer).Y , boxes[i-1].PositionAt(StartTime + timeBuffer).X, boxes[i-1].PositionAt(StartTime + timeBuffer).Y - 150);
                    }
                    
                }

                if (i >= 2){
                    if (direction == 1){
                        boxes[i-2].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-2].PositionAt(StartTime + timeBuffer).X, boxes[i-2].PositionAt(StartTime + timeBuffer).Y , boxes[i-2].PositionAt(StartTime + timeBuffer).X, boxes[i-2].PositionAt(StartTime + timeBuffer).Y + 150);
                    }
                    if (direction == 2){
                        boxes[i-2].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-2].PositionAt(StartTime + timeBuffer).X, boxes[i-2].PositionAt(StartTime + timeBuffer).Y , boxes[i-2].PositionAt(StartTime + timeBuffer).X - 150, boxes[i-2].PositionAt(StartTime + timeBuffer).Y);
                    }
                    if (direction == 3){
                        boxes[i-2].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-2].PositionAt(StartTime + timeBuffer).X, boxes[i-2].PositionAt(StartTime + timeBuffer).Y , boxes[i-2].PositionAt(StartTime + timeBuffer).X, boxes[i-2].PositionAt(StartTime + timeBuffer).Y - 150);
                    }
                    
                }

                if (i >= 3){
                    if (direction == 1){
                        boxes[i-3].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-3].PositionAt(StartTime + timeBuffer).X, boxes[i-3].PositionAt(StartTime + timeBuffer).Y , boxes[i-3].PositionAt(StartTime + timeBuffer).X, boxes[i-3].PositionAt(StartTime + timeBuffer).Y + 150);
                    }
                    if (direction == 2){
                        boxes[i-3].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-3].PositionAt(StartTime + timeBuffer).X, boxes[i-3].PositionAt(StartTime + timeBuffer).Y , boxes[i-3].PositionAt(StartTime + timeBuffer).X - 150, boxes[i-3].PositionAt(StartTime + timeBuffer).Y);
                    }
                    if (direction == 3){
                        boxes[i-3].Move(OsbEasing.OutExpo, StartTime + timeBuffer, StartTime + timeBuffer + 226, boxes[i-3].PositionAt(StartTime + timeBuffer).X, boxes[i-3].PositionAt(StartTime + timeBuffer).Y , boxes[i-3].PositionAt(StartTime + timeBuffer).X, boxes[i-3].PositionAt(StartTime + timeBuffer).Y - 150);
                    }
                    
                }
                boxExtra.Fade(StartTime + timeBuffer, StartTime + timeBuffer + 750, 1,1);
                boxExtra.Fade(StartTime + timeBuffer + 750, StartTime + timeBuffer + 1000, 1,0);
                timeBuffer += 226;
                lastval = direction;

                
            }
            box.Scale(OsbEasing.InExpo, 127793, 128021, 0.6, 0);
        }
    }
}

/*
var box = layer2.CreateSprite("sb/box.png", OsbOrigin.Centre);
            box.Fade(114157, 127793, 1, 1);
            box.Scale(OsbEasing.OutExpo, 114157,114612, 0, 0.6);
            box.Color(114157, 0.5, 0.5, 0.9);

            
            OsbSprite[,] boxes = new OsbSprite[5,9];
            boxes[2,4] = box;

            int timeBuffer = 0;
            for (int i = 0; i <= 60; i++){ //num repetitions
                int direction = Random(1,4);
                if (direction == 1){
                    for (int j = 0; j < 3; j++){ //iterate rows
                        for (int k = 0; k < 7; k++){ //iterate columns
                            
                        }
                    }
                }
            }
*/