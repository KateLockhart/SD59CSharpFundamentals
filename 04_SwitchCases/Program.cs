using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch Case
            //1. Call Switch 2.variable name you're using 
            //3.State a case, curly braces are optional for the body of case
            //4.use required break to stop code
            int input = 1;
            //1       2
            switch (input)
            {
                //3
                case 1:
                    {
                        Console.WriteLine("Hello");
                        //4
                        break;
                    }
                case 2:
                    Console.WriteLine("What are you doing?");
                    break;
                default:
                    Console.WriteLine("This is default. It will execute if no other case is evaluated as true. Defaults are not required.");
                    break;
            }


            DayOfWeek today = DateTime.Today.DayOfWeek;

            switch (today)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Oooo it's thirsty Thursday, at least it's almost Friday.");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Thank deity it's Friday.");
                    break;
                case DayOfWeek.Saturday:
                    break;
            }

            //switch case to make multiple cases to have the same output
            switch (today)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("We are open! 10am - 8pm");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Sorry, we're closed. Come back Monday through Friday!");
                    break;
            }


            //-----CHALLENGE-----
            //Ask the user how they are feeling on a scale of 1-5.
            //Capture their input and run it through a switch statement.
            //Output a different response for each value.
            //If they respond out of range, let them know.

            Console.WriteLine("How are you feeling on a scale of 1-5?");
            int answer = int.Parse(Console.ReadLine());
            switch (answer)
            {
                case 1:
                    Console.WriteLine("That's too bad, I'm sorry you're feeling low.");
                    break;
                case 2:
                    Console.WriteLine("It could be better, I know.");
                    break;
                case 3:
                    Console.WriteLine("Okay is better than nothing these days!");
                    break;
                case 4:
                    Console.WriteLine("I'm glad you're good!");
                    break;
                case 5:
                    Console.WriteLine("Wow! That's great. I wish I was doing so well.");
                    break;
                default:
                    Console.WriteLine("That's not a level in my range, please enter 1-5.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
