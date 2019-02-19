using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace DataAccessLayer
{
    public class DataLayer
    {
        public string DbConnection()
        {
            return ConnectionString();
        }
        private string ConnectionString()
        {
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["databasecon"];

            if (cs != null)
            {
                return cs.ConnectionString;
            }
            else
            {
                string s = ConfigurationManager.ConnectionStrings["databasecon"].ConnectionString;
                return "something else";
            }
        }
    }
}
