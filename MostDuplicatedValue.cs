using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
   public class MostDuplicatedValue
    {
        public static string GetMostDuplicatedValue(string  str)
        {
            const int ASCICharCount = 256;
            var resultTables = new int[256];
            for (int i = 0; i < str.Length; i++)
            {
                resultTables[str[i]]++;
            }
            var max = -1;
            var mostCharchter = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (max < resultTables[str[i]])
                {
                    max = resultTables[str[i]];
                    mostCharchter = str[i].ToString();
                }
            }

            return mostCharchter;
        }

       
    }
}
