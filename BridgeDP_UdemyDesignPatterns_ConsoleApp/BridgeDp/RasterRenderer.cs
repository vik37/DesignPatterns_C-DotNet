using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp
{
    public class RasterRenderer : IRenderer
    {
        public void RenderCircle(float radious)
        {
            Console.WriteLine($"Drowing pixels for circle with radious {radious}");
        }
    }
}
