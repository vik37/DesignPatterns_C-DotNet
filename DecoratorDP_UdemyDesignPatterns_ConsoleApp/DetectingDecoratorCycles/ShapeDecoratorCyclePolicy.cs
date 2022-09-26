using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles
{
    public abstract class ShapeDecoratorCyclePolicy
    {
        public abstract bool TypeAdditioAllowed(Type type,IList<Type> allTypes);
        public abstract bool AplicationAllowed(Type type, IList<Type> allTypes);
    }
}
