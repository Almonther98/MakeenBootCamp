namespace Day5_
{
    internal class Program
    {

        public static void swap(ref int x, ref int y) => x = x ^ y ^ (y = x);
    
        static void Main(string[] args)
        {
            int x, y, S, M;
            x = 5;
            y = 10;
            //sumMulti(x, y, out S, out M);
            swap(ref x, ref y);
            Console.WriteLine($"X+Y is {x}\nX*Y is {y}");

            Calculator clc = new Calculator();
            int a = 3 , b = 5;
            double c = 2.15, d = 6.54;
            string e = "Almundhar", f = " Almamari";
            Console.WriteLine(clc.add(a,b));
            Console.WriteLine(clc.add(c,d));
            Console.WriteLine(clc.add(e,f));

            if (clc.checkOddNumber(5))
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }


            Person p1 = new Person("mundhar",33,true );

            Console.WriteLine( p1.firstName );
        }
    }
}