using System;
using System.Collections.Generic;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.interfaces
{
    public interface ISpecifications<T>
    {
        bool IsSatisfied(T t);
    }
}
