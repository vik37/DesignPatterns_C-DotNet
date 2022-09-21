using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp
{
    public class VectorRenderer : IRenderer
    {
        public void RenderCircle(float radious)
        {
            Console.WriteLine($"Drowing a circle of radious {radious}");
        }
    }
}
