using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TreeviewProgram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("1. C#으로 배우는 게임 프로그래밍");
            treeView1.Nodes.Add("2. C#문법");
            treeView1.Nodes.Add("3. C#윈도우즈프로그래밍");
            treeView1.Nodes.Add("4. C#그래픽 프로그래밍");

            TreeNode sub = treeView1.Nodes[0].Nodes.Add("게임 프로그래밍은 재미있다.");
            sub.ImageIndex = 1;

            treeView1.ImageList = imageList1;
        }

    }
}