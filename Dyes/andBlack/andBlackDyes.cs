using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.andBlack
{
	
	public class BlackandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightBlackandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Black and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightBlackDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightBlueandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Blue and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 21;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightBlueDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightBrownandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Brown and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 50;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightBrownDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightCyanandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Cyan and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 19;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightCyanDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightGreenandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Green and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 17;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightGreenDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightLimeandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Lime and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 16;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightLimeDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightOrangeandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Orange and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 14;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightOrangeDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightPinkandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Pink and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 24;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightPinkDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightPurpleandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Purple and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 22;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightPurpleDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightRedandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Red and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightSilverandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Silver and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 54;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightSilverDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightSkyBlueandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Sky Blue and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 20;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightSkyBlueDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightTealandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Teal and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 18;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightTealDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightVioletandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Violet and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 23;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightVioletDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightYellowandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Yellow and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 15;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrightYellowDye);
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DimBlackandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Black and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimBlackDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DimBlueandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Blue and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 21;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimBlueDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimBrownandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Brown and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 50;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimBrownDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimCyanandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Cyan and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 19;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimCyanDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimGreenandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Green and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 17;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimGreenDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimLimeandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Lime and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 16;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimLimeDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimOrangeandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Orange and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 14;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimOrangeDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimPinkandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Pink and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 24;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimPinkDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimPurpleandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Purple and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 22;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimPurpleDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimRedandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Red and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimRedDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DimSilverandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Silver and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 54;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimSilverDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimSkyBlueandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Sky Blue and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 20;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimSkyBlueDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimTealandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Teal and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 18;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimTealDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	public class DimVioletandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Violet and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 23;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimVioletDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimYellowandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Yellow and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 15;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimYellowDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class FleshRedandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flesh Red and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshRedDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class GrossBrownandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gross Brown and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 50;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrossBrownDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class GrossPinkandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gross Pink and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 24;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrossPinkDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class RottenBrownandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Brown and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 50;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RottenBrownDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class RottenGreenandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rotten Green and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 17;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RottenGreenDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class ShadowPurpleandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shadow Purple and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 22;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowPurpleDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class ViciousRedandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vicious Red and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 13;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ViciousRedDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class VilePurpleandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vile Purple and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 22;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "VilePurpleDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
