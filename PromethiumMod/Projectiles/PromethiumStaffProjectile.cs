using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PromethiumMod.Projectiles
{
	public class PromethiumStaffProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ShadowFlameKnife);
			aiType = ProjectileID.ShadowFlameKnife;
			projectile.timeLeft = 8;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.ai[0] += 0.1f;
			projectile.velocity *= 1f;
		}
	}
}