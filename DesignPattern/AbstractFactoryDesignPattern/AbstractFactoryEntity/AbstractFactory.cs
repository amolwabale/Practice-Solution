using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.Interface;

namespace AbstractFactoryDesignPattern.AbstractFactoryEntity
{
    public abstract class AbstractFactory
    {
        public abstract IConvert CreateConvert();
        public abstract IDatabase CreateDatabase();
    }
}
