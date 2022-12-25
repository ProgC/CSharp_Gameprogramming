using System;
using System.Collections.Generic;
using System.Text;

namespace Game_RopePong
{
    

    class Spring
    {
        // 하나의 스프링은 2개를 연결한다.
        public MassBasedPoint pointA;
        public MassBasedPoint pointB;

        private double d; // 댐핑 감쇠
        private double k; // 탄성 스프링 상수
        private double L; // 스프링의 길이     

        #region SpringProperty
        public double Damper
        {
            get
            {
                return d;
            }
            set
            {
                d = value;
            }
        }

        public double ConstForce
        {
            get
            {
                return k;
            }
            set
            {
                k = value;
            }
        }
        
        public double RestLength        
        {
            get
            {
                return L;
            }
            set
            {
                L = value;
            }
        }
        #endregion

        public void CalculateReactions(double dt)
        {   
            Vector2D dirVector = pointA.Position - pointB.Position;

            // 스프링의 길이를 얻는다.
            double Length = dirVector.Length();
            double DeltahLength = Length - L;

            if ( DeltahLength >= -0.0001 && DeltahLength <= 0.0001 )
            {
                DeltahLength = 0;
            }
            
            // 스프링에 가해지는 힘을 구한다.
            double forceOfSpring = k * DeltahLength;

            // 스프링에 가해지는 댐핑 힘을 구한다.
            double dampeningOfForce = 0;
            if (dt < 1)
            {
                dampeningOfForce = d * DeltahLength * dt;
            }
            else
            {
                dampeningOfForce = d * DeltahLength / dt;
            }

            // 댐핑 힘은 스프링의 힘보다 클 수 없다.
            if (dampeningOfForce > forceOfSpring)
            {
                dampeningOfForce = forceOfSpring;
            }

            double responseOfForce = forceOfSpring - dampeningOfForce;

            dirVector.Normalize();
            Vector2D responseForce = dirVector * responseOfForce;

            // 결과를 포인트들에게 적용한다.
            pointA.ImpulseForce = pointA.ImpulseForce + responseForce * -1;
            pointB.ImpulseForce = pointB.ImpulseForce + responseForce;
        }
    }

    class RopeSimulation
    {
        private MassBasedPoint[] Points;
        private Spring[] Springs;
        public RopeSimulation()
        {

        }

        public MassBasedPoint[] GetPoints()
        {
            return Points;
        }

        public void Update()
        {
            // 로프 시뮬레이션을 적용한다.
            for (int i = 0; i < Springs.GetLength(0); i++)
            {
                Springs[i].CalculateReactions(2);
            }

            Vector2D dampening;
            for ( int i = 0; i < Points.GetLength(0); i++ )
            {
                dampening = Points[i].Velocity * -0.1;
                Points[i].Velocity = Points[i].Velocity + dampening;                
            }
            
            for (int i = 0; i < Points.GetLength(0); i++)
            {
                Points[i].Update(2);
            }
        }

        public void MakeRope(Vector2D A, Vector2D B, int nDivide)
        {
            Points = null;
            Springs = null;

            // nDivide개수만큼 나누어서 로프를 구성한다.
            // A와 B지점은 모두 움직이지 못하도록 고정한다.

            Vector2D dir = B - A;
            double Length = dir.Length() / nDivide;

            dir.Normalize();

            Points = new MassBasedPoint[nDivide];
            Springs = new Spring[nDivide-1]; // 스프링 개수는 정점 보다 1개 작게 만든다.
            
            for (int i = 0; i < nDivide; i++)
            {
                Points[i] = new MassBasedPoint();
            }
            
            Points[0].Movable = false;           
            Points[Points.GetLength(0) - 1].Movable = false;

            for ( int i = 0; i < nDivide; i++ ) {
                Points[i].Position = A + dir * (i * Length);

                Points[i].Mass = 40; // 질량 설정
                Points[i].Radius = 4; // 구 충돌을 위해서 반지름을 설정
                Points[i].Elasticity = 3; // 탄성 계수를 설정

                // 중력은 상수힘으로 놓는다.
                Points[i].ConstForce = new Vector2D(0, 0.9 * 2);
                Points[i].Velocity = new Vector2D(0, 0);                
            }
            
            // 스프링들을 연결한다.
            for (int i = 0; i < nDivide-1; i++)
            {
                Springs[i] = new Spring();
                Springs[i].pointA = Points[i];
                Springs[i].pointB = Points[i+1];

                Springs[i].Damper = 10; // 댐퍼
                Springs[i].ConstForce = 8; // 스프링 상수
                Springs[i].RestLength = 0.5;//Length; // 스프링 길이
            }
        }

    }
}
