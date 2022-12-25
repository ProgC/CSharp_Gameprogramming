using System;
using System.Collections.Generic;
using System.Text;

namespace Game_BMSPlayer
{
    class BpmBlock : Block
    {
        private int bpm = 130; // 기본값은 130

        #region BpmBlockProperty
        public int BPM
        {
            get
            {
                return bpm;
            }
            set
            {
                bpm = value;
            }
        }

        #endregion


        public BpmBlock(BMSPlayer player)
        {
            refBMSPlayer = player;
        }
        
        public override void Update()
        {
            if (!bPlay)
            {
                if (y >= 300)
                {
                    bPlay = true;
                                        
                    // bpm을 바꾼다.
                    refBMSPlayer.ChangeBpm(bpm);
                }
            }
        }
        public override void Render()
        {

        }
    }
}
