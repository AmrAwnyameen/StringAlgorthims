using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAlgorithms
{
    public class ReverseString
    {
        public static string GetReverseString(string word)
        {
            var builder = new StringBuilder();
            for (int i = word.ToCharArray().Length -1; i >=0; i--)
            {
                builder.Append(word[i]);
            }
            return builder.ToString();
        }

        public static string GetReverseStringByStack(string word)
        {
            var builder = new StringBuilder();
            var stack = new Stack<string>();
            for (int i = 0; i < word.ToCharArray().Length; i++)
            {
                stack.Push(word[i].ToString());
            }

            foreach (var item in stack)
            {
                builder.Append(item);
            }
            return builder.ToString();
        }

        public static string GetReverseWord(string word)
        {
            var builder = new StringBuilder();
            var results = word.Split(' ');
            for (int i = results.Length - 1; i >= 0; i--)
            {
                builder.Append(results[i] + " ");
            }
            return builder.ToString().Trim();

        }
    }
}
