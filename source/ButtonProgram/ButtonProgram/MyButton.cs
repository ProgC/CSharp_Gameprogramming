using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ButtonProgram
{
    class MyButton : Button
    {
        private Bitmap NormalBitmap;
        private Bitmap PushedBitmap;

        public MyButton()
        {            
            FlatStyle = FlatStyle.Flat;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.Selectable, false);
            
            NormalBitmap = new Bitmap(ButtonProgram.Properties.Resources.button1);
            PushedBitmap = new Bitmap(ButtonProgram.Properties.Resources.button2);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
 	        base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            
            if ( Capture && ((MouseButtons & MouseButtons.Left) != 0 ) )
            {
                this.Image = PushedBitmap;
            }
            else
            {
                this.Image = NormalBitmap;
            }
        }
    }
}
