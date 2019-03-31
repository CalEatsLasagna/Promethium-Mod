using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PromethiumHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Promethium Helmet");
			Tooltip.SetDefault("Increases damage by 4%");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 2975;
			item.rare = 0;
			item.defense = 4;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("PromethiumChestplate") && legs.type == mod.ItemType("PromethiumLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "A friendly Shadow Orb will help guide you.";
			player.AddBuff(BuffID.ShadowOrb, 300);
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "PromethiumBar", 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage *= 1.04f;
			player.thrownDamage *= 1.04f;
			player.rangedDamage *= 1.04f;
			player.magicDamage *= 1.04f;
			player.minionDamage *= 1.04f;
		}
	}
}