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

namespace Ayuraj_Computer_Shopee_App.Forms
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        void Clear_Controls()
        {
            cmb_User_Role.SelectedIndex = -1;
            tb_Username.Clear();
            tb_Password.Clear();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_User_Role, "Select distinct User_Role from tbl_User_Details", "User_Role");
        }
        private void cmb_User_Role_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tb_Username.Enabled = true;
        }

        private void tb_Username_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            int Cnt = 0;

            Class_File.Code_Class.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Class_File.Code_Class.Con;

            Cmd.CommandText = "Select Count (*) From tbl_User_Details where Username = @Uname And Password = @Pwd";
            Cmd.Parameters.Add("Uname", SqlDbType.NVarChar).Value = tb_Username.Text;
            Cmd.Parameters.Add("Pwd", SqlDbType.NVarChar).Value = tb_Password.Text;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                MessageBox.Show("Login Succefully", "Welcome", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                Class_File.Code_Class.UserName = tb_Username.Text;

                frm_Main Obj = new frm_Main();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invaild Username Or Password", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            Clear_Controls();

            Class_File.Code_Class.Con_Close();
        }

        private void btn_Submit_Click_1(object sender, EventArgs e)
        {
            if (cmb_User_Role.Text != null && tb_Username.Text != null && tb_Password.Text != null)
            {
                Class_File.Code_Class.Con_Open();

                String Query = "Select * From tbl_User_Details Where User_Role = @URole and Username=@UNm and Password = @Pass";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("URole", SqlDbType.VarChar).Value = cmb_User_Role.Text;
                Cmd.Parameters.Add("UNm", SqlDbType.NVarChar).Value = tb_Username.Text;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = tb_Password.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    Class_File.Code_Class.UserName = tb_Username.Text;
                    Class_File.Code_Class.UserRole = cmb_User_Role.Text;
                    frm_Main obj = new frm_Main();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Record");
                    Clear_Controls();
                }

                Class_File.Code_Class.Con_Close();
            }
        }

    }
}
