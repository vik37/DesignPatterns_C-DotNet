using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryDP_Homework
{
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public Person(int id,string name)
        {
            this.Id = id;
            this.Name = name;
        }        
        public override string ToString()
        {
            return $"Id: {Id}, name: {Name}";
        }
    }
}
