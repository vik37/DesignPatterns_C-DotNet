using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.PersonBuilder
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>> 
        where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorskAsA(string position)
        {
            person.Position = position;
            return (SELF)this;
        }
    }
}
