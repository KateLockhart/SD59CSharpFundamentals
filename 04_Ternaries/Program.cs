using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Ternaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary: conditional operator that evaluates a boolean, returns a value based on true/false result
            //Only good for an asisgnment; is an inline if else statement
            //paranthesis is where the conditional is housed

            int age = 31;     // <-- aka hardcoding in data
                         //condition  if true : if false
            bool isAdult = (age > 17) ? true : false;
            Console.WriteLine("Age is over 17: " + isAdult);


            int numOne = 10;
            //if this evalustes as true numTwo = 30, if false numTwo = 20
            int numTwo = (numOne == 10) ? 30 : 20;
            Console.WriteLine(numTwo);

            Console.WriteLine((numTwo == 30) ? "True" : "False");

            //-------------------------------------------------------

            //function, Methods are function's that we definie within a class... outside of a class it is just a function
            //functions are declared independantly, thus can be used throughout when called 
            int DoubleValue(int num)
            {
                return num * 2;
            }

            int TripleValue(int num)
            {
                return num * 3;
            }

            int dataToManipulate = 5;
            Console.WriteLine(dataToManipulate);

            int doubleValue = DoubleValue(dataToManipulate);
            Console.WriteLine(doubleValue);

            string userInput = Console.ReadLine();
            int manipulatedData = (userInput == "double") ? DoubleValue(dataToManipulate) : TripleValue(dataToManipulate);

            Console.WriteLine(manipulatedData);

            Console.ReadLine();
        }
    }
}
