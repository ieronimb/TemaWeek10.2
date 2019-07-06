using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatinExercitiul3
{
    class SpecialString
    {
        public static string GoatLatin(string str)
        {
            string output = string.Empty;
            var splitString = str.Split(' ');

            for (int i = 0; i < splitString.Length; i++)
            {
                string word = splitString[i];
                if (word.ToLower()[0].Equals('a') || word.ToLower()[0].Equals('e') ||
                   word.ToLower()[0].Equals('i') || word.ToLower()[0].Equals('o') ||
                   word.ToLower()[0].Equals('u'))
                    output += word + "ma" + new string('a', i + 1) + " ";
                else
                {
                    output += (word + word[0] + "ma" + new string('a', i + 1) + " ").Remove(0, 1);
                }

            }
            return output.Trim();
        }
    }
}
