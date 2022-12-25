using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

namespace Game_Flight2
{
    class Animation
    {
        private ArrayList FrameList = new ArrayList();

        private int nCurFrame = 0;
        private int nMaxFrame = 0;
        private int nTickFrame = 0;
        private bool bEnd = false;

        #region AnimationProperty
        public Bitmap Sprite
        {
            get
            {
                if (nMaxFrame == 0) return null;

                AniFrame frame = (AniFrame)FrameList[nCurFrame];
                return frame.Sprite;
            }
        }
        #endregion

        public Animation()
        {
            
        }
        
        public void AddFrame( Bitmap bitmap, int nTime )
        {
            AniFrame Frame = new AniFrame(bitmap, nTime);
            FrameList.Add(Frame);

            nMaxFrame = FrameList.Count;            
        }

        // 애니메이션이 끝났는가?
        public bool GetEnd() {
		    return bEnd;
	    }
        
        public void NextAni()
        {
            nTickFrame++;
            AniFrame frame = (AniFrame)FrameList[nCurFrame];

            if (nTickFrame > frame.TimeFrame )
            {
                nCurFrame++;
                nTickFrame = 0;

                if (nCurFrame >= nMaxFrame)
                {
                    nCurFrame--;
                    bEnd = true;
                }
            }
        }
    }
}
