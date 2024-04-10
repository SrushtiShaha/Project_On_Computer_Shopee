using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App
{
    public partial class frm_Report_Viewer : Form
    {
        public frm_Report_Viewer()
        {
            InitializeComponent();
        }

        public string ReportName { get; set; }

        public DataTable ReportData { get; set; }

        private void frm_Report_Viewer_Load(object sender, EventArgs e)
        {
            ReportDocument rdd = new ReportDocument();
            rdd.Load(ReportName);
            rdd.SetDataSource(ReportData);
            crv_Viewer.ReportSource = rdd;
        }
    }
}
