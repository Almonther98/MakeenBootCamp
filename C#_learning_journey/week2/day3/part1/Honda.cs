using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Honda : Vehicle, IDriver
    {
        public Honda(int model, int year, string category) : base(model, year, category)
        {
        }

        public void move()
        {
            Console.WriteLine("move");
        }

        public void start()
        {
         
        }

        public void stop()
        {
            Console.WriteLine("stop");
        }
    }
}
