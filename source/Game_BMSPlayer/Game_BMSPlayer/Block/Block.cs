using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_BMSPlayer
{
    abstract class Block
    {
        protected BMSPlayer refBMSPlayer = null;
        protected double x;
        protected double y;
        protected bool bPlay = false;
        
        #region BlockProperty
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        #endregion

        public Block()
        {
            x = 0;
        }

        public void MoveDown(double dy)
        {
            if (y < 400)
            {
                y += dy;
            }
        }

        public virtual void Update()
        {
        }
        public virtual void Render()
        {            
        }
    }
}
