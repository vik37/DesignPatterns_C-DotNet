using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterHomework
{
    public static class ExtensionMetods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Wdth * rc.Height;
        }
    }
}
