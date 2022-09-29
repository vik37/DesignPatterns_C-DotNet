using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.ValueProxy
{
    [DebuggerDisplay("{value*100.0f}%")]
    public struct Persentage
    {
        private readonly float value;
        internal Persentage(float value)
        {
            this.value = value;
        }
        public static float operator *(float f, Persentage p)
        {
            return f * p.value;
        }
        public static Persentage operator +(Persentage a, Persentage b)
        {
            return new Persentage(a.value + b.value);
        }
        public override string ToString()
        {
            return $"{value * 100}%";
        }
    }
}
