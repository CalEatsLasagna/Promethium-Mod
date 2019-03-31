using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Weapons
{
	public class GooStaff : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Goo Staff");
			Tooltip.SetDefault("Quite Sticky");
            Item.staff[item.type] = true;

        }
		public override void SetDefaults()
		{
            
            item.damage = 7;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 2;
			item.value = 2000;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
            item.shootSpeed = 5;
            item.shoot = mod.ProjectileType("Goo");
            item.mana = 2;

        }

        public override void UseStyle(Player player)
        {
            Random rnd = new Random();

            item.shootSpeed = rnd.Next(2, 6) + (rnd.Next(-4, 4)/4);
        }



        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Gel, 30);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
