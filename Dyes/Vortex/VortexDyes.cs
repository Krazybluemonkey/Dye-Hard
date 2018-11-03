using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Vortex
{
	public class BlackVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BlackDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BlueVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 9;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BlueDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BrownVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BrownDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class CyanVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyan Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 7;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.CyanDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class GreenVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 5;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GreenDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class LimeVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lime Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 4;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.LimeDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class OrangeVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 2;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.OrangeDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PinkVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PinkDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PurpleVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PurpleDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class RedVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.RedDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SilverVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 54;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SilverDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SkyBlueVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Blue Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 8;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SkyBlueDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class VioletVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violet Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 11;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.VioletDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class YellowVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 3;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.YellowDye);
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}