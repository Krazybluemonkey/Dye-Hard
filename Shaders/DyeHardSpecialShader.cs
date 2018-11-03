using System;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ModLoader;
using ShaderLib;

namespace DyeHard.Shaders
{
	public class DyeHardSpecialShader : ModArmorShaderData
	{
		bool IsPrimeColor = false;
		Vector3 PrimeColor = new Vector3(0f, 0f, 0f);
		bool IsSecondColor = false;
		Vector3 SecondColor = new Vector3(0f, 0f, 0f);
		int SpecialShader = 0;
		Mod mod = ModLoader.GetMod("DyeHard");
		bool UseSecond = false;

		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardSpecialShader() { }

		public DyeHardSpecialShader(string name, string passName, Vector3 p, Vector3 s, int special, bool sec)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			IsSecondColor = true;
			SecondColor = s;
			SpecialShader = special;
			UseSecond = sec;
		}

		public DyeHardSpecialShader(string name, string passName, Vector3 p, Vector3 s, float sat, int special, bool sec)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			IsSecondColor = true;
			SecondColor = s;
			UseSaturation(sat);
			SpecialShader = special;
			UseSecond = sec;
		}

		public DyeHardSpecialShader(string name, string passName, Vector3 p, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			SpecialShader = special;
		}

		public DyeHardSpecialShader(string name, string passName, Vector3 p, float sat, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			UseSaturation(sat);
			SpecialShader = special;
		}

		public DyeHardSpecialShader(string name, string passName, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			SpecialShader = special;
		}

		public DyeHardSpecialShader(string name, string passName, float sat, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSaturation(sat);
			SpecialShader = special;
		}

		public override void PreApply(Entity e, DrawData? drawData)
		{
			UseColor(PrimeColor);
			UseSecondaryColor(SecondColor);
			Vector3 newVector = new Vector3(0f, 0f, 0f);
			if (SpecialShader == 0) //life dye
			{

				Player player = e as Player;
				if (player == null) return;
				Vector3 vector = new Vector3(0.92f, 0f, 0f);
				if (IsPrimeColor)
				{
					vector = PrimeColor;
				}
				float resultX = ((float)player.statLife / (float)player.statLifeMax2 * vector.X + 0.08f);
				float resultY = ((float)player.statLife / (float)player.statLifeMax2 * vector.Y + 0.08f);
				float resultZ = ((float)player.statLife / (float)player.statLifeMax2 * vector.Z + 0.08f);
				if (vector.X <= 0.08f)
				{
					resultX = 0.08f;
				}
				if (vector.Y <= 0.08f)
				{
					resultY = 0.08f;
				}
				if (vector.Z <= 0.08f)
				{
					resultZ = 0.08f;
				}
				newVector = new Vector3(resultX, resultY, resultZ);
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 1) //mana dye
			{
				Player player = e as Player;
				if (player == null) return;
				Vector3 vector = new Vector3(0.8f, 0.7f, 1f);// 0.2f 0.3f
				if (IsPrimeColor)
				{
					vector = PrimeColor;
				}
				float resultX = ((1f - (float)player.statMana / (float)player.statManaMax2) * vector.X + (0.95f - vector.X));
				float resultY = ((1f - (float)player.statMana / (float)player.statManaMax2) * vector.Y + (0.95f - vector.Y));
				float resultZ = ((1f - (float)player.statMana / (float)player.statManaMax2) * vector.Z + (0.95f - vector.Z));
				if (vector.X >= 1f)
				{
					resultX = 1f;
				}
				if (vector.Y >= 1f)
				{
					resultY = 1f;
				}
				if (vector.Z >= 1f)
				{
					resultZ = 1f;
				}
				newVector = new Vector3(resultX, resultY, resultZ);
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 2) //depth dye
			{

				Player player = e as Player;
				if (player == null) return;
				float num29 = (float)(Main.worldSurface * 0.45) * 16f;
				float num30 = (float)(Main.worldSurface + Main.rockLayer) * 8f;
				float num31 = (float)(Main.rockLayer + (double)Main.maxTilesY) * 8f;
				float num32 = (float)(Main.maxTilesY - 150) * 16f;
				Vector2 center = player.Center;
				if (center.Y < num29)
				{
					float num33 = center.Y / num29;
					float num34 = 1f - num33;
					newVector.X = (0.45f * num34 + 0.1f * num33);
					newVector.Y = (0.63f * num34 + 0.85f * num33);
					newVector.Z = (0.97f * num34 + 0.36f * num33);
				}
				else if (center.Y < num30)
				{
					float num35 = num29;
					float num36 = (center.Y - num35) / (num30 - num35);
					float num37 = 1f - num36;
					newVector.X = (0.1f * num37 + 0.6f * num36);
					newVector.Y = (0.85f * num37 + 0.42f * num36);
					newVector.Z = (0.36f * num37 + 0.3f * num36);
				}
				else if (center.Y < num31)
				{
					float num38 = num30;
					float num39 = (center.Y - num38) / (num31 - num38);
					float num40 = 1f - num39;
					newVector.X = (0.6f * num40 + 0.5f * num39);
					newVector.Y = (0.42f * num40 + 0.5f * num39);
					newVector.Z = (0.3f * num40 + 0.5f * num39);
				}
				else if (center.Y < num32)
				{
					float num41 = num31;
					float num42 = (center.Y - num41) / (num32 - num41);
					float num43 = 1f - num42;
					newVector.X = (0.5f * num43 + 1f * num42);
					newVector.Y = (0.5f * num43 + 0.2f * num42);
					newVector.Z = (0.5f * num43 + 0.05f * num42);
				}
				else
				{
					newVector.X = 1f;
					newVector.Y = 0.2f;
					newVector.Z = 0.04f;
				}
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 3) //money dye
			{
				Player player = e as Player;
				if (player == null) return;
				int num17 = 0;
				for (int i = 0; i < 54; i++)
				{
					if (player.inventory[i].type == 71)
					{
						num17 += player.inventory[i].stack;
					}
					if (player.inventory[i].type == 72)
					{
						num17 += player.inventory[i].stack * 100;
					}
					if (player.inventory[i].type == 73)
					{
						num17 += player.inventory[i].stack * 10000;
					}
					if (player.inventory[i].type == 74)
					{
						num17 += player.inventory[i].stack * 1000000;
						if (num17 >= 2147483647)
						{
							num17 = 2147483647;
						}
					}
				}
				float num18 = (float)Item.buyPrice(0, 5, 0, 0);
				float num19 = (float)Item.buyPrice(0, 50, 0, 0);
				float num20 = (float)Item.buyPrice(2, 0, 0, 0);
				Vector3 color8 = new Vector3(0.89f, 0.47f, 0.3f);
				Vector3 color9 = new Vector3(0.69f, 0.76f, 0.76f);
				Vector3 color10 = new Vector3(0.8f, 0.71f, 0.29f);
				Vector3 color11 = new Vector3(0.64f, 0.68f, 0.68f);
				if ((float)num17 < num18)
				{
					float num21 = (float)num17 / num18;
					float num22 = 1f - num21;
					newVector.X = (color8.X * num22 + color9.X * num21);
					newVector.Y = (color8.Y * num22 + color9.Y * num21);
					newVector.Z = (color8.Z * num22 + color9.Z * num21);
				}
				else if ((float)num17 < num19)
				{
					float num24 = ((float)num17 - num18) / (num19 - num18);
					float num25 = 1f - num24;
					newVector.X = (color9.X * num25 + color10.X * num24);
					newVector.Y = (color9.Y * num25 + color10.Y * num24);
					newVector.Z = (color9.Z * num25 + color10.Z * num24);
				}
				else if ((float)num17 < num20)
				{
					float num27 = ((float)num17 - num19) / (num20 - num19);
					float num28 = 1f - num27;
					newVector.X = (color10.X * num28 + color11.X * num27);
					newVector.Y = (color10.Y * num28 + color11.Y * num27);
					newVector.Z = (color10.Z * num28 + color11.Z * num27);
				}
				else
				{
					newVector = color11;
				}
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 4) //time dye
			{
				Vector3 color4 = new Vector3(0.003f, 0.55f, 1f);
				Vector3 color5 = new Vector3(1f, 1f, 0f);
				Vector3 color6 = new Vector3(0.83f, 0.17f, 0.5f);
				Vector3 color7 = new Vector3(0.27f, 0.17f, 0.47f);
				if (Main.dayTime)
				{
					if (Main.time < 27000.0)
					{
						float num7 = (float)(Main.time / 27000.0);
						float num8 = 1f - num7;
						newVector.X = (color4.X * num8 + color5.X * num7);
						newVector.Y = (color4.Y * num8 + color5.Y * num7);
						newVector.Z = (color4.Z * num8 + color5.Z * num7);
					}
					else
					{
						float num9 = 27000f;
						float num10 = (float)((Main.time - (double)num9) / (54000.0 - (double)num9));
						float num11 = 1f - num10;
						newVector.X = (color5.X * num11 + color6.X * num10);
						newVector.Y = (color5.Y * num11 + color6.Y * num10);
						newVector.Z = (color5.Z * num11 + color6.Z * num10);
					}
				}
				else if (Main.time < 16200.0)
				{
					float num12 = (float)(Main.time / 16200.0);
					float num13 = 1f - num12;
					newVector.X = (color6.X * num13 + color7.X * num12);
					newVector.Y = (color6.Y * num13 + color7.Y * num12);
					newVector.Z = (color6.Z * num13 + color7.Z * num12);
				}
				else
				{
					float num14 = 16200f;
					float num15 = (float)((Main.time - (double)num14) / (32400.0 - (double)num14));
					float num16 = 1f - num15;
					newVector.X = (color7.X * num16 + color4.X * num15);
					newVector.Y = (color7.Y * num16 + color4.Y * num15);
					newVector.Z = (color7.Z * num16 + color4.Z * num15);
				}
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 5) //biome dye
			{
				newVector = ((Main.waterStyle != 2) ? ((Main.waterStyle != 3) ? ((Main.waterStyle != 4) ? ((Main.waterStyle != 5) ? ((Main.waterStyle != 6) ? ((Main.waterStyle != 7) ? ((Main.waterStyle != 8) ? ((Main.waterStyle != 9) ? ((Main.waterStyle != 10) ? new Vector3(0.11f, 0.85f, 0.36f) : new Vector3(0.82f, 0.31f, 0.31f)) : new Vector3(0.78f, 0f, 0f)) : new Vector3(0.5f, 0.5f, 0.5f)) : new Vector3(0.6f, 0.42f, 0.3f)) : new Vector3(0.91f, 0.86f, 0.4f)) : new Vector3(0.74f, 0.91f, 1f)) : new Vector3(0.31f, 0.75f, 0.9f)) : new Vector3(0.56f, 0.85f, 0.11f)) : new Vector3(0.49f, 0.47f, 0.94f));
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 6) //party dye, may delete
			{
				Player player = e as Player;
				if (player == null) return;
				newVector = new Vector3(0.95f, 0.09f, 0.69f);
				if (IsPrimeColor)
				{
					newVector = PrimeColor;
				}
				if (!Main.gameMenu && !Main.gamePaused)
				{
					if (Main.rand.Next(45) == 0)
					{
						int type = Main.rand.Next(139, 143);
						int num5 = Dust.NewDust(player.position, player.width, 8, type, 0f, 0f, 0, default(Color), 1.2f);
						Main.dust[num5].velocity.X *= 1f + (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.dust[num5].velocity.Y *= 1f + (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.dust[num5].velocity.X += (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.dust[num5].velocity.Y += (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.dust[num5].velocity.Y -= 1f;
						Main.dust[num5].scale *= 0.7f + (float)Main.rand.Next(-30, 31) * 0.01f;
						Dust obj = Main.dust[num5];
						obj.velocity += player.velocity * 0.2f;
					}
					if (Main.rand.Next(225) == 0)
					{
						int type2 = Main.rand.Next(276, 283);
						int num6 = Gore.NewGore(new Vector2(player.position.X + (float)Main.rand.Next(player.width), player.position.Y + (float)Main.rand.Next(8)), player.velocity, type2, 1f);
						Main.gore[num6].velocity.X *= 1f + (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.gore[num6].velocity.Y *= 1f + (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.gore[num6].scale *= 1f + (float)Main.rand.Next(-20, 21) * 0.01f;
						Main.gore[num6].velocity.X += (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.gore[num6].velocity.Y += (float)Main.rand.Next(-50, 51) * 0.01f;
						Main.gore[num6].velocity.Y -= 1f;
						Gore obj2 = Main.gore[num6];
						obj2.velocity += player.velocity * 0.2f;
					}
				}
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}

			if (SpecialShader == 7) //speed dye
			{
				Player player = e as Player;
				if (player == null) return;
				Vector3 vector = new Vector3(0f, 0f, 0f);
				if (IsPrimeColor)
				{
					vector = PrimeColor;
				}
				Vector3 vector2 = new Vector3(0.3f, 1f, 0.78f);
				if (UseSecond)
				{
					vector2 = SecondColor;
				}
				float num = Math.Abs(player.velocity.X) + Math.Abs(player.velocity.Y);
				float num2 = 10f;
				//if (num > num2)
				//{
				//    num = num2;
				//}
				float num3 = num / num2;
				float num4 = 1f - num3;
				newVector.X = (vector2.X * num3 + vector.X * num4);
				newVector.Y = (vector2.Y * num3 + vector.Y * num4);
				newVector.Z = (vector2.Z * num3 + vector.Z * num4);
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}
			
			if (SpecialShader == 8) //xna colors, use Color.*color*.ToVector3() as prime -unused-
			{
				newVector = PrimeColor;
				UseColor(newVector);
				if (!IsSecondColor)
				{
					SecondColor = newVector;
					UseSecondaryColor(SecondColor);
				}
			}
			//if (SpecialShader == 8)
			//{
			//    Player player = e as Player;
			//    if (player == null) return;
			//    Vector3 vector = new Vector3(0f, 0f, 0f);
			//    if (player.team >= 0 && player.team < Main.teamColor.Length)
			//    {
			//        vector = new Vector3(((float)Main.teamColor[player.team].R / 255), ((float)Main.teamColor[player.team].B / 255), ((float)Main.teamColor[player.team].G / 255));
			//    }
			//    UseColor(newVector);
			//    if (!IsSecondColor)
			//    {
			//        SecondColor = newVector;
			//        UseSecondaryColor(SecondColor);
			//    }
			//}
		}
	}
}