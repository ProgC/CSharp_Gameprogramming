using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;
using System.Windows.Forms;

namespace Game_Flight
{
    class Flight : MoveableEntity
    {
        private Bitmap[] FlightImg;
        
        public Flight(FlightWorld world)
        {
            SetWorld(world);
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

            rad = 7;
        }

        public override void Update()
        {

        }

        public override void Render()
        {
            GDIBuffer.Instance().GetGraphics.DrawImage( FlightImg[0],
                                                        new Point((int)Pos.x, (int)Pos.y));
        }

        public override void MoveLeft()
        {
            Pos.x -= 2;
        }
        public override void MoveRight()
        {
            Pos.x += 2;
        }
        public override void MoveUp()
        {
            Pos.y -= 2;
        }
        public override void MoveDown()
        {
            Pos.y += 2;
        }
    }
}
