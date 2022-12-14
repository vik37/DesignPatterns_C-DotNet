using System;
using System.Diagnostics;
using System.Linq;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion.interfaces;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.Liskov;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.SingleResponsibbility;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp
{
    internal class Program
    {
        #region
        // Part of Liskov Principle.
        //static public int Area(Rectangle r) => r.Width * r.Height;
        #endregion

        #region
        // Part of Dependency Inversion
        //public Program(Relationship relationship)
        //{
        //    var relations = relationship.Relations;
        //    foreach (var r in relations.Where(
        //            x => x.Item1.Name == "John" && x.Item2 == Relationships.Parent
        //        ))
        //    {
        //        Console.WriteLine($"John has child call {r.Item3.Name}");
        //    }
        //}

        public Program(IRelationshipBrowser relationshipBrowser)
        {
            foreach (var rb in relationshipBrowser.FindAllChildrenOf("John"))
            {
                Console.WriteLine($"John has a child called {rb.Name}");
            }
        }
        #endregion
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

            //Product apple = new Product("Apple", Color.Green, Size.Small);
            //Product tree = new Product("Tree", Color.Green, Size.Large);
            //Product house = new Product("House", Color.Blue, Size.Large);

            //Product[] products = { apple, tree, house };

            //var pf = new ProductFilter();

            //Console.WriteLine("Green products (old):");
            //foreach (var product in pf.FilterByColor(products,Color.Green))
            //{
            //    Console.WriteLine($"- {product.Name} is Green");
            //}

            //var bf = new BetterFilter();
            //Console.WriteLine("Green products (new):");
            //foreach (var product in bf.Filter(products,new ColorSpecification(Color.Green)))
            //{
            //    Console.WriteLine($"- {product.Name} is Green");
            //}
            //Console.WriteLine("Large Size");
            //foreach (var product in bf.Filter(products, new SizeSpecification(Size.Large)))
            //{
            //    Console.WriteLine($"- {product.Name} is Large");
            //}
            //Console.WriteLine("Green and Large Products");
            //foreach (var product in bf.Filter(products,new AndSpecification<Product>(new ColorSpecification(Color.Green),new SizeSpecification(Size.Large))))
            //{
            //    Console.WriteLine($"- {product.Name} is Green and Large");
            //}
            //Console.ReadLine();
            #endregion

            #region
            // Liskov Principle
            //Rectangle rc = new Rectangle(2,3);

            //Console.WriteLine($"{rc} has area {Area(rc)}");

            //Rectangle sq = new Square();
            //sq.Width = 4;

            //Console.WriteLine($"{sq} has area {Area(sq)}");

            #endregion

            #region
            // Dependency Inversion Principle

            var parent = new Person { Name = "John" };
            var child1 = new Person { Name = "Simith" };
            var child2 = new Person { Name = "Marry" };

            var relationships = new Relationship();
            relationships.AddParentAndChild(parent, child2);
            relationships.AddParentAndChild(parent, child1);

            new Program(relationships);

            #endregion

            Console.ReadLine();
        }
    }
}
