using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace ShadowLabelProgram
{
    class ShadowLabel : Label
    {
        private Color fore_color;
        private int dx;
        private int dy;
        private Brush backfont_brush;
        
        public ShadowLabel()
        {
            fore_color = Color.Black;
            backfont_brush = new SolidBrush(fore_color);
            dx = 1;
            dy = 1;
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        #region Properties for Shadow Label Control   
     
        [Category("그림자 라벨"),
         Description("그림자의 색상을 결정합니다.")]
        public Color BackForeColor
        {
            get
            {
                return fore_color;
            }
            set
            {
                fore_color = value;
                backfont_brush = new SolidBrush(fore_color);
            }
        }

        [Category("그림자 라벨"),
         Description("그림자의 x축 위치를 결정합니다.")]
        public int DX
        {
            get
            {
                return dx;
            }
            set
            {
                dx = value;
            }
        }

        [Category("그림자 라벨"),
         Description("그림자의 y축 위치를 결정합니다.")]
        public int DY
        {
            get
            {
                return dy;
            }
            set
            {
                dy = value;
            }
        }
        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // 배경색으로 똑같은 내용의 글자를 그린다. 좌표는 dx, dy
            g.DrawString(this.Text, this.Font, backfont_brush, dx, dy);            
            base.OnPaint(e);
        }        
    }
}
