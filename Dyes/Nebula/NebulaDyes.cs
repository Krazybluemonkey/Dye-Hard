using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Nebula
{
    public class BlackNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlackDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BlueNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BlueDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BrownNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BrownDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class CyanNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.CyanDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.GreenDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class LimeNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.LimeDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class OrangeNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.OrangeDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PinkNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PinkDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PurpleNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.PurpleDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class RedNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.RedDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SilverNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SilverDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SkyBlueNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SkyBlueDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class TealNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.TealDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class YellowNebulaDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Nebula Dye");
        }
        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 99;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 4;
        }
        public override void AddRecipes()
        {
            if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "craft")
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.YellowDye);
                recipe.AddIngredient(ItemID.NebulaDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}