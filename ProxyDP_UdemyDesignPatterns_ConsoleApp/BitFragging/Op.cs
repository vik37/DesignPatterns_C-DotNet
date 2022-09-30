using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.BitFragging
{
    public enum Op : byte
    {
        [Description("*")]
        Mul = 0,
        [Description("/")]
        Div = 1,
        [Description("+")]
        Add = 2,
        [Description("-")]
        Sub = 3
    }
}
