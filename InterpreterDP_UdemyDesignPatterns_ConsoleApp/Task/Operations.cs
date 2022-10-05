using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class Operations : IElement
    {
        public IElement Left, Right;
        public TypesOfOperation TypeOperations;
        public int Value {
            get
            {
                switch (TypeOperations)
                {
                    case TypesOfOperation.Add:
                        return Left.Value + Right.Value;
                    case TypesOfOperation.Substract:
                        return Left.Value - Right.Value;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            
        }
        public int Sum()
        {
            switch (TypeOperations)
            {
                case TypesOfOperation.Add:
                    return Left.Value + Right.Value;
                case TypesOfOperation.Substract:
                    return Left.Value - Right.Value;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
