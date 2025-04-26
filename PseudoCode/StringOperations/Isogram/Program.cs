using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isogram
{
    class Program
    {
        static bool IsIsogram(string isogramString)
        {
            var strArr = isogramString.ToLower().ToCharArray();
            HashSet<char> letterList = new HashSet<char>(); //Hashset has O(1) search complexity where else list has O(n)
            foreach (var item in strArr)
            {
                if (!letterList.Contains(item))
                    letterList.Add(item);
                else
                    return false;
            }
            return true;
        }
      
        static void Main(string[] args)
        {
            var IsStrgIsogram = IsIsogram("Algorism");
            Console.WriteLine("Algorism: " + IsStrgIsogram);
            IsStrgIsogram = IsIsogram("PasSword");
            Console.WriteLine("PasSword: " + IsStrgIsogram);
            IsStrgIsogram = IsIsogram("Consecutive");
            Console.WriteLine("Consecutive: " + IsStrgIsogram);
            
        }
    }
}
