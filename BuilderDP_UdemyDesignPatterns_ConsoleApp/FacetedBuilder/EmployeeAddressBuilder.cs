using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FacetedBuilder
{
    public class EmployeeAddressBuilder : EmployeeBuilder
    {
        public EmployeeAddressBuilder(Employee employee)
        {
            this.employee = employee;
        }
        public EmployeeAddressBuilder At(string streetAddress)
        {
            employee.Address = streetAddress;
            return this;
        }
        public EmployeeAddressBuilder WithPostcode(string poscode)
        {
            employee.Postcode = poscode;
            return this;
        }
        public EmployeeAddressBuilder In(string city)
        {
            employee.City = city;
            return this;
        }
    }
}
