using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Ooze
{
    public class BlackOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BlueOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BrownOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class CyanOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class LimeOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class OrangeOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PinkOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class RedOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SilverOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SkyBlueOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class TealOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class VioletOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class YellowOozeDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Ooze Dye");
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
                recipe.AddIngredient(ItemID.PurpleOozeDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}