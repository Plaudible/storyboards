using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Subtitles;
using System;
using System.Drawing;
using System.IO;

namespace StorybrewScripts
{
    public class GlitchLyrics : StoryboardObjectGenerator
    {
        [Configurable]
        public string SubtitlesPath = "lyrics.srt";

        [Configurable]
        public string FontName = "Verdana";

        [Configurable]
        public string SpritesPath = "sb/f";

        [Configurable]
        public int FontSize = 26;

        [Configurable]
        public float FontScale = 0.5f;

        [Configurable]
        public Color4 FontColor = Color4.White;

        [Configurable]
        public FontStyle FontStyle = FontStyle.Regular;

        [Configurable]
        public int GlowRadius = 0;

        [Configurable]
        public Color4 GlowColor = new Color4(255, 255, 255, 100);

        [Configurable]
        public bool AdditiveGlow = true;

        [Configurable]
        public int OutlineThickness = 3;

        [Configurable]
        public Color4 OutlineColor = new Color4(50, 50, 50, 200);

        [Configurable]
        public int ShadowThickness = 0;

        [Configurable]
        public Color4 ShadowColor = new Color4(0, 0, 0, 100);

        [Configurable]
        public Vector2 Padding = Vector2.Zero;

        [Configurable]
        public float SubtitleY = 400;

        [Configurable]
        public bool PerCharacter = true;

        [Configurable]
        public bool TrimTransparency = true;

        [Configurable]
        public bool EffectsOnly = false;

        [Configurable]
        public bool Debug = false;

        [Configurable]
        public OsbOrigin Origin = OsbOrigin.Centre;

        public override void Generate()
        {
            var font = LoadFont(SpritesPath, new FontDescription()
            {
                FontPath = FontName,
                FontSize = FontSize,
                Color = FontColor,
                Padding = Padding,
                FontStyle = FontStyle,
                TrimTransparency = TrimTransparency,
                EffectsOnly = EffectsOnly,
                Debug = Debug,
            },
            new FontGlow()
            {
                Radius = AdditiveGlow ? 0 : GlowRadius,
                Color = GlowColor,
            },
            new FontOutline()
            {
                Thickness = OutlineThickness,
                Color = OutlineColor,
            },
            new FontShadow()
            {
                Thickness = ShadowThickness,
                Color = ShadowColor,
            });

            var subtitles = LoadSubtitles(SubtitlesPath);

            if (GlowRadius > 0 && AdditiveGlow)
            {
                var glowFont = LoadFont(Path.Combine(SpritesPath, "glow"), new FontDescription()
                {
                    FontPath = FontName,
                    FontSize = FontSize,
                    Color = FontColor,
                    Padding = Padding,
                    FontStyle = FontStyle,
                    TrimTransparency = TrimTransparency,
                    EffectsOnly = true,
                    Debug = Debug,
                },
                new FontGlow()
                {
                    Radius = GlowRadius,
                    Color = GlowColor,
                });
                generateLyrics(glowFont, subtitles, "glow", true);
            }
            generateLyrics(font, subtitles, "", false);
        }

        public void generateLyrics(FontGenerator font, SubtitleSet subtitles, string layerName, bool additive)
        {
            var layer = GetLayer(layerName);
            if (PerCharacter) generatePerCharacter(font, subtitles, layer, additive);
            else generatePerLine(font, subtitles, layer, additive);
        }

        public void generatePerLine(FontGenerator font, SubtitleSet subtitles, StoryboardLayer layer, bool additive)
        {
            foreach (var line in subtitles.Lines)
            {
                var texture = font.GetTexture(line.Text);
                var position = new Vector2(320 - texture.BaseWidth * FontScale * 0.5f, SubtitleY)
                    + texture.OffsetFor(Origin) * FontScale;

                var sprite = layer.CreateSprite(texture.Path, Origin, position);
                var glitch1 = layer.CreateSprite(texture.Path, Origin, position);
                var glitch2 = layer.CreateSprite(texture.Path, Origin, position);
                sprite.Scale(OsbEasing.Out, line.StartTime, line.StartTime + 300, 0, FontScale * 0.9);
                sprite.Scale(OsbEasing.In, line.StartTime + 300, line.EndTime, FontScale * 0.9, FontScale);
                glitch1.Color(line.StartTime + 900,0.8,0.06,0.223);
                glitch2.Color(line.StartTime + 900,0.058,0.98,0.98);

                glitch1.Fade(line.StartTime + 300, line.StartTime + 400, 0, 0);
                glitch1.Fade(line.StartTime + 400, line.StartTime + 500, 0.25, 0.25);
                glitch1.Fade(line.StartTime + 500, line.EndTime, 0, 0);
                glitch1.Scale(OsbEasing.Out, line.StartTime, line.StartTime + 300, 0, FontScale * 0.9);
                glitch1.Scale(OsbEasing.In, line.StartTime + 300, line.EndTime, FontScale * 0.9, FontScale);
                glitch1.Move(line.StartTime+300, 317, 218);

                glitch2.Fade(line.StartTime + 350, line.StartTime + 450, 0, 0);
                glitch2.Fade(line.StartTime + 450, line.StartTime + 550, 0.25, 0.25);
                glitch2.Fade(line.StartTime + 550, line.EndTime, 0, 0);
                glitch2.Scale(OsbEasing.Out, line.StartTime, line.StartTime + 350, 0, FontScale * 0.9);
                glitch2.Scale(OsbEasing.In, line.StartTime + 350, line.EndTime, FontScale * 0.9, FontScale);
                glitch2.Move(line.StartTime+350, 323, 218);

                sprite.Fade(line.StartTime, line.EndTime, 1, 0); 
                if (additive) sprite.Additive(line.StartTime - 200, line.EndTime);
            }
        }

        public void generatePerCharacter(FontGenerator font, SubtitleSet subtitles, StoryboardLayer layer, bool additive)
        {
            foreach (var subtitleLine in subtitles.Lines)
            {
                var letterY = SubtitleY;
                foreach (var line in subtitleLine.Text.Split('\n'))
                {
                    var lineWidth = 0f;
                    var lineHeight = 0f;
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());
                        lineWidth += texture.BaseWidth * FontScale;
                        lineHeight = Math.Max(lineHeight, texture.BaseHeight * FontScale);
                    }

                    var letterX = 320 - lineWidth * 0.5f;
                    foreach (var letter in line)
                    {
                        var texture = font.GetTexture(letter.ToString());
                        if (!texture.IsEmpty)
                        {
                            var position = new Vector2(letterX, letterY)
                                + texture.OffsetFor(Origin) * FontScale;

                            var sprite = layer.CreateSprite(texture.Path, Origin, position);
                            sprite.Scale(subtitleLine.StartTime, FontScale);
                            sprite.Fade(subtitleLine.StartTime - 200, subtitleLine.StartTime, 0, 1);
                            sprite.Fade(subtitleLine.EndTime - 200, subtitleLine.EndTime, 1, 0);
                            if (additive) sprite.Additive(subtitleLine.StartTime - 200, subtitleLine.EndTime);
                        }
                        letterX += texture.BaseWidth * FontScale;
                    }
                    letterY += lineHeight;
                }
            }
        }
    }
}
