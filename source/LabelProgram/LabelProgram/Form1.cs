using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LabelProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("남성이므로 패스");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("독자의 이름이 " + txtName.Text + "라구요?\n" +
                            "나이는 " + txtAge.Text + "이구요...\n" +
                            "성별은 " + txtSex.Text + "이고\n" +
                            txtWhere.Text + "에 살고 계시네요. 반갑습니다.");
        }
    }
}