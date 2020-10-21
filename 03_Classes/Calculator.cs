using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Classes
{
    class Calculator
    {
        // Add
        public int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        // Subtract
        public int Subtract(int numOne, int numTwo)
        {
            int difference = numOne - numTwo;
            return difference;
        }

        // Multiply
        public int Multiply(int numOne, int numTwo)
        {
            int product = numOne * numTwo;
            return product;
        }

        // Divide
        public int Divide(int numOne, int numTwo)
        {
            int quotient = numOne / numTwo;
            return quotient;
        }

        //Calculate Remainder
        public int Remainder(int numOne, int numTwo)
        {
            int remainder = numOne % numTwo;
            return remainder;
        }
    }
}
