using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Globalization;

namespace Game_BMSPlayer
{
    class Bar
    {
        public enum BLOCK_IN_BAR
        {
            BPM,
            BITMAP,
            WAV,
            KEY
        };
        private BarMgr refBarMgr = null;
        private int BarNum = 0;

        // 하나 이상의 데이터를 가진다.
        private ArrayList KeyList = new ArrayList();

        #region BarProperty
        public int BarNumber
        {
            get
            {
                return BarNum;
            }
            set
            {
                BarNum = value;
            }
        }
        #endregion

        public Bar(BarMgr mgr)
        {
            this.refBarMgr = mgr;
        }

        public void AddKey( int channelfirst, int channelsecond, string data )
        {   
            Key key = new Key(channelfirst, channelsecond, data);
            KeyList.Add(key);

            // BarNum를 이용해서 y를 구하여 블럭의 위치를 설정한다.
            // 데이터를 분석한다.
            switch (channelfirst)
            {
                case 0:
                    DefaultChannel(channelsecond, data);
                    break;
                case 1: // 건반 채널
                    ChannelKeyboard(channelsecond, data);
                    break;
            }   
        }
        // 기본 채널 데이터 처리
        public void DefaultChannel(int channelNum, string data)
        {
            switch ( channelNum )
            {
                case 1: 
                    // 배경음 채널
                    ChannelWave(data);
                    break;
                case 2: 
                    // 마디 단축
                    break;
                case 3: 
                    // BPM채널
                    ChannelBpm(data);
                    break;
                case 4:
                    // BGA채널
                    ChannelBitmap(data);
                    break;
                case 5:
                    // BM98확장 채널
                    break;
                case 6:
                    // poor bga 채널
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default: // 여기에 올 수가 없다.

                    break;
            }
        }

        public void BlockProcess(int keynum, string data,BLOCK_IN_BAR type )
        {
            int n = data.Length / 2;

            for (int i = 0; i < n; i++)
            {
                int Num = int.Parse(data.Substring(i * 2, 2), NumberStyles.HexNumber);

                // 00이라면 그냥 넘긴다.
                if (Num == 0) continue;

                // 마디에서 위치는 index / n
                double y = -((i / (double)n) * refBarMgr.GetBMSPlayer.BarHeight) +
                           -(BarNum * refBarMgr.GetBMSPlayer.BarHeight) - 300;

                switch ( type )
                {
                    case BLOCK_IN_BAR.BPM:
                        refBarMgr.GetBMSPlayer.AddBpmBlock(Num, y);
                        break;
                    case BLOCK_IN_BAR.BITMAP:                        
                        refBarMgr.GetBMSPlayer.AddBitmapBlock(Num, y);            
                        break;
                    case BLOCK_IN_BAR.WAV:                        
                        refBarMgr.GetBMSPlayer.AddWaveBlock( Num , y);
                        break;
                    case BLOCK_IN_BAR.KEY:
                        refBarMgr.GetBMSPlayer.AddKeyboardBlock(keynum, Num, y);
                        break;
                }
                
            }
        }

        public void ChannelBpm(string data)
        {
            //#09103:42
            BlockProcess(0, data, BLOCK_IN_BAR.BPM);
        }

        // 비트맵 채널 처리
        public void ChannelBitmap(string data)
        {
            //#00004:01020102010201020102010201020102
            BlockProcess(0, data, BLOCK_IN_BAR.BITMAP);
        }

        // 웨이브 채널 처리
        public void ChannelWave(string data)
        {
            // #01401:00330033
            BlockProcess( 0, data, BLOCK_IN_BAR.WAV );
        }
        // 건반 채널 데이터 처리
        public void ChannelKeyboard(int KeyboardNum, string data)
        {   
            BlockProcess( KeyboardNum, data, BLOCK_IN_BAR.KEY );          
        }
    }
}
