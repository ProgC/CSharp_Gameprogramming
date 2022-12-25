using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace WindowsApplication1
{
    class ColorComboBox : ComboBox
    {
        public ColorComboBox()
        {
        
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);

            if (!DesignMode)
            {
                for (int i = 0; i < 10; i++)             
                {
                    Items.Add(i);
                }
            }
        }
    }
}
