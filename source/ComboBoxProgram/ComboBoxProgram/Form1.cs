using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBoxProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 머리 색상 등록
            cbHairColor.Init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbNation.AddWithImage("한국", new Bitmap(GetType(), "kor.bmp"));
            cbNation.AddWithImage("미국", new Bitmap(GetType(), "usa.bmp"));
            cbNation.AddWithImage("일본", new Bitmap(GetType(), "jpn.bmp"));
            cbNation.AddWithImage("캐나다", new Bitmap(GetType(), "can.bmp"));


            // 국적 등록
            /*cbNation.Items.Add("한국");
            cbNation.Items.Add("미국");
            cbNation.Items.Add("일본");
            cbNation.Items.Add("캐나다");*/
                                    
            // 케릭터 클래스 등록
            cbCharacterClass.Items.Add("전사");
            cbCharacterClass.Items.Add("마법사");
            cbCharacterClass.Items.Add("로그");            
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            StringBuilder msg = new StringBuilder();
            /*msg.AppendFormat("선택하신 국가는 {0} 이며 {1} 머리를 가진 {2} 케릭터를 생성하였습니다.",
                cbNation.SelectedItem.ToString(), cbHairColor.SelectedItem.ToString(),
                cbCharacterClass.SelectedItem.ToString());*/

            MessageBox.Show(msg.ToString());
        }
    }
}