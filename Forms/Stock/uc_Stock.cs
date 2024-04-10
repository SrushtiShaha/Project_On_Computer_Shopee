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
//    public partial class uc_Stock : UserControl
//    {
//        public uc_Stock()
//        {
//            InitializeComponent();
//        }

//        private void lbl_Add_New_Stock_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Stock obj = new frm_Add_New_Stock() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_View_Stock_List_Click(object sender, EventArgs e)
//        {
//            frm_View_Stock_List obj = new frm_View_Stock_List() { TopLevel = false, TopMost = true };
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

namespace Ayuraj_Computer_Shopee_App.Forms.Stock
{
    public partial class uc_Stock : UserControl
    {
        public uc_Stock()
        {
            InitializeComponent();
        }

        private void lbl_Add_New_Stock_Click(object sender, EventArgs e)
        {
            frm_Add_New_Stock obj = new frm_Add_New_Stock() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_View_Stock_List_Click(object sender, EventArgs e)
        {
            frm_View_Stock_List obj = new frm_View_Stock_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void uc_Stock_Load(object sender, EventArgs e)
        {
            if (Class_File.Code_Class.UserRole == "Employee")
            {
                Forms.frm_Main.pnl_FormLoader.Controls.Clear();
                lbl_Add_New_Stock.Enabled = false;

                frm_View_Stock_List obj = new frm_View_Stock_List() { TopLevel = false, TopMost = true };
                obj.FormBorderStyle = FormBorderStyle.None;

                Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}
