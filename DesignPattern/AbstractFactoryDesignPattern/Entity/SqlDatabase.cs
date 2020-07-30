using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AbstractFactoryDesignPattern.Interface;

namespace AbstractFactoryDesignPattern.Entity
{
    public class SqlDatabase : IDatabase
    {
        public ICommand GetDataReader()
        {
            return null;
        }

        public void Save()
        {
            Console.WriteLine("Saved sql connection");
        }
    }
}
