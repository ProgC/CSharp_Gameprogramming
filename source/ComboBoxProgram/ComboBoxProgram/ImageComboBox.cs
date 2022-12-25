using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace ComboBoxProgram
{
    class ImageComboBox : ComboBox
    {
        private ArrayList ImgList;
        private int nImageWidth;
        private int nImageHeight;

        public ImageComboBox()
        {
            ImgList = new ArrayList();

            DrawMode = DrawMode.OwnerDrawFixed;
            DropDownStyle = ComboBoxStyle.DropDownList;

            nImageWidth = 14;
            nImageHeight = 6;
        }
        
        // 항목의 내용과 이미지를 등록한다.
        public void AddWithImage( object obj, Bitmap bm)
        {
            ImgList.Add(bm);
            Items.Add(obj);            
        }

        [Category("이미지 콤보박스"),
        Description("이미지의 넓이를 설정합니다.")]
        public int ImageWidth
        {
            get
            {
                return nImageWidth;
            }
            set
            {
                nImageWidth = value;
            }
        }

        [Category("이미지 콤보박스"),
        Description("이미지의 높이를 설정합니다.")]
        public int ImageHeight
        {
            get
            {
                return nImageHeight;
            }
            set
            {
                nImageHeight = value;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (!DesignMode)
            {
                Graphics g = e.Graphics;

                Rectangle rectImgBox = new Rectangle(
                    e.Bounds.Left, e.Bounds.Top,
                    nImageWidth, nImageHeight);

                rectImgBox.Inflate(-1, -1);
                
                Rectangle rectTextBox = new Rectangle(
                    e.Bounds.Left + 2 * e.Bounds.Height,
                    e.Bounds.Top,
                    e.Bounds.Width - 2 * e.Bounds.Height,
                    e.Bounds.Height);

                e.DrawBackground();

                int nIndex = e.Index;
                if (nIndex < 0) return;
                if (nIndex >= ImgList.Count) return;
                g.DrawImage((Bitmap)ImgList[nIndex], rectImgBox);
                g.DrawRectangle(Pens.Black, rectImgBox);

                g.DrawString(Items[e.Index].ToString(), Font,
                    new SolidBrush(e.ForeColor), rectTextBox);
            }
        }
    }
}
