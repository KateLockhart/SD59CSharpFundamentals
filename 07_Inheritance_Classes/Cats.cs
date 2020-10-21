using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Inheritance_Classes
{
    //this is how C# declares inheritance, thus Cat is child to the parent Animal
    public class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("This is the Cat Constructor.");
            IsMammal = true;
            DietType = DietType.Omnivore;
            LivesLeft = 9;

        }

        public int LivesLeft { get; set; }
        public virtual void MakeSound() 
        {
            Console.WriteLine("Meow.");
        }

        public override void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves quickly when they want.");
        }
    }

    public class Liger : Cat
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger Constructor.");
        }

        public string TeethSize { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Roar.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
            base.Move();
        }

    }
}
