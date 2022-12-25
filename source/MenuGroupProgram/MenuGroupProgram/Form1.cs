using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MenuGroupProgram
{
    public partial class Form1 : Form
    {
        MainMenu mnuMain = new MainMenu();

        public Form1()
        {
            InitializeComponent();

            MenuItem mnuItemA = new MenuItem("메뉴 항목1", new EventHandler(MnuItemAEvent), Shortcut.CtrlZ);
            MenuItem mnuItemB = new MenuItem("메뉴 항목2", new EventHandler(MnuItemBEvent), Shortcut.CtrlX);
            MenuItem mnuItemC = new MenuItem("메뉴 항목3", new EventHandler(MnuItemCEvent), Shortcut.CtrlC);

            mnuItemA.MenuItems.Add(mnuItemB);
            mnuItemA.MenuItems.Add(mnuItemC);
                        
            mnuMain.MenuItems.Add(mnuItemA);
            Menu = mnuMain;
        }

        void MnuItemAEvent(object obj, EventArgs e)
        {
            MessageBox.Show("메뉴 항목 1 선택");
        }

        void MnuItemBEvent(object obj, EventArgs e)
        {
            MessageBox.Show("메뉴 항목 2 선택");
        }

        void MnuItemCEvent(object obj, EventArgs e)
        {
            MessageBox.Show("메뉴 항목 3 선택");
        }
    }
}