namespace class_tot
{

    /*
     COPYRIGHTS 2023
     To the extent possible under law, Al-Khalil has waived
     all copyright and related or neighboring rights to The Documentation Compendium.
        
     */

    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Employees");

            string Employees = Console.ReadLine();
            int numEmployees = int.Parse(Employees);
            Employe[] empls = new Employe[numEmployees];
            for (int i  = 0; i < numEmployees; i++)
            {
                Employe employe = new Employe();
                
                Console.WriteLine("Enter the  Employee First Name:");
                employe.fName = Console.ReadLine();
                Console.WriteLine("Enter the  Employee Last Name:");
                employe.lName = Console.ReadLine();
                Console.WriteLine("Enter the wage:");
                string tempWage = Console.ReadLine();
                employe.wage = double.Parse(tempWage);
                Console.WriteLine("Enter the logged hours for the employee");
                string tempLogged = Console.ReadLine();
                employe.loggedHours = double.Parse(tempLogged);
                Console.WriteLine("************************************************************************");

                empls[i] = employe;
            }
            
            for(int i = 0;i < numEmployees;i++)
            {
                double totalSalary = empls[i].loggedHours * empls[i].wage;
                double taxRate = totalSalary * Employe.TAX;
                double netSalary = totalSalary - taxRate;
                Console.WriteLine("**********************Employee information******************************");
                empls[i].Greeting();
                //Console.WriteLine($"Employee Full Name: {empls[i].fName} {empls[i].lName}");
                Console.WriteLine($"Employee Wage: {empls[i].wage}");
                Console.WriteLine($"Employee Logged Hours: {empls[i].loggedHours}");
                Console.WriteLine($"Employee Total Salary: {totalSalary}");
                Console.WriteLine($"Employee Tax Rate: {taxRate}");
                Console.WriteLine($"Employee Neet Salary: {netSalary}");
                Console.WriteLine("************************************************************************");

            }

            int num = 18;
            Employe employe1 = new Employe();

            employe1.addOne(ref num);

            Console.WriteLine(num);
        }
    }
}