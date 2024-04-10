//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.Employee
//{
//    public partial class uc_Employee : UserControl
//    {
//        public uc_Employee()
//        {
//            InitializeComponent();
//        }

//        private void lbl_Add_New_Employee_Click(object sender, EventArgs e)
//        {
//            frm_Add_New_Employee obj = new frm_Add_New_Employee() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_Search_Or_Update_Employee_Details_Click(object sender, EventArgs e)
//        {
//            frm_Search_Or_Update_Employee_Details obj = new frm_Search_Or_Update_Employee_Details() { TopLevel = false, TopMost = true };
//            obj.FormBorderStyle = FormBorderStyle.None;

//            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
//            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
//            obj.Show();
//        }

//        private void lbl_View_Employee_List_Click(object sender, EventArgs e)
//        {
//            frm_View_Employee_List obj = new frm_View_Employee_List() { TopLevel = false, TopMost = true };
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

namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    public partial class uc_Employee : UserControl
    {
        public uc_Employee()
        {
            InitializeComponent();
        }

        private void lbl_Add_New_Employee_Click(object sender, EventArgs e)
        {
            frm_Add_New_Employee obj = new frm_Add_New_Employee() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Search_Or_Update_Employee_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Or_Update_Employee_Details obj = new frm_Search_Or_Update_Employee_Details() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_View_Employee_List_Click(object sender, EventArgs e)
        {
            frm_View_Employee_List obj = new frm_View_Employee_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void uc_Employee_Load(object sender, EventArgs e)
        {
            if (Class_File.Code_Class.UserRole == "Employee")
            {
                lbl_Add_New_Employee.Enabled = false;
                lbl_Search_Or_Update_Employee_Details.Enabled = false;

                Forms.frm_Main.pnl_FormLoader.Controls.Clear();

                frm_View_Employee_List obj = new frm_View_Employee_List() { TopLevel = false, TopMost = true };
                obj.FormBorderStyle = FormBorderStyle.None;

                Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
                obj.Show();
            }
        }
    }
}
