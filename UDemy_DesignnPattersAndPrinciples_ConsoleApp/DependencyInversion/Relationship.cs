using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion.enums;
using UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion.interfaces;

namespace UDemy_DesignnPattersAndPrinciples_ConsoleApp.DependencyInversion
{
    public class Relationship : IRelationshipBrowser
    {
        private List<(Person, Relationships, Person)> relations = new List<(Person, Relationships, Person)> ();

        public void AddParentAndChild(Person parent, Person child)
        {
            relations.Add((parent,Relationships.Parent,child));
            relations.Add((child, Relationships.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var r in relations.Where(
               x => x.Item1.Name == "John" && x.Item2 == Relationships.Parent
            ).Select(x => new { x.Item3 }))
            {
                yield return r.Item3;
            }
        }

        // public List<(Person, Relationships, Person)> Relations => relations;
    }
}
