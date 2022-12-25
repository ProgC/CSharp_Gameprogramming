using System;
using System.Collections.Generic;
using System.Text;
using KModule;
using System.Windows.Forms;

namespace Game_Flight2
{
    class FlightListenerSecond : Listener
    {
        // 생성자에서는 여전히 아무것도 하지 않습니다.
        public FlightListenerSecond()
        {
        }

        public override void Listen(MoveableEntity pEntity)
        {
            bool bMove = false;
            if (KController.Instance().GetKeyState((int)Keys.A))
            {
                pEntity.MoveLeft();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.D))
            {
                pEntity.MoveRight();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.W))
            {
                pEntity.MoveUp();
                bMove = true;
            }
            if (KController.Instance().GetKeyState((int)Keys.S))
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
