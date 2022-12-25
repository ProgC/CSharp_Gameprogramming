using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace ShadowLabelProgram
{
    class ShadowLabelWithFliker : ShadowLabel
    {
        private Timer tm;
        
        public ShadowLabelWithFliker()
        {
            tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 500; // 기본값 0.5초
            tm.Tick += new EventHandler(OnTick);
        }

        
        #region Properties for Fliker

        [Category("깜빡이는 그림자 라벨"),
        Description("깜빡임을 설정합니다.")]
        public Boolean FlikerEnable
        {
            get
            {
                return tm.Enabled;
            }
            set
            {
                tm.Enabled = value;
            }
        }

        [Category("깜빡이는 그림자 라벨"),
        Description("깜빡이는 시간을 설정합니다.")]
        public int FlikerInterval
        {
            get
            {
                return tm.Interval;
            }
            set
            {
                tm.Interval = value;
            }
        }
        #endregion


        public void OnTick(object sender, EventArgs e)
        {
            // 실행 모드일 때만 동작
            if (!DesignMode)
            {
                this.Visible = !this.Visible;
            }
            else
            {
                this.Visible = true;
            }
        }
    }
}
