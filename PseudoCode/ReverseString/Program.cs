using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static string ReverseString(string stringToReverse)
        {
            var startIndex = 0;
            var EndIndex = stringToReverse.Length - 1;
            var strArray = stringToReverse.ToCharArray();
            string[] newArray = new string[EndIndex + 1];
            var counter = 0;
            while (true)
            {
                newArray[startIndex] = strArray[EndIndex].ToString();
                newArray[EndIndex] = strArray[startIndex].ToString();
                startIndex++;
                EndIndex--;
                if (startIndex > EndIndex)
                    return String.Join("", newArray);
            }
        }

        static void Main(string[] args)
        {
            var str = ReverseString("Amol Wabale");
        }
    }
}
