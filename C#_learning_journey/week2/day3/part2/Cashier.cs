using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8_2
{
    internal class Cashier
    {
        IPayment payment;
        decimal amount;


        public Cashier(IPayment payment, decimal amount) {
        this.payment = payment;
            this.amount = amount;
        }

        public void checout()
        {
            payment.pay(amount);
        }
    }

   
}
