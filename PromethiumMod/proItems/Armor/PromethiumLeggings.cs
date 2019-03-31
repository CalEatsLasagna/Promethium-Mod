using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PromethiumLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Promethium Leggings");
			Tooltip.SetDefault("6% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 2950;
			item.rare = 0;
			item.defense = 3;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed *= 1.06f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PromethiumBar", 9);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}