using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxProgram
{
    
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strData = "문자열 데이터";
            int nData = 10;
            float fData = 3.15F;

            
            listBox1.Items.Add(strData);
            listBox1.Items.Add(nData);
            listBox1.Items.Add(fData);
        }
        
        private void listBox1_Click(object sender, EventArgs e)
        {
            ListBox lstBox = (ListBox)sender;

            //MessageBox.Show("선택한 항목의 인덱스는 " + lstBox.SelectedIndex + "번입니다.");            
            //MessageBox.Show("선택한 항목 : " + lstBox.SelectedItem.ToString());

            MessageBox.Show("선택한 항목 : " + lstBox.Items[lstBox.SelectedIndex].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 객체로 지우기
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 인덱스로 지우기
            int nIndex = Convert.ToInt32(textBox1.Text);
            if (nIndex >= 0 && nIndex < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(nIndex);
            }
        }
    }

}