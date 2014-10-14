using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {

        private int _count;
        private int _number;
        public const int MaxNumberOfGuesses = 7;

        /// <summary>
        /// Constructor
        /// </summary>
        public SecretNumber()
        {

        }

        /// <summary>
        /// Initializes each new try by generating a random number between 1-100 and setting the _count field to zero
        /// </summary>
        public void Initialize()
        {
            Random random = new Random();
            _count = 0;
            _number = random.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {
            throw new ArgumentException();
        }

    }
}
