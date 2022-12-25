using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_Flight2
{
    class Bullet : MoveableEntity
    {
        private Bitmap BulletImg;
        
        
        public Bullet(FlightWorld world)
        {            
            SetWorld(world);
                                    
            pListener = new Listener();
            BulletImg = Properties.Resources.Bullet;
            BulletImg.MakeTransparent(Color.Magenta);

            Pos.x = refWorld.GetRandom().Next(refWorld.Width);
            Pos.y = 0;

            rad = 3;
        }

        public override void Update()
        {   
            Pos.x += Vel.x;
            Pos.y += Vel.y;

            if (Pos.x < -100)
            {
                refWorld.ApplyBullet(this);
            }
            if (Pos.x > refWorld.Width + 100)
            {
                refWorld.ApplyBullet(this);
            }
            if (Pos.y > refWorld.Height + 100)
            {
                refWorld.ApplyBullet(this);
            }
            if (Pos.y < -100)
            {
                refWorld.ApplyBullet(this);
            }
        }

        public override void Render()
        {
            GDIBuffer.Instance().GetGraphics.DrawImage(BulletImg,
                                                        new Point((int)Pos.x - (BulletImg.Width/2), 
                                                                  (int)Pos.y - (BulletImg.Height/2)));
        }
        
        public override void Hit()
        {
            refWorld.ApplyBullet(this);
        }
    }
}
