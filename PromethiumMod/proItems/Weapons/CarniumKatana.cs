using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Weapons
{
	public class CarniumKatana : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Carnium Katana");
		}
		
		public override void SetDefaults()
		{
			item.damage = 19;
			item.melee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 12;
			item.useAnimation = 12;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 4400;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CarniumBar", 9);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
