
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class BankAccount
    {
        private const int  MAX_WITHDRW = 1000;
        private readonly  int  acountNumber;
        private decimal balance;

        public BankAccount(int acountNumber)
        {
            this.acountNumber = acountNumber;
        }

  

        public void deposit(decimal amount)
        {
            if (amount > 0) {  
                this.balance += amount;
                logg("successful oprtion!");
            }
            else { 
                logg("unsuccessful  opration : invaled amount ");
            }
        }

        public void withdrw(decimal amount) {


            if (amount < 0)
            {
                logg("unsuccessful  opration : invaled amount ");
                return;
            }
            else if (amount > balance)
            {
                logg("unsuccessful  opration : your balance below your rqusted amount ");
                return;
            }


 
            else if (amount > MAX_WITHDRW)
            {

                logg("unsuccessful  opration : you cannot withdrw more than 1000 ");
                return;
            }

            else
            {
                this.balance -= amount;
                logg("successful oprtion!");
                return;
            }
                
              
            }




        


        private void logg(string message)
        {

            Console.WriteLine($"****{DateTime.Now.ToString("dd-MM-yyyy HH:mm")}*********");
            Console.WriteLine();
            Console.WriteLine(message);
            Console.WriteLine();
            Console.WriteLine($"account information :\nAccount Naumber : {acountNumber }\nYour Balance: {balance}");

        }
    }
}
