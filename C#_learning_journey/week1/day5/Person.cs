using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_
{
    internal class Person
    {
        public int id;
        public string firstName;
        public string lastName;
        public int age;
        public bool ismearred;
        public string jop;
        public string address ;

        public Person(int id , string firstName, string lastName,int age, bool ismearred, string jop, string address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.ismearred = ismearred;
            this.jop = jop;
            this.address = address;
        }
        public Person( string firstName, int age, bool ismearred )
        {
            this.id = 1;
            this.firstName = firstName;
            this.lastName = "NA";
            this.age = age;
            this.ismearred = ismearred;
            this.jop = "NA";
            this.address = "NA";
        }
    }
}
