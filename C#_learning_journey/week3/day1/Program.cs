namespace phonBook
{
    internal class Program
    {
        static void Main(string[] args)
        {


            PhonBook book1 = new PhonBook(5);

            book1[0, "mundhar"] = "99999999";

            Console.WriteLine(book1["mundhar"]);
        }
    }
}