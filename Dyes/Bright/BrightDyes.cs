using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Bright
{
	public class BrightBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Black Dye");
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
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightFleshRedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Flesh Red Dye");
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
			recipe.AddIngredient(mod, "FleshRedDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightGrossBrownDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Gross Brown Dye");
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
			recipe.AddIngredient(mod, "GrossBrownDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightGrossPinkDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Gross Pink Dye");
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
			recipe.AddIngredient(mod, "GrossPinkDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightRottenBrownDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Rotten Brown Dye");
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
			recipe.AddIngredient(mod, "RottenBrownDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightRottenGreenDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Rotten Green Dye");
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
			recipe.AddIngredient(mod, "RottenGreenDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightShadowPurpleDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shadow Purple Dye");
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
			recipe.AddIngredient(mod, "ShadowPurpleDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightViciousRedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Vicious Red Dye");
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
			recipe.AddIngredient(mod, "ViciousRedDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BrightVilePurpleDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Vile Purple Dye");
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
			recipe.AddIngredient(mod, "VilePurpleDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class LightDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Light Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 55;
		}
	}
}
