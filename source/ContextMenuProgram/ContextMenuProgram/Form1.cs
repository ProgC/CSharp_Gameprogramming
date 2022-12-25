using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContextMenuProgram
{
    public partial class Form1 : Form
    {
        MainMenu mnuMain = new MainMenu();

        public Form1()
        {
            InitializeComponent();

            ContextMenu contextMenu = new ContextMenu();
            
            MenuItem mnuItemA = new MenuItem("메뉴 항목1", new EventHandler(MnuItemAEvent), Shortcut.CtrlZ);
            MenuItem mnuItemB = new MenuItem("메뉴 항목2", new EventHandler(MnuItemBEvent), Shortcut.CtrlX);
            MenuItem mnuItemC = new MenuItem("메뉴 항목3", new EventHandler(MnuItemCEvent), Shortcut.CtrlC);

            contextMenu.MenuItems.Add(mnuItemA);
            contextMenu.MenuItems.Add(mnuItemB);
            contextMenu.MenuItems.Add(mnuItemC);

            ContextMenu = contextMenu;
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