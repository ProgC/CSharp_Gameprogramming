using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RadioButtonProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuyaCar(string name)
        {            
            MessageBox.Show(name);
        }
               
        private void button1_Click(object sender, EventArgs e)
        {
            if ( radioButton1.Checked )
                MessageBox.Show("투스카니는 구입하실 수 없습니다.");
            if ( radioButton2.Checked )
                MessageBox.Show("벤츠도 구입하실 수 없습니다." );
            if ( radioButton3.Checked )
                MessageBox.Show("오피러스 한대만 주면 안되겠니");
            if ( radioButton4.Checked )
                MessageBox.Show("페라리는 너무 비쌉니다.");
            if (radioButton5.Checked)
                MessageBox.Show("람보르기니는 더 비싸서 안됩니다.");


            // 이러한 방법도 있습니다.
            /*foreach (Control each in this.Controls)
            {
                RadioButton TempRadio = each as RadioButton;
                if (TempRadio != null)
                {
                    if (TempRadio.Checked)
                    {
                        BuyaCar(TempRadio.Text);
                    }
                }
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void ColorSelect(object sender, EventArgs e)
        {
            RadioButton radioBtn = (RadioButton)sender;

            switch (radioBtn.Text)
            {
                case "검정색":
                    button2.BackColor = Color.Black;
                    break;
                case "빨간색":
                    button2.BackColor = Color.Red;
                    break;
                case "초록색":
                    button2.BackColor = Color.Green;
                    break;
                case "파란색":
                    button2.BackColor = Color.Blue;
                    break;
            }

        }
        
    }
}