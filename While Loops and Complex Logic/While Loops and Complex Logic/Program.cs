    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops_and_Complex_Logic
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a new instance of our number guesser class
            var numberGuesser = new NumberGuesser();

            // Change the default maximum number to 200
            numberGuesser.MaximumNumber = 100;
            
            // Ask the user to think of a number
            numberGuesser.InformUser();

            // Asks user a series of questions to discover their number
            numberGuesser.DiscoverNumber();

            //Announce the results
            numberGuesser.AnnounResults();
        }
    }
}
