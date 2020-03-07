using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeString
{
    class Program
    {
        static bool IsStringPalindrom(string str)
        {
            var strArr = str.ToCharArray();
            var lowerIndex = 0;
            var higherIndex = strArr.Length - 1;
            while (true)
            {

                if (lowerIndex < higherIndex)
                {
                    if (strArr[lowerIndex] == strArr[higherIndex])
                    {
                        lowerIndex++;
                        higherIndex--;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                    return true;
            }
        }
        static void Main(string[] args)
        {
            var str =IsStringPalindrom("mom");
            
        }
    }
}
