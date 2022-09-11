using FactrotyDP_UdemyDesigPatters_CosoleApp.AsynchronousFactoryMethod;
using FactrotyDP_UdemyDesigPatters_CosoleApp.PointExample;
using System;
using System.Threading.Tasks;

namespace FactrotyDP_UdemyDesigPatters_CosoleApp
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        #region
        // Factory Method Pattern.
        //var point = Point.NewPolarPoint(1.0, Math.PI / 2);
        //Console.WriteLine(point);
        #endregion


        //Console.ReadLine();
        //}

        #region
        // Asynchronous Factory Method dp.
        static async Task Main(string[] args)
        {
            //var foo = new Foo();
            //await foo.InitAsync();
            Foo x = await Foo.CreateAsync();
            
        }
        #endregion

    }
}
