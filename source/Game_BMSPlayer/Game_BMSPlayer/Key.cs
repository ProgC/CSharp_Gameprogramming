using System;
using System.Collections.Generic;
using System.Text;

namespace Game_BMSPlayer
{
    struct Key
    {
        public string data;
        public int channelfirst;
        public int channelsecond;

        public Key(int channelfirst, int channelsecond, string data)
        {
            this.channelfirst = channelfirst;
            this.channelsecond = channelsecond;
            this.data = data;
        }       
    }
}
