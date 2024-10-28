using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Task
{
    internal class Planet
    {
        private double _planetId = 1;
        public string Name { get; set; }
        public double PlanetId { get; set; }
        public double Area { get; set; }
        public Planet(string name, double area)
        {
            Name = name;
            Area = area;
            PlanetId = ++_planetId;
        }
        public string ToString()
        {
            return $" Name:{Name} Area:{Area}";
        }
    }
}

