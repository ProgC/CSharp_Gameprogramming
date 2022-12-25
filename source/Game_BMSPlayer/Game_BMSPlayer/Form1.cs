using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using KModule;

namespace Game_BMSPlayer
{
    public partial class Form1 : Form
    {
        //private Timer tm;
        private BMSPlayer objPlayer;
        private DiskMgr objDiskMgr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objPlayer = new BMSPlayer(this);

            objDiskMgr = new DiskMgr();
            string[] disk = objDiskMgr.GetDiskList();
            for (int i = 0; i < disk.Length; i++)
            {
                listBox1.Items.Add(disk[i]);
            }

            GDIBuffer.Instance(300, 300);           

            /*tm = new Timer();
            tm.Enabled = true;
            tm.Interval = 30;
            tm.Tick += new EventHandler(tm_Tick);*/

            
        }

        public void tm_Tick(double dt, object sender, EventArgs e)
        {
            if (objPlayer != null)
            {
                objPlayer.Update(dt);
                objPlayer.Render();

                // 화면에 그린다.
                Graphics g = CreateGraphics();
                g.DrawImage(GDIBuffer.Instance().GetImage, 0, 0);
                g.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //bpm = Int32.Parse(textBox1.Text);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            objPlayer.Stop();            
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {   
            // bms파일을 읽어서 플레이 시킨다.
            objPlayer.Init( objDiskMgr.GetFullName(listBox1.SelectedIndex),
                            objDiskMgr.GetPathOfDisk(listBox1.SelectedIndex) );
            objPlayer.Play();
        }
    }
}