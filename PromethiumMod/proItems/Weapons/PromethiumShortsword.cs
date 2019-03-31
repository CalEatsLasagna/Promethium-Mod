using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems.Weapons
{
	public class PromethiumShortsword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Promethium Shortsword");
		}
		public override void SetDefaults()
		{
			item.damage = 13;
			item.melee = true;
			item.width = 22;
			item.height = 22;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 3;
			item.knockBack = 3;
			item.value = 4100;
			item.rare = 0;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}
	}
}
