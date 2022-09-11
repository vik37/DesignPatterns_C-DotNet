using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDP_Homework
{
    public class PersonFactory
    {
        private int count = 0;
        private Person CreatePersonInit(string name)
        {            
            return new Person(count++,name);
        }
        public void CreatePerson(string name)
        {
            var person = CreatePersonInit(name);
            Console.WriteLine(person);
        }
    }
}
