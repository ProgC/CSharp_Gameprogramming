using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_BMSPlayer
{
    class BitmapBlock : Block
    {
        private Bitmap ImgBitmap = null;
        private int bitNumber = 0;

        #region BitmapBlockProperty
        public int Index
        {
            get
            {
                return bitNumber;
            }
            set
            {
                bitNumber = value;
            }
        }
        #endregion

        public BitmapBlock(BMSPlayer player)
        {
            refBMSPlayer = player;
            ImgBitmap = Properties.Resources.BitmapKeyboard;
        }

        public override void Update()
        {
            if (!bPlay)
            {
                if (y >= 300)
                {
                    bPlay = true;
                                        
                    refBMSPlayer.ApplyBitmap( bitNumber );
                }
            }
        }
        public override void Render()
        {
            Graphics g = GDIBuffer.Instance().GetGraphics;

            if (y > 0 && y < 400)
            {
                g.DrawImage(ImgBitmap, (float)X, (float)y);
            }
        }
    }
}
