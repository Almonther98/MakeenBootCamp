using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class Vehicle
    {
        public int model { get; set; }
        public int year { get; set; }
        public string category { get; set; }

        public Vehicle(int model, int year, string category)
        {
            this.model = model;
            this.year = year;
            this.category = category;
        }
    }
}
