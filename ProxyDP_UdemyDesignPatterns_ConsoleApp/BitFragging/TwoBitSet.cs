using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.BitFragging
{
    public class TwoBitSet
    {
        // 64 bits --> 32 values
        private readonly ulong data;
        public TwoBitSet(ulong data)
        {
            this.data = data;
        }
        // 00 10 01 10
        public byte this[int index]
        {
            get
            {
                // 00 10 01 10
                var shift = index << 1;
                
                ulong mask = (0b11U << shift); // 00 11 00 00

                // 00 10 00 00 >> shift
                // 00 00 00 00 00 00 00 00 10
                return (byte)((data & mask) >> shift);
            }
        }
    }
}
