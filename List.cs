using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    internal class CaseAlternatorTask
    {
        static void Main(string[] argc)
        {
           
        }
        static void Solver(char[] word, int startIndex, List<string> result)
        {
            var subWord = word.ToArray();
            if (startIndex == word.Length)
            {
                result.Add(new string(word));
                return;
            }

            var lower = char.ToLower(word[startIndex]);
            var upper = char.ToUpper(word[startIndex]);
            word[startIndex] = lower;
            Solver(word, startIndex + 1, result);
            if (lower != upper)
            {
                word[startIndex] = upper;
                Solver(word, startIndex + 1, result);
            }
        }
    }

}