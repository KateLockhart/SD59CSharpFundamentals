using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance_Classes
{
    public enum DietType { Herbivore, Omnivore, Carnivore }
    public class Animal
    {
        // Constructor
        public Animal()
        {
            Console.WriteLine("This is the Animal Constuctor.");
        }


        public int LegCount { get; set; }
        public bool IsMammal { get; set; }
        public bool HasTail { get; set; }
        public DietType DietType { get; set; }

        public virtual void Move()
        {

            Console.WriteLine($"This {GetType().Name} moves.");
        }

        //override will modify a method, property, indexer, etc
        //public override string ToString()
        //{
        //    return base.ToString(); 
       //}
    }
}
