using IteratorDP_UdemyDesignPatterns_ConsoleApp.Iterator;
using System;
using System.Linq;

namespace IteratorDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Iterator
            var root = new Node<int>(1, new Node<int>(2), new Node<int>(3));
            var it = new InOrderIterator<int>(root);
            while (it.MoveNext())
            {
                Console.Write(it.Current.Value);
                Console.Write(",");
            }
            Console.WriteLine();

            var tree = new BinaryTree<int>(root);
            Console.WriteLine(string.Join(",",tree.InOrder.Select(x => x.Value)));
            #endregion
            Console.ReadLine();
        }
    }
}
