using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int CNP { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, int age, int cnp, string address) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.CNP = cnp;
            this.Address = address;
        }

        public string ShowInfo()
        {
            return this.FirstName + " " + this.LastName + " with the age " + this.Age
                + " has the CNP -> " + this.CNP+" and live at the address -> "+this.Address;
        }
    }
}