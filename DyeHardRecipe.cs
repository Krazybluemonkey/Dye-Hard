using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard
{
    public class DyeHardRecipe : ModRecipe
    {
        public DyeHardRecipe(Mod mod) : base(mod)
        {
            //idk what goes here
        }
        public override bool RecipeAvailable()
        {
            var config = ModContent.GetInstance<DyeHardConfig>();
            if (config.DyeAcquisition == OptionsEnum.Craft || config.DyeAcquisition == OptionsEnum.Both)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}