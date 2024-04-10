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
    public partial class frm_Delete_User : Form
    {
        public frm_Delete_User()
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
            tb_Password.Clear();
            tb_Admin_Password.Clear();
            tb_User_Id.Focus();
        }
        private void frm_Delete_User_Load(object sender, EventArgs e)
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
                    MessageBox.Show("No Record Found", "Invalid Roll No");
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

            if (tb_User_Id.Text != "" && tb_User_Role.Text != "" && tb_Username.Text != "" && tb_Password.Text != "" && tb_Admin_Password.Text != "")
            {
                if (tb_Admin_Password.Text == "a123")
                {
                    Query = "Select Password from tbl_User_Details where User_Role = @URole and Username = @Username";

                    Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                    Cmd.Parameters.Add("URole", SqlDbType.NVarChar).Value = tb_User_Role.Text;
                    Cmd.Parameters.Add("Username", SqlDbType.NVarChar).Value = tb_Username.Text;

                    SqlDataReader Dr = Cmd.ExecuteReader();


                    if (Dr.Read())
                    {

                        if (tb_Password.Text != Dr.GetString(Dr.GetOrdinal("Password")))
                        {
                            MessageBox.Show("Enter valid password", "Invalid Password");

                        }
                        else
                        {
                            Dr.Close();
                            Cmd.CommandText = "Delete from tbl_User_Details where User_ID = @UID";
                            Cmd.Parameters.Add("UID", SqlDbType.Int).Value = tb_User_Id.Text;

                            Cmd.ExecuteNonQuery();
                            MessageBox.Show("Record Deleted Succesful", "Success");

                            Clear_Controls();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record Found", "Record Not Found");
                        tb_User_Id.Clear();
                        tb_User_Id.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Enter Correct Admin Password", "Invalid Admin Password");
                    tb_Admin_Password.Clear();
                    tb_Admin_Password.Clear();
                }
            }
            else
            {
                MessageBox.Show("Fill All Fields", "Required fields");
            }

            Class_File.Code_Class.Con_Close();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
