using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_2
{
    internal class Reports
    {
        public delegate bool SalesConditon(Employee e);
        public void ProcessEmployee(Employee[] emp, string Title, SalesConditon cond)
        {

            Console.WriteLine(Title);
            Console.WriteLine("*****************************************");
            foreach (Employee e in emp)
            {
                if (cond(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.gender} | {e.TotalSales}");
                }
            }
            Console.WriteLine("\n\n");

        }
    }
}
