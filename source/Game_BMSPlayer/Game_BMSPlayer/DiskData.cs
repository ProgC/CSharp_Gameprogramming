using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Game_BMSPlayer
{
    class DiskData
    {
        public string FileFullName = null;
        public string PathName = null;
        public string title = null; // 타이틀
        public string Artist = null; // 만든이
        public string Genre = null; // 장르
        public double bpm = 1; // bpm
        public int playerlevel = 1; // 플레이어 레벨
        public int rank = 2; // 플레이 점수
        public int volume = 100; // 볼륨
        
        public DiskData()   
        {

        }
        
        // 파일을 읽어서 디스크의 정보를 대입한다.
        public bool ReadDisk(string filename)
        {
            this.FileFullName = filename;
            return true;
        }
    }
}
