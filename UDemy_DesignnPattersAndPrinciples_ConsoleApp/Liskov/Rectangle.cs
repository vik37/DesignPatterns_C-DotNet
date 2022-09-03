using System;
using System.Collections.Generic;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.Liskov
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle()
        {

        }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public override string ToString()
        {
            return $"{nameof(this.Width)}: {this.Width}, {nameof(this.Height)}: {this.Height}";
        }
    }
}
