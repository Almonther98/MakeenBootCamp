using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{
    internal class Cash : IPayment
    {

        public void pay(decimal amount)
        {
            Console.WriteLine($" Payed by cash ===> amount = {amount } $");
        }
    }
}
