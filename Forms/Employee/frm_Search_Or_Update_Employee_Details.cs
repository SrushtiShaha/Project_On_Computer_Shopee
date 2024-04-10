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

namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    public partial class frm_Search_Or_Update_Employee_Details : Form
    {
        public frm_Search_Or_Update_Employee_Details()
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
            tb_Employee_ID.Clear();
            tb_Employee_Name.Clear();
            tb_Contact_No.Clear();
            tb_Alternate_Contact_No.Clear();
            tb_Email_ID.Clear();
            tb_Aadhar_No.Clear();
            tb_PAN_No.Clear();
            tb_Address.Clear();
            dtp_Date_Of_Joining.Value = DateTime.Now;
            cmb_Job_Role.SelectedIndex = -1;
            cmb_Qualification.SelectedIndex = -1;
            tb_Salary.Clear();

            tb_Employee_ID.Enabled = true;
        }
        private void frm_Search_Or_Update_Employee_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Employee_ID != null)
            {
                Class_File.Code_Class.Con_Open();

                String Query = "Select * From tbl_Employee_Details Where Employee_ID = @EID";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Employee_Name.Text = Dr.GetString(Dr.GetOrdinal("Employee_Name"));
                    tb_Contact_No.Text = (Dr["Contact_No"].ToString());
                    tb_Alternate_Contact_No.Text = (Dr["Alt_Contact_No"].ToString());
                    tb_Email_ID.Text = (Dr["Email_Id"].ToString());
                    tb_Aadhar_No.Text = (Dr["Adhar_No"].ToString());
                    tb_PAN_No.Text = (Dr["PAN_No"].ToString());
                    tb_Address.Text = (Dr["Address"].ToString());
                    dtp_Date_Of_Joining.Text = (Dr["Date_Of_Joining"].ToString());
                    cmb_Job_Role.Text = Dr.GetString(Dr.GetOrdinal("Job_Role"));
                    cmb_Qualification.Text = Dr.GetString(Dr.GetOrdinal("Qualification"));
                    tb_Salary.Text = (Dr["Salary"].ToString());



                    tb_Employee_ID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Record");
                    tb_Employee_ID.Clear();
                }

                Class_File.Code_Class.Con_Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Class_File.Code_Class.Con;

            Cmd.CommandText = "Update tbl_Employee_Details set Email_Id =@Email,Address=@Address,Job_Role=@JobRole,Qualification=@Qualification,Salary=@Salary where Employee_ID = @EID";
            Cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
            Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
            Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
            Cmd.Parameters.Add("JobRole", SqlDbType.VarChar).Value = cmb_Job_Role.Text;
            Cmd.Parameters.Add("Qualification", SqlDbType.VarChar).Value = cmb_Qualification.Text;
            Cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;



            Cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear_Controls();
            Class_File.Code_Class.Con_Close();
        }
    }
}
