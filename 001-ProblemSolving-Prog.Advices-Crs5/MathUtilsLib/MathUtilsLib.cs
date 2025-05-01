using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace MathUtilsLib
{
	public static class Utils
	{
		public static int countDigitFrequency( int number, int digit )
		{
			// New Better Way
			int frequencyCount = 0;
			int lastDigit = 0;

			while (number > 0)
			{
				lastDigit = number % 10;
				if (lastDigit == digit)
					frequencyCount++;
				number /= 10;
			}
			return ( frequencyCount );


			/* // Old Way
			int frequency = 0;
			string numberStr = number.ToString( );
			char digitChar = digit.ToString( )[0];

			foreach (char aDigit in numberStr)
			{
				if (aDigit == digitChar)
					frequency++;
			}
			return ( frequency );
			*/
		}

		public static int calcSumOfDigits( int number )
		{
			int sum = 0;

			while (number > 0)
			{
				sum += number % 10;
				number /= 10;
			}
			return ( sum );
		}

		public static Dictionary<int, int> countDigitsFrequency( int number )
		{
			Dictionary<int, int> frequencyDict = new Dictionary<int, int>( );

			// Loop through digits (0-9)
			for (int digit = 0; digit <= 9; digit++)
			{
				// Reuse the countDigitFrequency function for each digit from 0 to 9
				int digitFrequency = countDigitFrequency( number, digit );

				// Only add to dictionary if the digit frequency is greater than 0
				if (digitFrequency > 0)
					frequencyDict[digit] = digitFrequency;
			}

			return ( frequencyDict );
		}


		// Function: Reverse the Digits of the Number
		public static int reverseNumber( int number )
		{
			int reversedNumber = 0;

			while (number > 0)
			{
				int lastDigit = number % 10;
				reversedNumber = reversedNumber * 10 + lastDigit;
				number /= 10;
			}
			return reversedNumber;
		}

	}

	public static class NumberTheory
	{
		public enum e_PrimeNotPrime
		{
			PRIME = 1,
			NOT_PRIME
		}

		public enum e_PerfectOrNot
		{
			PERFECT = 1,
			NOT_PERFECT
		}

        public static e_PrimeNotPrime  checkIsPrime(int nbr)
        {
            if (nbr == 1)
                return e_PrimeNotPrime.NOT_PRIME;
            
            int divisor = 2; // no benifit of testing number % 1
            double limit = Math.Sqrt(nbr);
            while(divisor <= limit)
            {
                if (nbr % divisor == 0)
                    return e_PrimeNotPrime.NOT_PRIME;
                ++divisor;
            }
            return e_PrimeNotPrime.PRIME; 
        }

        public static e_PerfectOrNot checkIsPerfect(int nbr)
        {
            if (nbr == 1)
                return (e_PerfectOrNot.PERFECT);

            int sum = 1;
            int divisor = 2;

            while(divisor < nbr)
            {
                if (nbr % divisor == 0)
                    sum += divisor;
                divisor++;
            }
            return (sum == nbr) ? (e_PerfectOrNot.PERFECT) : (e_PerfectOrNot.NOT_PERFECT); 
        }

		public static e_PrimeNotPrime  checkIsPrime(long nbr)
        {
            if (nbr == 1)
                return e_PrimeNotPrime.NOT_PRIME;
            
            long divisor = 2; // no benifit of testing number % 1
            double limit = Math.Sqrt(nbr);
            while(divisor <= limit)
            {
                if (nbr % divisor == 0)
                    return e_PrimeNotPrime.NOT_PRIME;
                ++divisor;
            }
            return e_PrimeNotPrime.PRIME; 
        }

        public static e_PerfectOrNot checkIsPerfect(long nbr)
        {
            if (nbr == 1)
                return (e_PerfectOrNot.PERFECT);

            long sum = 1;
            long divisor = 2;

            while(divisor < nbr)
            {
                if (nbr % divisor == 0)
                    sum += divisor;
                divisor++;
            }
            return (sum == nbr) ? (e_PerfectOrNot.PERFECT) : (e_PerfectOrNot.NOT_PERFECT); 
        }

		public static bool isPerfect( int number )
		{
			return ( checkIsPerfect(number) == e_PerfectOrNot.PERFECT ) ? ( true ) : ( false ); 

		}

		public static bool isPrime( int number )
		{
			return ( checkIsPrime(number) == e_PrimeNotPrime.PRIME ) ? ( true ) : ( false ); 
		}

        public static bool isPerfect( long number )
		{
			return ( checkIsPerfect(number) == e_PerfectOrNot.PERFECT ) ? ( true ) : ( false ); 

		}

		public static bool isPrime( long number )
		{
			return ( checkIsPrime(number) == e_PrimeNotPrime.PRIME ) ? ( true ) : ( false ); 
		}



	}

	public static class SequenceGenerators
	{
		public static List<long> GetPerfectNumbersUpTo( long limit )
        {
            var perfectNumbers = new List<long>( ); 

            for (long number = 2; number <= limit; number++ )
            {
                if (NumberTheory.isPerfect( number ))
                    perfectNumbers.Add( number );
            }
            return ( perfectNumbers ); 
        }

		public static List<int> GetPerfectNumbersUpTo( int limit )
        {
            var perfectNumbers = new List<int>( ); 

            for (int number = 2; number <= limit; number++ )
            {
                if (NumberTheory.isPerfect( number ))
                    perfectNumbers.Add( number );
            }
            return ( perfectNumbers ); 
        }

		public static List<int> GetPrimeNumbersUpTo( int limit )
        {
            var primes = new List<int>() ;

			for (int num = 2; num <= limit; num++)
				if (NumberTheory.isPrime( num ))
                    primes.Add( num );

			return ( primes );

        }
	}
}
