using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms
{
    public partial class frm_Report_Options : Form
    {
        public frm_Report_Options()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from tbl_Customer_Personal_Details";
            Cmd.Connection = Class_File.Code_Class.Con;
            DataTable Dt = new DataTable();
            SqlDataReader Dr = Cmd.ExecuteReader();

            Dt.Load(Dr);

            if (Dt.Rows.Count > 0)
            {
                frm_Report_Viewer Obj = new frm_Report_Viewer();
                String AppPath = Application.StartupPath;
                string ReportPath = @"CR_Customer_Personal.rpt";
                String FullPath = System.IO.Path.Combine(AppPath, ReportPath);

                Obj.ReportName = FullPath;
                Obj.ReportData = Dt;
                Obj.Show();
            }
            Class_File.Code_Class.Con_Close();
        }

        private void btn_Supplier_Report_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from tbl_Supplier_Details";
            Cmd.Connection = Class_File.Code_Class.Con;
            DataTable Dt = new DataTable();
            SqlDataReader Dr = Cmd.ExecuteReader();

            Dt.Load(Dr);

            if (Dt.Rows.Count > 0)
            {
                frm_Report_Viewer Obj = new frm_Report_Viewer();
                String AppPath = Application.StartupPath;
                string ReportPath = @"CR_Supplier_Report.rpt";
                String FullPath = System.IO.Path.Combine(AppPath, ReportPath);

                Obj.ReportName = FullPath;
                Obj.ReportData = Dt;
                Obj.Show();
            }
            Class_File.Code_Class.Con_Close();
        }

        private void btn_Stock_Report_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select * from tbl_Stock_Details";
            Cmd.Connection = Class_File.Code_Class.Con;
            DataTable Dt = new DataTable();
            SqlDataReader Dr = Cmd.ExecuteReader();

            Dt.Load(Dr);

            if (Dt.Rows.Count > 0)
            {
                frm_Report_Viewer Obj = new frm_Report_Viewer();
                String AppPath = Application.StartupPath;
                string ReportPath = @"CR_Stock_Report.rpt";
                String FullPath = System.IO.Path.Combine(AppPath, ReportPath);

                Obj.ReportName = FullPath;
                Obj.ReportData = Dt;
                Obj.Show();
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}
