using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    public sealed class SingletonTwo
    {
        private static SingletonTwo _instance = null;
        private static readonly  object _lock = new object();

        public static SingletonTwo GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonTwo();
                    }
                }
            }
            return _instance;
        }
    }
}
