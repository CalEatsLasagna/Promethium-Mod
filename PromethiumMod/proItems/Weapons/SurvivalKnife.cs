using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Weapons
{
	public class SurvivalKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Survival Knife");
		}
		public override void SetDefaults()
		{
			item.damage = 7;
			item.melee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 3400;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}
	}
}
