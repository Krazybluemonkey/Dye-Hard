using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.GameInput;

namespace DyeHard
{
	public class DyeHardPlayer : ModPlayer
	{

		public override void GetDyeTraderReward(List<int> dyeItemIDsPool)
		{
			long playerCoin = 0L;
			for (int l = 0; l < 54; l++)
			{
				if (Main.player[Main.myPlayer].inventory[l].type == 71)
				{
					playerCoin += Main.player[Main.myPlayer].inventory[l].stack;
				}
				if (Main.player[Main.myPlayer].inventory[l].type == 72)
				{
					playerCoin += Main.player[Main.myPlayer].inventory[l].stack * 100;
				}
				if (Main.player[Main.myPlayer].inventory[l].type == 73)
				{
					playerCoin += Main.player[Main.myPlayer].inventory[l].stack * 10000;
				}
				if (Main.player[Main.myPlayer].inventory[l].type == 74)
				{
					playerCoin += Main.player[Main.myPlayer].inventory[l].stack * 1000000;
				}
			}
			if (NPC.downedMoonlord)
			{
				dyeItemIDsPool.Add(mod.ItemType("QuinesMiasma"));
			}
			if (Config.DyeAcquisition == "both" || Config.DyeAcquisition == "reward")
			{
				dyeItemIDsPool.Add(mod.ItemType("LightDye"));
				//acid
				dyeItemIDsPool.Add(mod.ItemType("BlackAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("BrownAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("CyanAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("LimeAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("OrangeAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("PureBlueAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("PureGreenAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("PureRedAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("PinkAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("PurpleAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("SilverAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("SkyBlueAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("TealAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("VioletAcidDye"));
				dyeItemIDsPool.Add(mod.ItemType("YellowAcidDye"));
				//mushroom/midtone
				dyeItemIDsPool.Add(mod.ItemType("BlackMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("BlueMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("BrownMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("CyanMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("GreenMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("LimeMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("OrangeMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("PinkMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("PurpleMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("RedMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("SilverMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("SkyBlueMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("TealMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("VioletMidtoneDye"));
				dyeItemIDsPool.Add(mod.ItemType("YellowMidtoneDye"));
				//ooze
				dyeItemIDsPool.Add(mod.ItemType("BlackOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("BlueOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("BrownOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("BlueOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("CyanOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("GreenOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("LimeOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("OrangeOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("PinkOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("RedOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("SilverOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("SkyBlueOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("TealOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("VioletOozeDye"));
				dyeItemIDsPool.Add(mod.ItemType("YellowOozeDye"));
				//reflective
				dyeItemIDsPool.Add(mod.ItemType("ReflectiveTinDye"));
				dyeItemIDsPool.Add(mod.ItemType("ReflectiveTungstenDye"));
				dyeItemIDsPool.Add(mod.ItemType("ReflectivePlatinumDye"));
				if (NPC.downedBoss2)
				{
					dyeItemIDsPool.Add(mod.ItemType("ReflectiveDemoniteDye"));
				}
				//other
				dyeItemIDsPool.Add(mod.ItemType("DepthDye"));
				if (Main.player[Main.myPlayer].statLifeMax >= 400)
				{
					dyeItemIDsPool.Add(mod.ItemType("LifeDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenLifeDye"));
					dyeItemIDsPool.Add(mod.ItemType("BlueLifeDye"));
					dyeItemIDsPool.Add(mod.ItemType("GoldenLifeDye"));
				}
				if(Main.player[Main.myPlayer].statManaMax >= 200)
				{
					dyeItemIDsPool.Add(mod.ItemType("ManaDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenManaDye"));
					dyeItemIDsPool.Add(mod.ItemType("BlueManaDye"));
				}
				if (playerCoin >= 1000000)
				{
					dyeItemIDsPool.Add(mod.ItemType("MoneyDye"));
				}
				if (Main.moonPhase % 2 == 0 && Main.dayTime || Main.moonPhase % 2 == 1 && !Main.dayTime)
				{
					dyeItemIDsPool.Add(mod.ItemType("TimeDye"));
				}
				if (NPC.AnyNPCs(208))
				{
					dyeItemIDsPool.Add(mod.ItemType("PartyDye"));
					dyeItemIDsPool.Add(mod.ItemType("CottonCandyPartyDye"));
				}
				if (Main.hardMode)
				{
					//shifting rainbow
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowDye"));
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowAcidDye"));
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowMidtoneDye"));
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("ReflectiveShiftingRainbowDye"));
					//hades
					dyeItemIDsPool.Add(mod.ItemType("BlackHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("BlueHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("BrownHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("CyanHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("LimeHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("OrangeHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("PinkHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("PurpleHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("RedHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("SilverHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("SkyBlueHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("TealHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("VioletHadesDye"));
					dyeItemIDsPool.Add(mod.ItemType("YellowHadesDye"));
					//twilight
					dyeItemIDsPool.Add(mod.ItemType("BlackTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("BlueTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("BrownTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("CyanTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("LimeTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("OrangeTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("PinkTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("RedTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("SilverTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("SkyBlueTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("TealTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("VioletTwilightDye"));
					dyeItemIDsPool.Add(mod.ItemType("YellowTwilightDye"));
					//gel
					dyeItemIDsPool.Add(mod.ItemType("BlackGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("BlueGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("BrownGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("CyanGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("LimeGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("OrangeGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("PinkGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("PurpleGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("RedGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("SilverGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("SkyBlueGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("TealGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("VioletGelDye"));
					dyeItemIDsPool.Add(mod.ItemType("YellowGelDye"));
					//phase
					dyeItemIDsPool.Add(mod.ItemType("BlackPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("BluePhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("BrownPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("CyanPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("GreenPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("LimePhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("OrangePhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("PinkPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("PurplePhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("RedPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("SilverPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("SkyBluePhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("TealPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("VioletPhaseDye"));
					dyeItemIDsPool.Add(mod.ItemType("YellowPhaseDye"));
					//reflective
					dyeItemIDsPool.Add(mod.ItemType("ReflectiveCobaltDye"));
					dyeItemIDsPool.Add(mod.ItemType("ReflectiveMythrilDye"));
					dyeItemIDsPool.Add(mod.ItemType("ReflectiveAdamantiteDye"));
					//other
					dyeItemIDsPool.Add(mod.ItemType("BiomeDye"));
					if (NPC.downedMechBossAny)
					{
						//chlorophyte/highlight
						dyeItemIDsPool.Add(mod.ItemType("BlackHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("TealHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("VioletHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowHighlightDye"));
						dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowHighlightDye"));
						//living flame
						dyeItemIDsPool.Add(mod.ItemType("GreenLivingFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueLivingFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("VioletLivingGradientDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanLivingGradientDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowLivingGradientDye"));
						//other
						dyeItemIDsPool.Add(mod.ItemType("SpeedDye"));
					}
					if (NPC.downedPlantBoss)
					{
						//wisp
						dyeItemIDsPool.Add(mod.ItemType("SpiritDye"));
					}
					if (NPC.downedMartians)
					{
						//force field
						dyeItemIDsPool.Add(mod.ItemType("ForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlackForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("GreenForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("TealForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowForceFieldDye"));
						dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowForceFieldDye"));
					}
					if (NPC.downedTowerNebula)
					{
						//nebula
						dyeItemIDsPool.Add(mod.ItemType("BlackNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("GreenNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("TealNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowNebulaDye"));
						dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowNebulaDye"));
					}
					if (NPC.downedTowerStardust)
					{
						//stardust
						dyeItemIDsPool.Add(mod.ItemType("BlackStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("GreenStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("TealStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("VioletStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowStardustDye"));
						dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowStardustDye"));
					}
					if (NPC.downedTowerVortex)
					{
						//vortex
						dyeItemIDsPool.Add(mod.ItemType("BlackVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("GreenVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("VioletVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowVortexDye"));
						dyeItemIDsPool.Add(mod.ItemType("ShiftingRainbowVortexDye"));
					}
					if (NPC.downedMoonlord)
					{
						//gods' blood
						dyeItemIDsPool.Add(mod.ItemType("BlackGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("BlueGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("BrownGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("CyanGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("GreenGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("LimeGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("PinkGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("RedGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("SilverGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("TealGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("VioletGodsBlood"));
						dyeItemIDsPool.Add(mod.ItemType("YellowGodsBlood"));
						//devil's flame
						dyeItemIDsPool.Add(mod.ItemType("BlackDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("BlueDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("BrownDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("CyanDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("GreenDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("LimeDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("OrangeDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("PinkDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("PurpleDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("RedDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("SilverDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("SkyBlueDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("TealDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("VioletDevilsFlameDye"));
						dyeItemIDsPool.Add(mod.ItemType("YellowDevilsFlameDye"));
					}
				}
			}
		}
	}
}
