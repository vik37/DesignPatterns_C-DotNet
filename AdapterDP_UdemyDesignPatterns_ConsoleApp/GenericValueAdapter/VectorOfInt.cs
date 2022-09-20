using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter
{
    public class VectorOfInt<D> : Vector<VectorOfInt<D>,int, Dimensions.Two>
        where D : IInteger, new()
    {
        public VectorOfInt() { }
        public VectorOfInt(params int[] values) : base(values)
        {

        }
        // lhs = Left hand side
        // rhs = Rigt hand side
        // dim = Dimensions
        public static VectorOfInt<D> operator+
            (VectorOfInt<D> lhs, VectorOfInt<D> rhs)
        {
            var result = new VectorOfInt<D>();
            var dim = new D().Value;
            for (int i = 0; i < dim; i++)
            {
                result[i] = lhs[i] + rhs[i];
            }
            return result;
        }
    }
}
