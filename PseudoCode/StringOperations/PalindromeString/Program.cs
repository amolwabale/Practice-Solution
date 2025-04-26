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
            while (lowerIndex < higherIndex)
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
            return true;
        }

        static bool isAnagram(string one, string two)
        {
            if (one.Length != two.Length)
                return false;

            int[] arr = new int[26];
            one = one.ToLower();
            two = two.ToLower();
            foreach (char item in one)
            {
                arr[item - 'a']++;
            }

            foreach (char item in two)
            {
                arr[item - 'a']--;
            }

            foreach(var item in arr)
            {
                if (item != 0)
                    return false;
            }

            return true;

        }
        static void Main(string[] args)
        {
            var str = IsStringPalindrom("mom");

            var isAna = isAnagram("listen", "silezt");

        }
    }
}
