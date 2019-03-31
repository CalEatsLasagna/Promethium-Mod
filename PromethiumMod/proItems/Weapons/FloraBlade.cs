using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Weapons
{
	public class FloraBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flora Blade");
			Tooltip.SetDefault("Deceptively effective.");
		}
		public override void SetDefaults()
		{
			item.damage = 15;
			item.melee = true;
			item.width = 524;
			item.height = 524;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType ("Flower");
			item.shootSpeed = 18;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Daybloom, 3);
			recipe.AddIngredient(ItemID.Shiverthorn, 2);
			recipe.AddIngredient(ItemID.Blinkroot, 2);
			recipe.AddIngredient(ItemID.GoldBar, 7);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
