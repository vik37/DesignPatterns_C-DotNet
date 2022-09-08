using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FacetedBuilder
{
    public class EmployeeBuilder   // Facade.
    {
        protected Employee employee = new Employee();
        public EmployeeJobBuilder works => new EmployeeJobBuilder(employee);
        public EmployeeAddressBuilder lives => new EmployeeAddressBuilder(employee);

        public static implicit operator Employee(EmployeeBuilder eb)
        {
            return eb.employee;
        }
    }
}
