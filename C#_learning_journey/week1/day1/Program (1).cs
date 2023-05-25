namespace programOfDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            **************************************************************************************
            *******this program has bref explaining with examples about basics of C# languge *****
            **************************************************************************************
             */

            //** Console is pre-bult class that handel input output to the user 
            // here is an example how it used to show message and take name as input

            Console.WriteLine("Please enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("hi " + name);

            //** Variables
            // used to stor informatin inside within the program and phiscaly located in the RAM.
            // tow main type of datatypes of variables in C# Value Type and Reference Type
            // Value Type: -------> fixed siz known 
            // Reference Type: -------> not known size 

            // value data types  examples:

            //declration
            bool check = false;
            byte byte_ = 8;
            char char_= 'a';
            double d= 2.5;
            float f = 1.0f;
            int i = 0;
            long l = 10000;
            short s = 4;
            // range for some datatypes
            Console.WriteLine();
            Console.WriteLine("variables:");
            Console.WriteLine($"minimum value of byte is {byte.MinValue} and maxmum value is {byte.MaxValue}");
            Console.WriteLine($"minimum value of double is {double.MinValue} and maxmum value is {double.MaxValue}");
            Console.WriteLine($"minimum value of float is {float.MinValue} and maxmum value is {float.MaxValue}");
            Console.WriteLine($"minimum value of integr is {int.MinValue} and maxmum value is {int.MaxValue}");
            Console.WriteLine($"minimum value of long is {long.MinValue} and maxmum value is {long.MaxValue}");
            Console.WriteLine($"minimum value of short is {short.MinValue} and maxmum value is {short.MaxValue}");
            Console.WriteLine();

            // check hashcode to diffrechate from refrence datatype
            Console.WriteLine("hash code of integer i ---->" + i.GetHashCode());

            // Reference data types example:
            //string declration
            String ss = "this is strng content ";

            //object creation
            // also object is under refrence we can see that from hash code is diffrent from value type and like random.
            Object obj = new object();
            Console.WriteLine("hash code of obj ---->" + obj.GetHashCode());


            //* dynamic and var keywords 

            // dynamic is dinamicly spcfy the data type at the momment any time during the running of the program
            dynamic dy = 33; // will be int datatype
            //also it can be changed during comple time 
            dy = "fff";

            // var is dynamicly specification of the datatype and cannot be changed once spcifide 
            var vr = true; // will be boolean datatype 
            // also var has key words to spcifi the datatype
            var ff = 2f; // will be float datatype
            var ll = 33l;// will be long 

            //*********************************************************************************************************************

            // boolean and opreation
            var h = 6;
            var o = 11;
            // compration Operators
            bool first = h == o; // false
            bool second = h != o; // true 
            bool third = h < o; // true 
            bool forth = h > o; // false
            bool fifeth = h <= o; // true 
            bool sixth = h >= o; // false

            // logical Operators 
            bool andop = (h == o) && (h != o) ; // false 
            bool orop = (h == o) || (h != o); // true
            bool notop =  (h != o); // true
            bool xor = (h == o) ^ (h != o); // true ( when deffrent it is true )



        }
    }
}