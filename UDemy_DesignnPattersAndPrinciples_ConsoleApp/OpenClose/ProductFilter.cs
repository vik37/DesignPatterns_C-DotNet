using System;
using System.Collections.Generic;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose
{
    // IT'S NOT OPEN  CLOSE
    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if(p.Size == size)
                {
                    yield return p;
                }
            }
        }
        public IEnumerable<Product> FilterByColor(IEnumerable<Product> products, Color color)
        {
            foreach (var p in products)
            {
                if (p.Color == color)
                {
                    yield return p;
                }
            }
        }
        public IEnumerable<Product> FilterByColorAdSize(IEnumerable<Product> products, Size size, Color color)
        {
            foreach (var p in products)
            {
                if (p.Size == size && p.Color == color)
                {
                    yield return p;
                }
            }
        }
    }
}
