using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal class caterpillar : Vehicle, ILoader, IDriver
    {
        public caterpillar(int model, int year, string category) : base(model, year, category)
        {
        }

        public void Load()
        {
            Console.WriteLine("Load");
        }

        public void move()
        {
            Console.WriteLine("Move");
        }

        public void stop()
        {
            Console.WriteLine("Stop");
        }

        public void unLoad()
        {
            Console.WriteLine("unload");
        }
        void IDriver.start() {
            Console.WriteLine("Start From IDriver");
        }
        void ILoader.start() {
            Console.WriteLine("Start From ILoader");
        }

    }
}
