using System.Transactions;

namespace day3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            dynamic number = "unvalid int ";

            while (true)
            {
                
                Console.WriteLine("enter number of student :");
                var s = Console.ReadLine();
                if (int.TryParse(s, out int z))
                {
                    if(z > 0) { 
                    number = int.Parse(s);
                    // numbrr = z
                    break;}
                }
                
                Console.WriteLine($"invalid number !!");
            }

            int[] listGrade =new int[number];


            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"enter Student {i+1} grade :");
                while (true)
                {

                    var s = Console.ReadLine();
                    if (int.TryParse(s, out int z))
                    {
                        listGrade[i] = int.Parse(s);
                        break;
                    }



                    Console.WriteLine($"invalid number !!");
                }

            }
            
            for (int i = 0;i < listGrade.Length; i++)
            {

                if (listGrade[i] >= 90)
                {
                    Console.WriteLine($"student number {i+1} get A ");
                }
                else if (listGrade[i] >= 80)
                {
                    Console.WriteLine($"student number {i+1} get B ");
                }
                else if (listGrade[i] >= 70)
                {
                    Console.WriteLine($"student number {i + 1} get C ");
                }
                else if (listGrade[i] >= 60)
                {
                    Console.WriteLine($"student number {i + 1} get D ");
                }
                else
                {
                    Console.WriteLine($"student number {i + 1} get F ");
                }

                
            }


        }
    }
}