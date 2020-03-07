using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FactoryDesignPattern.Constant;

namespace FactoryDesignPattern
{
    public class DatabaseFactory
    {
        public IDatabase GetDatabase(eDbType edbType)
        {
            IDatabase idb = null;
            switch (edbType)
            {
                case eDbType.Sql:
                    idb = new SqlDatabase();
                    break;
                case eDbType.MsAccess:
                    idb = new MsAccessDatabase();
                    break;
                case eDbType.Oracle:
                    idb = new OracleDatabase();
                    break;
                default:
                    break;
            }
            return idb;
        }
    }
}
