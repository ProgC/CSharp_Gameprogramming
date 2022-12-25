using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight
{
    struct Vector2D    
    {
        public double x;
        public double y;

        public double DistanceBetween(Vector2D p)
        {
            return Math.Sqrt((Math.Pow(Math.Abs(p.x - x),2) + Math.Pow(Math.Abs(p.y - y),2)));
        }
    }

    class MoveableEntity
    {
        protected Listener pListener = null;
        protected Vector2D Pos;
        protected Vector2D Vel;
        protected FlightWorld refWorld;
        protected double rad;
        
        #region MoveableEntityProperty
        public Vector2D Position
        {
            get
            {
                return Pos;
            }
            set
            {
                Pos = value;
            }
        }
        public Vector2D Velocity
        {
            get
            {
                return Vel;
            }
            set
            {
                Vel = value;
            }
        }
        public double Radius
        {
            get
            {
                return rad;
            }
            set
            {
                rad = value;
            }
        }

        #endregion
        
        public void SetWorld(FlightWorld world)
        {   
            refWorld = world;
        }
        public virtual void Update()
        {
        }
        public virtual void Render()
        {
        }

        public void SetListener(Listener p)
        {
            pListener = p;
        }

        public virtual void ProcessListen()
        {
            if (pListener != null)
            {
                pListener.Listen(this);
            }
        }

        public virtual void MoveLeft()
        {
        }
        public virtual void MoveRight()
        {
        }
        public virtual void MoveUp()
        {
        }
        public virtual void MoveDown()
        {
        }

        public virtual bool Collide(MoveableEntity pEntity)
        {
            // 충돌 되는지 우선 검사한다.
            if (Pos.DistanceBetween(pEntity.Position) > (rad + pEntity.Radius))
            {
                return false;
            }

            // 충돌 되었다면 기본적인 처리를 한다.
            return true;
        }
    }
}
