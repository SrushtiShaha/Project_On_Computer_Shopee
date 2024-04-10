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
    public partial class frm_Add_New_Employee : Form
    {
        public frm_Add_New_Employee()
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
            tb_Employee_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Employee_Details", "Select Max(Employee_ID) from tbl_Employee_Details"));

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
            tb_Note.Clear();
        }
        private void frm_Add_New_Employee_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (tb_Employee_ID.Text != "" && tb_Employee_Name.Text != "" && tb_Contact_No.Text != "" && tb_Email_ID.Text != "" && tb_Aadhar_No.Text != "" && tb_PAN_No.Text != "" && tb_Address.Text != "" && cmb_Job_Role.Text != "" && cmb_Qualification.Text != "" && tb_Salary.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Employee_Details(Employee_ID,Employee_Name,Contact_No,Alt_Contact_No,Email_Id,Adhar_No,PAN_No,Address,Date_Of_Joining,Job_Role,Qualification,Salary,Note) Values(@EID,@ENm,@Contact,@AltContact,@Email,@Adhar,@PAN,@Address,@Date,@JobRole,@Qualification,@Salary,@Note)";
                                                                     //@EID,@ENm,@Contact,@AltContact,@Email,@Adhar,@PAN,@Address,@Date,@JobRole,@Qualification,@Salary,@Note
                Cmd.Parameters.Add("EID", SqlDbType.Int).Value = tb_Employee_ID.Text;
                Cmd.Parameters.Add("ENm", SqlDbType.VarChar).Value = tb_Employee_Name.Text;
                Cmd.Parameters.Add("Contact", SqlDbType.Decimal).Value = tb_Contact_No.Text;
                Cmd.Parameters.Add("AltContact", SqlDbType.Decimal).Value = tb_Alternate_Contact_No.Text;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("Adhar", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("PAN", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date_Of_Joining.Value.Date;
                Cmd.Parameters.Add("JobRole", SqlDbType.VarChar).Value = cmb_Job_Role.Text;
                Cmd.Parameters.Add("Qualification", SqlDbType.VarChar).Value = cmb_Qualification.Text;
                Cmd.Parameters.Add("Salary", SqlDbType.Money).Value = tb_Salary.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill all Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Class_File.Code_Class.Con_Close();

        }
    }
}
