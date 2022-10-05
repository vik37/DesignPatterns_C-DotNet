using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public static class Interpreter
    {
        public static List<Token> Lex(string expression)
        {
            var result = new List<Token>();
            int countPar = 0;
            for (int i = 0; i < expression.Length; i++)
            {                
                switch (expression[i])
                {
                    case '+':
                        result.Add(new Token("+", TypesAndOperations.Add));
                        countPar++; 
                        break;
                    case '-':
                        result.Add(new Token("-", TypesAndOperations.Substract));
                        countPar++;
                        break;
                    default:
                        var sb = new StringBuilder();
                        int count = 0;
                        for (int j = i; j < expression.Length; j++)
                        {
                            if (char.IsDigit(expression[j]))
                            {
                                sb.Append(expression[j]);
                                
                                if(j == expression.Length - 1)
                                {
                                    result.Add(new Token(sb.ToString(), TypesAndOperations.Integer));
                                    i = expression.Length - 1;
                                    break;
                                }
                                count++;
                            }
                            else
                            {
                                result.Add(new Token(sb.ToString(), TypesAndOperations.Integer));
                                if(count > 1) i++;
                                break;
                            }
                        }
                        if (countPar == 1 && !char.IsNumber(expression[i + 1]))
                        {
                            result.Add(new Token("*", TypesAndOperations.LeftPar));
                        }
                        break;
                }
            }
            return result;
        }

        public static IElement Parser(List<Token> tokens)
        {
            var result = new Operations();
            bool haveLHS = false;
            for (int i = 0; i < tokens.Count; i++)
            {
                var token = tokens[i];
                switch (token.TypesAndOperations)
                {
                    case TypesAndOperations.Integer:
                        var integer = new Integer(int.Parse(token.Text));
                        if (!haveLHS)
                        {
                            result.Left = integer;
                            haveLHS = true;
                        }
                        else
                        {
                            result.Right = integer;
                        }
                        break;
                    case TypesAndOperations.Add:
                        result.TypeOperations = TypesOfOperation.Add;
                        break;
                    case TypesAndOperations.Substract:
                        result.TypeOperations = TypesOfOperation.Substract;
                        break;
                    case TypesAndOperations.LeftPar:
                        result.Left = new Integer(result.Sum());
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            return result;
        }
    }
}
