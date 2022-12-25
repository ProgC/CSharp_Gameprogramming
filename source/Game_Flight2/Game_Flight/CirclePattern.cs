using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight2
{
    class CirclePattern : PatternState
    {
        private int nTickCount; 
        public CirclePattern(BulletStrategyMgr bulletMgr)
        {
            refBulletMgr = bulletMgr;
        }
        public override void ApplyBullet(MoveableEntity pEntity)
        {
            Vector2D pos = pEntity.Position;
            Vector2D vel = pEntity.Velocity;
            
            int GameWidth = refBulletMgr.World.Width;
            int GameHeight = refBulletMgr.World.Height;
            
            pos.x = refBulletMgr.World.GetRandom().Next(GameWidth);
            pos.y = refBulletMgr.World.GetRandom().Next(GameHeight);

            double centerx = GameWidth / 2;
            double centery = GameHeight / 2;

            Vector2D CenterPos = new Vector2D(centerx, centery);
            Vector2D Dir = pos - CenterPos;
            Dir.Normalize();

            double Len = Math.Sqrt(centerx * centerx + centery * centery);
            Dir.x *= Len;
            Dir.y *= Len;
            
            pos.x = centerx + Dir.x;
            pos.y = centery + Dir.y;

            MoveableEntity rFlight = refBulletMgr.World.GetFlightRandom();
            Vector2D FlightPos = rFlight.Position;
            Dir = FlightPos - pos;
            Dir.Normalize();
            vel.x = Dir.x;
            vel.y = Dir.y;
            
            pEntity.Position = pos;
            pEntity.Velocity = vel;
        }

        public override void Begin()
        {
            nTickCount = 0;
        }
        public override void Update()
        {
            // 2초에 한번씩 BasicPattern으로 교체한다.
            nTickCount++;
            // 30/1000 = 0.03초이고
            // 2초 / 0.03 = 횟수
            if (nTickCount >= 66)
            {
                refBulletMgr.ChangeState(new BasicPattern(refBulletMgr));
            }    
        }
        public override void End()
        {
        }
    }
}
