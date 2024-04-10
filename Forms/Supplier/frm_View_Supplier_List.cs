using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
{
    public partial class frm_View_Supplier_List : Form
    {
        public frm_View_Supplier_List()
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
        public void Clear_Controls()
        {
            cmb_Supplier_Name.SelectedIndex = -1;
            //dgv_Supplier_Details.DataSource = null;
        }
        private void frm_View_Supplier_List_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            if (cmb_Supplier_Name.SelectedIndex == -1)
            {
                Class_File.Code_Class.FillCombo(cmb_Supplier_Name, "Select Supplier_Name from tbl_Supplier_Details", "Supplier_Name");
                Clear_Controls();
            }

            Class_File.Code_Class.BindDataGrid(dgv_Supplier_Details, "Select * from tbl_Supplier_Details");

            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void cmb_Supplier_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            DataRowView row = (DataRowView)cmb_Supplier_Name.SelectedItem;
            if (row != null)
            {
                Class_File.Code_Class.BindDataGrid(dgv_Supplier_Details, "Select  * from tbl_Supplier_Details where Supplier_Name = '" + cmb_Supplier_Name.Text + "'");
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}

