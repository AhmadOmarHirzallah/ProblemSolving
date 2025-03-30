using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * - Write a program to check if a number is perfect or not 
 * - Note: Perfect Number = Sum(All Divisors)
 * - Examples:
 *      -> 28 = 1 + 2 + 4 + 7 + 14 (Perfect)
 *      -> 6 = 1 + 2 + 3 (Perfect)
 *      -> 12   (Not Perfect)
*/

namespace Problem3
{
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

        static bool CheckIsPerfectNbr(int nbr)
        {
            if (nbr == 1)
                return (true);

            int sum = 1;
            int divisor = 2;

            while(divisor < nbr)
            {
                if (nbr % divisor == 0)
                    sum += divisor;
                divisor++;
            }
            return (sum == nbr); 
        }

        static void PrintResult(int nbr)
        {
            bool isPerfect = CheckIsPerfectNbr(nbr);
            Console.WriteLine(isPerfect ?
                                $"{nbr} is a Perfect Number :)"     : 
                                $"{nbr} ISN'T a Perfect Number :(");
        }








        static void Main(string[] args)
        {
            PrintResult(readPositiveNbr("Please enter a positive number:"));
        }
    }
}
