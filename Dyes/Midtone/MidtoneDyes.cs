using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Midtone
{
    public class BlackMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlackDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BlueMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlueDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BrownMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BrownDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class CyanMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CyanDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.GreenDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class LimeMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LimeDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class OrangeMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.OrangeDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PinkMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PinkDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PurpleMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PurpleDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class RedMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.RedDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SilverMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SilverDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SkyBlueMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SkyBlueDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class TealMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TealDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class VioletMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.VioletDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class YellowMidtoneDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Midtone Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = Item.sellPrice(0, 0, 75, 0);
			item.rare = 2;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.YellowDye);
                recipe.AddIngredient(ItemID.MushroomDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}