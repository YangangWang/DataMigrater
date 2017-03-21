using OGT.Common.DbLogin;
using OGT.DataLoader.Entity;
using OGT.Entity;
using OGT.Entity.NBearFramework;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Demo.DAL
{
    public class DbHelper
    {
        private IEntityContext _entityContext = null;
        public static DbConnectionInfo GetConnection()
        {
            string filePath = "ConnectionStrings";
            DbConnectionInfoManagerWindow win = new DbConnectionInfoManagerWindow(filePath);
            DbConnectionInfo info = null;
            if ((bool)win.ShowDialog())
            {
                info = win.SelectedConnectionInfo;
            }
            if (info != null)
                return info;
            return null;
        }
        public DbHelper(DbConnectionInfo connInfo)
        {
            _entityContext = new NBearEntityContext(connInfo);
            EntityHelper.Initialize(_entityContext);
        }

        public  List<string> GetTableNames()
        {
            try
            {
                DataTable dt = _entityContext.FindDataTable("select table_name from user_tables");
                List<string> result = Table2List(dt);
                return result;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }
        private static List<string> Table2List(DataTable dt)
        {
            List<string> result = new List<string>();
            
            foreach (DataRow row in dt.Rows)
            {
                result.Add(row[0].ToString());
            }
            return result;
        }
        public void Migrate(string table1,string table2)
        {

        }
    }
}
