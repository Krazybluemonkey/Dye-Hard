using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Player
{
	public class FamiliarDyeHair : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Hair)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].hairColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyeEye : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Eyes)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].eyeColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyeSkin : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Skin)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].skinColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyeShirt : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Shirt)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].shirtColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyeUndershirt : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Undershirt)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].underShirtColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyePants : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Pants)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].pantsColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
	
	public class FamiliarDyeShoe : ModItem
	{
		public override string Texture
		{
			get
			{
				return "DyeHard/Dyes/Player/FamiliarDye";
			}
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar Dye (Shoes)");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.color = Main.player[Main.myPlayer].shoeColor;
			item.rare = 0;
			item.dye = 54;
		}
	}
}
