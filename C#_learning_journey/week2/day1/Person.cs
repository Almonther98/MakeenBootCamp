
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Person
    {
        // encapculation 
        private String fName ;
        private String lName ;
        private int age ;
        private decimal salary;
        public string relationship { set; get; } 

        // setter 
        public void setFname(String fName) { this.fName = fName; }
        public void setLName(String lName) { this.lName = lName; }
        public void setAge(int age) { this.age = age; }
        public void setSalary(int salary) { this.salary = salary; }
        // getter 
        public string  getFName() { return this.fName;}
        public string getLName() { return this.lName; }
        public int getAge() { return this.age; }
        public decimal getSalary() { return this.salary; }


        public String displayInfo() => $"First Name : {fName}\nLast Name : {lName}\nAge : {age}\nRelationship : {relationship} ";

        public int PersaonAge(int input ) { return (DateTime.Now.Year - input); }
    
    
    }

}

