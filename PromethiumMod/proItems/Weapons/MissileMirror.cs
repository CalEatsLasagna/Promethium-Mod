using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Windows.Forms;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace PromethiumMod.proItems.Weapons
{

    public class MissileMirror : ModItem
    {

        public bool terminate = false;
        public bool termCancel = true;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Missile Mirror"); 
            Tooltip.SetDefault("Faster than walking");
            Item.staff[item.type] = true;
            
            

        }
        public override void SetDefaults()
        {

            item.width = 40;
            item.height = 40;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.channel = true;
            item.shoot = mod.ProjectileType("MissileMirrorProjectile");
            

        }

        public override bool CanUseItem(Player player)
        {
            if (player.HasBuff(88))
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MagicMirror);
			recipe.AddIngredient(ItemID.MagicMissile);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
