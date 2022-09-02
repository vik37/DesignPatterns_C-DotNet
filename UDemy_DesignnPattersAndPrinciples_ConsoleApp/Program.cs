using System;
using System.Diagnostics;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.SingleResponsibbility;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Single Responsibility Principle

           // var j = new Journal();
           // j.AddEntry("I was try to cry!");
           // j.AddEntry("I ate a bbug!");

            
           // Console.WriteLine(j);
           // var p = new Persistence();
           // string filename = @"journal.txt";
           // p.SaveToFile(j, filename, true);
           //// Process.Start(filename);
           // Console.ReadLine();
            #endregion

            #region
            // Open Close Principle

            Product apple = new Product("Apple", Color.Green, Size.Small);
            Product tree = new Product("Tree", Color.Green, Size.Large);
            Product house = new Product("House", Color.Blue, Size.Large);

            Product[] products = { apple, tree, house };

            //var pf = new ProductFilter();

            //Console.WriteLine("Green products (old):");
            //foreach (var product in pf.FilterByColor(products,Color.Green))
            //{
            //    Console.WriteLine($"- {product.Name} is Green");
            //}

            var bf = new BetterFilter();
            Console.WriteLine("Green products (new):");
            foreach (var product in bf.Filter(products,new ColorSpecification(Color.Green)))
            {
                Console.WriteLine($"- {product.Name} is Green");
            }
            Console.WriteLine("Large Size");
            foreach (var product in bf.Filter(products, new SizeSpecification(Size.Large)))
            {
                Console.WriteLine($"- {product.Name} is Large");
            }
            Console.WriteLine("Green and Large Products");
            foreach (var product in bf.Filter(products,new AndSpecification<Product>(new ColorSpecification(Color.Green),new SizeSpecification(Size.Large))))
            {
                Console.WriteLine($"- {product.Name} is Green and Large");
            }
            Console.ReadLine();
            #endregion
        }
    }
}
