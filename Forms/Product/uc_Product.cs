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
//    public partial class uc_Product : UserControl
//    {
//        public uc_Product()
//        {
//            InitializeComponent();
//        }

//        private void lbl_Add_New_Product_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Product obj = new frm_Add_New_Product() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Update_Product_Details_Click(object sender, EventArgs e)
//        {
//            frm_Search_Or_Update_Product_Details obj = new frm_Search_Or_Update_Product_Details() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_View_Product_List_Click(object sender, EventArgs e)
//        {
//            frm_View_Product_List obj = new frm_View_Product_List() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Add_New_Category_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Category obj = new frm_Add_New_Category() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Add_New_Subcategory_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Subcategory obj = new frm_Add_New_Subcategory() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    public partial class uc_Product : UserControl
    {
        public uc_Product()
        {
            InitializeComponent();
        }

        private void lbl_Add_New_Product_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Update_Product_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Product_Details obj = new frm_Search_Or_Update_Product_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_View_Product_List_Click(object sender, EventArgs e)
        {
            frm_View_Product_List obj = new frm_View_Product_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void uc_Product_Load(object sender, EventArgs e)
        {
            if (Class_File.Code_Class.UserRole == "Employee")
            {
                lbl_Add_New_Product.Enabled = false;

                Forms.frm_Main.pnl_FormLoader.Controls.Clear();

                frm_Search_Or_Update_Product_Details obj = new frm_Search_Or_Update_Product_Details() { TopLevel = false, TopMost = true };
                obj.FormBorderStyle = FormBorderStyle.None;

                Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}
