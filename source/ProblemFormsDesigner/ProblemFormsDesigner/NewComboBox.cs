using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ProblemFormsDesigner
{
    class NewComboBox : ComboBox
    {
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
