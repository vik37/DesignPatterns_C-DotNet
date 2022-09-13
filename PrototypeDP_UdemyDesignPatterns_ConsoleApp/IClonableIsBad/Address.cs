using System;
using System.Collections.Generic;
using System.Text;

namespace PrototypeDP_UdemyDesignPatterns_ConsoleApp.IClonableIsBad
{
    public class Address : ICloneable
    {
        public string StreetName;
        public int HouseNumber;
        public Address(string streetName, int houseNumber)
        {
            if(streetName == null)
            {
                throw new ArgumentNullException(paramName: nameof(streetName));
            }
            StreetName = streetName;
            HouseNumber = houseNumber;
        }

        public object Clone()
        {
            return new Address(StreetName, HouseNumber);
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }
    }
}
