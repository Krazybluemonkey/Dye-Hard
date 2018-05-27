using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.FlameandBlack
{
    public class CyanGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Gradient and Black Dye");
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

    public class VioletGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Gradient and Black Dye");
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

    public class YellowGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Gradient and Black Dye");
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
	
	public class BrightCyanGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Cyan Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightCyanGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightVioletGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Violet Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightVioletGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightYellowGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Yellow Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightYellowGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimCyanGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Cyan Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimCyanGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimVioletGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Violet Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimVioletGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimYellowGradientandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Yellow Gradient and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimYellowGradientDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class BrightFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightBlueFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Blue Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightBlueFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightGreenFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Green Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightGreenFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBlueFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Blue Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimBlueFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimGreenFlameandBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Green Flame and Black Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "DimGreenFlameDye");
			recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
