using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems
{
	public class TaintedMushroom : ModItem
	{
		public override void SetStaticDefaults()
		{
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 490;
			item.rare = 1;	
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PromethiumOre", 3);
			recipe.AddIngredient(ItemID.GlowingMushroom);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}