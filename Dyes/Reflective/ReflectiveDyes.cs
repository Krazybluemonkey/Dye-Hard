using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Reflective
{
    public class ReflectiveAdamantiteDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Adamantite Dye");
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
                recipe.AddIngredient(ItemID.AdamantiteOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectiveCobaltDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Cobalt Dye");
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
                recipe.AddIngredient(ItemID.CobaltOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectiveDemoniteDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Demonite Dye");
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
                recipe.AddIngredient(ItemID.DemoniteOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectiveMythrilDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Mythril Dye");
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
                recipe.AddIngredient(ItemID.MythrilOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectivePlatinumDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Platinum Dye");
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
                recipe.AddIngredient(ItemID.PlatinumOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectiveTinDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Tin Dye");
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
                recipe.AddIngredient(ItemID.TinOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class ReflectiveTungstenDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reflective Tungsten Dye");
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
                recipe.AddIngredient(ItemID.TungstenOre, 5);
                recipe.AddIngredient(ItemID.ReflectiveDye);
                recipe.AddTile(TileID.DyeVat);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
}
