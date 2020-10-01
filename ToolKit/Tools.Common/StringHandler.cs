using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Common
{
    public static class StringHandler
    {
        /// <summary>
        /// addSpaces adds a space before every capital letter, except the first, in a string. 
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string addSpaces(this string source)
        {
            string result = "";

            if (!string.IsNullOrWhiteSpace(source))
            {
                foreach(char letter in source)
                {
                    if (char.IsUpper(letter))
                    {
                        result.Trim();
                        result += " ";
                    }
                    result += letter;
                }
            }
            return result.Trim();
        }
    }
}
