using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // New up my vehicle instance
            Vehicle firstVehicle = new Vehicle("Toyota");

            //Setting the make property in make instance
            firstVehicle.Make = (firstVehicle.Make);

            //Getting the make property from firstVehicle and writing to the console
            Console.WriteLine(firstVehicle.Make);

            //These are setting the rest of the properties
            firstVehicle.Model = "Civic";
            firstVehicle.Mileage = 12345.67d;
            firstVehicle.TypeOfVehicle = VehicleType.Car;

            //Writing a string by getting the vehicle property values by the . (dot) method
            Console.WriteLine($"I own a {firstVehicle.Make} {firstVehicle.Model} and it has {firstVehicle.Mileage} miles on it.");


            //using the constructor to assign property values 
            Vehicle car = new Vehicle("Toyota", "Corolla", 21300, VehicleType.Car);
            Vehicle rocket = new Vehicle("SpaceX", "Falcon Heavy", 3000000, VehicleType.Spaceship);

            Console.WriteLine(rocket.Model);


            
            Person instructor = new Person();
            //these are both gets & sets
            instructor.FirstName = "Joshua";
            instructor.LastName = "Tucker";
            //can only use get for FullName
            Console.WriteLine(instructor.FirstName);

            //changing the first and last will change the full name
            //instructor.FirstName = "Casey";
            //instructor.LastName = "Wilson";
            //Console.WriteLine(instructor.FirstName);

            instructor.DateOfBirth = new DateTime(1991, 9, 11);
            Console.WriteLine(instructor.Age);

            instructor.Transport = firstVehicle;
            Console.WriteLine(instructor.Transport.TypeOfVehicle);



            Person student = new Person();
            student.FirstName = "Wes";
            student.LastName = "Winn";

            instructor.SayHello();
            //^ouput of: Hello, my name is Joshua.
            instructor.SayHello(student.FirstName);
            //^output of: Hello Wes, my name is Joshua.
            instructor.SayHello(student);
            //^output of: Hello Wes Winn, my name is Joshua.


            Console.ReadLine();
        }
    }
}
