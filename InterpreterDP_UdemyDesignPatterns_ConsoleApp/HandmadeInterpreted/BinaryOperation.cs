using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.HandmadeInterpreted
{
    public class BinaryOperation : IElement
    {
        public enum Type
        {
            Addition, Substraction
        }
        public Type MyType;
        public IElement Left, Right;
        public int Value 
        { 
            get
            {
                switch (MyType)
                {
                    case Type.Addition:
                        return Left.Value + Right.Value;                       
                    case Type.Substraction:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
