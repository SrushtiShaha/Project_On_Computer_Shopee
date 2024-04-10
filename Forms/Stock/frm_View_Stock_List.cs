//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.Stock
//{
//    public partial class frm_View_Stock_List : Form
//    {
//        public frm_View_Stock_List()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            cmb_Product_Name.SelectedIndex = -1;
//            cmb_Category_Name.SelectedIndex = -1;
//            cmb_Subcategory_Name.SelectedIndex = -1;
//        }
//        private void frm_View_Stock_List_Load(object sender, EventArgs e)
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

namespace Ayuraj_Computer_Shopee_App.Forms.Stock
{
    public partial class frm_View_Stock_List : Form
    {
        public frm_View_Stock_List()
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
        private void frm_View_Stock_List_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Product_Name, "Select distinct Product_Name from tbl_Product_Details", "Product_Name");
            Class_File.Code_Class.FillCombo(cmb_Category_Name, "Select distinct Category_Name from tbl_Product_Details", "Category_Name");
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select distinct Subcategory_Name from tbl_Product_Details", "Subcategory_Name");

            Class_File.Code_Class.BindDataGrid(dgv_Stock_Details, "Select * from tbl_Stock_Details");
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.BindDataGrid(dgv_Stock_Details, "Select * from tbl_Stock_Details");
            Clear_Controls();
        }

        //private void cmb_Product_Name_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    cmb_Category_Name.Enabled = true;
        //    Class_File.Code_Class.Con_Open();
        //    SqlCommand cmd = new SqlCommand();

        //    String Query = "Select Category_Name from tbl_Product_Details where Product_Name =@PNm";
        //    cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

        //    cmd.Parameters.Add("@PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
        //    SqlDataReader Dr = cmd.ExecuteReader();

        //    if (Dr.Read())
        //    {
        //        Dr.Close();
        //        String Query1 = "Select * from tbl_Product_Details where Product_Name ='" + cmb_Product_Name.Text + "' ";
        //        Class_File.Code_Class.FillCombo(cmb_Category_Name, Query1, "Category_Name");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Records Not Found", "Records Not Found");
        //    }
        //    Class_File.Code_Class.Con_Close();
        //}

        //private void cmb_Category_Name_SelectionChangeCommitted(object sender, EventArgs e)
        //{
        //    cmb_Subcategory_Name.Enabled = true;
        //    Class_File.Code_Class.Con_Open();

        //    SqlCommand cmd = new SqlCommand();

        //    String Query = "Select Subcategory_Name from tbl_Product_Details where Category_Name =@CNm";
        //    cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

        //    cmd.Parameters.Add("@CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
        //    SqlDataReader Dr = cmd.ExecuteReader();

        //    if (Dr.Read())
        //    {
        //        Dr.Close();
        //        String Query1 = "Select * from tbl_Product_Details where Category_Name ='" + cmb_Category_Name.Text + "'and Product_Name ='" + cmb_Product_Name.Text + "' ";
        //        Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, Query1, "Subcategory_Name");
        //    }
        //    else
        //    {
        //        MessageBox.Show("Records Not Found", "Records Not Found");
        //    }
        //    Class_File.Code_Class.Con_Close();
        //}

        private void cmb_Subcategory_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            DataRowView row = (DataRowView)cmb_Subcategory_Name.SelectedItem;
            if (row != null)
            {
                Class_File.Code_Class.BindDataGrid(dgv_Stock_Details, "Select  * from tbl_Stock_Details where Product_Name = '" + cmb_Product_Name.Text + "' and Category_Name = '" + cmb_Category_Name.Text + "' and Subcategory_Name = '" + cmb_Subcategory_Name.Text + "'");
            }
            else
            {
                MessageBox.Show("Records Not Found", "Records Not Found");
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}

