using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter
{
    public class Vector2i : VectorOfInt<Dimensions.Two>
    {
        public Vector2i()
        {

        }
        public Vector2i(params int[] values) : base(values)
        {

        }
    }
}
