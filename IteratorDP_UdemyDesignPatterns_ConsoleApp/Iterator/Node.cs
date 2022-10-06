﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorDP_UdemyDesignPatterns_ConsoleApp.Iterator
{
    public class Node<T>
    {
        public T Value;
        public Node<T> Left, Right;
        public Node<T> Parent;
        public Node(T value)
        {
            Value = value;
        }
        public Node(T value, Node<T> left, Node<T> right)
        {
            Value = value;
            Left = left;
            Right = right;
            Left.Parent = Right.Parent = this;
        }
    }
}
