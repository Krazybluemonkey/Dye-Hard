using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DyeHard.NPCs
{
	public class DyeHardGlobalNPC : GlobalNPC
	{
		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if (type == NPCID.DyeTrader)
			{
				if (Main.moonPhase == 4)
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("LightDye"));
					nextSlot++;
				}
				if (NPC.AnyNPCs(NPCID.Clothier))
				{
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeHair"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeEye"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeSkin"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeShirt"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeUndershirt"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyePants"));
					nextSlot++;
					shop.item[nextSlot].SetDefaults(mod.ItemType("FamiliarDyeShoe"));
					nextSlot++;
				}
			}
		}
	}
}
