using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_BMSPlayer
{
    class NoteEffect
    {
        private Bitmap ImgEffect;
        private int x;
        private int y;
        private int nTickCount;
        private bool bStart;
        
        #region NoteEffectProperty
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
        #endregion
        
        public NoteEffect()
        {
            bStart = false;
            ImgEffect = Properties.Resources.WhiteNoteEffect;

            ImgEffect.MakeTransparent(Color.Magenta);
            nTickCount = 0;
        }
        
        public void Update()
        {
            if (bStart)
            {
                nTickCount++;
                if (nTickCount > 10)
                {
                    bStart = false;
                }
            }
        }

        public void Render()
        {
            if (bStart)
            {
                Graphics g = GDIBuffer.Instance().GetGraphics;
                g.DrawImage(ImgEffect, x, y);
            }
        }

        public void Start()
        {
            bStart = true;
            nTickCount = 0;
        }
    }
}
