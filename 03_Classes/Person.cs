using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public class Person
    {
        // Properties: First Name, Last Name, Full Name, Date of Birth, Age
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //can declare vaiables in the get/set to call on and return values
        //we built the string and use return to access it
        //we remove set to make it a "read only" property, it will read a property but cannot change it
        //thus full name stays the same(can only get) where first and last name can get and set(changes to these will change full name)
        public string FullName
        {
            get
            {
                string fullName = $"{FirstName} {LastName}";
                return fullName;
            }
           }
        public DateTime DateOfBirth { get; set; }
        public int Age 
        {
            get
            {
                //Take the DateOfBirth and figure out length of time since then
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                //Calculate our age based off the TimeSpan, used total days devided by total days in a year
                double totaleAgeInYears = ageSpan.TotalDays / 365.25;
                //Convert double years into an int
                int yearsOfAge = Convert.ToInt32(Math.Floor(totaleAgeInYears));
                return yearsOfAge;
            }
        }

        public Vehicle Transport { get; set; }


        // Methds
        //Parts of a method
        // 1. Access modifier => public, internal, private (examples)
        // 2. Return Type => the output from the method
        // 3. Method signature => Name and parameters-put in braces (input)
        // 4. Body of the Code => Logic/Code that gets executed with the method runs

        //1      2      3
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {FirstName}.");
        }
        //overloading by having the same return type name but different parameters
        //it doesn't care what the value is as long as it's the same parameter
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello {name}, my name is {FirstName}.");
        }
        public void SayHello(Person person)
        {
            Console.WriteLine($"Hello {person.FullName}, my name is {FirstName}.");
        }
    }
}
