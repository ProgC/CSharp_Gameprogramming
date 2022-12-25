using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckBoxForMediatorPattern
{
    public partial class Form1 : Form
    {
        Mediator med = new Mediator();
        
        public Form1()
        {
            InitializeComponent();

            med.Add(chkKnight, chkBerserker, chkWizard);
            med.AddSecond(chkOne, chkTwo, chkStaff);
        }

        private void chkKnight_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);            
        }

        private void chkBerserker_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);
        }

        private void chkWizard_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkbox = (CheckBox)sender;
            med.ChangeAction(chkbox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}