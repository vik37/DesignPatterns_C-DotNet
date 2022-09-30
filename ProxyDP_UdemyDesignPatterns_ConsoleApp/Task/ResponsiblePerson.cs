using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyDP_UdemyDesignPatterns_ConsoleApp.Task
{
    public class ResponsiblePerson
    {
        private Person person;
        public ResponsiblePerson(Person person)
        {
            this.person = person;            
        }
        public int Age
        {
            get { return person.Age; }
            set { person.Age = value; }
        }
        public string Drink()
        {
            return Age > 18 ? person.Drink() : "too young";
        }

        public string Drive()
        {
            return Age > 16 ? person.Drive() : "too young";
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
