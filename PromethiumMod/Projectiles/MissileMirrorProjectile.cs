using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;



namespace PromethiumMod.Projectiles
{
    public class MissileMirrorProjectile : ModProjectile
    {
        public int timeLeft = 0;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Missile Mirror");
        }

        public override void SetDefaults()
        {
            projectile.width = 8;
            projectile.height = 8;
            projectile.aiStyle = 9;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.timeLeft = 3600;
            aiType = ProjectileID.MagicMissile;
			projectile.penetrate = 1;

        }



        public override void AI()
        {
            Player player = Main.player[projectile.owner];

            Vector2 vel = Main.MouseWorld - projectile.Center;
            float magnitude = Convert.ToSingle(Math.Sqrt(vel.X * vel.X + vel.Y * vel.Y));

            if (magnitude >= 16)
            {
                vel *= 15 / magnitude; //movementFactor can be anything that sets the speed
            }
            else
            {

                vel = new Vector2(0f, 0f);

                //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


            }
            projectile.velocity = vel;
            if(!player.channel)
                {
                projectile.Kill();
                player.AddBuff(88, 88, true/*replace 88 with whatever custom debuff you want*/);
                }


        }

        public override void Kill(int timeLeft)
        {
            Player player = Main.player[projectile.owner];
            player.Center = projectile.Center;
        }

        // Additional hooks/methods here.
    }
}