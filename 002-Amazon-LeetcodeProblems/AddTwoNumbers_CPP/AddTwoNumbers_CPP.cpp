#include <iostream>
#include <vector>

class ListNode
{
public:
    int val;
    ListNode* next;

    ListNode(int value) : val(value), next(nullptr) {}

    void print()
    {
        ListNode* temp = this;
        while (temp) {
           std::cout << temp->val;
            if (temp->next)
                std::cout << " -> ";
            temp = temp->next;
        }
        std::cout << std::endl;
    }
};


class Solution
{
public:
	ListNode* add2Nbrs(ListNode *l1, ListNode *l2)
	{
        int  x, y, summation, carry = 0;
		ListNode *dummy =  new ListNode(0);
        ListNode *current = dummy;

        while (l1 != nullptr || l2 != nullptr || carry != 0)
        {
            x = (l1 != nullptr) ? (l1->val) : 0;
            y = (l2 != nullptr) ? (l2->val) : 0;
            summation = x + y + carry;
            carry = summation / 10;
            current->next = new ListNode(summation % 10);
            current = current->next;
            if (l1 != nullptr)
                l1 = l1->next;
            if (l2 != nullptr)
                l2 = l2->next; 
        }
        return (dummy->next); 
	}

    ListNode* buildList(const std::vector<int>& vals)
    {
        ListNode* dummy = new ListNode(0);
        ListNode* current = dummy;
        for (int v : vals)
        {
            current->next = new ListNode(v);
            current = current->next;
        }
        return (dummy->next);
    }
 
private:

};


int main()
{
    Solution solver;

    ListNode* l1 = solver.buildList(std::vector <int> {2, 4, 3});
    ListNode* l2 = solver.buildList(std::vector <int> {5, 6, 4});

    ListNode* result = solver.add2Nbrs(l1, l2);
    std::cout << "C++ Result: ";
    result->print();  // method inside ListNode class!

	return (0);
}

