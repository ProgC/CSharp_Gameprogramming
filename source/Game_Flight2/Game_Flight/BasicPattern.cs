using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Game_Flight2
{
    class BasicPattern : PatternState
    {
        private int nTickCount;
        public BasicPattern(BulletStrategyMgr bulletMgr)
        {
            refBulletMgr = bulletMgr;
        }
        public override void ApplyBullet(MoveableEntity pEntity)
        {
            Vector2D pos = pEntity.Position;
            Vector2D vel = pEntity.Velocity;
            pos.x = refBulletMgr.World.GetRandom().Next(refBulletMgr.World.Width);
            pos.y = 0;
            vel.x = 0;
            vel.y = 1 +refBulletMgr.World.GetRandom().NextDouble() * 3;
            
            pEntity.Position = pos;
            pEntity.Velocity = vel;
        }

        public override void Begin()
        {
            nTickCount = 0;
        }
        public override void Update()
        {
            // 3초에 한번씩 CirclePattern으로 교체한다.
            nTickCount++;
            // 30/1000 = 0.03초이고
            // 3초 / 0.03 = 횟수
            if (nTickCount >= 100)
            {
                refBulletMgr.ChangeState(new CirclePattern(refBulletMgr));
            }            
        }
        public override void End()
        {
        }
    }
}
