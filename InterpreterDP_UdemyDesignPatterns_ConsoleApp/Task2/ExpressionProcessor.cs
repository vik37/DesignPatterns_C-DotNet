﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task2
{
    public class ExpressionProcessor
    {
        public Dictionary<char,int> Variables = new Dictionary<char, int>();
        public enum NextOp
        {
            Nothing,
            Plus,
            Minus
        }
        public int Calculate(string expression)
        {
            int current = 0;
            var nextOp = NextOp.Nothing;
            var parts = Regex.Split(expression, @"(?<=[+-])");
            foreach (var part in parts)
            {
                var noOp = part.Split(new[] {"+","-"},StringSplitOptions.RemoveEmptyEntries);
                var first = noOp[0];
                int value, z;
                if (int.TryParse(first, out z))
                    value = z;
                else if (first.Length == 1 && Variables.ContainsKey(first[0]))
                    value = Variables[first[0]];
                else return 0;

                switch (nextOp)
                {
                    case NextOp.Nothing:
                        current = value;
                        break;
                    case NextOp.Plus:
                        current += value;
                        break;
                    case NextOp.Minus:
                        current -= value;
                        break;
                }
                if(part.EndsWith("+")) nextOp = NextOp.Plus;
                else if(part.EndsWith("-")) nextOp = NextOp.Minus;
            }
            return current;
        }
    }
}
