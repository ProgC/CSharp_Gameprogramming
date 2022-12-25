using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace Game_BMSPlayer
{
    class BitmapList
    {
        private BMSPlayer refBMSPlayer = null;
        private ArrayList bmpList = new ArrayList();
        
        public BitmapList(BMSPlayer player)
        {
            refBMSPlayer = player;

            Init();
        }

        public void Init()
        {
            bmpList.Clear();
            
            for (int i = 0; i < 256; i++)
            {
                string Temp = "Empty";
                bmpList.Add(Temp);
            }
        }
        public void AddBmp(int bitmapIndex, string filename)
        {
            try
            {
                bmpList[bitmapIndex] = null;

                Bitmap data = new Bitmap(filename);
                bmpList[bitmapIndex] = data;
            }
            catch( IndexOutOfRangeException e )
            {
                MessageBox.Show(e.Message);
            }
        }
        public Bitmap GetBitmap(int num)
        {
            try
            {
                return (Bitmap)bmpList[num];
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }
        }
    }
}
