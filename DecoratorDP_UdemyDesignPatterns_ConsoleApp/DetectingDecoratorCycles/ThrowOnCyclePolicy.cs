using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorDP_UdemyDesignPatterns_ConsoleApp.DetectingDecoratorCycles
{
    public class ThrowOnCyclePolicy : ShapeDecoratorCyclePolicy
    {
        private bool Handler(Type type,IList<Type> allTypes)
        {
            if (allTypes.Contains(type))
            {
                throw new InvalidOperationException
                    (
                        $"Cycle detected! Type is already a {type.FullName}!"
                    );
            }
            return true;
        }
        public override bool AplicationAllowed(Type type, IList<Type> allTypes)
        {
            return Handler(type, allTypes);
        }

        public override bool TypeAdditioAllowed(Type type, IList<Type> allTypes)
        {
            return Handler(type, allTypes);
        }
    }
}
