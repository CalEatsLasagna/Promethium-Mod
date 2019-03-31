using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.proItems
{
	public class CarniumBar : ModItem
	{
		public override void SetStaticDefaults()
		{
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.value = 800;
			item.rare = 1;	
		}
	}
}