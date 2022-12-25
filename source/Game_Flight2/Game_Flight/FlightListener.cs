using System;
using System.Collections.Generic;
using System.Text;
using KModule;
using System.Windows.Forms;

namespace Game_Flight2
{
    class FlightListener : Listener
    {
        public FlightListener()
        {
            
        }
        
        public override void Listen(MoveableEntity pEntity)
        {
            bool bMove = false;
            if (KController.Instance().GetKeyState((int)Keys.Left))
            {
                pEntity.MoveLeft();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.Right))
            {
                pEntity.MoveRight();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.Up))
            {
                pEntity.MoveUp();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.Down))
            {
                pEntity.MoveDown();
                bMove = true;
            }
            if (!bMove)
            {
                pEntity.NoMove();
            }
        }
    }
}
