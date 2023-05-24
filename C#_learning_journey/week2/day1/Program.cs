using System.Security.Cryptography.X509Certificates;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();


            //Console.WriteLine("enter date of barth : dd/mm/yy ");
            //String[] date = Console.ReadLine().Split("/");

            //int age = p1.PersaonAge(int.Parse( date[2]));
            //p1.setFname("Almundhar");
            //p1.setLName("Almamari");
            //p1.setAge(age);
            //p1.setSalary(700);
            //p1.relationship = "singale";

            //Console.WriteLine(p1.displayInfo());


            BankAccount account = new BankAccount(11111);

            account.deposit(1000);
            account.withdrw(100);

           
        }



    }

       
}