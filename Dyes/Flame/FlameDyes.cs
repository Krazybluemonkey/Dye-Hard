using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Flame
{
		
    public class BrightCyanGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Cyan Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddTile(TileID.DyeVat);
            recipe.AddIngredient(ItemID.CyanGradientDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightVioletGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Violet Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VioletGradientDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightYellowGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Yellow Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowGradientDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimCyanGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Cyan Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CyanGradientDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimVioletGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Violet Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VioletGradientDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimYellowGradientDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Yellow Gradient Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.YellowGradientDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class BrightFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlameDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightBlueFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Blue Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlueFlameDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightGreenFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Green Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenFlameDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlameDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBlueFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Blue Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BlueFlameDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimGreenFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Green Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 20, 0);
			item.rare = 1;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreenFlameDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
