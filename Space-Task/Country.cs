using Core.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Task
{
    internal class Country
    {
        private double _countryId = 1;
        public string Name { get; set; }
        public double CountryId { get; set; }
        public double Area { get; set; }
        public string Anthem { get; set; }
        public Region region { get; set; }
        public Country(string name, double area, string anthem)
        {
            Name = name;
            CountryId = ++_countryId;
            Area = area;
            Anthem = anthem;
        }
        public string ToString()
        {
            return $" Name:{Name} Area:{Area}";
        }

    }
}

