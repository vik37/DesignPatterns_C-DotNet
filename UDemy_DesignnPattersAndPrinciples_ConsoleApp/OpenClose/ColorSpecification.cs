using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose
{
    public class ColorSpecification : ISpecifications<Product>
    {
        private Color Color;
        public ColorSpecification(Color color)
        {
            this.Color = color;
        }

        public bool IsSatisfied(Product t)
        {
           return t.Color == Color;
        }
    }
}
