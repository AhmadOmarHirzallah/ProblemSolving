using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * - Write a program to print all the Prime Numbers from 1 to N 
 * - if input is 10
 *  - output: 2 , 3, 5, 7
*/  
namespace Problem2
{

    enum e_PrimeNotPrime
    {
        PRIME = 1,
        NOT_PRIME
    }
    class Program
    {

        static int readPositiveNbr(string msg)
        {
            int nbr = 0;
            bool isNbr;

            while (nbr <= 0)
            {
                Console.WriteLine(msg);
                isNbr = int.TryParse(Console.ReadLine(), out nbr);
                if (!isNbr)
                    nbr = 0;    // As reset
            }
            return (nbr);
        }

        static e_PrimeNotPrime  CheckIsPrime(int nbr)
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

        static void printPrimeNbrsFrom1ToN(int n)
        {
            Console.WriteLine($"\n\nPrime Numbers from 1 To {n} are:\n");
            int i = 2;

            // Find and print the first prime number
            while (i <= n)
            {
                if (CheckIsPrime(i) == e_PrimeNotPrime.PRIME)
                {
                    Console.Write(i);
                    i++;
                    break;
                }
                i++;
            }

            // Continue printing subsequent prime numbers with a comma prefix.
            while(i <= n)
            {
                if (CheckIsPrime(i) == e_PrimeNotPrime.PRIME)
                    Console.Write(" ,  " + i);
                i++; 
            }
            Console.WriteLine();

        }



        static void Main(string[] args)
        {
            printPrimeNbrsFrom1ToN(readPositiveNbr("Please enter a positive number:"));
        }
    }
}
