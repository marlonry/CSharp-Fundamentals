using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();


            // Variables - Data Types

            byte myByte = 255;                     // 8 bits
            char myChar = "A"; // or (char)65      // 16 bits   
            short s = 65;                          // 16 bits 
            int myInt = 1043;                      // 32 bits    // Negative or positive numbers
            uint myUInt = 23495;                   // 32 bits    // Only positive numbers, larger numbers
            float myFloat = 1.4534f;               // 32 bits    // precise numbers f to specify it's a float
            double myDouble = 1.4345;              // 64 bits    // larger floating point numbers
            decimal myDecimal = (decimal)1.3434;   // 128 bit    // larger decimal numbers, need to specify it's a decimal

            string myString = "Hello World";       // it's a class but always known as a variable, collection of characters

            bool myBool1 = true;
            bool myBool2 = false;
        }
    }
}
