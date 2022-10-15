using ObserverDP_UdemyDesignPatterns_ConsoleApp.ObservableCollections;
using ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaEventKeyword;
using ObserverDP_UdemyDesignPatterns_ConsoleApp.ObserverViaSpecialInterfaces;
using ObserverDP_UdemyDesignPatterns_ConsoleApp.Task;
using ObserverDP_UdemyDesignPatterns_ConsoleApp.WeakEventPattern;
using System;
using System.ComponentModel;

namespace ObserverDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)  // observer
        {
            #region Observer via 'event' Keyword
            //var person = new Person();
            //person.FallsIll += CallDoctor;
            //person.CatchACold();
            //person.FallsIll -= CallDoctor;
            #endregion

            #region Weak Event Pattern
            //var btn = new Button();
            //var window = new Window(btn);
            //var windowRef = new WeakReference(window);
            //btn.Fired();

            //Console.WriteLine("Setting window to null");
            //window = null;
            //FireGC();
            //Console.WriteLine($"Is the window alive after GC? {windowRef.IsAlive}");
            #endregion

            #region Observer via Special Interfaces
            //new Observer();

            #endregion

            #region Observable Collections 

            //var market = new Market();
            //market.Prices.ListChanged += (sender, eventArgs) =>
            //{
            //    if(eventArgs.ListChangedType == ListChangedType.ItemAdded)
            //    {
            //        float price = ((BindingList<float>)sender)[eventArgs.NewIndex];
            //        Console.WriteLine($"Binding list got a price {price}");
            //    }
            //};
            //market.AddPrice(123);
            #endregion
            
            #region Task

            Game game = new Game();
            var rat = new Rat(game);
            Console.WriteLine(rat.Attack);
            var rat2 = new Rat(game);
            Console.WriteLine(rat2.Attack);

            #endregion
            Console.ReadLine();
        }
        #region Weak Event Pattern
        //private static void FireGC()
        //{
        //    Console.WriteLine("Starting GC.");
        //    GC.Collect();
        //    GC.WaitForPendingFinalizers();
        //    GC.Collect();
        //    Console.WriteLine("GC is done.");
        //}
        #endregion

        #region Observer via 'event' Keyword
        public static void CallDoctor(object sender, FalsIlEventArgs eventArgs)
        {
            Console.WriteLine($"A doctor has been called to {eventArgs.Address}");
        }
        #endregion
    }
}
