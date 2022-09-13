using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad
{
    public class Person : ICloneable
    {
        public string[] Names;
        public Address Address;
        public Person(string[] names, Address address)
        {
            if(names == null) 
            {
                throw new ArgumentNullException(paramName: nameof(names));
            }
            if(address == null)
            {
                throw new ArgumentNullException(paramName: nameof(address));
            }
            Names = names;
            Address = address;
        }

        public object Clone()
        {
            //return new Person(Names, Address);
            return new Person(Names, (Address) Address.Clone());
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)}: {Address}";
        }
    }
}
