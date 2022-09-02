using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if(name == null)
            {
                throw new ArgumentNullException(paramName: nameof(name));
            }
            Name = name;
            Color = color;
            Size = size;
        }
    }
}
