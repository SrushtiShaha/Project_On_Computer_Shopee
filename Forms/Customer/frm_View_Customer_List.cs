using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    public partial class frm_View_Customer_List : Form
    {
        public frm_View_Customer_List()
        {
            InitializeComponent();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Class_File.Code_Class.Only_Numeric(e);
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            Class_File.Code_Class.Only_Numeric(e);
        }

        private void frm_View_Customer_List_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.BindDataGrid(dgv_Customer_Personal_Details, "Select * from tbl_Customer_Personal_Details");

        }


        private void dgv_Customer_Personal_Details_MouseClick(object sender, MouseEventArgs e)
        {
            Class_File.Code_Class.BindDataGrid(dgv_Customer_Purchase_Details, "Select * from tbl_Customer_Purchase_Details where Customer_ID = '" + dgv_Customer_Personal_Details.SelectedRows[0].Cells["Customer_ID"].Value.ToString() + "'");
        }
    }
}
