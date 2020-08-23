using CodePlayGround.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            ContractEmployee obj = new ContractEmployee();

            //Dictionary<String, String> obj = new Dictionary<string, string>();

            CustomDictionarys<string, int> obj2 = new CustomDictionarys<string, int>();
            obj2.Add("1", 5);
            obj2.Add("1", 5);
            

        }
    }
} 
