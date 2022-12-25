using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ContextMenuGroupProgram
{
    public partial class Form1 : Form
    {
        MainMenu mnuMain = new MainMenu();

        public Form1()
        {
            InitializeComponent();

            ContextMenu contextMenuForWorker = new ContextMenu();
            ContextMenu contextMenuForKnight = new ContextMenu();
            
            MenuItem mnuWorkerConstructor = new MenuItem("건물짓기", new EventHandler(WorkerConstructor));
            MenuItem mnuWorkerFarming = new MenuItem("농사짓기", new EventHandler(WorkerFarming));
            MenuItem mnuWorkerMining = new MenuItem("광물캐기", new EventHandler(WorkerMining));

            contextMenuForWorker.MenuItems.Add(mnuWorkerConstructor);
            contextMenuForWorker.MenuItems.Add(mnuWorkerFarming);
            contextMenuForWorker.MenuItems.Add(mnuWorkerMining);


            MenuItem mnuKnightAttack = new MenuItem("공격하기", new EventHandler(KnightAttack));
            MenuItem mnuKnightWander = new MenuItem("어슬렁거리기", new EventHandler(KnightWander));
            MenuItem mnuKnightSkill = new MenuItem("기술연마", new EventHandler(KnightSkill));

            contextMenuForKnight.MenuItems.Add(mnuKnightAttack);
            contextMenuForKnight.MenuItems.Add(mnuKnightWander);
            contextMenuForKnight.MenuItems.Add(mnuKnightSkill);
            
            picWorker.ContextMenu = contextMenuForWorker;
            picKnight.ContextMenu = contextMenuForKnight;
        }

        void WorkerConstructor(object obj, EventArgs e)
        {
            MessageBox.Show("건물짓기");
        }
        void WorkerFarming(object obj, EventArgs e)
        {
            MessageBox.Show("농사짓기");
        }
        void WorkerMining(object obj, EventArgs e)
        {
            MessageBox.Show("광물캐기");
        }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              

        void KnightAttack(object obj, EventArgs e)
        {
            MessageBox.Show("공격하기");
        }
        void KnightWander(object obj, EventArgs e)
        {
            MessageBox.Show("어슬렁거리기");
        }
        void KnightSkill(object obj, EventArgs e)
        {
            MessageBox.Show("기술연마하기");
        }

    }
}