using System;
using System.Linq;

public class Palindrome
{
    public static bool IsPalindrome(string word)
    {
            word = word.ToLower();
            var ArrayReverseWord = word.Reverse();

            string reverseWord = new string(ArrayReverseWord.ToArray());
            if (reverseWord == word) return true;
            else return false;    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
    }
}