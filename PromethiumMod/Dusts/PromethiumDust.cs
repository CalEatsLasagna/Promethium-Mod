using Terraria;
using Terraria.ModLoader;

namespace PromethiumMod.Dusts
{
	public class PromethiumDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 1.2f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 1.8f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 1.15f;
			dust.scale *= 0.87f;
			float light = 0.45f * dust.scale;
			Lighting.AddLight(dust.position, light, light, light);
			if (dust.scale < 0.5f)
			{
				dust.active = false;
			}
			return false;
		}
	}
}