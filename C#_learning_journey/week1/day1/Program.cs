namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program.mundhar();
        }

        static void mundhar() {
            int n = 55;
            int m = 55;
            n = m;
            int n2 = 34;
            object obj = new object();
            object obj2 = new object();

            Console.WriteLine(n.GetHashCode());
            Console.WriteLine(n2.GetHashCode());
            Console.WriteLine(m.GetHashCode());
            Console.WriteLine(obj.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());

            Console.WriteLine($"*****************-*****************");
            Console.WriteLine($"****************---****************");
            Console.WriteLine($"***************-----***************");
            Console.WriteLine($"**************-------**************");
            Console.WriteLine($"*************---------*************");
            Console.WriteLine($"************-----------************");
            Console.WriteLine($"***********-------------***********");
            Console.WriteLine($"**********---------------**********");
            Console.WriteLine($"*********-----------------*********");
            Console.WriteLine($"********-------------------********");
            Console.WriteLine($"*******---------------------*******");
            Console.WriteLine($"******-----------------------******");
            Console.WriteLine($"*****-------------------------*****");
            Console.WriteLine($"****---------------------------****");
            Console.WriteLine($"***-----------------------------***");
            Console.WriteLine($"**-------------------------------**");
            Console.WriteLine($"*---------------------------------*");
            Console.WriteLine($"---------> {n} <-----> {m} <---------");




            var h = 6;
            var f = 11;

            bool first = h == f; // false
            bool second = h != f; // true 
            bool third = h < f; // true 
            bool forth = h > f; // false
            bool fifeth = h <= f; // true 
            bool sixth = h >= f; // false

            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);
            Console.WriteLine(forth);
            Console.WriteLine(fifeth);
            Console.WriteLine(sixth);
            Console.WriteLine();
            Console.WriteLine(first ^ second  ); // if diffrent is true  
            Console.WriteLine(second ^ third );// if not diffrent is false   



        }

    }
}