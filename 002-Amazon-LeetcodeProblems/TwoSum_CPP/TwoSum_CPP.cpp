#include <iostream>
#include <vector>
#include <unordered_map>

std::vector <int>  twoSum(const std::vector <int>& nbrs, int target)
{
    std::unordered_map <int, int> map;
    int complement;

    for (int i = 0; i < nbrs.size(); i++)
    {
        complement = target - nbrs[i];
        if (map.find(complement) != map.end())
            return (std::vector <int> { map[complement], i});

        map[nbrs[i]] = i;
    }
    return (std::vector <int> {-1, -1}); 
}

int main()
{
    std::vector <int> nums = {2, 7, 11, 15};
    int target = 26;

    std::vector<int> result = twoSum(nums, target);

    if (result[0] != -1)
        std::cout << "Indices: [" << result[0] << ", " << result[1] << "]" << std::endl;
    else
        std::cout << "No valid pair found." << std::endl;


    return (0);
}

