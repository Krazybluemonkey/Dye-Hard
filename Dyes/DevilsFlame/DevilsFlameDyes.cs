using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.DevilsFlame
{
    public class BlackDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BlueDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.BlueDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class BrownDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.BrownDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class CyanDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.CyanDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class GreenDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.GreenDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class LimeDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.LimeDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class OrangeDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.OrangeDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class PinkDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.PinkDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class PurpleDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.PurpleDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class RedDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.RedDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class SilverDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class SkyBlueDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.SkyBlueDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class TealDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.TealDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class VioletDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.VioletDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class YellowDevilsFlameDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Devil's Flame Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "QuinesMiasma");
            recipe.AddIngredient(ItemID.YellowDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
	
	public class QuinesMiasma : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Quines' Miasma");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.rare = 9;
			item.value = Item.sellPrice(0, 3, 0, 0);
        }

        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.DevDye);
                recipe.AddIngredient(ItemID.HadesDye);
                recipe.AddIngredient(ItemID.CyanDye);
                recipe.AddIngredient(ItemID.SkyBlueDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this, 4);
                recipe.AddRecipe();
            }
        }
    }
}