using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public interface IPrototypeDP<T>
    {
        T DeepCopy();
    }
}
