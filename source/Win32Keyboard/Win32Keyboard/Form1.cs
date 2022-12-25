using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Win32Keyboard
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        public Form1()
        {
            InitializeComponent();
                        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((GetAsyncKeyState(Keys.Left) & 0x8000) > 0)
            {
                picCharacter.Left -= 1;
            }
            if ((GetAsyncKeyState(Keys.Right) & 0x8000) > 0)
            {
                picCharacter.Left += 1;
            }
            if ((GetAsyncKeyState(Keys.Up) & 0x8000) > 0)
            {
                picCharacter.Top -= 1;
            }
            if ((GetAsyncKeyState(Keys.Down) & 0x8000) > 0)
            {
                picCharacter.Top += 1;
            }
        }
    }
}