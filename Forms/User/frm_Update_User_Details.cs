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
//    public partial class frm_Update_User_Details : Form
//    {
//        public frm_Update_User_Details()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            tb_User_Id.Clear();
//            cmb_User_Role.SelectedIndex = -1;
//            cmb_Username.SelectedIndex = -1;
//            tb_New_Password.Clear();
//            tb_Confirm_Password.Clear();
//        }
//        private void frm_Update_User_Details_Load(object sender, EventArgs e)
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

namespace Ayuraj_Computer_Shopee_App.Forms.User
{
    public partial class frm_Update_User_Details : Form
    {
        public frm_Update_User_Details()
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
            tb_User_Id.Clear();
            tb_User_Role.Clear();
            tb_Username.Clear();
            tb_New_Password.Clear();
            tb_Confirm_Password.Clear();
        }
        private void frm_Update_User_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_User_Id != null)
            {
                Class_File.Code_Class.Con_Open();

                String Query = "Select * From tbl_User_Details Where User_ID = @UID";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("UID", SqlDbType.Int).Value = tb_User_Id.Text;
                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_User_Role.Text = Dr.GetString(Dr.GetOrdinal("User_Role"));
                    tb_Username.Text = Dr.GetString(Dr.GetOrdinal("Username"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Record");
                    tb_User_Id.Clear();
                }

                Class_File.Code_Class.Con_Close();
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Class_File.Code_Class.Con;
            String Query;

            if (tb_User_Id.Text != "" && tb_User_Role.Text != "" && tb_Username.Text != "" && tb_New_Password.Text != "" && tb_Confirm_Password.Text != "")
            {
                Cmd.CommandText = "Update tbl_User_Details set Password= @Pass where User_ID = @UID";
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Confirm_Password.Text;
                Cmd.Parameters.Add("UID", SqlDbType.Int).Value = tb_User_Id.Text;

                Cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Succesful", "Success");

                Clear_Controls();
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}

