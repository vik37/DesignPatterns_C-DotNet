using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles
{
    public class AbsorbCyclePolicy : ShapeDecoratorCyclePolicy
    {
        public override bool AplicationAllowed(Type type, IList<Type> allTypes)
        {
            return true;
        }

        public override bool TypeAdditioAllowed(Type type, IList<Type> allTypes)
        {
            return !allTypes.Contains(type);
        }
    }
}
