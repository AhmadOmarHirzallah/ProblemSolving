using System;

public class LongestPalindromicSubString
{

    public struct stPalindromData
    {
        public string   strInput;
        public int startIndex;       // Starting index of the longest palindrome
        public int maxLength;        // Length of the longest palindrome
        
    }


    // Expands around a center and updates start and maxLength if a longer palindrome is found
    /*
         -  Without ref, the struct would be copied into the method AND
             changes inside wouldn’t reflect outside.
         -  The ref keyword in C# tells the compiler to pass
             a variable by reference, not by value.
    */

    private void    ExpandAroundCenter(ref stPalindromData Data, int left, int right)
    {
        /*
            input: "babad"
            Check center at index 1 ('a')

            left = 1, right = 1 → 'a' == 'a' → expand

            left = 0, right = 2 → 'b' == 'b' → expand

            left = -1, right = 3 → stop (left out of bounds)
            The actual valid palindrome is between (left+1 = 0) and (right-1 = 2)
            
            len = right - left - 1 = 3 - (-1) - 1 = 3
        */
        while (left >= 0 && right < Data.strInput.Length && 
                Data.strInput[left] == Data.strInput[right])
        {
            left--;
            right++;
        }
        int currentLen = right - left - 1;
        if (currentLen > Data.maxLength)
        {
            Data.startIndex = left + 1;
            Data.maxLength = currentLen;
        }
    }

    public string   LongestPalindStr(string inputStr)
    {
        if (string.IsNullOrEmpty(inputStr))
            return ("");

        stPalindromData Data = new stPalindromData
        {
            strInput = inputStr,
            startIndex = 0,
            maxLength = 0
        };

        for (int center = 0; center < inputStr.Length; center++)
        {
            /*
                -  Without ref, the struct would be copied into the method AND
                    changes inside wouldn’t reflect outside.
                -  The ref keyword in C# tells the compiler to pass
                    a variable by reference, not by value.
            */
            ExpandAroundCenter(ref Data, center, center);        // Odd length palindrome
            ExpandAroundCenter(ref Data, center, center + 1);    // Even length palindrome 
        }
        return (inputStr.Substring(Data.startIndex, Data.maxLength)); 
    }
}

class Program
{
    static void Main()
    {
        LongestPalindromicSubString solver = new LongestPalindromicSubString();
        string input = "babad";
        string result = solver.LongestPalindStr(input);
        Console.WriteLine($"Longest Palindromic Substring: {result}");
    }
}

// C Code
/*
#include <stdio.h>
#include <string.h>

typedef struct {
    const char* input;
    int startIndex;
    int maxLength;
} PalindromeData;

void expandAroundCenter(PalindromeData* data, int left, int right) {
    while (left >= 0 && right < strlen(data->input) && data->input[left] == data->input[right]) {
        left--;
        right++;
    }

    int currentLength = right - left - 1;
    if (currentLength > data->maxLength) {
        data->startIndex = left + 1;
        data->maxLength = currentLength;
    }
}

void longestPalindrome(const char* input, char* output) {
    PalindromeData data = { input, 0, 0 };

    for (int i = 0; i < strlen(input); i++) {
        expandAroundCenter(&data, i, i);       // Odd length
        expandAroundCenter(&data, i, i + 1);   // Even length
    }

    strncpy(output, input + data.startIndex, data.maxLength);
    output[data.maxLength] = '\0';
}

int main()
{
    const char* str = "babad";
    char result[100];
    longestPalindrome(str, result);
    printf("Longest Palindromic Substring: %s\n", result);
    return 0;
}
*/


// CPP
/*
#include <iostream>
#include <string>

struct PalindromeData {
    std::string input;
    int startIndex = 0;
    int maxLength = 0;
};

void expandAroundCenter(PalindromeData& data, int left, int right) {
    while (left >= 0 && right < data.input.size() && data.input[left] == data.input[right]) {
        left--;
        right++;
    }

    int currentLength = right - left - 1;
    if (currentLength > data.maxLength) {
        data.startIndex = left + 1;
        data.maxLength = currentLength;
    }
}

std::string longestPalindrome(const std::string& input) {
    if (input.empty()) return "";

    PalindromeData data;
    data.input = input;

    for (int i = 0; i < input.size(); i++) {
        expandAroundCenter(data, i, i);       // Odd
        expandAroundCenter(data, i, i + 1);   // Even
    }

    return input.substr(data.startIndex, data.maxLength);
}

int main() {
    std::string str = "babad";
    std::string result = longestPalindrome(str);
    std::cout << "Longest Palindromic Substring: " << result << std::endl;
    return 0;
}
*/