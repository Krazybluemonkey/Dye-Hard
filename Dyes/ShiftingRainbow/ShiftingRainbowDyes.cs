using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.ShiftingRainbow
{
	public class BrightShiftingRainbowandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightShiftingRainbowandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow and Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightShiftingRainbowFlameandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow Flame and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightShiftingRainbowFlameandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow Flameand Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class BrightShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bright Shifting Rainbow Flame Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowDye");
			recipe.AddIngredient(ItemID.FlameDye);
			recipe.AddIngredient(ItemID.GreenFlameDye);
			recipe.AddIngredient(ItemID.BlueFlameDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow and Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow Flame Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowDye");
			recipe.AddIngredient(ItemID.FlameDye);
			recipe.AddIngredient(ItemID.GreenFlameDye);
			recipe.AddIngredient(ItemID.BlueFlameDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowFlameandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow Flame and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class DimShiftingRainbowFlameandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dim Shifting Rainbow Flame and Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseBrightShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Bright Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseBrightShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Bright Shifting Rainbow FlameDye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightShiftingRainbowFlameDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseDimShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Dim Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseDimShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Dim Shifting Rainbow FlameDye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimShiftingRainbowFlameDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class IntenseShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Intense Shifting Rainbow Flame Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowFlameDye", 2);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ReflectiveShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reflective Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.ReflectiveDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowAcidDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Acid Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.AcidDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow and Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowAuraDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Aura Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 3, 0, 0);
			item.rare = 9;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.LokisDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(ItemID.RainbowBrick, 5);
				recipe.AddIngredient(ItemID.BottledWater);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowFlameandBlackDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Flame and Black Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowFlameandSilverDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Flame and Silver Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowFlameDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Flame Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ShiftingRainbowDye");
			recipe.AddIngredient(ItemID.FlameDye);
			recipe.AddIngredient(ItemID.GreenFlameDye);
			recipe.AddIngredient(ItemID.BlueFlameDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class ShiftingRainbowForceFieldDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Force Field Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ForceFieldDye");
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowHadesDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Hades Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.HadesDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowHighlightDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Highlight Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.ChlorophyteDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowMidtoneDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Midtone Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.MushroomDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowNebulaDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Nebula Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.NebulaDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowPhaseDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Phase Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.PhaseDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowStardustDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Stardust Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.StardustDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowTwilightDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Twilight Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 1, 50, 0);
			item.rare = 3;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.TwilightDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}

	public class ShiftingRainbowVortexDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shifting Rainbow Vortex Dye");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 2, 50, 0);
			item.rare = 4;
			item.dye = 73;
		}
		public override void AddRecipes()
		{
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
			{
				ModRecipe recipe = new ModRecipe(mod);
				recipe.AddIngredient(mod, "ShiftingRainbowDye");
				recipe.AddIngredient(ItemID.VortexDye);
				recipe.AddTile(TileID.DyeVat);
				recipe.SetResult(this);
				recipe.AddRecipe();
			}
		}
	}
}