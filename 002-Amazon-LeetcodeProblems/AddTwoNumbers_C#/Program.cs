using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers_C_
{
    class Program
    {

        /*
           Pseudo Code:

            Create dummy node to store result
        
            Set current pointer to dummy
            Set carry = 0

            While there are still nodes in l1 or l2 or carry is not 0:
            Get value from l1 if exists, else 0
            Get value from l2 if exists, else 0
            Add both values + carry
            carry = sum / 10
            digit = sum % 10
            Create new node with digit and attach to result list
            Move to next node in l1 and l2 if they exist

            Return dummy.next
        */
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {

            /*
             * - Dummy node to help us build the result list.
             * - Dummy node has (.val = 0) & Dummy (.next) = null (as default parameter set value)
             
             **** -  Dummy acts like the head of the result list.
             **** - We will return Dummy.next at the end, because that's where the real answer begins.
             */
            ListNode Dummy = new ListNode(0);  //   كاذب ، وهمي  



            /*
             * - Current is a moving pointer used to build the result list.
             * - It starts at Dummy and moves forward as we add nodes.
             * - Current is a moving pointer used to build the result list.
             * - It starts at Dummy and moves forward as we add nodes.
             */ 
            ListNode Current = Dummy;



            int carry = 0;  // carry: stores overflow from previous digit addition
            int x, y, sum;  // (x, y: digit values from l1 and l2) && (sum: total sum = x + y + carry)

            // Keep looping as long as: (There's still data in l1 OR l2) OR (you still have a carry)
            while(l1 != null || l2 != null || carry != 0)
            {
                // Get the current digit from l1 or l2, or 0 if the list is over
                x = (l1 != null) ? l1.val : 0;
                y = (l2 != null) ? l2.val : 0;

                // Add them up with the carry from before 
                sum = x + y + carry;

                carry = sum / 10;   // New carry

                Current.next = new ListNode(sum % 10);  // Create node with last digit
                // ----       If sum = 17, carry = 1, value in node = 7

                Current = Current.next;
                
                if (l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            return Dummy.next;      // The actual list starts from the node after dummy.
        }


        public static ListNode BuildList(int[] values)
        {
            ListNode Dummy = new ListNode(0);
            ListNode Current = Dummy;

            foreach(int val in values)
            {
                Current.next = new ListNode(val);
                Current = Current.next;
            }
            return (Dummy.next); 
        }

        public static void  PrintList(ListNode Head)
        {
            while (Head != null)
            {
                Console.Write(Head.val);
                if (Head.next != null)
                    Console.Write(" -> ");
                Head = Head.next; 
            }
            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            var solver = new Program();

            var l1 = BuildList(new int[] { 2, 4, 3 });
            var l2 = BuildList(new int[] { 5, 6, 4 });

            Console.Write("Example 1 Result:  ");
            PrintList(solver.AddTwoNumbers(l1, l2));
            
            var l3 = BuildList(new int[] { 9,9,9,9,9,9,9 });
            var l4 = BuildList(new int[] { 9,9,9,9 });

            Console.Write("Example 2 Result:  ");
            PrintList(solver.AddTwoNumbers(l3, l4));
        }
    }
}
