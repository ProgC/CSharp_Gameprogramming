using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Game_Flight2
{
    class AniFrame
    {
        private Bitmap refBitmap;
        private int nTime;

        #region AniFrameProperty
        public Bitmap Sprite
        {
            get
            {
                return refBitmap;
            }            
        }
        public int TimeFrame
        {
            get
            {
                return nTime;
            }
        }
        #endregion

        public AniFrame(Bitmap bitmap, int nTime)
        {
            this.refBitmap = bitmap;
            this.nTime = nTime;
        }
    }
}
