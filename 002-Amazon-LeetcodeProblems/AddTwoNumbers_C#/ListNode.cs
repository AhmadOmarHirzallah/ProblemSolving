using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTwoNumbers_C_
{
    class ListNode
    {
        public int val;
        public ListNode next;

        /*
         * ✅ So when you do:
           - ListNode node = new ListNode(5);
           - You are saying:
                - val = 5
                - next = null (default)
           - So 1'st Value goes into --> 1 Parameter.
        */

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
