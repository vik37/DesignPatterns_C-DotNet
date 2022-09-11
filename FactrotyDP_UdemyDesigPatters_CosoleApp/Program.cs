using FactrotyDP_UdemyDesigPatters_CosoleApp.AbstractFactory;
using FactrotyDP_UdemyDesigPatters_CosoleApp.AsynchronousFactoryMethod;
using FactrotyDP_UdemyDesigPatters_CosoleApp.ObjectTrackingAndBulkReplacment;
using FactrotyDP_UdemyDesigPatters_CosoleApp.PointExample;
using System;
using System.Threading.Tasks;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            // Factory Method Pattern.
            //var point = Point.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);
            #endregion

            #region
            // Factory
            //var point = PointFactory.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);
            #endregion

            #region
            // Object Tracking and Bulk Replacment.
            //var factory = new TrackingThemeFactory();
            //var theme1 = factory.CreateTheme(false);
            //var theme2 = factory.CreateTheme(true);
            //Console.WriteLine(factory.Info);

            //var factory2 = new ReplaceableThemeFactory();
            //var magicTheme = factory2.CreateTheme(true);
            //Console.WriteLine(magicTheme.Value.BgrColor);
            //factory2.ReplaceTheme(false);
            //Console.WriteLine(magicTheme.Value.BgrColor);
            #endregion

            #region
            // Inner Factoury
            //var point = Point.Factory.NewPolarPoint(1.0, Math.PI / 2);
            //Console.WriteLine(point);
            //var origin = Point.Origin;
            #endregion
            #region
            // Abstract Factory
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrink.Tea, 100);
            drink.Consum();
            #endregion

            Console.ReadLine();
        }

        #region
        // Asynchronous Factory Method dp.
        //static async Task Main(string[] args)
        //{
        //var foo = new Foo();
        //await foo.InitAsync();
        //    Foo x = await Foo.CreateAsync();

        //}
        #endregion

    }
}
