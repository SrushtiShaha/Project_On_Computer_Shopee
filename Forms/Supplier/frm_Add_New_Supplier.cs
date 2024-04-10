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
//    public partial class frm_Add_New_Supplier : Form
//    {
//        public frm_Add_New_Supplier()
//        {
//            InitializeComponent();
//        }
//        public void Clear_Controls()
//        {
//            tb_Supplier_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Supplier_Details", "Select Max(Supplier_ID) from tbl_Supplier_Details"));

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
//        private void frm_Add_New_Supplier_Load(object sender, EventArgs e)
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

namespace Ayuraj_Computer_Shopee_App.Forms.Supplier
{
    public partial class frm_Add_New_Supplier : Form
    {
        public frm_Add_New_Supplier()
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
            tb_Supplier_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Supplier_Details", "Select Max(Supplier_ID) from tbl_Supplier_Details"));

            tb_Supplier_Name.Clear();
            tb_Contact_No.Clear();
            tb_Alternate_Contact_No.Clear();
            tb__Office_Address.Clear();
            tb_Email_ID.Clear();
            tb_PAN_No.Clear();
            tb_Aadhar_No.Clear();
            dtp_Tie_Up_Date.Value = DateTime.Now;
            tb_Note.Clear();
        }
        private void frm_Add_New_Supplier_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Supplier_Name.Text != "" && tb_Contact_No.Text != "" && tb_Alternate_Contact_No.Text != "" && tb__Office_Address.Text != "" && tb_Email_ID.Text != "" && tb_PAN_No.Text != "" && tb_Aadhar_No.Text != "" && dtp_Tie_Up_Date.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Supplier_Details(Supplier_ID,Supplier_Name,Contact_No,Alt_Contact_No,Office_Address,Email_ID,PAN_No,Adhar_No,Tie_Up_Date,Note) " +
                    "Values(@SID,@SNm,@Contact,@Alt_Contact,@Adress,@Email,@PAN,@Aadhar,@Date,@Note)";
                Cmd.Parameters.Add("SID", SqlDbType.Int).Value = tb_Supplier_ID.Text;
                Cmd.Parameters.Add("SNm", SqlDbType.VarChar).Value = tb_Supplier_Name.Text;
                Cmd.Parameters.Add("Contact", SqlDbType.Decimal).Value = tb_Contact_No.Text;
                Cmd.Parameters.Add("Alt_Contact", SqlDbType.Decimal).Value = tb_Alternate_Contact_No.Text;
                Cmd.Parameters.Add("Adress", SqlDbType.VarChar).Value = tb__Office_Address.Text;
                Cmd.Parameters.Add("Email", SqlDbType.VarChar).Value = tb_Email_ID.Text;
                Cmd.Parameters.Add("PAN", SqlDbType.NVarChar).Value = tb_PAN_No.Text;
                Cmd.Parameters.Add("Aadhar", SqlDbType.Decimal).Value = tb_Aadhar_No.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Tie_Up_Date.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();

            }
            else
            {
                MessageBox.Show("First Fill all Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}

