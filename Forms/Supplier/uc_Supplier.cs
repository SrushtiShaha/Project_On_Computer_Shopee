//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
//{
//    public partial class uc_Supplier : UserControl
//    {
//        public uc_Supplier()
//        {
//            InitializeComponent();
//        }

//        private void lbl_Add_New_Supplier_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Supplier obj = new frm_Add_New_Supplier() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Update_Supplier_Details_Click(object sender, EventArgs e)
//        {
//            frm_Search_Or_Update_Supplier_Details obj = new frm_Search_Or_Update_Supplier_Details() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_View_Supplier_List_Click(object sender, EventArgs e)
//        {
//            frm_View_Supplier_List obj = new frm_View_Supplier_List() { TopLevel = false, TopMost = true };
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

namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
{
    public partial class uc_Supplier : UserControl
    {
        public uc_Supplier()
        {
            InitializeComponent();
        }

        private void lbl_Add_New_Supplier_Click(object sender, EventArgs e)
        {
            frm_Add_New_Supplier obj = new frm_Add_New_Supplier() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Update_Supplier_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Supplier_Details obj = new frm_Search_Or_Update_Supplier_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_View_Supplier_List_Click(object sender, EventArgs e)
        {
            frm_View_Supplier_List obj = new frm_View_Supplier_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void uc_Supplier_Load(object sender, EventArgs e)
        {
            if (Class_File.Code_Class.UserRole == "Employee")
            {
                Forms.frm_Main.pnl_FormLoader.Controls.Clear();
                lbl_Add_New_Supplier.Enabled = false;
                lbl_View_Supplier_List.Enabled = false;

                frm_Search_Or_Update_Supplier_Details obj = new frm_Search_Or_Update_Supplier_Details() { TopLevel = false, TopMost = true };
                obj.FormBorderStyle = FormBorderStyle.None;

                Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}

