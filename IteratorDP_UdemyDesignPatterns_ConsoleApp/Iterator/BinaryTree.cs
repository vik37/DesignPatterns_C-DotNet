using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDP_UdemyDesignPatterns_ConsoleApp.Iterator
{
    public class BinaryTree<T>
    {
        private Node<T> root;
        public BinaryTree(Node<T> root)
        {
            this.root = root;
        }
        public IEnumerable<Node<T>> InOrder
        {
            get
            {
                IEnumerable<Node<T>> Traverse(Node<T> current)
                {
                    if(current.Left != null)
                    {
                        foreach (var left in Traverse(current.Left))
                            yield return left;
                    }
                    if (current.Right != null)
                    {
                        foreach (var right in Traverse(current.Right))
                            yield return right;
                    }
                    yield return current;
                }
                foreach(var node in Traverse(root))
                    yield return node;
            }
        }
    }
}
