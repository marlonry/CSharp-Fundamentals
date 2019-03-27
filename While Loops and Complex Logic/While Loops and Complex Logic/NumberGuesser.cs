using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops_and_Complex_Logic
{
    /// <summary>
    /// Asks the user to guess a number between a certain range and then guesses that number in the fewest possible guesses
    /// </summary>
    public class NumberGuesser
    {
        #region Public Properties
        /// <summary>
        /// The largest number we ask the user to guess, between 0 and this number
        /// </summary>
        public int MaximumNumber { get; set; }

        /// <summary>
        /// The Current Number of Guesses the computer has had
        /// </summary>
        public int CurrentNumberOfGuesses { get; private set; }

        /// <summary>
        /// The current known minimum number the user is thinking of
        /// </summary>
        public int CurrentGuessMinimum { get; private set; }

        /// <summary>
        /// The current maximum number the user is thinking of
        /// </summary>
        public int CurrentGuessMaximum { get; private set; }
        #endregion

        #region Constructor

        /// <summary>
        /// Default Constructor
        /// </summary>
        public NumberGuesser() // constructors has no return value and has the same name as the class
        {
            // Set default maximum number
            this.MaximumNumber = 100;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Asks the user to think of a number between 0 and the maximum number
        /// </summary>
        public void InformUser()
        {
            // Ask user to think of a number between 0 and Maximum Number
            Console.WriteLine($"I want you to think a number between 0 and {this.MaximumNumber}");
            Console.ReadLine();
        }


        /// <summary>
        /// Asks the user a series of questions to discover the number they are thinking of
        /// </summary>
        public void DiscoverNumber()
        {
            // Clear Variables to ther initial values before a discovery
            this.CurrentNumberOfGuesses = 0;
            this.CurrentGuessMinimum = 0;
            this.CurrentGuessMaximum = this.MaximumNumber / 2;

            //while guesses is not the same as the known maximum value
            while (this.CurrentGuessMinimum != this.CurrentGuessMaximum)
            {
                // increases guess amount by one
                this.CurrentNumberOfGuesses++;

                // ask the user if their number is between the guess
                Console.WriteLine($"is your number between { this.CurrentGuessMinimum } and { this.CurrentGuessMaximum}?");
                string response = Console.ReadLine();

                //bool hasResponse = (response?.Length > 0); ----> old way
                //if (hasResponse && (response[0] == 'y' || response[0] == 'Y'))

                //new c# way of checking for things using safe navigator operator and extension methods / linq queries ----> new way

                // if the user confirmed their number is withing the current range
                if (response?.ToLower().FirstOrDefault() == 'y')
                {
                    // We know the number is between guesMin and guessMax
                    // so set the new maximum number
                    this.MaximumNumber = this.CurrentGuessMaximum;
                    // change the next guess range to be half of the new maximum range;
                    this.CurrentGuessMaximum = this.CurrentGuessMaximum - (this.CurrentGuessMaximum - this.CurrentGuessMinimum) / 2;
                }
                // the number is grater than guessMax and less than or equal to max
                else
                {
                    // the new minimum is one above the old max
                    this.CurrentGuessMinimum = this.CurrentGuessMaximum + 1;

                    // guess the bottom half of the new range
                    int remainingDiffrence = this.MaximumNumber - this.CurrentGuessMaximum;

                    // set the guess max to half way between the guessMin and Max
                    // NOTE: Math.Ceiling will round up the remaining difference to 2, if the difference is 3
                    this.CurrentGuessMaximum += (int)Math.Ceiling(remainingDiffrence / 2f);

                }
                // if we only have 2 numbers left, guess one of them
                if (this.CurrentGuessMinimum + 1 == this.MaximumNumber)
                {
                    // increase the guess number
                    this.CurrentNumberOfGuesses++;

                    Console.WriteLine($"is you number { this.CurrentGuessMinimum }?");
                    response = Console.ReadLine();


                    // ask the user if their number is the lower number
                    if (response?.ToLower().FirstOrDefault() == 'y')
                    {
                        break;
                    }
                    else
                    {
                        // that means the number must be the higher of the two;
                        this.CurrentGuessMinimum = this.MaximumNumber;
                        break;
                    }
                }
            }

        }


        /// <summary>
        /// Announces the number the user was thinking of and the number guesses it took
        /// </summary>
        public void AnnounResults()
        {
            // tell the user their number
            Console.WriteLine($"** Your number is { this.CurrentGuessMinimum } **");

            // let the user know how many guesses it took
            Console.WriteLine($"guessing your number took { this.CurrentNumberOfGuesses } guesses");

            Console.ReadLine();
        }
        #endregion
    }
}
