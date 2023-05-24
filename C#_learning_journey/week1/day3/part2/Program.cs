namespace day3_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            dynamic reduce = "unvalid int ";

            while (true)
            {

                Console.WriteLine("enter reduce of circle :");
                var s = Console.ReadLine();
                if (int.TryParse(s, out int z))
                {
                    if (z > 0)
                    {
                        reduce = int.Parse(s);
                        // numbrr = z
                        break;
                    }
                }

                Console.WriteLine($"invalid reduce !!");
            }

            int opration = 0;

            while (true)
            {
                Console.WriteLine("enter 1 for circumference or 2 for Area to be found :");
                var s = Console.ReadLine();
                if (int.TryParse(s, out int z))
                {
                    if (z ==1 || z==2)
                    {
                        reduce = int.Parse(s);
                        // numbrr = z
                        break;
                    }
                }

                Console.WriteLine($"invalid opratin number !!");
            }


            if (opration == 1)
            {
                double circumference = 2* Math.PI * reduce;
                Console.WriteLine();
                Console.WriteLine($"circumference is --> {circumference}");
            }
            else
            {
                double Area =  Math.PI * Math.Pow( reduce, 2);
                Console.WriteLine();
                Console.WriteLine($"Area is --> {Area}");
            }



        }
    }
}