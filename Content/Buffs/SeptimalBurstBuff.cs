﻿using gvmod.Common.Players;
using Terraria;
using Terraria.ModLoader;

namespace gvmod.Content.Buffs
{
    public class SeptimalBurstBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.debuff[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = false;
        }

        public override bool RightClick(int buffIndex)
        {
            return true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            AdeptPlayer adept = player.GetModPlayer<AdeptPlayer>();
            adept.SPRegenModifier *= 1.5f;
        }
    }
}
