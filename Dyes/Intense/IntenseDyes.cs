using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Intense
{
	public class IntenseBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Black Dye");
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
			recipe.AddIngredient(ItemID.BlackDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseBlueDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Blue Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 9;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BlueDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseBrownDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Brown Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BrownDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseCyanDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Cyan Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 7;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CyanDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseGreenDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Green Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 5;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.GreenDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseLimeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Lime Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 4;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LimeDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseOrangeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Orange Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 2;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.OrangeDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntensePinkDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Pink Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PinkDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntensePurpleDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Purple Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurpleDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseRedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Red Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RedDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Silver Dye");
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
			recipe.AddIngredient(ItemID.SilverDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseSkyBlueDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Sky Blue Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 8;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SkyBlueDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseTealDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Teal Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 6;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TealDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseVioletDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Violet Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 11;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.VioletDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseYellowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Yellow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 3;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.YellowDye, 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class IntenseFleshRedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Flesh Red Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "FleshRedDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseGrossBrownDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Gross Brown Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrossBrownDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseGrossPinkDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Gross Pink Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "GrossPinkDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseRottenBrownDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Rotten Brown Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RottenBrownDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseRottenGreenDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Rotten Green Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 5;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "RottenGreenDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseShadowPurpleDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Shadow Purple Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShadowPurpleDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseViciousRedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Vicious Red Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ViciousRedDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseVilePurpleDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Vile Purple Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "VilePurpleDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
