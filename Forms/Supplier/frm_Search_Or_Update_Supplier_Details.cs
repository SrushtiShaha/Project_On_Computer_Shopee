//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
//{
//    public partial class frm_Search_Or_Update_Supplier_Details : Form
//    {
//        public frm_Search_Or_Update_Supplier_Details()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            tb_Supplier_ID.Clear();
//            tb_Supplier_Name.Clear();
//            tb_Contact_No.Clear();
//            tb_Alternate_Contact_No.Clear();
//            tb__Office_Address.Clear();
//            tb_Email_ID.Clear();
//            tb_PAN_No.Clear();
//            tb_Aadhar_No.Clear();
//            dtp_Tie_Up_Date.Value = DateTime.Now;
//            tb_Note.Clear();
//        }
//        private void pb_Refresh_Click(object sender, EventArgs e)
//        {
//            Clear_Controls();
//        }

//        private void frm_Search_Or_Update_Supplier_Details_Load(object sender, EventArgs e)
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

namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
{
    public partial class frm_Search_Or_Update_Supplier_Details : Form
    {
        public frm_Search_Or_Update_Supplier_Details()
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
            tb_Supplier_ID.Clear();
            tb_Supplier_Name.Clear();
            tb_Contact_No.Clear();
            tb_Alternate_Contact_No.Clear();
            tb__Office_Address.Clear();
            tb_Email_ID.Clear();
            tb_PAN_No.Clear();
            tb_Aadhar_No.Clear();
            dtp_Tie_Up_Date.Value = DateTime.Now;
            tb_Note.Clear();
            tb_Supplier_ID.Enabled = true;
        }
        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void frm_Search_Or_Update_Supplier_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Supplier_ID != null)
            {
                Class_File.Code_Class.Con_Open();

                String Query = "Select * From tbl_Supplier_Details Where Supplier_ID = @SID";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Supplier_ID.Text;
                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Supplier_Name.Text = Dr.GetString(Dr.GetOrdinal("Supplier_Name"));
                    tb_Contact_No.Text = (Dr["Contact_No"].ToString());
                    tb_Alternate_Contact_No.Text = (Dr["Alt_Contact_No"].ToString());
                    tb__Office_Address.Text = Dr.GetString(Dr.GetOrdinal("Office_Address"));
                    tb_Email_ID.Text = Dr.GetString(Dr.GetOrdinal("Email_ID"));
                    tb_PAN_No.Text = Dr.GetString(Dr.GetOrdinal("PAN_No"));
                    tb_Aadhar_No.Text = (Dr["Adhar_No"].ToString());
                    dtp_Tie_Up_Date.Text = (Dr["Tie_Up_Date"].ToString());
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Record");
                    tb_Supplier_ID.Clear();
                }
                tb_Supplier_ID.Enabled = false;
                Class_File.Code_Class.Con_Close();
            }

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (tb_Alternate_Contact_No.Text != "" && tb__Office_Address.Text != "" && tb_Email_ID.Text != "" && tb_Note.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Update tbl_Supplier_Details set Alt_Contact_No=@Alt_Contact,Office_Address=@Adress,Email_ID=@Email,Note=@Note";
                Cmd.Parameters.Add("Alt_Contact", SqlDbType.Decimal).Value = tb_Alternate_Contact_No.Text;
                Cmd.Parameters.Add("Adress", SqlDbType.VarChar).Value = tb__Office_Address.Text;
                Cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
