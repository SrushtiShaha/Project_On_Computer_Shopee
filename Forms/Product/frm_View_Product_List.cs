//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.Product
//{
//    public partial class frm_View_Product_List : Form
//    {
//        public frm_View_Product_List()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            cmb_Product_Name.SelectedIndex = -1;
//            cmb_Category_Name.SelectedIndex = -1;
//            cmb_Subcategory_Name.SelectedIndex = -1;
//        }
//        private void frm_View_Product_Details_Load(object sender, EventArgs e)
//        {
//            Clear_Controls();
//        }

//        private void pb_Refresh_Click(object sender, EventArgs e)
//        {
//            Clear_Controls();
//        }
//    }
//}
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

namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    public partial class frm_View_Product_List : Form
    {
        public frm_View_Product_List()
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
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
        }
        private void frm_View_Product_Details_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Product_Name, "Select distinct Product_Name from tbl_Product_Details", "Product_Name");
            Class_File.Code_Class.FillCombo(cmb_Category_Name, "Select distinct Category_Name from tbl_Category_Details", "Category_Name");
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select distinct Subcategory_Name from tbl_Subcategory_Details", "Subcategory_Name");

            Class_File.Code_Class.BindDataGrid(dgv_Product_Details, "Select * from tbl_Product_Details");
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.BindDataGrid(dgv_Product_Details, "Select * from tbl_Supplier_Details");
            Clear_Controls();
        }

        private void cmb_Product_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Category_Name.Enabled = true;
        }

        private void cmb_Category_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmb_Subcategory_Name.Enabled = true;
        }

        private void cmb_Subcategory_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            DataRowView row = (DataRowView)cmb_Subcategory_Name.SelectedItem;
            if (row != null)
            {
                Class_File.Code_Class.BindDataGrid(dgv_Product_Details, "Select  * from tbl_Product_Details where Product_Name = '" + cmb_Product_Name.Text + "' and Category_Name = '" + cmb_Category_Name.Text + "' and Subcategory_Name = '" + cmb_Subcategory_Name.Text + "'");
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}
