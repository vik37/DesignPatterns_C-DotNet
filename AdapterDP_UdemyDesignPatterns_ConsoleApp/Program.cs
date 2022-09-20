﻿using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter;
using AdapterDP_UdemyDesignPatterns_ConsoleApp.VectorDemo;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var v = new Vector2i(1,2);
            v[0] = 0;
            var vv = new Vector2i(3,2);
            var result = v + vv;
            Console.WriteLine(result);

            Vector3f u = Vector3f.Create(3.5f, 2.2f, 1);
            Console.WriteLine(u);
            #endregion
            Console.ReadLine();
        }
    }
}
