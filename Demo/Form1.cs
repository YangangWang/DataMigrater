using Demo.BLL;
using OGT.Common.DbLogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            BusinessClass.ConfigDB(1);
            txtDB1.Text = BusinessClass.FirstConn.GetConnectionString();

            List<string> tableNames = BusinessClass.FirstTables;
            cboTable1.Properties.Items.AddRange(tableNames);
            if (cboTable1.Properties.Items.Count > 0)
                cboTable1.SelectedIndex = 0;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            BusinessClass.ConfigDB(2);
            txtDB2.Text = BusinessClass.SecondConn.GetConnectionString();
            List<string> tableNames = BusinessClass.SecondTables;
            cboTable2.Properties.Items.AddRange(tableNames);
            if (cboTable2.Properties.Items.Count > 0)
                cboTable2.SelectedIndex = 0;
        }
        BackgroundWorker backWorker = null;
        private void btnStart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //repositoryItemProgressBar1
            backWorker = new BackgroundWorker();
            backWorker.DoWork += BackWorker_DoWork;
            backWorker.RunWorkerCompleted += BackWorker_RunWorkerCompleted;

            backWorker.RunWorkerAsync();
        }

        private void BackWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BackWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            //backWorker.ReportProgress()
        }
    }
}
