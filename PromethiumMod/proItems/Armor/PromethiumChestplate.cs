using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PromethiumChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Promethium Chestplate");
			Tooltip.SetDefault("+20 max mana");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 3000;
			item.rare = 0;
			item.defense = 4;
		}

		public override void UpdateEquip(Player player)
		{
		player.statManaMax2 += 20;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PromethiumBar", 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}