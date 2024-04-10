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
//    public partial class frm_View_Employee_List : Form
//    {
//        public frm_View_Employee_List()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Conrols()
//        {
//            cmb_Employee_Name.SelectedIndex = -1;
//        }
//        private void frm_View_Employee_List_Load(object sender, EventArgs e)
//        {
//            Clear_Conrols();
//        }

//        private void pb_Refresh_Click(object sender, EventArgs e)
//        {
//            Clear_Conrols();
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
    public partial class frm_View_Employee_List : Form
    {
        public frm_View_Employee_List()
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
        public void Clear_Conrols()
        {
            cmb_Employee_Name.SelectedIndex = -1;
        }
        private void frm_View_Employee_List_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Employee_Name, "Select distinct Employee_Name from tbl_Employee_Details", "Employee_Name");
            Class_File.Code_Class.BindDataGrid(dgv_Employee_Details, "Select * from tbl_Employee_Details");
            Clear_Conrols();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.BindDataGrid(dgv_Employee_Details, "Select * from tbl_Employee_Details");
            Clear_Conrols();
        }

        private void cmb_Employee_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            DataRowView row = (DataRowView)cmb_Employee_Name.SelectedItem;
            if (row != null)
            {
                Class_File.Code_Class.BindDataGrid(dgv_Employee_Details, "Select  * from tbl_Employee_Details where Employee_Name = '" + cmb_Employee_Name.Text + "'");
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}

