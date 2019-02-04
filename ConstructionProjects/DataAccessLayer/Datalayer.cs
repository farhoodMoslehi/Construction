using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Configuration;

namespace DataAccessLayer
{
    class Datalayer
    {
        public string DBConnection()
        {
            return ConnectionString();
        }
        private string ConnectionString()
        {
            ConnectionStringSettings cs = ConfigurationManager.ConnectionStrings["Databasecon"];

            if (cs != null)
            {
                return cs.ConnectionString;
            }
            else
            {
                string s = ConfigurationManager.ConnectionStrings["Databasecon"].ConnectionString;
                return "something else";
            }
        }
    }
}
