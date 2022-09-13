using PrototypeDP_UdemyDesignPatterns_ConsoleApp.ConstructorCopy;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TestDP_Methods.Prototype_Test
{
    internal class PersonObjectComperer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if (x == null && y == null)
                { return true; }
            else if (x == null || y == null)
                { return false; }
            else if (object.ReferenceEquals(x, y))
                { return true; }
            else if (x.Address == null && y.Address == null)
                { return true; }
            else if (x.Address == null || y.Address == null)
                { return false; }
            else if (object.ReferenceEquals(x.Address, y.Address))
            { return true; }
            else
            {
                return x.Names == y.Names
                           && x.Address.HouseNumber == y.Address.HouseNumber
                           && x.Address.StreetName == y.Address.StreetName;
            }
        }

        public int GetHashCode([DisallowNull] Person obj)
        {
            return $"{obj.Names}{obj.Address.HouseNumber}{obj.Address.StreetName}".GetHashCode();
        }
    }
}
