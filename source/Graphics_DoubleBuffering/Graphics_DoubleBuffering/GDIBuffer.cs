using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Graphics_DoubleBuffering
{
    class GDIBuffer
    {
        public static GDIBuffer oInstance = null;
        private Graphics background;
        private Bitmap bitOffScreen;

        private int nWidth;
        private int nHeight;
        
        int GetWidth() 
        {
            return nWidth;
        }

        int GetHeight() 
        {
            return nHeight;
        }
               
        public Graphics GetGraphics
        {
            get
            {
                return background;
            }
        }

        public Bitmap GetImage
        {
            get
            {
                return bitOffScreen;
            }
        }

        private GDIBuffer(int nW, int nH)
        {
            nWidth = nW;
            nHeight = nH;
          
            bitOffScreen = new Bitmap( nWidth, nHeight );
            background = Graphics.FromImage(bitOffScreen);
        }

        public static GDIBuffer Instance(int nW, int nH)
        {
            if ( oInstance == null ) 
            {
                oInstance = new GDIBuffer(nW, nH);
            }
            return oInstance;
        }

        public static GDIBuffer Instance() 
        {  
            try
            {
                if ( oInstance == null )
                {
                    throw( new Exception("didn't make this instance") );
                }
                return oInstance;
            } 
            catch( Exception e ) 
            {
                throw(e);
            }            
        }
    }
}
