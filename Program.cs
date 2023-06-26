using System;
using System.Diagnostics.Metrics;

// PALINDROME CHECKER

static string PalindromeCheck(string text)
{
    text = text.ToUpper();
    int lentext = text.Length;
    string reversed = "";
    string cleantext = "";

    for (int c = (lentext - 1); c > -1; c--)
    {
        if (char.IsPunctuation(text[c]) == false && char.IsWhiteSpace(text[c]) == false)
        {
            reversed += text[c];
            Console.WriteLine(reversed);
        }
    }

    for (int x = 0; x < text.Length; x++)
    {
        if (!char.IsPunctuation(text[x]) && !char.IsWhiteSpace(text[x]))
        {
            cleantext += text[x];
            Console.WriteLine(cleantext);
        }
    }

    if (cleantext == reversed)
    {
        return "Palindrome";
    }
    else
    {
        return "Not a Palindrome";
    }
}

Console.WriteLine("---PALINDROME CHECKER---");
Console.WriteLine("")
string userInput = Console.ReadLine();
string isPalindrome = PalindromeCheck(userInput);
Console.WriteLine(isPalindrome);