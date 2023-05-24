using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_tot
{
    public class Employe
    {
        public const double TAX = 0.03;
        public string fName;
        public string lName;
        public double wage;
        public double loggedHours;


        public void Greeting()
        {
            Console.WriteLine($"Hello {fName} {lName}");
        }

        public int addOne(ref int num)
        {
            num += 1;
            return num;
        }
    }
}
