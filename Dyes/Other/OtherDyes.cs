using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Other
{
	public class BiomeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Biome Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BiomeHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class BlueLifeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Life Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "LifeDye");
			recipe.AddIngredient(ItemID.BlueDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DepthDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Depth Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DepthHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class GoldenLifeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Golden Life Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "LifeDye");
			recipe.AddIngredient(ItemID.LifeFruit);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class GreenLifeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Life Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "LifeDye");
			recipe.AddIngredient(ItemID.GreenDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class GreenManaDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Mana Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ManaDye");
			recipe.AddIngredient(ItemID.GreenDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class LifeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Life Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class ManaDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ManaHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class MoneyDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Money Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoneyHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class RedManaDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Mana Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "ManaDye");
			recipe.AddIngredient(ItemID.RedDye);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class SpeedDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Speed Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpeedHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class TimeDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Time Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TimeHairDye);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class CrystalShineDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Shine Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CrystalShard, 5);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DemonFireDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demon Fire Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Obsidian, 5);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class StarLightDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Light Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	
	public class DeterminedHeartDye : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Determined Heart Dye");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LifeCrystal);
			recipe.AddIngredient(ItemID.BottledWater);
			recipe.AddTile(TileID.DyeVat);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
