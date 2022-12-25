using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ComboBoxProgram
{
    class ColorComboBox : ComboBox
    {
        private string[] colorname = new string[] { "검정색", "초록색", "빨간색", "파란색", "하얀색" };
        private string[] value_colorname = new string[] { "Black", "Green", "Red", "Blue", "White" };
        private bool bInit = false;
        
        public ColorComboBox()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            DrawMode = DrawMode.OwnerDrawFixed;
            ItemHeight = Font.Height;
        }
        
        public void Init()
        {
            if (!bInit)
            {                
                for (int i = 0; i < colorname.Length; i++)
                {
                    Items.Add(colorname[i]);
                }
                
                // 가장 첫번째 요소를 선택합니다.
                SelectedIndex = 0;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (!DesignMode)
            {
                Graphics g = e.Graphics;

                Rectangle rectColorBox = new Rectangle(
                    e.Bounds.Left, e.Bounds.Top,
                    e.Bounds.Height * 2, e.Bounds.Height);

                rectColorBox.Inflate(-2, -2);

                Rectangle rectTextBox = new Rectangle(
                    e.Bounds.Left + 2 * e.Bounds.Height,
                    e.Bounds.Top,
                    e.Bounds.Width - 2 * e.Bounds.Height,
                    e.Bounds.Height);

                e.DrawBackground();
                g.DrawRectangle(Pens.Black, rectColorBox);

                g.FillRectangle(
                    new SolidBrush(Color.FromName(value_colorname[e.Index].ToString())),
                    rectColorBox);

                g.DrawString(Items[e.Index].ToString(), Font,
                    new SolidBrush(e.ForeColor), rectTextBox);
            }         
        }       
    }
}
