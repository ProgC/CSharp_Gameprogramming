using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Drawing;

namespace Graphics_GDIProject_Snow
{
    class SnowWorld
    {
        private int width;
        private int height;
        private ArrayList SnowList = new ArrayList();
        Random objRandom = new Random();

        public SnowWorld(int width, int height)
        {
            this.width = width;
            this.height = height;

            
            for (int i = 0; i < 100; i++)
            {
                Snow snow = new Snow(objRandom.Next(width), objRandom.Next(height),this);
                SnowList.Add(snow);
            }            
        }

        #region SnowWorldProperty
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        #endregion

        public void Update()
        {
            foreach (Snow eachsnow in SnowList)
            {
                eachsnow.Update();
            }            
        }

        public void Render()
        {
            GDIBuffer.Instance().GetGraphics.Clear(Color.Black);
            foreach (Snow eachsnow in SnowList)
            {
                eachsnow.Render();
            }
        }        
    }
}
