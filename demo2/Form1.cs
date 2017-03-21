using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;
using System.Data;
using OGT.Entity;
using OGT.Common.DbLogin;
using OGT.Common.DbLogin.Model;
using OGT.Entity.NBearFramework;
//using Microsoft

namespace demo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connStr = GetDatabaseConnectionString();
                DbConnectionInfo info = new SQLServerWithSqlClient(connStr);
                IEntityContext entityContext = new NBearEntityContext(info);
                EntityHelper.Initialize(entityContext);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        private string GetDatabaseConnectionString()
        {
            DataConnectionDialog dialog = new DataConnectionDialog();
            dialog.DataSources.Clear();

            dialog.DataSources.Add(DataSource.AccessDataSource);    //Access
            dialog.DataSources.Add(DataSource.SqlDataSource);       //Sql Server
            dialog.DataSources.Add(DataSource.OracleDataSource);    //Oracle
            dialog.DataSources.Add(DataSource.OdbcDataSource);      //Odbc
            dialog.DataSources.Add(DataSource.SqlFileDataSource);   //Sql Server File

            //设置默认数据提供程序
            dialog.SelectedDataSource = DataSource.SqlDataSource;
            dialog.SelectedDataProvider = DataProvider.SqlDataProvider;

            string result = string.Empty;
            if (DataConnectionDialog.Show(dialog) == DialogResult.OK)
            {
                result = dialog.ConnectionString;
            }
            return result;
        }
        private string GetCustomDatabaseConnectionString()
        {
            DataConnectionDialog dialog = new DataConnectionDialog();
            dialog.DataSources.Clear();

            DataSource ds = new DataSource("显示部分类型的数据源", "显示部分类型的DataProvider");
            ds.Providers.Add(DataProvider.SqlDataProvider);
            ds.Providers.Add(DataProvider.OracleDataProvider);
            dialog.DataSources.Add(ds);
            

            //设置默认数据提供程序
            //dialog.SelectedDataSource = DataSource.SqlDataSource;
            //dialog.SelectedDataProvider = DataProvider.SqlDataProvider;

            string result = string.Empty;
            if (DataConnectionDialog.Show(dialog) == DialogResult.OK)
            {
                result = dialog.ConnectionString;
            }
            return result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connStr= GetCustomDatabaseConnectionString();

        }
    }
}
