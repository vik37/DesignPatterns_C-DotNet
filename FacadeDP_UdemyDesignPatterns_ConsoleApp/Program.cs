using FacadeDP_UdemyDesignPatterns_ConsoleApp.Task_Homework;
using System;
using System.Collections.Generic;

namespace FacadeDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var magicSquare = new MagicSquareGenerator();
            var a = magicSquare.Generate(4);
            foreach (var item in a)
            {
                foreach (var b in item)
                {
                    Console.Write(b);
                }
                Console.WriteLine(" ");
            }
            Console.ReadLine();
        }
    }
}
