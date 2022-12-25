using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Game_BMSPlayer
{
    class BarMgr
    {
        private BMSPlayer refBMSPlayer = null;
        private ArrayList BarList = new ArrayList();

        #region BarMgrProperty
        public BMSPlayer GetBMSPlayer
        {
            get
            {
                return refBMSPlayer;
            }
        }

        #endregion

        public BarMgr(BMSPlayer player)
        {
            this.refBMSPlayer = player;                        
        }
        
        // 마디 번호
        public void AddBar(int barNum, int channelfirst, int channelsecond, string data)
        {
            // 바가 이미 있다면 키만을 추가한다.
            for (int i = 0; i < BarList.Count; i++)
            {
                if (((Bar)BarList[i]).BarNumber == barNum)
                {
                    // 채널 번호와 데이터를 넘긴다.
                    ((Bar)BarList[i]).AddKey(channelfirst, channelsecond, data);
                    return;
                }
            }    
            
            // 바가 없다면 바를 추가하고 키를 추가한다.
            Bar bar = new Bar(this);
            bar.BarNumber = barNum;
            bar.AddKey( channelfirst, channelsecond, data);
            BarList.Add(bar);
        }
    }
}
