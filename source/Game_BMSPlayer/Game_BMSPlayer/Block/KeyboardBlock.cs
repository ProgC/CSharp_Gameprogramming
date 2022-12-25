using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using KModule;

namespace Game_BMSPlayer
{
    class KeyboardBlock : Block
    {
        enum BLOCK_TYPE
        {
            White,
            Blue,
            Red
        };

        private BLOCK_TYPE blockType = BLOCK_TYPE.White;

        private Bitmap ImgWhite;
        private Bitmap ImgBlue;
        private Bitmap ImgRed;
        private int WavNumber; // 눌러졌을 때 웨이브 파일 번호
        private int keyboard;

        #region KeyboardBlockProperty
        public int Index
        {
            get
            {
                return WavNumber;
            }
            set
            {
                WavNumber = value;
            }
        }
        public int Keyboard
        {
            get
            {
                return keyboard;
            }
            set
            {
                keyboard = value;
            }
        }
        #endregion

        public KeyboardBlock(BMSPlayer player)
        {
            refBMSPlayer = player;
            ImgWhite = Properties.Resources.WhiteKeyboard;
            ImgBlue = Properties.Resources.BlueKeyboard;
            ImgRed = Properties.Resources.RedKeyboard;
        }

        public override void Update()
        {
            if (!bPlay)
            {
                if (y >= 300)
                {
                    bPlay = true;

                    // 웨이브 파일 출력
                    refBMSPlayer.PlayWav(Index);
                    refBMSPlayer.ApplyEffect(keyboard);
                }
            }            
        }
        public override void Render()
        {
            Graphics g = GDIBuffer.Instance().GetGraphics;

            if (y > 0 && y < 400)
            {
                switch (blockType)
                {
                    case BLOCK_TYPE.White:
                        g.DrawImage(ImgWhite, (float)x, (float)y);
                        break;
                    case BLOCK_TYPE.Blue:
                        g.DrawImage(ImgBlue, (float)x, (float)y);
                        break;
                    case BLOCK_TYPE.Red:
                        g.DrawImage(ImgRed, (float)x, (float)y);
                        break;
                }
            }
        }

        public void SetWhite()
        {
            blockType = BLOCK_TYPE.White;
        }
        public void SetBlue()
        {
            blockType = BLOCK_TYPE.Blue;
        }
        public void SetRed()
        {
            blockType = BLOCK_TYPE.Red;
        }
    }
}
