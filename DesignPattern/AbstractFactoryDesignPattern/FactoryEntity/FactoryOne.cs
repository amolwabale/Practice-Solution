using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactoryDesignPattern.AbstractFactoryEntity;
using AbstractFactoryDesignPattern.Entity;
using AbstractFactoryDesignPattern.Interface;

namespace AbstractFactoryDesignPattern.FactoryEntity
{
    public class FactoryOne : AbstractFactory
    {
        public override IConvert CreateConvert()
        {
            return new Excel();
        }

        public override IDatabase CreateDatabase()
        {
            return new OracleDatabase();
        }
    }
}
