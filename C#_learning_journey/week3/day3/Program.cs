namespace Day13
{

    public delegate void Rectangle_(double length, double width);
    internal class Program
    {
        // multi cast delegator 
        static void Main(string[] args)
        {
            rectangel rectangel = new rectangel();  
            Rectangle_ rec = new Rectangle_(rectangel.getArea);
            rec += rectangel.getParametr;
            rec += rectangel.getAdd;
            rec += rectangel.getSubstract;
            rec += rectangel.getDvition;

            rec(10,20);

        }
    }


    class rectangel
    {

        public double length { get; set; }
        public double width { get; set; }

        public void getArea(double length, double width)
        {
            Console.WriteLine($"the area is : {length * width}");
        }

        public void getParametr(double length, double width)
        {
            Console.WriteLine($"the tParametr is : {2*(length + width)}");
        }


        public void getAdd(double length, double width)
        {
            Console.WriteLine($"the Add is : { (length + width)}");
        }

        public void getSubstract(double length, double width)
        {
            Console.WriteLine($"the Substract is : {(length - width)}");
        }

        public void getDvition(double length, double width)
        {
            Console.WriteLine($"the Dvition is : {(length - width)}");
        }
    }
}