using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.ConstructorCopy
{
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
}
