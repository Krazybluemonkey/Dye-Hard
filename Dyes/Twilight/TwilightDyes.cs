using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Twilight
{
    public class BlackTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlackDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BlueTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlueDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BrownTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BrownDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class CyanTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CyanDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.GreenDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class LimeTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LimeDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class OrangeTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.OrangeDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PinkTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PinkDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class RedTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.RedDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SilverTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SilverDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SkyBlueTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SkyBlueDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class TealTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TealDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class VioletTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.VioletDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class YellowTwilightDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Twilight Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 1, 50, 0);
            item.rare = 3;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.YellowDye);
                recipe.AddIngredient(ItemID.TwilightDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}