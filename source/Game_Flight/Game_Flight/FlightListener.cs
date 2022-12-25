using System;
using System.Collections.Generic;
using System.Text;
using KModule;
using System.Windows.Forms;

namespace Game_Flight
{
    class FlightListener : Listener
    {
        public FlightListener()
        {
            
        }
        
        public override void Listen(MoveableEntity pEntity)
        {
            if (KController.Instance().GetKeyState((int)Keys.Left))
            {
                pEntity.MoveLeft();
            }
            if (KController.Instance().GetKeyState((int)Keys.Right))
            {
                pEntity.MoveRight();
            }
            if (KController.Instance().GetKeyState((int)Keys.Up))
            {
                pEntity.MoveUp();
            }
            if (KController.Instance().GetKeyState((int)Keys.Down))
            {
                pEntity.MoveDown();
            }
        }
    }
}
