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
    public class ScrollingText : StoryboardObjectGenerator
    {
        //Class variable 
        private FontGenerator font;
        //Cursor placement
        private int cursorPositionY = 50;
        private int cursorPositionX = -100;

        private OsbSprite cursor;

        [Configurable]
        public int startTime = 43385;

        [Configurable]
        public int endTime = 63385;

        public override void Generate()
        {   
            SetupFont();

            cursor = GetLayer("FONTS").CreateSprite("sb/bar.png",OsbOrigin.Centre, new Vector2(cursorPositionX, cursorPositionY));
            cursor.Fade(startTime, endTime, 1, 1);
            cursor.Scale(startTime, 1);

            //sample text generation for sprites
            //String input = "Test test test";
            //font.GetTexture(input);

            GenerateText(43385, "Initializing rebooting sequence...");
            GenerateText(44052, "void kernel_restart_beatmap(char *cmd)");
            GenerateText(44719, "{");
            GenerateText(44802, "   blocking_circle_combo_chain(&reboot_note_list, OSU_RESTART, cmd);");
            GenerateText(45885, "   game_state = CORRUPTED;");
            GenerateText(46219, "   gamestate_disable();");
            GenerateText(46552, "   device_shutdown();");
            GenerateText(46885, "}");

            GenerateText(46969, "void migrate_to_reboot_osu(void)");
            GenerateText(47409, "{");
            GenerateText(47469, "   /* The boot is always logical 0 */");
            GenerateText(47969, "   int osu = reboot_osu;");
            GenerateText(48302, "   osu_hotplug_disable();");
            GenerateText(48702, "   if (!osu_online(acct))");
            GenerateText(49052, "       osu = osulogout_first(osu_online_mask);");
            GenerateText(49634, "");
            GenerateText(49635, "   current->flags |= PF_NO_SETAFFINITY;");
            GenerateText(50135, "");
            GenerateText(50136, "   set_amnt_allowed_ptr(current, osumask_of(acct));");
            GenerateText(50802, "}");

            GenerateText(50805, "void kernel_restart(char *cmd)");
            GenerateText(51302, "{");
            GenerateText(51320, "   syscore_shutdown();");
            GenerateText(51635, "   pr_emerg(\"Restarting beatmap\");");
            GenerateText(52052, "   kmsg_dump(KMSG_DUMP_SHUTDOWN);");
            GenerateText(52552, "}");
            GenerateText(52719, "Missing reboot operatives, attempting force shut down...");
            GenerateText(54052, "");
            GenerateText(54052, "");

            /*
            GenerateTextScroll(54052, "CRITICAL STRUCTURE CORRUPTION!");
            GenerateTextScroll(54052, "struct group_info *groups_alloc(int gidsetsize)");
            GenerateTextScroll(54052, "{");
            GenerateTextScroll(54052, "     struct group_info *group_info;");
            GenerateTextScroll(54052, "     int nblocks;");
            GenerateTextScroll(54052, "     int i;");
            GenerateTextScroll(54052, "");
            GenerateTextScroll(54052, "     nblocks = (gidsetsize + NGROUPS_PER_BLOCK - 1) / NGROUPS_PER_BLOCK;");

            GenerateTextScroll(54052, "     /* Make sure we always allocate at least one indirect block pointer");
            GenerateTextScroll(54052, "     nblocks = nblocks ? : 1;");
            GenerateTextScroll(54052, "     group_info = kmalloc(sizeof(*group_info) + nblocks*sizeof(gid_t *), GFP_USER);");
            GenerateTextScroll(54052, "     if (!group_info)");
            GenerateTextScroll(54052, "     return NULL;");
            GenerateTextScroll(54052, "     group_info->ngroups = gidsetsize;");
            GenerateTextScroll(54052, "     group_info->nblocks = nblocks;");
            GenerateTextScroll(54052, "     atomic_set(&group_info->usage, 1);");
            GenerateTextScroll(54052, "");
            GenerateTextScroll(54052, "     if (gidsetsize <= NGROUPS_SMALL)");
            GenerateTextScroll(54052, "         group_info->blocks[0] = group_info->small_block;");

            GenerateTextScroll(54052, "     else {");
            GenerateTextScroll(54052, "         for (i = 0; i < nblocks; i++) {");
            GenerateTextScroll(54052, "             gid_t *b;");
            GenerateTextScroll(54052, "             b = (void *)__get_free_page(GFP_USER);");
            GenerateTextScroll(54052, "             if (!b)");
            GenerateTextScroll(54052, "                 goto out_undo_partial_alloc;");
            GenerateTextScroll(54052, "             group_info->blocks[i] = b;");
            GenerateTextScroll(54052, "         }");
            GenerateTextScroll(54052, "     }");
            GenerateTextScroll(54052, "return group_info;");
            */
        }

        private void SetupFont()
        {
            this.font = LoadFont("sb/f/code", new FontDescription{
                FontPath = "RobotoMono.ttf",
                Color = Color4.White
            });
        }

        private void GenerateText(int startTime, String text){
            cursor.MoveY(startTime, cursorPositionY);
            cursorPositionX = -50;
            int delay = 0;
            foreach(var letter in text){
                //generate new image file
                var texture = font.GetTexture(letter.ToString());

                if (!texture.IsEmpty){
                    //generate sprite
                    var sprite = GetLayer("FONTS").CreateSprite(texture.Path, OsbOrigin.CentreLeft, new Vector2(cursorPositionX, cursorPositionY));
                    //display sprite
                    sprite.Fade(startTime + delay, endTime - 2000, 0.4, 0.4);
                    //sprite.Fade(endTime, endTime, 0, 0);
                    sprite.Scale(startTime + delay, 0.12f);

                    delay += Random(5, 25);
                    if (sprite.PositionAt(54052).Y < 0){

                    }
                }
                cursorPositionX += 8;
                cursor.MoveX(startTime + delay, cursorPositionX + 8);
            }
            cursorPositionY += 15;
        }
    }
}
