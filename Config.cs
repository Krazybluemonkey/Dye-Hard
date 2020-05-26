using Terraria.ModLoader.Config;
using System.ComponentModel;

namespace DyeHard
{
    public class DyeHardConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Label("Dye Acquisition")]
        [Tooltip("Method of obtaining dyes from Dye Hard")]
        [DefaultValue(OptionsEnum.Craft)]
        public OptionsEnum DyeAcquisition;
    }

    public enum OptionsEnum
    {
        Craft,
        Reward,
        Both
    }
}