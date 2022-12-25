using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;


namespace window_for_console
{
    class Program : Form
    {
        public Program()
        {
            this.Click += new EventHandler(button1_Click);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("click form");
        }
        
        static void Main(string[] args)
        {
            Program form1 = new Program();
            form1.Show();
            bool bLoop = true;
            while (bLoop)
            {
                Thread.Sleep(1);
                //Application.DoEvents();

                

            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Program
            // 
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Name = "Program";
            this.Load += new System.EventHandler(this.Program_Load);
            this.ResumeLayout(false);

        }

        private void Program_Load(object sender, EventArgs e)
        {

        }

       
    }
}
