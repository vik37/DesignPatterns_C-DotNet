using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose
{
    public class SizeSpecification : ISpecifications<Product>
    {
        private Size Size;
        public SizeSpecification(Size size)
        {
            Size = size;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == Size;
        }
    }
}
