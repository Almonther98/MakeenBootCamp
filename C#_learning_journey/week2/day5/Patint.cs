using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day10
{
    internal class Patint
    {
        public string patientName { get; set; }
        public int age { get; set; }
        public bool relationship { get; set; }
        
        public int apointmentDay { get; set; }



        public Patint(string patientName, int age, bool relationship, int apointmentDay)
        {
            this.patientName = patientName; 
            this.age = age;
            this.relationship = relationship;
            this.apointmentDay = apointmentDay;
          
        }
    }
}
