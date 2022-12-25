using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_Flight
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
            //Pos.x += Vel.x;
            //Pos.y += Vel.y;
            //Pos.x = refWorld.GetRandom().Next(refWorld.Width);
            //Pos.y = refWorld.GetRandom().Next(refWorld.Height);
            Pos.y += 0.1;
        }

        public override void Render()
        {
            GDIBuffer.Instance().GetGraphics.DrawImage(BulletImg,
                                                        new Point((int)Pos.x, (int)Pos.y));
        }
        
        public override bool Collide(MoveableEntity pEntity)
        {
            // 같은 객체끼리는 충돌 검사를 하지 않는다.
            Type ts = this.GetType();
            Type tt = pEntity.GetType();

            if (ts.FullName.Equals(tt.FullName))
            {
                return false;
            }

            bool retValue = base.Collide(pEntity);
            
            if (retValue)
            {
                Pos.y = 0;
            }
            return retValue;
        }
    }
}
