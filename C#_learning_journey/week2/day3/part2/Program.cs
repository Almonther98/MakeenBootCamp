namespace Day8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cashier opration = new Cashier(new Visa(), (decimal) 99.4);
            Cashier opration2 = new Cashier(new Cash(), (decimal)50.4);

            opration.checout();
            opration2.checout();
        }
    }
}