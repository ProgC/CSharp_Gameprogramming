using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using KModule;
using Microsoft.DirectX;
using Microsoft.DirectX.DirectSound;
using System.Windows.Forms;

namespace Game_BMSPlayer
{
    class BMSPlayer
    {
        private Form1 refForm;
        private BMSParser parser = null;
        private double bpm = 130; // 기본값은 130으로 한다.
        private BarMgr objBarMgr = null;
        private double CurrentTime = 0;
        private const double barHeight = 150;
        private ArrayList Blocks = new ArrayList();
        private bool Playing = false;
        private Bitmap backgroundImg = null;
        private Device sounddevice = null;
        private WaveList objWaveList = null;
        private BitmapList objBitmapList = null;
        private Bitmap ImgBackground = null;
        private NoteEffect[] NoteEffects = new NoteEffect[6];
        
        #region BMSPlayerProperty

        public double BPM
        {
            get
            {
                return bpm;
            }
            set
            {
                if (value == 0)
                {
                    bpm = 1;
                    return;
                }
                bpm = value;
            }
        }
        public bool IsPlay
        {
            get
            {
                return Playing;
            }
        }
        public double BarHeight
        {
            get
            {
                return barHeight;
            }
        }
        public Device SoundDevice
        {
            get
            {
                return sounddevice;
            }
        }
        #endregion

        public BMSPlayer(Form1 form)
        {
            refForm = form;
            backgroundImg = Properties.Resources.BackGround;

            for (int i = 0; i < NoteEffects.Length; i++)
            {
                NoteEffects[i] = new NoteEffect();
            }

            NoteEffects[0].X = 0;
            NoteEffects[0].Y = 0;

            NoteEffects[1].X = 10;
            NoteEffects[1].Y = 0;

            NoteEffects[2].X = 20;
            NoteEffects[2].Y = 0;

            NoteEffects[3].X = 30;
            NoteEffects[3].Y = 0;

            NoteEffects[4].X = 40;
            NoteEffects[4].Y = 0;
        }
        public void Init(string filename, string path)
        {
            // 사운드 디바이스를 생성한다.
            try
            {
                if (sounddevice == null)
                {
                    sounddevice = new Device();
                    sounddevice.SetCooperativeLevel(refForm, CooperativeLevel.Priority);
                }

                Blocks.Clear();

                if (objWaveList != null)
                {
                    objWaveList.StopAll();
                    objWaveList = null;
                }
                objWaveList = new WaveList(this);

                if (objBitmapList != null)
                {
                    objBitmapList = null;
                }
                objBitmapList = new BitmapList(this);

                if (objBarMgr != null)
                {
                    objBarMgr = null;
                }
                objBarMgr = new BarMgr(this);

                if (parser != null)
                {
                    parser = null;
                }
                parser = new BMSParser(this);

                parser.LoadBMS(filename, path);
                // 모든 웨이브 파일, 비트맵 파일들을 로드하고
                // 바를 생성한다.
                parser.Parse();

                CurrentTime = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Update(double dt)
        {
            if (Playing)
            {
                // 게임이 시작되면 플레이를 한다.
                for (int i = 0; i < NoteEffects.Length; i++)
                {
                    NoteEffects[i].Update();
                }

                CurrentTime += dt;
                                         
                double BarPerSecond = (4 * 60) / bpm;
                double dyt = BarHeight * (dt / BarPerSecond);

                for (int i = 0; i < Blocks.Count; i++)
                {
                    // 블럭을 모두 내린다.
                    ((Block)Blocks[i]).MoveDown(dyt);
                    ((Block)Blocks[i]).Update();
                }                                
            }
        }
        public void Render()
        {
            if (Playing)
            {
                Graphics g = GDIBuffer.Instance().GetGraphics;
                g.Clear(Color.Black);
                // 배경 및 UI를 그려준다.
                g.DrawImage(backgroundImg, 0, 0);

                if (ImgBackground != null)
                {
                    g.DrawImage(ImgBackground, 67, 32 , 224, 225);
                }

                for (int i = 0; i < NoteEffects.Length; i++)
                {
                    NoteEffects[i].Render();
                }
                for (int i = 0; i < Blocks.Count; i++)
                {
                    ((Block)Blocks[i]).Render();
                }
            }
        }

        public void AddBmp(int bitmapIndex, string filename)
        {
            objBitmapList.AddBmp(bitmapIndex, filename);
        }
        public void AddWav(int wavNum, string filename)
        {
            objWaveList.AddWav(wavNum, filename);
        }
        public void AddBar(int BarNum, int ChannelFirst, int ChannelSecond, string data)
        {
            objBarMgr.AddBar(BarNum, ChannelFirst, ChannelSecond, data);
        }

        // Bpm블럭 추가
        public void AddBpmBlock(int bpm, double y)
        {
            Block block = new BpmBlock(this);

            ((BpmBlock)block).BPM = bpm;

            block.X = 100;
            block.Y = y;
            Blocks.Add(block);
        }

        // 비트맵 블럭 추가
        public void AddBitmapBlock(int bitmapnum, double y)
        {
            Block block = new BitmapBlock(this);

            ((BitmapBlock)block).Index = bitmapnum;

            block.X = 120;
            block.Y = y;
            Blocks.Add(block);
        }

        // 웨이브 블럭 추가
        public void AddWaveBlock(int wavnum, double y)
        {
            Block block = new BgmBlock(this);

            // 웨이브 번호는 1부터 시작하기 때문이다.
            //int wavIndex = wavnum - 1;

            ((BgmBlock)block).Index = wavnum;
            block.X = 100;
            block.Y = y;
            Blocks.Add(block);
        }

        // 건반 블럭 추가
        public void AddKeyboardBlock(int keyboard, int wavNum, double y)
        {
            Block block = new KeyboardBlock(this);

            ((KeyboardBlock)block).Index = wavNum;
            ((KeyboardBlock)block).Keyboard = keyboard;
                
            switch (keyboard)
            {
                case 1:
                    block.X = 0;
                    ((KeyboardBlock)block).SetWhite();
                    break;
                case 3:
                    block.X = 20;
                    ((KeyboardBlock)block).SetWhite();
                    break;
                case 5:
                    block.X = 40;
                    ((KeyboardBlock)block).SetWhite();
                    break;
                case 6:
                    block.X = 60;
                    ((KeyboardBlock)block).SetRed();
                    break;

                case 2:
                    block.X = 10;
                    ((KeyboardBlock)block).SetBlue();
                    break;
                case 4:
                    block.X = 30;
                    ((KeyboardBlock)block).SetBlue();
                    break;
            }

            block.Y = y;
            Blocks.Add(block); 
        }
        public void Play()
        {
            Playing = true;
        }
        public void Stop()
        {
            Playing = false;
        }
        public void PlayWav(int Num)
        {
            objWaveList.Play(Num);
        }
        public void ChangeBpm(int bpm)
        {
            this.bpm = bpm;
        }
        public void ApplyBitmap(int num)
        {
            ImgBackground = objBitmapList.GetBitmap(num);
        }
        public void ApplyEffect(int keyboard)
        {
            try
            {
                NoteEffects[keyboard-1].Start();
            }
            catch ( IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
            }            
        }
    }
}
