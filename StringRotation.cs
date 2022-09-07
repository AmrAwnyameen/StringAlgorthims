using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class StringRotation
    {
       public static bool CheckIsStringRotation (string str1, string str2)
        {
            var word = str1 + str1;
            if (str1.Length == str2.Length && (str1 + str1).Contains(str2))
                return true;

            return false;
        }
    }
}
