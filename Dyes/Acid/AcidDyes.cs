using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Acid
{
	public class PureRedAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Red Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.RedDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class OrangeAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 2;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.OrangeDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class YellowAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 3;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.YellowDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class LimeAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lime Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 4;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.LimeDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PureGreenAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Green Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 5;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GreenDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class TealAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teal Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 6;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.TealDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class CyanAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyan Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 7;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.CyanDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SkyBlueAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Blue Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 8;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SkyBlueDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PureBlueAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pure Blue Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 9;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BlueDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PurpleAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PurpleDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class VioletAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violet Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 11;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.VioletDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PinkAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PinkDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BrownAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BrownDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SilverAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 54;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SilverDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BlackAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.YellowDye);
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}
