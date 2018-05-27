using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.Dyes
{
    public class DummyDyeNumber1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Dummy Dye #1");
			Tooltip.SetDefault("Unobtainable.\nUsed to reset the dye limit, it doesn't do anything!");
        }
        public override void SetDefaults()
        {
            item.rare = -1;
        }
    }
}