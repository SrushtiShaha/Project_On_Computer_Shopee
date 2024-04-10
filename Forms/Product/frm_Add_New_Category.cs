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
//    public partial class frm_Add_New_Category : Form
//    {
//        public frm_Add_New_Category()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            tb_Category_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Category_Details", "Select Max(Category_ID) from tbl_Category_Details"));

//            cmb_Product_Name.SelectedIndex = -1;
//            tb_Category_Name.Clear();
//            cmb_Subcategory_Name.SelectedIndex = -1;
//        }
//        private void lbl_Back_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Product obj = new frm_Add_New_Product() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void frm_Add_New_Category_Load(object sender, EventArgs e)
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
    public partial class frm_Add_New_Category : Form
    {
        public frm_Add_New_Category()
        {
            InitializeComponent();
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            Class_File.Code_Class.Only_Numeric(e);
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            Class_File.Code_Class.Only_Text(e);
        }

        public void Clear_Controls()
        {
            tb_Category_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Category_Details", "Select Max(Category_ID) from tbl_Category_Details"));

            tb_Category_Name.Clear();
            cmb_Subcategory_Name.SelectedIndex = -1;
        }
        private void lbl_Back_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void frm_Add_New_Category_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select distinct Subcategory_Name from tbl_Subcategory_Details", "Subcategory_Name");
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Category_Details(Category_ID,Category_Name,Subcategory_Name) Values(@CID,@CNm,@SCNm)";

                Cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Category_ID.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = tb_Category_Name.Text;
                Cmd.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill all Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
