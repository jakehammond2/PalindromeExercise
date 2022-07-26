using System;
using System.Linq;
namespace PalindromeExercise;


public class WordSmith
{
    public WordSmith()
    {
    }

    public bool IsAPalindrome(string word)
    {
        return word.ToLower().SequenceEqual(word.ToLower().Reverse());

        //string backwards = "";

        //for (int i = word.Length - 1; i >= 0; i--)
        //{
        //    backwards += word[i]; 
        //}
        //if (word == backwards)
        //{
        //    return true;
        //}
        //else
        //{
        //    return false; 
        //}
        
    }

    
}

