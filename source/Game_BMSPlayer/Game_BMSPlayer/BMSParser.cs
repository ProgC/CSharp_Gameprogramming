using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Globalization;

namespace Game_BMSPlayer
{
    class BMSParser
    {
        private BMSPlayer refBMSPlayer = null;
        private string filename;
        private string pathname;

        public BMSParser(BMSPlayer player)
        {
            refBMSPlayer = player;
        }

        public bool LoadBMS(string filename, string pathname)
        {
            this.filename = filename;
            this.pathname = pathname;
            return true;
        }

        public void Parse()
        {
            StreamReader stream = new StreamReader(filename, System.Text.Encoding.Default);
            
            string linedata;
            do
            {
                linedata = stream.ReadLine();
                Process(linedata);
            } while (linedata != null);
            // 모두 사용한 스트림은 닫아 주어야 한다.
            stream.Close();
        }
        
        public void Process(string linedata)
        {
            // BMS파일 명세에 따라서 동작한다.

            // 읽은 데이터가 없다면 리턴한다.
            if (linedata == null ) return;

            if (linedata.StartsWith("#"))
            {
                char[] seps = new char[]{' ',':'};
                
                string[] StringList = linedata.Split(seps);
                
                if ( StringList[0].Equals("#PLAYER") )
                {
                    // Player데이터를 얻어 온다.                    
                    int Player = int.Parse(StringList[1]);
                }
                else if (StringList[0].Equals("#GENRE"))
                {
                }
                else if (StringList[0].Equals("#TITLE"))
                {

                }
                else if (StringList[0].Equals("#ARTIST"))
                {

                }
                else if (StringList[0].Equals("#BPM"))
                {
                    refBMSPlayer.BPM = double.Parse(StringList[1]);
                }
                else if (StringList[0].Equals("#PLAYLEVEL"))
                {

                }
                else if (StringList[0].Equals("#RANK"))
                {

                }
                else if (StringList[0].Equals("#VOLWAV"))
                {

                }
                else if (StringList[0].Equals("#STAGEFILE"))
                {

                }
                else if (StringList[0].Equals("#TOTAL"))
                {

                }
                else if (StringList[0].Equals("#MIDIFILE"))
                {

                }
                else if (StringList[0].Equals("#VIDEOFILE"))
                {

                }
                else if (StringList[0].Substring(0, 4).Equals("#WAV"))
                {
                    int wavIndex = int.Parse(StringList[0].Substring(4, 2),NumberStyles.HexNumber);
                    refBMSPlayer.AddWav( wavIndex, pathname + "/" + StringList[1]);
                }
                else if (StringList[0].Substring(0, 4).Equals("#BMP"))
                {
                    int bitmapIndex = int.Parse(StringList[0].Substring(4, 2), NumberStyles.HexNumber);
                    refBMSPlayer.AddBmp(bitmapIndex, pathname + "/" + StringList[1]);
                }
                else // 그 외에는 모두 데이터 파일이라고 한다.
                {
                    try
                    {
                        // 마디를 등록한다.
                        int BarNum = GetBarNum(StringList[0]);
                        int ChannelNum = GetChannelNum(StringList[0]);

                        // 채널의 두자리에서 10의 자리에 있는 수로 파싱이되며
                        int ChannelFirst = GetChannelFirst(StringList[0]);

                        // 1의 자리에 있는 수는 그에 따라서 결정된다.
                        int ChannelSecond = GetChannelSecond(StringList[0]);

                        refBMSPlayer.AddBar(BarNum, ChannelFirst, ChannelSecond, StringList[1]);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            else
            {
                // #으로 시작하지 않는 문자는 모두 무시한다.
                return;
            }
        }

        private int GetBarNum(string data)
        {
            return int.Parse(data.Substring(1,3));
        }

        // 채널의 합쳐진 번호
        private int GetChannelNum(string data)
        {
            return int.Parse(data.Substring(4,2));
        }

        // 채널의 앞에 번호
        private int GetChannelFirst(string data)
        {
            return int.Parse(data.Substring(4,1));
        }

        // 채널의 뒤에 번호
        private int GetChannelSecond(string data)
        {
            return int.Parse(data.Substring(5,1));
        }
    }
}

