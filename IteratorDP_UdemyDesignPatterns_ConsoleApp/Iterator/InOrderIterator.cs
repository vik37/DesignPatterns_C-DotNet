using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDP_UdemyDesignPatterns_ConsoleApp.Iterator
{
    public class InOrderIterator<T>
    {
        private readonly Node<T> root;
        private bool yealdedStart;
        public Node<T> Current;
        public InOrderIterator(Node<T> root)
        {
            this.root = root;
            Current = root;
            while(Current.Left != null)
            {
                Current = Current.Left;
            }
        }
        public bool MoveNext()
        {
            if (!yealdedStart)
            {
                yealdedStart = true;
                return true;
            }
            if(Current.Right != null)
            {
                Current = Current.Right;
                while(Current.Left != null)
                {
                    Current = Current.Left;                    
                }
                return true;
            }
            else
            {
                var p = Current.Parent;
                while(p != null && Current == p.Right)
                {
                    Current = p;
                    p = p.Parent;
                }
                Current = p;
                return Current != null;
            }
        }
        public void Reset()
        {
            Current = root;
            yealdedStart = false;
        }
    }
}
