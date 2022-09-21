using BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeDP_UdemyDesignPatterns_ConsoleApp.BridgeDp
{
    public class Circle : Shape
    {
        private float radius;
        public Circle(IRenderer rendered, float radius) : base(rendered)
        {
            this.radius = radius;
        }

        public override void Drow()
        {
            renderer.RenderCircle(radius);
        }

        public override void Resize(float factor)
        {
            radius *= factor;
        }
    }
}
