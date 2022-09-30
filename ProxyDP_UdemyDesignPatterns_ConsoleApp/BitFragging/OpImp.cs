using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.BitFragging
{
    public static class OpImp
    {
        static OpImp()
        {
            var type = typeof(Op);
            foreach (Op op in Enum.GetValues(type))
            {
                MemberInfo[] memberInfos = type.GetMember(op.ToString());
                if(memberInfos.Length > 0)
                {
                    var attr = memberInfos[0].GetCustomAttributes(
                        typeof(DescriptionAttribute),false);
                    if(attr.Length > 0)
                    {
                        opNames[op] = ((DescriptionAttribute) attr[0]).Description[0];
                    }
                }
            }
        }
        private static readonly Dictionary<Op, char> opNames
            = new Dictionary<Op, char>();

        // notice the data types!
        private static readonly Dictionary<Op, Func<double, double, double>> opImpl
            = new Dictionary<Op, Func<double, double, double>>()
            {
                [Op.Mul] = ((x, y) => x * y),
                [Op.Div] = ((x, y) => x / y),
                [Op.Add] = ((x, y) => x + y),
                [Op.Sub] = ((x, y) => x - y)
            };
        public static double Call(this Op op, int x, int y)
        {
            return opImpl[op](x, y);
        }
        public static char Name(this Op op)
        {
            return opNames[op];
        }
    }
}
