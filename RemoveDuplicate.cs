using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public static class RemoveDuplicate
    {
        public static string RemoveDuplicateString(string str)
        {
            var output = new StringBuilder();
            var stringResult = new HashSet<string>();
            for (int i = 0; i < str.ToCharArray().Length ; i++)
            {
                if (!stringResult.Contains(str[i].ToString()))
                {
                    stringResult.Add(str[i].ToString());
                    output.Append(str[i].ToString());
                }
            }

            return output.ToString();
        }
    }
}
