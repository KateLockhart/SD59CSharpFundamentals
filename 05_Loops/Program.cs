using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loops - 
            //---------------------------------------------------------------------------------------
            int total = 1;

            // WHILE LOOP

            while (total != 10)
            {
                Console.WriteLine(total);
                // reassigning the value of total to equal total + 1
                //can be written total++; or what's written below
                //total += 1; sets value of total + 1

                total = total + 1;
            }

            //reset the value of total to test another loop
            total = 0;
            //    condition in parentheses, just like all the syntax with Conditionals
            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal reached");
                    break;
                }
                //like an else, this will fire until total is equal to 10, then hits the console and break
                total++;
            }
            total++; // this will take the value of total to 11

            //ANOTHER EXAMPLE 

            Random rand = new Random();

            int someCount;
            bool keepLooping = true;

            while (keepLooping)
            {    //random will generate a random number between 0-19 with how its written below
                someCount = rand.Next(0, 20);

                if (someCount == 6 || someCount == 10)
                {   //continue will disregard the rest of the loop, and will go back to the top to loop again
                    continue;
                }
                Console.WriteLine(someCount);

                if (someCount == 15)
                {
                    keepLooping = false;
                }
            }

            //---------------------------------------------------------------------------------------------------

            //FOR LOOP

            //for ( initialization ; condition ; iterator )
            //{
            //
            //}

            int studentCount = 21;

            // 1. Starting point
            // 2. While this condition is true, keep looping
            // 3. What we do after each iteration/loop
            // 4. Code we execute each iteration/loop
        //  for          1      ;   2   (condition)     ;     3
            for (int counter = 0; counter < studentCount; counter++)
            {
                // 4 code to execute
                Console.WriteLine(counter);
            }

            // Another Example

            string[] students = { "Adam", "Justin", "Joshua", "Daniella", "Ingeborg" };
                  //1        2 (condition)        3
            for (int i = 0; i < students.Length; i++)
            {
                // the i'th index of our array, it will return the value of that index
                Console.WriteLine($"Welcome to the class {students[i]}!");
            }

            //-----------------------------------------------------------------------------------------

            //FOREACH LOOP

            // 1 Collection being worked on
            // 2 Name of the current iteration
            // 3 Type in the collection
            // 4 "in" keyword used to seperate the indiviual and the collection
            //using the above data/conditions in last ex ^

            //         3       2    4     1
            foreach (string student in students)
            {
                Console.WriteLine(student + " is a student in the class... or are they instructors?");
            }

            //we are now iterating through a student's name
            string oneStudent = students[2];
            foreach (char letter in oneStudent)
            {
                Console.WriteLine(letter + " is a letter in my name.");
            }

            //another example
            string myName = "Kate Lockhart";
            foreach (char letter in myName)
            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
            }

            //THE BEST EXAMPLE 
            string[] myShitList = { "Kate", "Mitchell", "Hustin", "Brittany" };
            foreach (var student in myShitList)
            {
                Console.WriteLine(student + " is a JS asshole...");
            }

            //------------------------------------------------------------------------------------------

            // DO WHILE LOOP
            //do something once, and then continue to do that while the condition is true

            //While Loop is a Pre-Test, meaning it will test the conditional for the ture/false before the first iteration
            //Do While Loop is a Pot-Test, it eill run 1 iteration and then test the conditional for true/false before continuing to the next iteration
            //Every do requires a while

            int iterator = 0;
            do
            {
                //we will run this conde once, and then keep running it until our condition is false
                Console.WriteLine("Hello!");
                iterator++;
            }
                  //condition
            while (iterator < 5);


            do
            {
                Console.WriteLine("My do while condition is false!");
            }
            while (false);


            Console.ReadLine();
        }
    }
}
