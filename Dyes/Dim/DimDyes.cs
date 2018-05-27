using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Dim
{
    public class DimBlackDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Black Dye");
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
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBlueDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Blue Dye");
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
            recipe.AddIngredient(ItemID.BlueDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBrownDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Brown Dye");
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
            recipe.AddIngredient(ItemID.BrownDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimCyanDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Cyan Dye");
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
            recipe.AddIngredient(ItemID.CyanDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimGreenDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Green Dye");
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
            recipe.AddIngredient(ItemID.GreenDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimLimeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Lime Dye");
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
            recipe.AddIngredient(ItemID.LimeDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimOrangeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Orange Dye");
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
            recipe.AddIngredient(ItemID.OrangeDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimPinkDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Pink Dye");
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
            recipe.AddIngredient(ItemID.PinkDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimPurpleDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Purple Dye");
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
            recipe.AddIngredient(ItemID.PurpleDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimRedDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Red Dye");
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
            recipe.AddIngredient(ItemID.RedDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimSkyBlueDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Sky Blue Dye");
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
            recipe.AddIngredient(ItemID.SkyBlueDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimTealDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Teal Dye");
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
            recipe.AddIngredient(ItemID.TealDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimVioletDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Violet Dye");
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
            recipe.AddIngredient(ItemID.VioletDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimYellowDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Yellow Dye");
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
            recipe.AddIngredient(ItemID.YellowDye);
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimFleshRedDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Flesh Red Dye");
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
            recipe.AddIngredient(mod, "FleshRedDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimGrossBrownDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Gross Brown Dye");
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
            recipe.AddIngredient(mod, "GrossBrownDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimGrossPinkDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Gross Pink Dye");
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
            recipe.AddIngredient(mod, "GrossPinkDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimRottenBrownDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Rotten Brown Dye");
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
            recipe.AddIngredient(mod, "RottenBrownDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimRottenGreenDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Rotten Green Dye");
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
            recipe.AddIngredient(mod, "RottenGreenDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimShadowPurpleDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Shadow Purple Dye");
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
            recipe.AddIngredient(mod, "ShadowPurpleDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimViciousRedDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Vicious Red Dye");
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
            recipe.AddIngredient(mod, "ViciousRedDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimVilePurpleDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Vile Purple Dye");
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
            recipe.AddIngredient(mod, "VilePurpleDye");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
