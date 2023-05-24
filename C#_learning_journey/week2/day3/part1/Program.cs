namespace Day8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Honda honda = new Honda(1,1999,"accord");
            honda.move();
            honda.stop();

            IDriver caterpillar = new caterpillar(1, 2000, "ABC");
            caterpillar.move();
            caterpillar.stop();
            caterpillar.start();

        }
    }
}