using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.Collections;
using System.Threading;

namespace Game_BMSPlayer
{
    class WaveList
    {
        private BMSPlayer refBMSPlayer = null;
        private ArrayList wavList = new ArrayList();

        public WaveList(BMSPlayer player)
        {
            refBMSPlayer = player;

            Init();
        }
        public void Init()
        {
            // 사운드 버퍼를 미리 만들어 놓고 1:1대응한다.
            for (int i = 0; i < 256; i++)
            {
                string Temp = "Empty";
                wavList.Add(Temp);
            }
        }
        public void StopAll()
        {
            for (int i = 0; i < 256; i++)
            {
                if (wavList[i] is string) continue;
                ((SecondaryBuffer)wavList[i]).Stop();
            }
        }
        public void AddWav(int wavNum, string filename)
        {
            BufferDescription desc = new BufferDescription(); 
            desc.ControlEffects = false;
            SecondaryBuffer wav = new SecondaryBuffer(filename,desc, refBMSPlayer.SoundDevice);
            
            wavList[wavNum] = null;
            wavList[wavNum] = wav;
        }
        public void Play(int num)
        {
            if (wavList[num] is string) return;
            ((SecondaryBuffer)wavList[num]).SetCurrentPosition(0);
            ((SecondaryBuffer)wavList[num]).Play(0, BufferPlayFlags.Default);
        }
    }
}
