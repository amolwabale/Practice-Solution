using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton _singleton = null;
        private int count = 0;
        private Singleton()
        {
            count++;
        }
        public static Singleton GetInstance
        {
            get
            {
                if (_singleton == null)
                    _singleton = new Singleton();
                return _singleton;
            }
        }

        public void PintCount()
        {
            Console.WriteLine("Count is {0}",count);
        }
    }
}
