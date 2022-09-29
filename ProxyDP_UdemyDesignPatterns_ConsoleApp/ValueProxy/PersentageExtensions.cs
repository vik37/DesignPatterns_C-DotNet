using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.ValueProxy
{
    public static class PersentageExtensions
    {
        public static Persentage Percent(this float value)
        {
            return new Persentage(value / 100.0f);
        }
        public static Persentage Percent(this int value)
        {
            return new Persentage(value / 100.0f);
        }
    }
}
