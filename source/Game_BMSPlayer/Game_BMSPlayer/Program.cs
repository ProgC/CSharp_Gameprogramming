using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Game_BMSPlayer
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
                       
            Form1 frm = new Form1();
            frm.Show();
            
            int StartTime = Environment.TickCount;
                                    
            while (frm.Created)
            {
                int EndTime = Environment.TickCount;
                // millisecond to second.
                double dt = (EndTime - StartTime) / (double)1000;
                StartTime = Environment.TickCount;
                
                Application.DoEvents();

                if (frm.IsDisposed) break;
                frm.tm_Tick(dt, null, null);
            }
            frm.Close();
        }
    }
}