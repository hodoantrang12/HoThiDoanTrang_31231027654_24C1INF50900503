using System;

internal class Program
{
    static void Main()
    {
        //Ex01();
        //Ex02();
        //Ex03();
        Ex04();
    }
    static void Ex01()
    {
        Console.WriteLine("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        // Counters for alphabets, digits, and special characters
        int alphabetCount = 0, digitCount = 0, specialCharCount = 0;

        // Iterate through the string
        foreach (char c in input)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                alphabetCount++;
            }
            else if (c >= '0' && c <= '9')
            {
                digitCount++;
            }
            else
            {
                specialCharCount++;
            }
        }

        // Display the counts
        Console.WriteLine($"Alphabets: {alphabetCount}");
        Console.WriteLine($"Digits: {digitCount}");
        Console.WriteLine($"Special Characters: {specialCharCount}");
    }

    static void Ex02()
    //count_vowels_consonants
    {
        Console.WriteLine("Nhap mot chuoi: ");
        string input = Console.ReadLine();

        int vowelCount = 0, consonantCount = 0;
        // Convert input string to lowercase for easier comparison
        input = input.ToLower();

        // Iterate through each character in the string
        foreach (char c in input)
        {
            if (c >= 'a' && c <= 'z') // Check if the character is a letter
            {
                if ("aeiou".Contains(c)) // Check if it is a vowel
                {
                    vowelCount++;
                }
                else // If not a vowel, it is a consonant
                {
                    consonantCount++;
                }
            }
        }

        // Display the counts
        Console.WriteLine($"Number of vowels: {vowelCount}");
        Console.WriteLine($"Number of consonants: {consonantCount}");
    }

    static void Ex03()
    //compare 2 strings
    {
        // Input two strings
        Console.WriteLine("Nhap chuoi 1:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Nhap chuoi 2:");
        string str2 = Console.ReadLine();

        // Compare the strings
        int result = CompareStrings(str1, str2);

        // Output the result
        if (result == 0)
        {
            Console.WriteLine("Hai chuoi bang nhau.");
        }
        else if (result < 0)
        {
            Console.WriteLine("Chuoi 1 nho hon chuoi 2");
        }
        else
        {
            Console.WriteLine("Chuoi 1 lon hon chuoi 2");
        }
    }

    static int CompareStrings(string s1, string s2)
    {
        int i = 0;

        // Compare each character until one string ends or a difference is found
        while (i < s1.Length && i < s2.Length)
        {
            if (s1[i] != s2[i])
            {
                return s1[i] - s2[i];
            }
            i++;
        }

        // If all characters are equal so far, compare the lengths
        if (s1.Length == s2.Length)
        {
            return 0; // Strings are equal
        }
        else if (s1.Length < s2.Length)
        {
            return -1; // First string is shorter
        }
        else
        {
            return 1; // First string is longer
        }
    }

    static void Ex04()
    {
        // Input the main string
        Console.WriteLine("Enter the main string:");
        string mainString = Console.ReadLine();

        // Input the substring to check
        Console.WriteLine("Enter the substring to check:");
        string subString = Console.ReadLine();

        // Check if the substring is present in the main string
        bool isPresent = CheckSubstring(mainString, subString);

        // Output the result
        if (isPresent)
        {
            Console.WriteLine("The substring is present in the main string.");
        }
        else
        {
            Console.WriteLine("The substring is not present in the main string.");
        }
    }

    static bool CheckSubstring(string mainString, string subString)
    {
        // Get the lengths of both strings
        int mainLength = mainString.Length;
        int subLength = subString.Length;

        // Loop through the main string to check for the substring
        for (int i = 0; i <= mainLength - subLength; i++)
        {
            int j;
            for (j = 0; j < subLength; j++)
            {
                if (mainString[i + j] != subString[j])
                {
                    break;
                }
            }

            // If all characters of the substring matched
            if (j == subLength)
            {
                return true;
            }
        }

        return false; // Substring not found
    }
}


