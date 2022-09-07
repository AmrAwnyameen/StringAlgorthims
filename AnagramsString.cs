using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class AnagramsString
    {
        public static bool areAnagrams(string str, string str2)
        {
            if (str ==null || str ==null)
                return false;

            var arrayOne = str.ToLower().ToCharArray().OrderBy(s=> s).ToArray();
            var arrayTwo = str2.ToLower().ToCharArray().OrderBy(s => s).ToArray();
            if (arrayOne.SequenceEqual(arrayTwo))
                return true;

            return false;
        }
    }
}
