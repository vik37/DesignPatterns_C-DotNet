using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp
{
    public abstract class Shape
    {
        protected IRenderer renderer;
        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }
        public abstract void Drow();
        public abstract void Resize(float factor);
    }
}
