using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vet
{
    public abstract class Animal
    {
        public string date { get; set; }
        public string name { get; set; }
        public string place { get; set; }
        public string family { get; set; }
        public string species { get; set; }
        public double weight { get; set; }

        public Animal(string date, string name, string place, string family, string species, double weight)
        { 
            this.date = date;
            this.name = name;
            this.place = place;
            this.family = family;
            this.species = species;
            this.weight = weight;
        }
    }
}
