#include <stdio.h>


void	twoSum(int* nbrs, int size, int target, int* result)
{
	// No available index is -1
	result[0] = -1;
	result[1] = -1;

	for (size_t i = 0; i < size; i++)
	{
		for (size_t j = (i + 1) ; j < size; j++)
		{
			if (nbrs[i] + nbrs[j] == target)
			{
				result[0] = i;
				result[1] = j;
				return;
			}
		}
	}
}

int main()
{
	int nbrs[] = { 2, 83, 7, 8, 9, 34 , 5, 3, 1, 2, 7, 89, 9, 8 };
	int target = 16;
	int result[2];

	twoSum(nbrs, (sizeof(nbrs) / sizeof(nbrs[0])), target, result);
	if (result[0] != -1)
		printf("Indicies: [%d, %d]\n", result[0], result[1]);
	else
		printf("No Valid Pairs are found :(\n");

	return (0);
}