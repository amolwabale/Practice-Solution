using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var instance = Singleton.GetInstance;
            instance.PintCount();
            var instance1 = Singleton.GetInstance;
            instance.PintCount();

            var t = SingletonDoubleCheck.GetInstance();
        }
    }
}
