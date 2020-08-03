using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    public class SingletonEagerLoading
    {
        private static SingletonEagerLoading _singletonEagerLoading = new SingletonEagerLoading();

        private static SingletonEagerLoading GetInstance()
        {
            return _singletonEagerLoading;
        }
    }
}
