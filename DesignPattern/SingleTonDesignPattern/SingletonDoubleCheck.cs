using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    public sealed class SingletonDoubleCheck
    {
        private static SingletonDoubleCheck _instance = null;
        private static readonly  object _lock = new object();

        public static SingletonDoubleCheck GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonDoubleCheck();
                    }
                }
            }
            return _instance;
        }
    }
}
