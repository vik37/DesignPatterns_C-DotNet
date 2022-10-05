using System;
using System.Collections.Generic;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            // todo
            var sb = new StringBuilder();           
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsLetter(expression[i]) && char.IsLetter(expression[i - 1]))
                {
                    return 0;
                }
                if (char.IsLetter(expression[i]))
                {
                    foreach (KeyValuePair<char, int> v in Variables)
                    {

                        if (expression[i].Equals(v.Key))
                        {
                            sb.Append(v.Value);                            
                        }
                    }
                }
                else
                {
                    sb.Append(expression[i]);
                }               
            }
            var lex = Interpreter.Lex(sb.ToString());
            
            var result = Interpreter.Parser(lex);

            return result.Value;
        }
    }
}
