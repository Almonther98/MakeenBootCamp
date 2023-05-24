using System.Reflection;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Declaration
            int[] l = new int[6] { 1, 2, 3, 4, 5, 6 };
            string[] str = { "ee", "rr", "tt" };
            //or
            int[] l2 = new int[3];
            l2[0] = 1;
            l2[1] = 2;
            l2[2] = 3;

            //Multidimensional
            int[,] mtx = new int[3, 3];

            mtx[0, 0] = 1;
            mtx[0, 1] = 1;
            mtx[0, 2] = 1;
            mtx[1, 0] = 2;
            mtx[1, 1] = 2;
            mtx[1, 2] = 2;
            mtx[2, 0] = 3;
            mtx[2, 1] = 3;
            mtx[2, 2] = 3;

            // Jagged Array 

            int[][] jcd = new int[3][];
            jcd[0] = new int[] { 1, 1 };
            jcd[1] = new int[] { 2, 2, 2 };
            jcd[2] = new int[] { 3, 3, 3 };


            int[] sls = l[2..4];

            for (int i = 0; i < sls.Length; i++)
            {
                Console.WriteLine(sls[i]);
            }

            Console.WriteLine("next");
            int[] sls1 = l[..4];

            for (int i = 0; i < sls1.Length; i++)
            {
                Console.WriteLine(sls1[i]);
            }

            Console.WriteLine("next");
      
            int[] sls2 = l[1..^2];

            for (int i = 0; i < sls2.Length; i++)
            {
                Console.WriteLine(sls2[i]);
            }


            while (true)
            {
                Console.WriteLine("enter number");
                int number=  int.Parse( Console.ReadLine());
                if (number == 0)
                {
                    break;
                }

                Console.WriteLine(((number % 2)==0)? "even":"odd");

               

            }
         
            string s = null;
            s?.ToUpper();
            s = s ?? "mun";
            Console.WriteLine(s);
            Console.WriteLine();

            int r = 1;

            Console.WriteLine(r++);
            Console.WriteLine(++r);






        }
    }
}