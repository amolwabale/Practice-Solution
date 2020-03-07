using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class SqlDatabase : IDatabase
    {
        public DbCommand GetDatabaseCmd()
        {
            throw new NotImplementedException();
        }

        public DbDataReader GetDatabaseReader()
        {
            throw new NotImplementedException();
        }

        public DataSet GetDataset()
        {
            throw new NotImplementedException();
        }
    }
}
