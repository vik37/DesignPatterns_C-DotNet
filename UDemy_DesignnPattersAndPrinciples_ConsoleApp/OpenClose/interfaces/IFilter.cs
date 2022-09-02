using System;
using System.Collections.Generic;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.OpenClose.interfaces
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecifications<T> spec);
    }
}
