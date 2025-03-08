using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  - write a number that read a number (check if it is a valid nbr first until it is entered)
 *      and print it in reversed order (store it and print it)
 *  - Example:
 *      - 1234 -> 4321
 *      - 9304 -> 4039
*/ 
namespace Problem5
{
    class Program
    {

        static int ReadValidNbr(string msg)
        {
            int nbr;

            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out nbr))
                    return (nbr);
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
            return (nbr);
        }

        static string ReverseNbr(int nbr)
        {
            string OriginalString = Math.Abs(nbr).ToString();
            string ReversedString = new string(OriginalString.Reverse().ToArray());

            if (nbr < 0)
                ReversedString = "-" + ReversedString;

            return (ReversedString); 
        }


        static void PrintResult(int OriginalNbr, string ReversedString)
        {
            Console.WriteLine($"The Reversed String of ({OriginalNbr}) is: ({ReversedString})");
        }



        static void Main(string[] args)
        {
            int OriginalNbr = ReadValidNbr("Please enter an integer (Positive or Negative):  ");
            string ReversedNbr = ReverseNbr(OriginalNbr);
            PrintResult(OriginalNbr, ReversedNbr);

        }
    }
}
