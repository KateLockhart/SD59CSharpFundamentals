using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    public enum VehicleType { Car, Truck, Van, Motorcycle, Spaceship, Plane, Boat} 
    public class Vehicle
    {
        // Constructor
        //adding a constructor to the class, public makes it available to all the files
        //brackets house parameters (type name)
        //curly brackets house 
        public Vehicle(string make, string model, double mileage, VehicleType type)
        {
            Make = make;
            Model = model;
            Mileage = mileage;
            TypeOfVehicle = type;
        }

        // Properties
        //will make properties accessible to other places
        
        public string Make { get; set; }
        public string Model { get; set; }
        public double Mileage { get; set; }
        public ValueType TypeOfVehicle { get; set; }


      
    }
}
