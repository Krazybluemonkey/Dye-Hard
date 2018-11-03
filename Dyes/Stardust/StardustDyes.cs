using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Stardust
{
	public class BlackStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BlueStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BrownStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class CyanStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyan Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class GreenStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class LimeStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lime Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class OrangeStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PinkStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Stardust Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PinkDye);
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PurpleStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class RedStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SilverStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class TealStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teal Stardust Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 6;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.TealDye);
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class VioletStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violet Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class YellowStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Stardust Dye");
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
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}