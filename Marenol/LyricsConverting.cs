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
using System.IO;

namespace StorybrewScripts
{
    public class LyricsConverting : StoryboardObjectGenerator
    {
        [Configurable]
        public string InputFile = "lyrics.txt";

        [Configurable]
        public string OutputFile = "lyrics.srt";

        public override void Generate()
        {
            using (var stream = OpenProjectFile(InputFile))
            using (var reader = new StreamReader(stream, System.Text.Encoding.UTF8))
            using (StreamWriter write = new StreamWriter(ProjectPath + "\\" + OutputFile))
            {
                string[] word = new string[30000];
                int[] start = new int[30000];
                int[] end = new int[30000];
                int[] smin = new int[30000];
                int[] ssec = new int[30000];
                int[] smsec = new int[30000];
                int[] emin = new int[30000];
                int[] esec = new int[30000];
                int[] emsec = new int[30000];
                int i = 1;
                int count = 0;
                foreach (string st in File.ReadAllLines(ProjectPath + "\\" + InputFile))
                {
                    word[i] = st.Split(',')[0];
                    start[i] = int.Parse(st.Split(',')[1]);
                    end[i] = int.Parse(st.Split(',')[2]);
                    smin[i] = start[i] / 60000;
                    ssec[i] = (start[i] - smin[i] * 60000) / 1000;
                    smsec[i] = start[i] - smin[i] * 60000 - ssec[i] * 1000;
                    emin[i] = end[i] / 60000;
                    esec[i] = (end[i] - emin[i] * 60000) / 1000;
                    emsec[i] = end[i] - emin[i] * 60000 - esec[i] * 1000;
                    i++;
                    count++;
                }
                string smin1, ssec1, smsec1, emin1, esec1, emsec1;
                for (int a = 1; a <= count; a++)
                {
                    smin1 = String.Format("{0:00}", smin[a]);
                    ssec1 = String.Format("{0:00}", ssec[a]);
                    smsec1 = String.Format("{0:000}", smsec[a]);
                    emin1 = String.Format("{0:00}", emin[a]);
                    esec1 = String.Format("{0:00}", esec[a]);
                    emsec1 = String.Format("{0:000}", emsec[a]);
                    write.WriteLine(a);
                    write.WriteLine("00:{0}:{1},{2} --> 00:{3}:{4},{5}", smin1, ssec1, smsec1, emin1, esec1, emsec1);
                    write.WriteLine(word[a]);
                    write.WriteLine();
                }
            }
        }
    }
}
