using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_VariablesAndValueTypes
{
    class Program
    {
        //used to define a new enum, it's a basic type that you give specific values
        enum PastryType { Cake, Cupcake, Eclaire }



        static void Main(string[] args)
        {
            // Booleans
            // Declaration - type name;
            bool isDeclared;

            // Assigning a value
            isDeclared = true;

            // Declaring and initializing it 
            bool isDelclaredAndInitialized = false;
            // can assign another value after being intitalized 
            isDelclaredAndInitialized = true;

            // Characters
            // use single quotes to initialize types 
            // (Kate Lockhart )=(14 characters)
            char letter = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            // the backslash will make a special char be seen as a character inside the ''
            char specialCharacter = '\'';

            // Whole Numbers
            //byte only goes from 0 to 255
            byte byteExample = 0;
            //shorts 0 to 32767
            short shortExample = 32767;
            Int16 anotherShortEx = -32000;
            //integer
            int intMin = -2147483648;
            //uint is an unsigned integer
            uint unsignedInt = 40000000;
            // long int has 64 bit max, largest of the signed numbers
            long longExample = 9223372036854775807;

            // Decimals
            //the only declaration type with suffixes
            //float will be a double unless you have a f to define it as float
            float floatExample = 1.320561408513f;
            //double can have a d to indicate its a double but it's optional
            double doubleExample = 1.320561408513d;
            //m is used to indicate decimal
            decimal decimalExample = 1.320561408513m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);

            // Structs
            //always have a default value
            //date time itself is a type 
            DateTime today = DateTime.Today;
            DateTime tomorrow = new DateTime(2020, 7, 29);

            // Enums
            PastryType myPastry = PastryType.Cake;
            PastryType anotherOne = PastryType.Eclaire;
            //DayOfWeek is a built out enum anyone can access
            DayOfWeek dayOfWeek = DayOfWeek.Tuesday;

            Console.ReadLine();
        }
    }
}
