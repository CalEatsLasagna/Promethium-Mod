using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.Projectiles
{
	public class Flame : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Flames);
			aiType = ProjectileID.Flames;
			projectile.timeLeft = 40;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 1f;
			target.AddBuff(BuffID.OnFire, 500);
		}
	}
}