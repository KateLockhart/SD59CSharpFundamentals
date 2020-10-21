﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOne = 22;
            int numTwo = 15;

            // Addition: +
            int sum = numOne + numTwo;
            Console.WriteLine(sum);

            // Subtraction: -
            int difference = numOne - numTwo;
            Console.WriteLine(difference);

            //Multiplication: *
            int product = numOne * numTwo;
            Console.WriteLine(product);

            // Division: /
            int quotient = numOne / numTwo;
            Console.WriteLine(quotient);

            // Remainder: %
            int remainder = numOne % numTwo;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someDay = new DateTime(1978, 1, 1);

            TimeSpan banana = now - someDay;
            Console.WriteLine(banana);


            // ---------------------------------------------------------------------


            // Comparison Operators
            //parce will turn a string into a number but is very fragile if characters don't have #s
            Console.WriteLine("Enter your age:");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            bool equals = age == 42;
            Console.WriteLine("User is 42: " + equals);

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            bool userIsAdam = name == "Adam";
            Console.WriteLine("User is Adam: " + userIsAdam);

            bool userIsNotAdam = name != "Adam";
            Console.WriteLine("User is not Adam, it's " + name + ". That's " + userIsNotAdam);

            // > >= == < <=
            //greater than, less than, etc.

            bool isOlder = age > 12;
            bool lessThanOrEqualTo = age <= 17;

            List<string> firstList = new List<string>();
            firstList.Add(name);

            List<string> secondList = new List<string>();
            secondList.Add(name);

            bool listsAreEqual = firstList == secondList;
            //will return false because both have become new and seperate lists that are not equal 
            Console.WriteLine($"The lists are the same: {listsAreEqual}.");

            bool isTeen = isOlder && lessThanOrEqualTo;
            bool or = isOlder || lessThanOrEqualTo;



            bool trueValue = true;
            bool falseValue = false;
            // OR comparison
            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;
            // AND comparison
            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");
            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and True: {fAndT}");
            Console.WriteLine($"False and False: {fAndF}");




            Console.ReadLine();
        }
    }
}
