using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems
{
	public class PromethiumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("It's incredibly heavy.");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 600;
			item.rare = 1;	
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PromethiumOre", 4);
			recipe.AddTile(TileID.Furnaces);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}