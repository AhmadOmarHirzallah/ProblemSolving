using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  - Write a program to print all perfect numbers from 1 to N
 *  - Example:
 *      - Input : 500 
 *      - Output: 6, 28 496
*/ 

namespace Problem4
{
    class Program
    {

        static int ReadPositiveNbr(string msg)
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
                return (false);

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

        static void PrintPerfectNbrsFrom1ToN(int n)
        {
            Console.WriteLine($"\n\nPerfect Numbers from 1 To {n} are:\n");
            int i = 1;

            // Find and print the first Perfect Number
            while (i <= n)
            {
                if (CheckIsPerfectNbr(i) == true)
                {
                    Console.Write(i);
                    i++;
                    break;
                }
                i++;
            }
            // Continue printing subsequent Perfect numbers with a comma prefix.
            while(i <= n)
            {
                if (CheckIsPerfectNbr(i) == true)
                    Console.Write(" ,  " + i);
                i++; 
            }
            Console.WriteLine(); 
        }



        static void Main(string[] args)
        {
            PrintPerfectNbrsFrom1ToN(ReadPositiveNbr("Please enter a positive number:"));

        }
    }
}
