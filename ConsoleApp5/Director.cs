using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
   
    class Director : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public Director(string firstName, string lastName, string country)
        {
            FirstName = firstName;
            LastName = lastName;
            Country = country;
        }
        public override string ToString()
        {
            return $"First name: {FirstName}\nLast name: {LastName}\nCountry: {Country}";
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
