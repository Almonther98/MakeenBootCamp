using System.Collections;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace day10
{
    internal class Program
    {
        static void Main(string[] args)
        {


           






            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            int age = 0;
            while (true) 
            {
                Console.WriteLine("Please enter your age:");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int age_))
                {
                    age = age_;
                    break;
                }
                Console.WriteLine("invalid input!");
            }


           
            bool relationship;
            while (true) 
            {
                Console.WriteLine("Please enter your relationship stutuse (m for marrid // s for single) :");
                string stutuse = Console.ReadLine();
                if ( stutuse.ToLower() == "m") {
                    
                        relationship = true;
                    break;
                     
                
                }
                else if (stutuse.ToLower() == "m")
                {
                    relationship = false;
                    break;
                }
                Console.WriteLine("invalid input!");
            }

            

            int[] pikedDayse = new int[7];

            pikedDayse[5] = 1;
            pikedDayse[6] = 1;
            bool flag = false;
            Patint patint;
            while (true) 
            {
                Console.WriteLine("Please enter day to pik an apontment (1 -7) :");
                string input = Console.ReadLine();

                switch (input) { 
                    case "7":
                    case "6":
                    case "5":
                        pikedDayse[4] = 1;
                        flag = true;
                         patint = new Patint(name, age, relationship, 4);
                        break;
                    case "4":
                        pikedDayse[3] = 1;
                        flag = true;
                         patint = new Patint(name, age, relationship, 3);
                        break;
                    case "3":
                        pikedDayse[2] = 1;
                        flag = true;
                        patint = new Patint(name, age, relationship, 2);
                        break;
                    case "2":
                        pikedDayse[1] = 1; 
                        flag = true;
                        patint = new Patint(name, age, relationship, 1);
                        break;
                    case "1":
                        pikedDayse[0] = 1; 
                        flag = true;
                        patint = new Patint(name, age, relationship, 0);
                        break;
                }
                if(flag) { break; }
                Console.WriteLine("invalid day!");
            }


            Console.WriteLine(patint.patientName+ "  "+ patint.age+ "  "+ patint.relationship + " "+ patint.apointmentDay );

        }
    }
    public enum WeekDay 
    {
        Sunday = 1,
        Monday ,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
        
    }

}