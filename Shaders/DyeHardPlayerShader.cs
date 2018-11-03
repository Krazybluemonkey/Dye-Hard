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
		Mod mod = ModLoader.GetMod("DyeHard");
		bool UseSecond = false;

		public override bool Autoload() => false;

		private string _name;
		public override string Name => _name;

		public DyeHardPlayerShader() { }

		public DyeHardPlayerShader(string name, string passName, Vector3 p, Vector3 s, int special, bool sec)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			IsSecondColor = true;
			SecondColor = s;
			PlayerShader = special;
			UseSecond = sec;
		}

		public DyeHardPlayerShader(string name, string passName, Vector3 p, Vector3 s, float sat, int special, bool sec)
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
			UseSecond = sec;
		}

		public DyeHardPlayerShader(string name, string passName, Vector3 p, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			PlayerShader = special;
		}

		public DyeHardPlayerShader(string name, string passName, Vector3 p, float sat, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			IsPrimeColor = true;
			PrimeColor = p;
			UseSaturation(sat);
			PlayerShader = special;
		}

		public DyeHardPlayerShader(string name, string passName, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			PlayerShader = special;
		}

		public DyeHardPlayerShader(string name, string passName, float sat, int special)
		{
			_name = name;
			PassName = passName;
			UseImage("Images/Misc/noise");
			UseSaturation(sat);
			PlayerShader = special;
		}

		public override void PreApply(Entity e, DrawData? drawData)
		{
			UseColor(PrimeColor);
			UseSecondaryColor(SecondColor);
			Vector3 newVector = new Vector3(0f, 0f, 0f);
			if (PlayerShader == 0)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].hairColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].hairColor);
				}
			}

			if (PlayerShader == 1)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].eyeColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].eyeColor);
				}
			}

			if (PlayerShader == 2)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].skinColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].skinColor);
				}
			}

			if (PlayerShader == 3)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].shirtColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].shirtColor);
				}
			}

			if (PlayerShader == 4)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].underShirtColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].underShirtColor);
				}
			}

			if (PlayerShader == 5)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].pantsColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].pantsColor);
				}
			}

			if (PlayerShader == 6)
			{
				Player player = e as Player;
				if (player == null) return;
				UseColor(Main.player[Main.myPlayer].shoeColor);
				if (!IsSecondColor)
				{
					UseSecondaryColor(Main.player[Main.myPlayer].shoeColor);
				}
			}
		}
	}
}