using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FacetedBuilder
{
    public class EmployeeJobBuilder : EmployeeBuilder
    {
        public EmployeeJobBuilder(Employee employee)
        {
            this.employee = employee;
        }
        public EmployeeJobBuilder At(string companyName)
        {
            employee.CompanyName = companyName;
            return this;
        }
        public EmployeeJobBuilder AsA(string position)
        {
            employee.Position = position;
            return this;
        }
        public EmployeeJobBuilder Earning(int ammount)
        {
            employee.AnnualIncome = ammount;
            return this;
        }
    }
}
