using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECRC.StringManipulator
{
    public class StringManipulator
    {
        public string ReverseString(string input)
        {
            if (string.IsNullOrEmpty(input))
                return input;

            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public string RemoveSpaces(string input)
        {
            return string.IsNullOrEmpty(input) ? input : input.Replace(" ", "");
        }
    }
}
