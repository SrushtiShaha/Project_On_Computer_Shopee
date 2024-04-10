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

namespace Ayuraj_Computer_Shopee_App.Forms.Product
{
    public partial class frm_Search_Or_Update_Product_Details : Form
    {
        public frm_Search_Or_Update_Product_Details()
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
            tb_Product_ID.Clear();
            tb_Product_Name.Clear();
            tb_Category_Name.Clear();
            tb_Subcategory_NAme.Clear();
            dtp_Import_Date.Value = DateTime.Now;
            tb_Purchase_Price.Clear();
            tb_Note.Clear();

            tb_Product_ID.Enabled = true;
        }
        private void frm_Search_Or_Update_Product_Details_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (tb_Product_ID != null)
            {
                Class_File.Code_Class.Con_Open();

                String Query = "Select * From tbl_Product_Details Where Product_ID = @PID";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    tb_Product_Name.Text = Dr.GetString(Dr.GetOrdinal("Product_Name"));
                    tb_Category_Name.Text = Dr.GetString(Dr.GetOrdinal("Category_Name"));
                    tb_Subcategory_NAme.Text = Dr.GetString(Dr.GetOrdinal("Subcategory_Name"));
                    dtp_Import_Date.Text = (Dr["Import_Date"].ToString());
                    tb_Purchase_Price.Text = (Dr["Purchase_Price"].ToString());

                    tb_Product_ID.Enabled = false;
                    tb_Note.Text = Dr.GetString(Dr.GetOrdinal("Note"));
                }
                else
                {
                    MessageBox.Show("No Record Found", "Invalid Record");
                    tb_Product_ID.Clear();
                }
                
                Class_File.Code_Class.Con_Close();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Class_File.Code_Class.Con;

            Cmd.CommandText = "Update tbl_Product_Details set Note =@Note where Product_ID = @PID";
            Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
            Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;


            Cmd.ExecuteNonQuery();

            MessageBox.Show("Record Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Clear_Controls();
            Class_File.Code_Class.Con_Close();
        }
    }
}
