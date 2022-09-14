using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.Homework
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
