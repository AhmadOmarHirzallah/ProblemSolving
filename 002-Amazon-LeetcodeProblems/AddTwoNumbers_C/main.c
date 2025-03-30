#include <stdio.h>
#include <stdlib.h>


/*
    What is a "Struct API"?
    In C, we don’t have classes or methods.
    But we can simulate OOP-like design using:
    A struct to represent data
    A set of functions that act on that data
    📦 Together, these form a "struct API" — an interface for using the struct.
*/
typedef struct s_listNode
{
    int val;
    struct s_listNode* next;
}                           t_listNode;


t_listNode  *create_lstNode(int val)
{
    t_listNode* node = (t_listNode*)malloc(sizeof(t_listNode));
    if (node == NULL)
        return (NULL);
    node->next = NULL;
    node->val = val;

    return (node);
}

t_listNode  *build_lstNode(const int* nbrsArr, int size)
{
    t_listNode dummy = (t_listNode){.val = 0, .next = NULL };

    t_listNode* current = &dummy;
    for (int i = 0; i < size; i++)
    {
        current->next = create_lstNode(nbrsArr[i]);
        current = current->next;
    }
    return (dummy.next); 
}

t_listNode  *addTwo_lstNode(t_listNode *l1, t_listNode *l2)
{
    t_listNode dummy = (t_listNode){ .val = 0, .next = NULL };
    t_listNode* current = &dummy;
    int carry = 0;
    int x, y, summation;

    while (l1 != NULL || l2 != NULL || carry != 0)
    {
        x = (l1 != NULL) ? l1->val : 0;
        y = (l2 != NULL) ? l2->val : 0;
        summation = x + y + carry;
        carry = summation / 10;
        current->next = create_lstNode(summation % 10);
        current = current->next;
        if (l1 != NULL)
            l1 = l1->next;
        if (l2 != NULL)
            l2 = l2->next; 
    }
    return (dummy.next);
}

void    printListNode(t_listNode* head)
{
    while (head != NULL)
    {
        printf("%d", head->val);
        if (head->next != NULL)
            printf(" -> ");
        head = head->next;
    }
    printf("\n"); 
}

int main() {
    int a[] = {9, 9, 9, 9, 9, 9, 9};
    int b[] = {9, 9, 9, 9};
    t_listNode* l1 = build_lstNode(a, 7);
    t_listNode* l2 = build_lstNode(b, 4);
    t_listNode* result = addTwo_lstNode(l1, l2);

    printf("C Result: ");
    printListNode(result);


    int a2[] = {2, 4, 3};
    int b2[] = {5, 6, 4};
    t_listNode* l3 = build_lstNode(a2, 3);
    t_listNode* l4 = build_lstNode(b2, 3);
    t_listNode* result2 = addTwo_lstNode(l3, l4);

    printf("\n\nC Result: ");
    printListNode(result2);
    return 0;
}