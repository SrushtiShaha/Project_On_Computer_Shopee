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

namespace Ayuraj_Computer_Shopee_App.Forms.User
{
    public partial class frm_View_User_List : Form
    {
        public frm_View_User_List()
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
            cmb_User_Role.SelectedIndex = -1;

        }
        private void frm_View_User_List_Load(object sender, EventArgs e)
        {
            Clear_Controls();

            if (cmb_User_Role.SelectedIndex == -1)
            {
                Class_File.Code_Class.FillCombo(cmb_User_Role, "Select distinct User_Role from tbl_User_Details", "User_Role");
                Clear_Controls();
            }

            Class_File.Code_Class.BindDataGrid(dgv_User_Details, "Select  User_ID,User_Role,Username from tbl_User_Details");

        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void cmb_User_Role_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataRowView row = (DataRowView)cmb_User_Role.SelectedItem;
            if (row != null)
            {
                Class_File.Code_Class.BindDataGrid(dgv_User_Details, "Select  User_ID,User_Role,Username from tbl_User_Details where User_Role = '"+cmb_User_Role.Text+"'");    
            }
        }
    }
}
