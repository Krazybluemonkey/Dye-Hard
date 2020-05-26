using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ModLoader;
using ShaderLib;

namespace DyeHard.Shaders
{
    public class DyeHardPlayerShader : ModArmorShaderData
    {
        bool IsPrimeColor = false;
        Vector3 PrimeColor = new Vector3(0f, 0f, 0f);
        bool IsSecondColor = false;
        Vector3 SecondColor = new Vector3(0f, 0f, 0f);
        int PlayerShader = 0;
        int ColorStyle = 0;
        Mod mod = ModLoader.GetMod("DyeHard");
        bool UseSecond = false;

        public override bool Autoload() => false;

        private string _name;
        public override string Name => _name;

        public DyeHardPlayerShader() { }

        public DyeHardPlayerShader(string name, string passName, Vector3 p, Vector3 s, int special, int color, bool sec)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            IsPrimeColor = true;
            PrimeColor = p;
            IsSecondColor = true;
            SecondColor = s;
            PlayerShader = special;
            ColorStyle = color;
            UseSecond = sec;
        }

        public DyeHardPlayerShader(string name, string passName, Vector3 p, Vector3 s, float sat, int special, int color, bool sec)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            IsPrimeColor = true;
            PrimeColor = p;
            IsSecondColor = true;
            SecondColor = s;
            UseSaturation(sat);
            PlayerShader = special;
            ColorStyle = color;
            UseSecond = sec;
        }

        public DyeHardPlayerShader(string name, string passName, Vector3 p, int special, int color)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            IsPrimeColor = true;
            PrimeColor = p;
            PlayerShader = special;
            ColorStyle = color;
        }

        public DyeHardPlayerShader(string name, string passName, Vector3 p, float sat, int special, int color)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            IsPrimeColor = true;
            PrimeColor = p;
            UseSaturation(sat);
            PlayerShader = special;
            ColorStyle = color;
        }

        public DyeHardPlayerShader(string name, string passName, int special, int color)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            PlayerShader = special;
            ColorStyle = color;
        }

        public DyeHardPlayerShader(string name, string passName, float sat, int special, int color)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            UseSaturation(sat);
            PlayerShader = special;
            ColorStyle = color;
        }

        public DyeHardPlayerShader(string name, string passName, int special, int color, bool sec)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            PlayerShader = special;
            ColorStyle = color;
            UseSecond = sec;
        }

        public DyeHardPlayerShader(string name, string passName, float sat, int special, int color, bool sec)
        {
            _name = name;
            PassName = passName;
            UseImage("Images/Misc/noise");
            UseSaturation(sat);
            PlayerShader = special;
            ColorStyle = color;
            UseSecond = sec;
        }

        public override void PreApply(Entity e, DrawData? drawData)
        {
            Color p = default(Color);
            Color s = default(Color);
            Vector3 newVector = new Vector3(0f, 0f, 0f);
            if (PlayerShader == 0)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].hairColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].hairColor;
                }
            }

            if (PlayerShader == 1)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].eyeColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].eyeColor;
                }
            }

            if (PlayerShader == 2)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].skinColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].skinColor;
                }
            }

            if (PlayerShader == 3)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].shirtColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].shirtColor;
                }
            }

            if (PlayerShader == 4)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].underShirtColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].underShirtColor;
                }
            }

            if (PlayerShader == 5)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].pantsColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].pantsColor;
                }
            }

            if (PlayerShader == 6)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].shoeColor;
                if (!IsSecondColor)
                {
                    s = Main.player[Main.myPlayer].shoeColor;
                }
            }

            if (PlayerShader == 7)//flame dyes(shirt->undershirt)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].shirtColor;
                s = Main.player[Main.myPlayer].underShirtColor;
                IsSecondColor = true;
            }

            if (PlayerShader == 8)//flame dyes(pants->shoe)
            {
                Player player = e as Player;
                if (player == null) return;
                p = Main.player[Main.myPlayer].pantsColor;
                s = Main.player[Main.myPlayer].shoeColor;
                IsSecondColor = true;
            }

            if (ColorStyle == 1) //bright
            {
                p = new Color(p.R / 2 + 127, p.G / 2 + 127, p.B / 2 + 127);
                s = new Color(s.R / 2 + 127, s.G / 2 + 127, s.B / 2 + 127);
            }
            if (ColorStyle == 2) //dim
            {
                p = new Color(p.R / 2, p.G / 2, p.B / 2);
                s = new Color(s.R / 2, s.G / 2, s.B / 2);
            }

            UseColor(p);
            if (!IsSecondColor)
            {
                UseSecondaryColor(p);
            }
            else
            {
                UseSecondaryColor(s);
            }
        }
    }
}