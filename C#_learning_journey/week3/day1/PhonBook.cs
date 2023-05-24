using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonBook
{
    internal class PhonBook
    {
        private string[] names;
        private string[] numbers;
        private int size;
        private int counter=0;


        public string this[int idx,string name]
        {
            set { this.names[idx] = name; this.numbers[idx] = value; }
            
        }

        public string this[ string name]
        {
            get
            {
                for (int i = 0; i < size; i++)
                {
                    if (this.names[i] == name) return "Name: " + this.names[i] + "  Numbers: "+  this.numbers[i];
                }

                return "notfound !";
            }
        }



        public PhonBook( int size)
        {
            this.size = size;
            this.names = new string[size];
            this.numbers = new string[size];
        }

        // set value 
        public void setValue( string name, string number  )
        {
            if(counter>size-1) {
                Console.WriteLine("exceed the numbers limit");
                return;
            }
            this.names[counter] = name;
            this.numbers[counter] = number;
            counter++;
        }


        public string getValue( string name )
        {

            int pos = 0;
            for ( int i = 0;i< size; i++)
            {
                if (names[i] == name ) { pos = i; }
            }

            return $"Name: {names[pos]}   Number: {numbers[pos]}";
        }

    }


}
