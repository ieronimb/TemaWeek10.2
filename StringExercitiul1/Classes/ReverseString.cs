using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExercitiul1.Classes
{
    public class ReverseString
    {
        public static string ReverseLettersOnly(string aString)
        {
            if (aString == null)
                return null;

            var length = aString.Length;
            var start = 0;
            var end = length - 1;

            var charArray = aString.ToCharArray();

            while (start < end)
            {
                var startLetter = aString[start];
                var endLetter = aString[end];

                var startIsLetter = isLetter(startLetter);
                var endIsLetter = isLetter(endLetter);
                if (!startIsLetter)
                {
                    start++;
                }
                else if (!endIsLetter)
                {
                    end--;
                }
                else
                {
                    var tmp = charArray[start];
                    charArray[start] = charArray[end];
                    charArray[end] = tmp;
                    start++;
                    end--;
                }
            }

            return new string(charArray);
        }

        private static bool isLetter(char item)
        {
            return (item >= 'A' && item <= 'Z') ||
                   (item >= 'a' && item <= 'z');
        }
    }
}
