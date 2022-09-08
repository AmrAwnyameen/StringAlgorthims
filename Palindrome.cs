using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
   public static class Palindrome
    {
        public static bool ifStringPalindrome(string word)
        {
            //12321 //12321

            //abba //abba
            if (string.IsNullOrEmpty(word))
                return false;

            var left = 0;
            var right = word.Length - 1;
            while(left < right)
            {
                if (word.ToLower().ElementAt(left++) != word.ToLower().ElementAt(right--))
                    return false;
            }
            return true;

        }
    }
}
