//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.User
//{
//    public partial class uc_User : UserControl
//    {
//        public uc_User()
//        {
//            InitializeComponent();
//        }

//        private void lbl_Add_New_User_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_User obj = new frm_Add_New_User() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Update_User_Details_Click(object sender, EventArgs e)
//        {
//            frm_Update_User_Details obj = new frm_Update_User_Details() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Delete_User_Details_Click(object sender, EventArgs e)
//        {
//            frm_Delete_User obj = new frm_Delete_User() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_View_User_List_Click(object sender, EventArgs e)
//        {
//            frm_View_User_List obj = new frm_View_User_List() { TopLevel = false, TopMost = true };
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

namespace Ayuraj_Computer_Shopee_App.Forms.User
{
    public partial class uc_User : UserControl
    {
        public uc_User()
        {
            InitializeComponent();
        }

        private void lbl_Add_New_User_Click(object sender, EventArgs e)
        {
            frm_Add_New_User obj = new frm_Add_New_User() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Update_User_Details_Click(object sender, EventArgs e)
        {
            frm_Update_User_Details obj = new frm_Update_User_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Delete_User_Details_Click(object sender, EventArgs e)
        {
            frm_Delete_User obj = new frm_Delete_User() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_View_User_List_Click(object sender, EventArgs e)
        {
            frm_View_User_List obj = new frm_View_User_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void uc_User_Load(object sender, EventArgs e)
        {
            if (Class_File.Code_Class.UserRole == "Employee")
            {
                Forms.frm_Main.pnl_FormLoader.Controls.Clear();
                lbl_Add_New_User.Enabled = false;
                lbl_Delete_User_Details.Enabled = false;
                lbl_Update_User_Details.Enabled = false;

                frm_View_User_List obj = new frm_View_User_List
                    
                          () { TopLevel = false, TopMost = true };
                obj.FormBorderStyle = FormBorderStyle.None;

                Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}

