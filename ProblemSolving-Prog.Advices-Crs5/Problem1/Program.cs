using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * A program print multiplication table from 1 to 10
*/

namespace Problem1
{
    class Program
    {


        static void printTableHeader()
        {
            Console.WriteLine("\n");
            Console.WriteLine("\t\t\t----- Multiplication Table from 1 to 10 ------\n");
            Console.Write("\t");

            int i = 1;
            while (i <= 10)
            {
                Console.Write(i + "\t");
                i++;
            }
            Console.WriteLine("\n___________________________________________________________________________________");

        }


        static string getColumnSeparator(int rowNbr)
        {
            if (rowNbr < 10)
                return ("   |");
            else
                return ("  |");
        }


        static void printMultiplicationTable()
        {
            printTableHeader();

            /*
             * - Lambda expressions in C# provide a concise way to define anonymous functions (functions without a name).
             * - They are particularly useful when working with delegates, LINQ, and functional programming concepts.
             * - Func<int, int, int> is a delegate type that represents a function taking two int parameters and returning an int.
             *      - <int,int,int> -> 1st and 2nd are paremeters; The last int (3rd) is the return type of the function (the result of x * y).
             * - The lambda expression (x, y) => x * y
             *      defines a function that takes x and y and returns their product (x * y).
             * - lambda to compute the product of two numbers.
             * - This demonstrates C#'s support for functional programming.
            */
            Func<int, int, int> MultiplyNbrs;
            MultiplyNbrs = (x, y) => x * y;
            int i = 1;
            int j;
            while (i <= 10)
            {
                Console.Write(" " + i + getColumnSeparator(i) + "\t");
                j = 1;
                while (j <= 10)
                {
                    Console.Write(MultiplyNbrs(i, j) + "\t");
                    j++; 
                }
                Console.WriteLine();
                i++; 
            } 
        }


        static void Main(string[] args)
        {
            printMultiplicationTable();

        }
    }
}
