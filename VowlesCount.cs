using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
   public static class VowlesCount
    {
       public static int GetVowlesCount(string  word)
        {
            var count = 0;
            var vowles = "aeiou";
            for (int i = 0; i < word.ToCharArray().Length; i++)
            {
                if (vowles.IndexOf(word[i].ToString().ToLower()) != -1)
                    count++;
            }
            return count;

        }
    }
}
