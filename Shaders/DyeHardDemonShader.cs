using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ModLoader;
using ShaderLib;

namespace DyeHard.Shaders
{
	public class DyeHardDemonShader : ModArmorShaderData
	{
		int DemonShader = 0;
		Mod mod = ModLoader.GetMod("DyeHard");
		bool UseSecond = false;

		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardDemonShader() { }

		public DyeHardDemonShader(string name, string passName, int demon, bool sec)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			DemonShader = demon;
			UseSecond = sec;
		}

		public DyeHardDemonShader(string name, string passName, float sat, int demon, bool sec)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSaturation(sat);
			DemonShader = demon;
			UseSecond = sec;
		}

		public override void PreApply(Entity e, DrawData? drawData)
		{
			Vector3 newVector = new Vector3(0f, 0f, 0f);
            switch (DemonShader)
            {
                case 0://demon flame dye
                    newVector = new Vector3(0.5f * Main.demonTorch + 1f * (1f - Main.demonTorch), 0.3f, 1f * Main.demonTorch + 0.5f * (1f - Main.demonTorch));
                    UseColor(newVector);
                    if (UseSecond)
                    {
                        UseSecondaryColor(newVector);
                    }
                    break;
                case 1://crystal shine dye
                    Color color = Main.hslToRgb(Main.demonTorch * 0.12f + 0.69f, 1f, 0.75f);
                    newVector = color.ToVector3() * 1.2f;
                    UseColor(newVector);
                    if (UseSecond)
                    {
                        UseSecondaryColor(newVector);
                    }
                    break;
                case 2://star light dye
                    newVector = new Vector3(0.9f - (Main.demonTorch * 0.2f), 0.9f - (Main.demonTorch * 0.2f), 0.7f + (Main.demonTorch * 0.2f));
                    UseColor(newVector);
                    if (UseSecond)
                    {
                        UseSecondaryColor(newVector);
                    }
                    break;
                case 3://determined heart dye
                    newVector = new Vector3(1f - (Main.demonTorch * 0.1f), 0.3f - (Main.demonTorch * 0.2f), 0.5f + (Main.demonTorch * 0.2f));
                    UseColor(newVector);
                    if (UseSecond)
                    {
                        UseSecondaryColor(newVector);
                    }
                    break;
            }
		}
	}
}