using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using ShaderLib;

namespace DyeHard.Shaders
{
	public class DyeHardRainbowShiftingShader : ModArmorShaderData
	{
		bool IsSecondColor;
		int RainbowStyle = 0;
		int ColorStyle = 0;
		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardRainbowShiftingShader() { }

		public DyeHardRainbowShiftingShader(string name, string passName, int rain, int color)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			RainbowStyle = rain;
			ColorStyle = color;
		}

		public DyeHardRainbowShiftingShader(string name, string passName, float sat, int rain, int color)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSaturation(sat);
			RainbowStyle = rain;
			ColorStyle = color;
		}

		public DyeHardRainbowShiftingShader(string name, string passName, Vector3 s, int rain, int color)
		{
			IsSecondColor = true;
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSecondaryColor(s);
			RainbowStyle = rain;
			ColorStyle = color;
		}

		public DyeHardRainbowShiftingShader(string name, string passName, Vector3 s, float sat, int rain, int color)
		{
			IsSecondColor = true;
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSecondaryColor(s);
			UseSaturation(sat);
			RainbowStyle = rain;
			ColorStyle = color;
		}

		public override void PreApply(Entity e, DrawData? drawData)
		{
			Color f = default(Color);
			Color s = default(Color);
			bool IsS = false;

			if (RainbowStyle == 0) //base dye
			{
				f = Main.DiscoColor;
			}

			if (RainbowStyle == 1) //flame, may need a rework
			{
				IsS = true;
				f = Main.DiscoColor;

				if (Main.DiscoR > 0)
				{
					s = new Color(Main.DiscoR, Main.DiscoG + (Main.DiscoG + 255), Main.DiscoB);
				}
				if (Main.DiscoG > 0)
				{
					s = new Color(Main.DiscoR + (Main.DiscoG + 255), Main.DiscoG + (Main.DiscoG + 255), Main.DiscoB);
				}
				if (Main.DiscoB > 0)
				{

					if (Main.DiscoG > 0)
					{
						s = new Color((Main.DiscoR + (Main.DiscoR + 255)) - Main.DiscoB, Main.DiscoG + (Main.DiscoB + 255), Main.DiscoB);
					}
					if (Main.DiscoR > 0)
					{
						s = new Color(Main.DiscoR, (Main.DiscoG + (Main.DiscoG + 255)) - Main.DiscoR, Main.DiscoB);
						if (Main.DiscoB < 255)
						{
							s = new Color(Main.DiscoR, (Main.DiscoG + (Main.DiscoG + 255)) - Main.DiscoB, Main.DiscoB);
						}
					}
				}
				if (s.R >= 255)
				{
					s.R = 255;
				}
				if (s.G >= 255)
				{
					s.G = 255;
				}
				if (s.B >= 255)
				{
					s.B = 255;
				}
			}

			//special dye with rainbow, unused
			if (RainbowStyle == 2)//life
			{
				Player player = e as Player;
				if (player == null) return;

				Color newColor = default(Color);

				newColor.R = (byte)((float)player.statLife / (float)player.statLifeMax2 * Main.DiscoR);
				newColor.G = (byte)((float)player.statLife / (float)player.statLifeMax2 * Main.DiscoG);
				newColor.B = (byte)((float)player.statLife / (float)player.statLifeMax2 * Main.DiscoB);

				if (newColor.R <= 20)
				{
					newColor.R = 20;
				}
				if (newColor.G <= 20)
				{
					newColor.G = 20;
				}
				if (newColor.B <= 20)
				{
					newColor.B = 20;
				}
				f = newColor;
			}

			if (RainbowStyle == 3)//mana
			{
				Player player = e as Player;
				if (player == null) return;

				Color newColor = default(Color);

				newColor.R = (byte)((1f - (float)player.statMana / (float)player.statManaMax2) * Main.DiscoR + (255 - Main.DiscoR));
				newColor.G = (byte)((1f - (float)player.statMana / (float)player.statManaMax2) * Main.DiscoG + (255 - Main.DiscoG));
				newColor.B = (byte)((1f - (float)player.statMana / (float)player.statManaMax2) * Main.DiscoB + (255 - Main.DiscoB));

				if (newColor.R >= 255)
				{
					newColor.R = 255;
				}
				if (newColor.G >= 255)
				{
					newColor.G = 255;
				}
				if (newColor.B >= 255)
				{
					newColor.B = 255;
				}
				f = newColor;
			}

			if (RainbowStyle == 4)//speed
			{
				Player player = e as Player;
				if (player == null) return;

				Color newColor = default(Color);

				float num = Math.Abs(player.velocity.X) + Math.Abs(player.velocity.Y);
				float num2 = 10f;
				if (num > num2)
				{
					num = num2;
				}
				float num3 = num / num2;
				float num4 = 1f - num3;
				newColor.R = (byte)(Main.DiscoR * num3 + 255 * num4);
				newColor.G = (byte)(Main.DiscoG * num3 + 255 * num4);
				newColor.B = (byte)(Main.DiscoB * num3 + 255 * num4);
				f = newColor;
			}
			//was going to use for wisp, may still..
			if (RainbowStyle == 5)
			{
				IsS = true;
				f = Main.DiscoColor;
				s = new Color(Main.DiscoR - 160, Main.DiscoG - 160, Main.DiscoB - 160);
			}
			if (ColorStyle == 1) //bright
			{
				f = new Color(f.R / 2 + 127, f.G / 2 + 127, f.B / 2 + 127);
				s = new Color(s.R / 2 + 127, s.G / 2 + 127, s.B / 2 + 127);
			}
			if (ColorStyle == 2) //dim
			{
				f = new Color(f.R / 2, f.G / 2, f.B / 2);
				s = new Color(s.R / 2, s.G / 2, s.B / 2);
			}


			UseColor(f);
			if (!IsSecondColor && !IsS)
			{
				UseSecondaryColor(f);
			}
			else
			{
				UseSecondaryColor(s);
			}
		}
	}
}