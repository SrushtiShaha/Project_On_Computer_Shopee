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
    public partial class frm_Add_New_User : Form
    {
        public frm_Add_New_User()
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
            tb_User_Id.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_User_Details", "Select Max(User_ID) from tbl_User_Details"));

            cmb_User_Role.SelectedIndex = -1;
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Confirm_Password.Clear();
        }

        private void frm_Add_New_User_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (tb_User_Id.Text != "" && cmb_User_Role.Text != "" && tb_Username.Text != "" && tb_Password.Text != "" && tb_Confirm_Password.Text != "")
            {
                if (tb_Password.Text != tb_Confirm_Password.Text)
                {
                    MessageBox.Show("Password and Confirm Password does not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tb_Confirm_Password.Clear();
                }
                else
                {
                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Class_File.Code_Class.Con;

                    Cmd.CommandText = "Insert Into tbl_User_Details(User_ID,User_Role,Username,Password) Values(@UID,@URole,@UNm,@UPass)";
                    Cmd.Parameters.Add("UID", SqlDbType.Int).Value = tb_User_Id.Text;
                    Cmd.Parameters.Add("URole", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                    Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_Username.Text;
                    Cmd.Parameters.Add("UPass", SqlDbType.NVarChar).Value = tb_Password.Text;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }

            }
            else
            {
                MessageBox.Show("Fill All Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            Class_File.Code_Class.Con_Close();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}

