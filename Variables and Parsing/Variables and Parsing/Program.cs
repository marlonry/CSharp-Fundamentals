using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Parsing
{
    class Program
    {
        // 3. Accesibility Levels

        // protected - only for the classes that posses it, that includes classes that extend the super class;
        // private - just used for the class its named on
        // public - anything outside can access it, no access restrictions

        private static byte myPrivate;
        protected static byte myProtected;
        public static byte myPublic;
        //internal //class libraries, dll , anything define in that program is accesible only to that project
                 // protected internal // limited to the code assembly

        // 4. Different ways to declare variables (members vs properties)

        private static byte mMyVariable; // member or field when they are private;
        private static string mMyString;
        private static string mMyCreditCardNumber;

        public byte MyVariable { get; set; } // something accesible in other places

        public Program()
        {
            
        }

        static void Main(string[] args)
        {
            // 1. Comments

            /* Multi
               line
               comment
            */

            // 2. Ending Lines and Statements
            //byte myByte = 12;

            // 5. Reading text from user input
            // 6. Parsing                     -----------> All 4 in the example Below.
            // 7. Calculations
            // 8. Constructing strings from variables


            Console.WriteLine("Please enter a number between 1 and 10...");
            string userResponse = Console.ReadLine();

            int userNumber;

            if( int.TryParse(userResponse, out userNumber) )
            {
                if(userNumber < 1 ||  userNumber > 10)
                {
                    Console.WriteLine("Sorry, the number was outside of the range");
                }
                else
                {
                    //userNumber = userNumber * 2;

                    userNumber *= 2;

                    Console.WriteLine($"Your new number is {userNumber}. Which is 2 times the value");
                }
            }
            else
            {
                Console.WriteLine("Sorry, that was not a recognized number");
            }

            Console.WriteLine("Press Enter to Close");
            Console.ReadLine();

            //mMyVariable = userResponse;
        }
    }
}
