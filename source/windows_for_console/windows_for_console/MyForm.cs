using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace windows_for_console
{
    class MyForm : Form
    {
        public MyForm()
        {
            this.Visible = true;
            
        }

        protected override void OnClick(EventArgs e)
        {
            MessageBox.Show("안뇽?");
        }    
    }
}
