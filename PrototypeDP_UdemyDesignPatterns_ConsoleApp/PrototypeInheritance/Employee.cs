using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.PrototypeInheritance
{
    public class Employee : Person, IDeepCopyable<Employee>
    {
        public int Salery;
        public Employee() { }
        public Employee(string[] names, Address address, int salery)
            : base(names,address)
        { 
            Salery = salery;
        }

        public void CopyTo(Employee target)
        {
            base.CopyTo(target);
            target.Salery = Salery;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salery)}: {Salery}";
        }
        //public Employee DeepCopy()
        //{
        //    return new Employee((string[])Names.Clone(), Address.DeepCopy(), Salery);
        //}

    }
}
