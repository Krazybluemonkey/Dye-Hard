using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Hades
{
	public class BlackHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Black Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 53;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BlackDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BlueHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 9;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BlueDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class BrownHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Brown Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 49;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.BrownDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class CyanHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cyan Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 7;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.CyanDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class GreenHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 5;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.GreenDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class LimeHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lime Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 4;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.LimeDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class OrangeHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orange Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 2;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.OrangeDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PinkHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pink Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 12;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PinkDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class PurpleHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 10;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.PurpleDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class RedHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 1;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.RedDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SilverHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 54;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SilverDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class SkyBlueHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sky Blue Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 8;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.SkyBlueDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class TealHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Teal Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 6;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.TealDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class VioletHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Violet Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 11;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.VioletDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class YellowHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Yellow Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 3;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.YellowDye);
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}
