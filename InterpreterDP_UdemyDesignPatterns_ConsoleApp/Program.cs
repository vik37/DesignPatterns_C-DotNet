//using InterpreterDP_UdemyDesignPatterns_ConsoleApp.HandmadeInterpreted;
using InterpreterDP_UdemyDesignPatterns_ConsoleApp.Task;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterpreterDP_UdemyDesignPatterns_ConsoleApp
{
    internal class Program
    {
        #region Hadmade Interprered
        //static List<Token> Lex(string input)
        //{
        //    var result = new List<Token>();
        //    for (int i = 0; i < input.Length; i++)
        //    {
        //        switch (input[i])
        //        {
        //            case '+':
        //                result.Add(new Token(Token.Type.Plus, "+"));
        //                break;
        //            case '-':
        //                result.Add(new Token(Token.Type.Minus, "-"));
        //                break;
        //            case '(':
        //                result.Add(new Token(Token.Type.Lparen, "("));
        //                break;
        //            case ')':
        //                result.Add(new Token(Token.Type.Rparen, ")"));
        //                break;
        //            default:
        //                var sb = new StringBuilder(input[i].ToString());
        //                for (int j = i + 1; j < input.Length; ++j)
        //                {
        //                    if (char.IsDigit(input[j]))
        //                    {
        //                        sb.Append(input[j]);
        //                        ++i;
        //                    }
        //                    else
        //                    {
        //                        result.Add(new Token(Token.Type.Integer, sb.ToString()));
        //                        break;
        //                    }
        //                }
        //                break;
        //        }
        //    }
        //    return result;
        //}
        //static IElement Parse(IReadOnlyList<Token> tokens)
        //{
        //    var result = new BinaryOperation();
        //    bool haveLHS = false;
        //    for (int i = 0; i < tokens.Count; i++)
        //    {
        //        var token = tokens[i];
        //        switch (token.TokenType)
        //        {
        //            case Token.Type.Integer:
        //                var integer = new Integer(int.Parse(token.Text));
        //                if (!haveLHS)
        //                {
        //                    result.Left = integer;
        //                    haveLHS = true;
        //                }
        //                else
        //                {
        //                    result.Right = integer;
        //                }
        //                break;
        //            case Token.Type.Plus:
        //                result.MyType = BinaryOperation.Type.Addition;
        //                break;
        //            case Token.Type.Minus:
        //                result.MyType = BinaryOperation.Type.Substraction;
        //                break;
        //            case Token.Type.Lparen:
        //                int j = i;
        //                for (; j < tokens.Count; ++j)
        //                    if (tokens[j].TokenType == Token.Type.Rparen)
        //                        break;
        //                var subexpression = tokens.Skip(i + 1).Take(j - i - 1).ToList();
        //                var element = Parse(subexpression);
        //                if (!haveLHS)
        //                {
        //                    result.Left = element;
        //                    haveLHS = true;
        //                }
        //                else
        //                {
        //                    result.Right = element;
        //                }
        //                i = j;
        //                break;
        //            default:
        //                throw new ArgumentOutOfRangeException();
        //        }
        //    }
        //    return result;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Hadmade Interprered
            // ( 13 + 4 ) - ( 12
            //string input = "(13+4)-(12+1)";
            //var tokens = Lex(input);
            //Console.WriteLine(string.Join("\t", tokens));

            //var parsed = Parse(tokens);
            //Console.WriteLine($"{input} = {parsed.Value}");
            #endregion

            #region Task
            string one = "1+2+3";
            string two = "1+2+xy";
            string three = "10-2-x";
            var proccess = new ExpressionProcessor();
            proccess.Variables.Add('x', 3);
            proccess.Variables.Add('y', 23);
            int n = proccess.Calculate(three);
            Console.WriteLine(n);
            #endregion
            Console.ReadLine();
        }
    }
}
