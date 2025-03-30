using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * - We want to solve this problem s
 *  - https://leetcode.com/problem-list/954v5ops/
*/
namespace Two_Sum_Problem_in_C_
{
    /*
     * What is a Dictionary?
     * 
     *   A dictionary in C# is like a phone book:
     *   You give it a key (like a name), and it tells you the value (like a phone number).
     *   In our case, 
     *      the (key) is a (number) from the array,
     *      and the (value) is its (index).
     *   
     *   - We use it to remember numbers we've already seen.
    */ 

    class Program
    {

         /*
          * 🔖 Explanation: Dictionary is used to map each number to its index.
          * This allows O(1) lookup to check if the "complement" exists,
          * meaning we can solve the problem in one pass (O(n) time).
          */
        static int[] TwoSum(int[] Nbrs, int target)
        {
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            int complement;

            for (int i = 0; i < Nbrs.Length; i++)
            {
                complement = target - Nbrs[i];

                // Check if we have already seen the complement :: (i.e., we found a pair)
                if (Dict.ContainsKey(complement))
                    return (new int[] { Dict[complement], i });

                /*
                 * 🔖 Optimization: Prevents exception if same number exists twice (e.g., [3,3])
                 * Only add current number if it doesn't already exist in the dictionary
                 */
                if (!Dict.ContainsKey(Nbrs[i]))
                    Dict[Nbrs[i]] = i;
            }
            return (new int[] { -1, -1 });
        }

        static void Main(string[] args)
        {
            int[]   Nbrs = { 2, 7, 8, 3, 1, 5, 9, 11 };
            int     target = 4;
            int[] result = TwoSum(Nbrs, target);

            /*
             * 
             * - String Interpolation:
             * - Introduced in C# 6.0, this $ sign is a shortcut to build a string using variables inside it.
             * - $ before the string
             * - Tells the compiler: “Hey, there will be variables inside this string, inside curly braces {}”
             * - [{result[0]}, {result[1]}]
             *      - result[0]: Gets the first value from the result array
             *      - result[1]: Gets the second value from the array
             */
            if (result[0] == -1)
                Console.WriteLine("No valid pair found for the given target.");
            else
                Console.WriteLine($"[{result[0]}, {result[1]}]");

        }
    }
}
