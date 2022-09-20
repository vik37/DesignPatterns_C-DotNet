using AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDP_UdemyDesignPatterns_ConsoleApp.GenericValueAdapter
{
    public class Vector<TSelf, T, D>
        where D : IInteger, new()
        where TSelf : Vector<TSelf, T, D>, new()
    {
        protected T[] Data;
        public Vector()
        {
            Data = new T[new D().Value];
        }
        public Vector(params T[] values)
        {
            var requierdSize = new D().Value;
            Data = new T[requierdSize];

            var providedSize = values.Length;
            for (int i = 0; i < Math.Min(requierdSize,providedSize); ++i)
            {
                Data[i] = values[i];
            }
        }
        public static TSelf Create(params T[] values)
        {
            var result = new TSelf();
            var requierdSize = new D().Value;
            result.Data = new T[requierdSize];

            var providedSize = values.Length;
            for (int i = 0; i < Math.Min(requierdSize, providedSize); ++i)
            {
                result.Data[i] = values[i];
            }
            return result;
        }
        public T this[int index]
        {
            get => Data[index];
            set => Data[index] = value;
        }
        public T X
        {
            get => Data[0];
            set => Data[0] = value;
        }
    }
}
