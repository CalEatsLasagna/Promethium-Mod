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
 
namespace PromethiumMod
{
    public class ProPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public static bool hasProjectile;

		public override void SetupStartInventory(IList<Item> items)
        {
            Item item = new Item();
            item.SetDefaults(mod.ItemType("SurvivalKnife"));
            item.stack = 1;
            items.Add(item);
        }
    }
}