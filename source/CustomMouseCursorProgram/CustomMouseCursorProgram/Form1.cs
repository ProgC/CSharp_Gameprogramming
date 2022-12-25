using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// 아래 2개를 using해주어야 한다.
using Microsoft.Win32;
using System.Runtime.InteropServices;


namespace CustomMouseCursorProgram
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);
    

        private Bitmap MouseImg;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MouseImg = Properties.Resources.MouseCursor;
            MouseImg.MakeTransparent(Color.Magenta);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(100, 100);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(MouseImg, 50, 50);

            // 핸들로 객체를 만들어서 할당한 후에
            IntPtr refObj = bmp.GetHicon();
            Cursor newCursor = new Cursor(refObj);
            
            this.Cursor = newCursor;
            
            // 핸들을 삭제해 주어야 한다.
            DestroyIcon(newCursor.Handle);
            
            g.Dispose();
        }
    }
}