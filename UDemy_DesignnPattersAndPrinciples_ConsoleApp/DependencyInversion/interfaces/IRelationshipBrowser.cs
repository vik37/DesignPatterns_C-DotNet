using System;
using System.Collections.Generic;
using System.Text;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion.interfaces
{
    public interface IRelationshipBrowser
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }
}
