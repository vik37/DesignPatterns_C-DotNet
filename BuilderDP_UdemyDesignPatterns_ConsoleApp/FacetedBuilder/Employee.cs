using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDP_UdemyDesignPatterns_ConsoleApp.FacetedBuilder
{
    public class Employee
    {
        // address
        public string Address, Postcode, City;

        // employment
        public string CompanyName, Position;

        public int AnnualIncome;

        public override string ToString()
        {
            return $" Address - {nameof(Address)}: {Address}, {nameof(Postcode)}: {Postcode}, {nameof(City)}: {City} \n " +
                $"Employment - {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position} \n {nameof(AnnualIncome)}: {AnnualIncome}";
        }

    }
}
