using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_BMSPlayer
{
    class BgmBlock : Block
    {   
        private Bitmap ImgBgm = null;
        private int WaveNumber = 0;
        
        #region WavBlockProperty
        public int Index
        {
            get
            {
                return WaveNumber;
            }
            set
            {
                WaveNumber = value;
            }
        }
        #endregion

        public BgmBlock(BMSPlayer player)
        {
            refBMSPlayer = player;
            ImgBgm = Properties.Resources.BgmKeyboard;
        }

        public override void Update()
        {
            if ( !bPlay )            
            {
                if ( y >= 300 )
                {
                    bPlay = true;

                    // 배경 음악 출력
                    refBMSPlayer.PlayWav(Index);
                }
            }
        }

        public override void Render()
        {
            Graphics g = GDIBuffer.Instance().GetGraphics;

            if (y > 0 && y < 400)
            {
                g.DrawImage(ImgBgm, (float)X, (float)y);
            }            
        }
    }
}
