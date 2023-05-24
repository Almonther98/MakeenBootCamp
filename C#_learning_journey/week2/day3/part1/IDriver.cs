using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    internal interface IDriver
    {
        void move();
        void stop();

        void start();
    }
}
