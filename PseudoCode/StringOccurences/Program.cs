using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOccurences
{
    class Program
    {
        static int GetStringOccurences(string strToFind, string str)
        {
            var occurences = 0;
            var startIndex = 0;
            var strLen = strToFind.Length;
            while(true)
            {
                var subStr = str.Substring(startIndex, strLen);
                if (subStr.ToLower() == strToFind.ToLower())
                    occurences++;
                startIndex ++;
                if (startIndex > str.Length || (startIndex + strLen) > str.Length)
                    return occurences;
            }
        }
        static void Main(string[] args)
        {
            var str = "apple";
            var occ = GetStringOccurences("app",str);
        }
    }
}
