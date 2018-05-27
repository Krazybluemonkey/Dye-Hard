using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.andSilver
{
	public class SilverandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class BrightBlackandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Black and Silver Dye");
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
            recipe.AddIngredient(mod, "BrightBlackDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightBlueandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Blue and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightBlueDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightBrownandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Brown and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightBrownDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightCyanandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Cyan and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightCyanDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightGreenandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Green and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightGreenDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightLimeandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Lime and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightLimeDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightOrangeandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Orange and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightOrangeDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightPinkandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Pink and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightPinkDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightPurpleandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Purple and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightPurpleDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightRedandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Red and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class BrightSilverandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Silver and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightSilverDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightSkyBlueandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Sky Blue and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightSkyBlueDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightTealandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Teal and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightTealDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightVioletandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Violet and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightVioletDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrightYellowandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bright Yellow and Silver Dye");
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
            recipe.AddIngredient(ItemID.BrightYellowDye);
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
    public class DimBlackandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Black and Silver Dye");
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
            recipe.AddIngredient(mod, "DimBlackDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBlueandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Blue and Silver Dye");
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
            recipe.AddIngredient(mod, "DimBlueDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimBrownandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Brown and Silver Dye");
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
            recipe.AddIngredient(mod, "DimBrownDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimCyanandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Cyan and Silver Dye");
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
            recipe.AddIngredient(mod, "DimCyanDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimGreenandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Green and Silver Dye");
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
            recipe.AddIngredient(mod, "DimGreenDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimLimeandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Lime and Silver Dye");
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
            recipe.AddIngredient(mod, "DimLimeDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimOrangeandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Orange and Silver Dye");
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
            recipe.AddIngredient(mod, "DimOrangeDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimPinkandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Pink and Silver Dye");
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
            recipe.AddIngredient(mod, "DimPinkDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimPurpleandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Purple and Silver Dye");
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
            recipe.AddIngredient(mod, "DimPurpleDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimRedandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Red and Silver Dye");
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
            recipe.AddIngredient(mod, "DimRedDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class DimSilverandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Silver and Silver Dye");
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
            recipe.AddIngredient(mod, "DimSilverDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimSkyBlueandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Sky Blue and Silver Dye");
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
            recipe.AddIngredient(mod, "DimSkyBlueDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimTealandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Teal and Silver Dye");
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
            recipe.AddIngredient(mod, "DimTealDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimVioletandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Violet and Silver Dye");
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
            recipe.AddIngredient(mod, "DimVioletDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DimYellowandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dim Yellow and Silver Dye");
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
            recipe.AddIngredient(mod, "DimYellowDye");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class FleshRedandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Flesh Red and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class GrossBrownandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gross Brown and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class GrossPinkandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Gross Pink and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class RottenBrownandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rotten Brown and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class RottenGreenandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Rotten Green and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class ShadowPurpleandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shadow Purple and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class ViciousRedandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vicious Red and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class VilePurpleandSilverDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Vile Purple and Silver Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
