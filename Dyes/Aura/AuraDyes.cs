using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes.Aura
{
    public class BlackAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Black Aura Dye");
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
            recipe.AddIngredient(ItemID.BlackDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BlueAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Blue Aura Dye");
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
            recipe.AddIngredient(ItemID.BlueDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BrownAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Brown Aura Dye");
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
            recipe.AddIngredient(ItemID.BrownDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class CyanAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cyan Aura Dye");
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
            recipe.AddIngredient(ItemID.CyanDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class GreenAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Green Aura Dye");
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
            recipe.AddIngredient(ItemID.GreenDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class LimeAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Lime Aura Dye");
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
            recipe.AddIngredient(ItemID.LimeDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class OrangeAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Orange Aura Dye");
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
            recipe.AddIngredient(ItemID.OrangeDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PinkAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Pink Aura Dye");
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
            recipe.AddIngredient(ItemID.PinkDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PurpleAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Aura Dye");
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
            recipe.AddIngredient(ItemID.PurpleDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class RedAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Red Aura Dye");
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
            recipe.AddIngredient(ItemID.RedDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class SilverAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Silver Aura Dye");
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
            recipe.AddIngredient(ItemID.SilverDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class SkyBlueAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sky Blue Aura Dye");
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
            recipe.AddIngredient(ItemID.SkyBlueDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class TealAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Teal Aura Dye");
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
            recipe.AddIngredient(ItemID.TealDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class VioletAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Violet Aura Dye");
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
            recipe.AddIngredient(ItemID.VioletDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class YellowAuraDye : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Yellow Aura Dye");
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
            recipe.AddIngredient(ItemID.YellowDye);
            recipe.AddIngredient(ItemID.LokisDye);
            recipe.AddTile(TileID.DyeVat);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
