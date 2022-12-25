using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_Flight
{
    class FlightWorld
    {
        private int width;
        private int height;
        private ArrayList objList = new ArrayList();
        private Random rnd = new Random();
        private CollisionMgr colMgr;

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
                        
            // 총알과 비행기를 등록한다.
            for (int i = 0; i < 100; i++)
            {
                Bullet bullet = new Bullet(this);
                objList.Add(bullet);
            }
            
            Flight flight = new Flight(this);
            flight.SetListener(new FlightListener());
            objList.Add(flight);

            // 만들어진 오브젝트 리스트 데이터를 이용하여
            // 충돌 데이터를 만든다.
            colMgr.Build(objList);
        }

        public void FrameUpdate()
        {
            foreach (MoveableEntity entity in objList)
            {
                entity.ProcessListen();
                entity.Update();
            }

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
    }
}
