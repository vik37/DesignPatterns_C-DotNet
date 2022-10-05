using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Token
    {
        public string Text;
        public TypesAndOperations TypesAndOperations;
        public Token(string text, TypesAndOperations typeOperations)
        {
            Text = text;
            TypesAndOperations = typeOperations;
        }
    }
}
