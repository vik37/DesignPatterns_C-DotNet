using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterHomework;
using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection;
using AdapterDP_UdemyDesignPatterns_ConsoleApp.AdapterInDependencyInjection.Interfaces;
using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter;
using AdapterDP_UdemyDesignPatterns_ConsoleApp.VectorDemo;
using Autofac;
using Autofac.Features.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        #region
        // Vector\Raster Demo

        private static readonly List<VectorRectangle> vectorRectangle 
            = new List<VectorRectangle>
            {
                new Rectangle(1,1,10,10),
                new Rectangle(3,3,6,6),

            };
        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }
        private static void Draw()
        {
            foreach (var vr in vectorRectangle)
            {
                foreach (var line in vr)
                {
                    var adapter = new LineToPointAdapter(line);
                    foreach (var item in adapter)
                    {
                        DrawPoint(item);
                    }
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region
            // Vector\Raster Demo
            //Draw();
            //Draw();
            #endregion

            #region
            // Generic Value Adapter
            //var v = new Vector2i(1,2);
            //v[0] = 0;
            //var vv = new Vector2i(3,2);
            //var result = v + vv;
            //Console.WriteLine(result);

            //Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
            //Console.WriteLine(u);
            #endregion

            #region
            // Adapter with Aependency Injection (Autofac)
            //var cb = new ContainerBuilder();
            //cb.RegisterType<SaveCommand>().As<ICommand>()
            //    .WithMetadata("Name","Save");
            //cb.RegisterType<OpenCommand>().As<ICommand>()
            //    .WithMetadata("Name","Open");
            //cb.RegisterType<Button>();
            //cb.RegisterAdapter<ICommand, Button>(cmd => new Button(cmd));
            //cb.RegisterAdapter<Meta<ICommand>, Button>(cmd => 
            //    new Button(cmd.Value, (string)cmd.Metadata["Name"])
            //);
            //cb.RegisterType<Editor>();
            //using(var c = cb.Build())
            //{
            //    var editor = c.Resolve<Editor>();
            //    //editor.ClickAll();

            //    foreach (var btn in editor.Buttons)
            //    {
            //        btn.Click();
            //    }
            //}
            #endregion

            #region
            // Homework
            Square square = new Square() { Side = 2 };
            var str = new SquareToRectangleAdapter(square);
            foreach (var item in str.SquarePoints())
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.ReadLine();
        }
    }
}
