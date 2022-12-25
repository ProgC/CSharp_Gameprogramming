using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Flight2
{
    struct Vector2D    
    {
        public double x;
        public double y;

        public Vector2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length()
        {
            return Math.Sqrt(x * x + y * y);
        }
        public void Normalize()
        {
            double len = Length();
            if (len == 0) len = 1;
            x /= len;
            y /= len;
        }

        public double DistanceBetween(Vector2D p)
        {
            return Math.Sqrt((Math.Pow(Math.Abs(p.x - x),2) + Math.Pow(Math.Abs(p.y - y),2)));
        }
        public static Vector2D operator -(Vector2D lhs, Vector2D rhs)
        {
            return new Vector2D(lhs.x - rhs.x, lhs.y - rhs.y);
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
        public virtual void NoMove()
        {
        }

        public virtual bool Collide(MoveableEntity pEntity)
        {
            // 같은 객체끼리는 충돌 검사를 하지 않는다.
            Type ts = this.GetType();
            Type tt = pEntity.GetType();

            if (ts.FullName.Equals(tt.FullName))
            {
                return false;
            }

            if (IsCollision() != true || pEntity.IsCollision() != true) return false;
            
            // 충돌 되는지 우선 검사한다.
            if (Pos.DistanceBetween(pEntity.Position) > (rad + pEntity.Radius))
            {
                return false;
            }
            return true;
        }

        public virtual void Hit()
        {
        }

        public virtual bool IsCollision()
        {
            return true;
        }
    }
}
