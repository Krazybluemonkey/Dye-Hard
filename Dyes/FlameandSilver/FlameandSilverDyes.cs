using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.FlameandSilver
{
    public class CyanGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Gradient and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class VioletGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Gradient and Silver Dye");
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

    public class YellowGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Gradient and Silver Dye");
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
	
	public class BrightCyanGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Cyan Gradient and Silver Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightCyanGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightVioletGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Violet Gradient and Silver Dye");
        }
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.FlameDye);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "BrightVioletGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightYellowGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Yellow Gradient and Silver Dye");
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
			recipe.AddIngredient(mod, "BrightYellowGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimCyanGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Cyan Gradient and Silver Dye");
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
			recipe.AddIngredient(mod, "DimCyanGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimVioletGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Violet Gradient and Silver Dye");
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
			recipe.AddIngredient(mod, "DimVioletGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimYellowGradientandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Yellow Gradient and Silver Dye");
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
			recipe.AddIngredient(mod, "DimYellowGradientDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class BrightFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "BrightFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightBlueFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Blue Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "BrightBlueFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightGreenFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Green Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "BrightGreenFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "DimFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBlueFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Blue Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "DimBlueFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimGreenFlameandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Green Flame and Silver Dye");
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
			recipe.AddIngredient(mod, "DimGreenFlameDye");
			recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
