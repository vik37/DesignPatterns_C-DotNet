using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.PersonBuilder
{
    public abstract class PersonBuilding
    {
        protected Person person = new Person();

        public Person Build()
        {
            return person;
        }
    }
}
