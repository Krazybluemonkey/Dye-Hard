using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Phase
{
    public class BlackPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BluePhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class BrownPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class CyanPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class LimePhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class OrangePhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class PinkPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class RedPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SilverPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class SkyBluePhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class TealPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class VioletPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class YellowPhaseDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Phase Dye");
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
                recipe.AddIngredient(ItemID.PhaseDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
