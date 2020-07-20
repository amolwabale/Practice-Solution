using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern
{
    public class Open : IExecuter
    {
        public void Execute()
        {
            Console.WriteLine("Open");
        }
    }
}
