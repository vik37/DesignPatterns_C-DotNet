using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.HandmadeInterpreted
{
    public class Token
    {
        public enum Type
        {
            Integer, Plus, Minus, Lparen, Rparen
        }
        public Type TokenType;
        public string Text;
        public Token(Type tokenType, string text)
        {
            TokenType = tokenType;
            Text = text;
        }
        public override string ToString()
        {
            return $"`{Text}`";
        }
    }
}
