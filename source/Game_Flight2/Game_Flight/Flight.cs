using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;
using System.Windows.Forms;

namespace Game_Flight2
{
    class Flight : MoveableEntity
    {
        private enum FlightState { F_STAND, F_LEFT, F_RIGHT, F_BOMB };
        private enum KeyState { LEFT, RIGHT, UP, DOWN, NOKEY };
        private FlightState nState = FlightState.F_STAND;
        private Bitmap[] FlightImg;
        private KeyState PrevKey = KeyState.NOKEY;
        private Animation aniObj;
        
        private FlightState[,] FinalStateTbl = new FlightState[5, 5] {
        {FlightState.F_LEFT,FlightState.F_LEFT,FlightState.F_LEFT,FlightState.F_LEFT,FlightState.F_LEFT},
        {FlightState.F_RIGHT,FlightState.F_RIGHT,FlightState.F_RIGHT,FlightState.F_RIGHT,FlightState.F_RIGHT},
        {FlightState.F_LEFT,FlightState.F_RIGHT,FlightState.F_STAND,FlightState.F_STAND,FlightState.F_STAND},
        {FlightState.F_LEFT,FlightState.F_RIGHT,FlightState.F_STAND,FlightState.F_STAND,FlightState.F_STAND},
        {FlightState.F_STAND,FlightState.F_STAND,FlightState.F_STAND,FlightState.F_STAND,FlightState.F_STAND}        
        };
        
        public Flight(FlightWorld world)
        {
            SetWorld(world);
            nState = FlightState.F_STAND;
            //pListener = new FlightListener();

            FlightImg = new Bitmap[8];

            FlightImg[0] = Properties.Resources.FlightStand;
            FlightImg[1] = Properties.Resources.FlightLeft;
            FlightImg[2] = Properties.Resources.FlightRight;

            FlightImg[3] = Properties.Resources.FlightBomb1;
            FlightImg[4] = Properties.Resources.FlightBomb2;
            FlightImg[5] = Properties.Resources.FlightBomb3;
            FlightImg[6] = Properties.Resources.FlightBomb4;
            FlightImg[7] = Properties.Resources.FlightBomb5;

            for (int i = 0; i < 8; i++)
            {
                FlightImg[i].MakeTransparent(Color.Magenta);
            }

            // 애니메이션을 등록한다.
            aniObj = new Animation();
            aniObj.AddFrame(FlightImg[3], 3);
            aniObj.AddFrame(FlightImg[4], 3);
            aniObj.AddFrame(FlightImg[5], 3);
            aniObj.AddFrame(FlightImg[6], 3);
            aniObj.AddFrame(FlightImg[7], 3);

            rad = 5;
            Pos.x = refWorld.Width / 2;
            Pos.y = refWorld.Height / 2;
        }

        public override void Update()
        {
            if (nState == FlightState.F_BOMB)
            {
                if (!aniObj.GetEnd())
                {
                    aniObj.NextAni();
                }
            }
        }

        public override void Render()
        {
            switch ( nState )
            {
                case FlightState.F_STAND:
                    GDIBuffer.Instance().GetGraphics.DrawImage( FlightImg[0],
                                                        new Point((int)Pos.x - FlightImg[0].Width/2, 
                                                                  (int)Pos.y - FlightImg[0].Height/2));
                    break;

                case FlightState.F_LEFT:
                    GDIBuffer.Instance().GetGraphics.DrawImage(FlightImg[1],
                                                        new Point((int)Pos.x - FlightImg[1].Width / 2,
                                                                  (int)Pos.y - FlightImg[1].Height / 2));
                    break;
                case FlightState.F_RIGHT:
                    GDIBuffer.Instance().GetGraphics.DrawImage(FlightImg[2],
                                                        new Point((int)Pos.x - FlightImg[2].Width / 2,
                                                                  (int)Pos.y - FlightImg[2].Height / 2));
                    break;

                case FlightState.F_BOMB:
                    GDIBuffer.Instance().GetGraphics.DrawImage(aniObj.Sprite,
                                                        new Point((int)Pos.x - aniObj.Sprite.Width / 2,
                                                                  (int)Pos.y - aniObj.Sprite.Height / 2));
                    break;
            }
        }

        public override void MoveLeft()
        {
            if (nState == FlightState.F_BOMB) return;
            Pos.x -= 2;
            nState = GetFlightState(KeyState.LEFT);
            PrevKey = KeyState.LEFT;
        }
        public override void MoveRight()
        {
            if (nState == FlightState.F_BOMB) return;
            Pos.x += 2;
            nState = GetFlightState(KeyState.RIGHT);
            PrevKey = KeyState.RIGHT;
        }
        public override void MoveUp()
        {
            if (nState == FlightState.F_BOMB) return;
            Pos.y -= 2;
            nState = GetFlightState(KeyState.UP);
            PrevKey = KeyState.UP;
        }
        public override void MoveDown()
        {
            if (nState == FlightState.F_BOMB) return;
            Pos.y += 2;
            nState = GetFlightState(KeyState.DOWN);
            PrevKey = KeyState.DOWN;
        }
        public override void NoMove()
        {
            if (nState == FlightState.F_BOMB) return;
            PrevKey = KeyState.NOKEY;
            nState = FlightState.F_STAND;            
        }

        private FlightState GetFlightState(KeyState key)
        {
            return FinalStateTbl[(int)PrevKey, (int)key];
        }
        
        public override void Hit()
        {
            //Application.Exit();
            if (nState != FlightState.F_BOMB)
            {
                Bomb();
            }
        }

        private void Bomb()
        {
            nState = FlightState.F_BOMB;
        }

        public override bool IsCollision()
        {
            if (nState == FlightState.F_BOMB)
                return false;

            return true;
        }
    }
}
