using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class Capitalization
    {
        public static string GetCapitalizationWord(string sentense)
        {
         

            var regaxResult = Regex.Replace(sentense, @"\s+", " ");
            var words = regaxResult.Trim().Replace("   ", String.Empty).Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Substring(0, 1).ToUpper() +
                     words[i].Substring(1).ToLower();
            }

            return string.Join(" ", words);
        }
    }
}
