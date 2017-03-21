using Demo.DAL;
using OGT.Common.DbLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.BLL
{
   public class BusinessClass
    {
        static DbConnectionInfo _firstConn = null;
        static DbConnectionInfo _secondConn = null;
        static List<string> _firstTables = null;
        static List<string> _secondTables = null;

        public static DbConnectionInfo FirstConn { get => _firstConn; set => _firstConn = value; }
        public static DbConnectionInfo SecondConn { get => _secondConn; set => _secondConn = value; }
        public static List<string> FirstTables { get => _firstTables; set => _firstTables = value; }
        public static List<string> SecondTables { get => _secondTables; set => _secondTables = value; }

        public static void ConfigDB(int i)
        {
            DbConnectionInfo conn = DbHelper.GetConnection();
            if (i == 1)
                _firstConn = conn;
            else
                _secondConn = conn;

            if (i == 1)
            {
                DbHelper helper = new DbHelper(_firstConn);
                List<string> tableNames = helper.GetTableNames();
                FirstTables = tableNames;
            }
            if (i == 2)
            {
                DbHelper helper = new DbHelper(_firstConn);
                List<string> tableNames = helper.GetTableNames();
                SecondTables = tableNames;
            }
        }
    }
}

