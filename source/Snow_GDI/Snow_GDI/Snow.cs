using System;
using System.Collections.Generic;
using System.Text;

namespace Snow_GDI
{
    class Snow
    {
        private int x;
        private int y;

        public Snow(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
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

        public int Y
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
    }
}
