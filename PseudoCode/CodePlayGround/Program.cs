using CodePlayGround.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{
    public static class Demo
    {

        public static string AddHypenQuote(this string str)
        {
            return "-" + str + "-";
        }
    }
    class Program
    {

        

        static void Main(string[] args)
        {


            ContractEmployee obj = new ContractEmployee();

            //Dictionary<String, String> obj = new Dictionary<string, string>();

            CustomDictionarys<string, int> obj2 = new CustomDictionarys<string, int>();
            obj2.Add("1", 5);
            obj2.Add("1", 5);

            string data = "Interview".AddHypenQuote();

            var data1 = AddBigNumbers("204", "301");

            var reverseString = ReverseString("Amol Wabale");
        }

        public static string AddBigNumbers(string num1, string num2)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;

            int i = num1.Length - 1;
            int j = num2.Length - 1;

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = i >= 0 ? num1[i] - '0' : 0;
                int digit2 = j >= 0 ? num2[j] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                result.Insert(0, sum % 10);
                carry = sum / 10;

                i--;
                j--;
            }

            return result.ToString();
        }

        public static string ReverseString(string str)
        {
            var charArr = str.ToCharArray();

            var i = 0;
            var k = charArr.Length - 1;

            while (i < k)
            {
                var temp = charArr[i];
                charArr[i] = charArr[k];
                charArr[k] = temp;
                i++;
                k--;
            }

            //XOR SWAP
            //if (charArr[i] != charArr[k]) // Only swap if the characters are different
            //{
            //    // Swap using XOR trick
            //    charArr[i] = charArr[i] ^ charArr[k];
            //    charArr[k] = charArr[i] ^ charArr[k];
            //    charArr[i] = charArr[i] ^ charArr[k];
            //}

            return new string(charArr);

        }


    }
} 
