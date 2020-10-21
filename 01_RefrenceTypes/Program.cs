using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_RefrenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Strings 
            string declared; 
            declared = "This is assignment.";
            //Write out something to the console
            Console.WriteLine("What is your first name?");
            //Read line will wait until info is wrriten to process
            string firstName = Console.ReadLine();

            Console.WriteLine("Hello " + firstName);

            Console.WriteLine("What's your last name though?");
            string lastName = Console.ReadLine();

            Console.WriteLine("Ah, nice to meet you " + firstName + " " + lastName + ".");

            //Composite formatting 
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);
            Console.WriteLine(compositeFullName);

            //String interpolation
            string interpolatedFullName = $"{firstName} {lastName}";
            Console.WriteLine(interpolatedFullName);

            //Concatenation
            string concatenatedFullName = firstName + " " + lastName;
            Console.WriteLine(concatenatedFullName);

            // Collections
            //using arrays to hold data, array has a zero index
            //are static items, thus limited to amount of items listed in it's origonal declaration 
            string[] stringArray = { "Hello", "World", firstName, lastName };
            //indexer used to acess array data
            string thirdItem = stringArray[2];
            Console.WriteLine("The third item is " + thirdItem);
            //will change hello to hey there 
            stringArray[0] = "Hey there";
            Console.WriteLine(stringArray[0]);

            // List
            //list class needs a type in <>
            //new creates a new instance, needed to initialize the new list 
            List<string> listOfStrings = new List<string>();
            List<string> anotherRefrence = listOfStrings;
            listOfStrings.Add("Hello there");

            //Queue
            Queue<int> firstInFirstOut = new Queue<int>();
            //enqueue adds to queue and dequeue remoes it
            firstInFirstOut.Enqueue(37);
            int output = firstInFirstOut.Dequeue();

            //Stack
            //opisite of queue
            Stack<int> firstInLastOut = new Stack<int>();

            //Dictionary
            //only matches two things at most
            //needs both a type for the key and value <key, value>
            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();
            keyAndValue.Add(42, "Kate");

            Console.ReadLine();
        } 
    }
}
