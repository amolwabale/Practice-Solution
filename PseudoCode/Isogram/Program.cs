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
            var strArr = isogramString.ToCharArray();
            var letterList = new List<string>();
            foreach (var item in strArr)
            {
                var temp = item.ToString().ToLower();
                if (!letterList.Contains(temp))
                    letterList.Add(temp);
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
