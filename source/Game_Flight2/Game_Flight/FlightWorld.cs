using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_Flight2
{
    class FlightWorld
    {
        private int width;
        private int height;
        private ArrayList objList = new ArrayList();
        private ArrayList FlightList = new ArrayList();
        private Random rnd = new Random();
        private CollisionMgr colMgr;
        private BulletStrategyMgr bulletMgr;

        #region FlightWorldProperty
        public int Width
        {
            get
            {
                return width;
            }
        }
        public int Height
        {
            get
            {
                return height;
            }
        }        
        #endregion

        public FlightWorld(int width, int height)
        {
            this.width = width;
            this.height = height;

            GDIBuffer.Instance(width, height);

            colMgr = new CollisionMgr();
            bulletMgr = new BulletStrategyMgr(this);
            
            Flight flight = new Flight(this);
            flight.SetListener(new FlightListener());
            objList.Add(flight);

            //Flight flight2 = new Flight(this);
            //flight2.SetListener(new FlightListenerSecond());
            //objList.Add(flight2);
            // 만들어진 오브젝트 리스트 데이터를 이용하여
            // 충돌 데이터를 만든다.

            FlightList.Add(flight);
            //FlightList.Add(flight2);


            // 총알과 비행기를 등록한다.
            for (int i = 0; i < 50; i++)
            {
                Bullet bullet = new Bullet(this);
                bulletMgr.ApplyBullet(bullet);
                objList.Add(bullet);
            }

            // 충돌 데이터를 생성한다.
            colMgr.Build(objList);
        }

        public void FrameUpdate()
        {
            foreach (MoveableEntity entity in objList)
            {
                entity.ProcessListen();
                entity.Update();
            }
            bulletMgr.Update();
            colMgr.ProcessCollision();
        }

        public void FrameRender()
        {
            GDIBuffer.Instance().GetGraphics.Clear(Color.Black);            
            foreach (MoveableEntity entity in objList)
            {
                entity.Render();
            }
        }

        public Random GetRandom()
        {
            return rnd;
        }        

        public void ApplyBullet(MoveableEntity pEntity)
        {
            bulletMgr.ApplyBullet(pEntity);
        }

        public MoveableEntity GetFlightRandom()
        {
            int nCount = FlightList.Count;
            int idx = rnd.Next(nCount);
            return (MoveableEntity)FlightList[idx];
        }
    }
}
