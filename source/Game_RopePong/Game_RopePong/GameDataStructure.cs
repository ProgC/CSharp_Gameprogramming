using System;
using System.Collections.Generic;
using System.Text;

namespace Game_RopePong
{
    struct Vector2D
    {
        public Vector2D(double x_, double y_)
        {
            x = x_;
            y = y_;

        }

        public double Length()
        {
            double len = 0;
            len = Math.Sqrt(x * x + y * y);
            return len;
        }

        public double Distance(ref Vector2D value)
        {
            return Math.Sqrt(
                Math.Pow(Math.Abs(value.x - x), 2) +
                Math.Pow((double)Math.Abs(value.y - y), 2));
        }

        public static Vector2D DirectionVector(Vector2D from, Vector2D to)
        {
            Vector2D dirVector;
            dirVector.x = to.x - from.x;
            dirVector.y = to.y - from.y;
            return dirVector;
        }

        public void Normalize()
        {
            double Len = Length();
            if (Len == 0) Len = 1;
            x /= Len;
            y /= Len;
        }

        public double Dot(Vector2D v)
        {
            return (x * v.x + y * v.y);
        }
        
        public static Vector2D operator+(Vector2D lhs, Vector2D rhs)
        {
            return new Vector2D(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2D operator-(Vector2D lhs, Vector2D rhs)
        {
            return new Vector2D(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static Vector2D operator*(Vector2D lhs, double value)
        {
            return new Vector2D(lhs.x * value, lhs.y * value);
        }        
        public static Vector2D operator /(Vector2D lhs, double value)
        {
            return new Vector2D(lhs.x / value, lhs.y / value);
        }
        public double x;
        public double y;
    }

    class GameDataStructure
    {
    }

    class MassBasedPoint
    {
        private bool bIsMovable = true;
        private double mass; // 질량
        private double radius; // 반지름
        private double elasticity; // 탄성계수
        private Vector2D Pos; // 위치
        private Vector2D Vel; // 속도
        private Vector2D Acc; // 가속도
        private Vector2D constForce;
        private Vector2D impulseForce;
        

        #region PointProperty
        public bool Movable
        {
            get
            {
                return bIsMovable;
            }
            set
            {
                bIsMovable = value;
            }
        }

        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                mass = value;
            }
        }

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Elasticity
        {
            get
            {
                return elasticity;
            }
            set
            {
                elasticity = value;
            }
        }

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
                if (bIsMovable)
                {
                    Vel = value;
                }
                else
                {
                    Vel.x = 0;
                    Vel.y = 0;
                }
            }
        }

        public Vector2D Acceleration
        {
            get
            {
                return Acc;
            }
            set
            {
                if (bIsMovable)
                {
                    Acc = value;
                }
                else
                {
                    Acc.x = 0;
                    Acc.y = 0;
                }
            }
        }

        public Vector2D ConstForce
        {
            get
            {
                return constForce;
            }
            set
            {
                if (bIsMovable)
                {
                    constForce = value;
                }
                else
                {
                    constForce.x = 0;
                    constForce.y = 0;
                }
            }
        }

        public Vector2D ImpulseForce
        {
            get
            {
                return impulseForce;
            }
            set
            {
                if (bIsMovable)
                {
                    impulseForce = value;
                }
                else
                {
                    impulseForce.x = 0;
                    impulseForce.y = 0;
                }

            }
        }
        #endregion

        public void Update(double dt)
        {
            Acc = (constForce + impulseForce) / mass;

            impulseForce.x = 0;
            impulseForce.y = 0;

            Vel += Acc * dt;
            Pos += Vel * dt;
        }
    }
}
