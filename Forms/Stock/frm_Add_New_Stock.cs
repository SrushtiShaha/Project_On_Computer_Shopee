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

namespace Ayuraj_Computer_Shopee_App.Forms.Stock
{
    public partial class frm_Add_New_Stock : Form
    {
        public frm_Add_New_Stock()
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
            tb_Stock_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Stock_Details", "Select Max(Stock_ID) from tbl_Stock_Details"));

            cmb_Product_Name.SelectedIndex = -1;
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            tb_Remaining_Stock_Quantity.Clear();
            tb_New_Stock_Quantity.Clear();
            dtp_Import_Date.Value = DateTime.Now;
        }
        private void frm_Add_New_Stock_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Product_Name, "Select distinct Product_Name from tbl_Product_Details", "Product_Name");
            Class_File.Code_Class.FillCombo(cmb_Category_Name, "Select distinct Category_Name from tbl_Category_Details", "Category_Name");
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select distinct Subcategory_Name from tbl_Subcategory_Details", "Subcategory_Name");
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (cmb_Product_Name.Text != "" && cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && tb_Remaining_Stock_Quantity.Text != "" && tb_New_Stock_Quantity.Text != "")
            {
                String Query = "Select Stock_Quantity from tbl_Stock_Details Where Product_Name = @PNm and Category_Name = @CNm and Subcategory_Name = @SNm";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                Cmd.Parameters.Add("SNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();

                if (Dr.Read())
                {
                    
                    double Qty = Convert.ToInt32(Dr["Stock_Quantity"].ToString()) + Convert.ToInt32(tb_New_Stock_Quantity.Text);

                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Class_File.Code_Class.Con;

                    Cmd1.CommandText = "Update tbl_Stock_Details set Stock_Quantity = @Qty where Product_Name = @PNm and Category_Name = @CNm and Subcategory_Name = @SCNm";
                    Cmd1.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                    Cmd1.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                    Cmd1.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Decimal).Value = Qty;


                    Dr.Close();
                    Cmd1.ExecuteNonQuery();

                    Clear_Controls();
                    Class_File.Code_Class.Con_Close();
                }
                else
                {
                    Dr.Close();
                    SqlCommand Cmd2 = new SqlCommand();
                    Cmd2.Connection = Class_File.Code_Class.Con;

                    Cmd2.CommandText = "Insert Into tbl_Stock_Details(Stock_ID,Product_Name,Category_Name,Subcategory_Name,Stock_Quantity,Import_Date) Values(@SID,@PNm,@CNm,@SCNm,@Qty,@Date)";

                    Cmd2.Parameters.Add("SID", SqlDbType.Int).Value = tb_Stock_ID.Text;
                    Cmd2.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                    Cmd2.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                    Cmd2.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                    Cmd2.Parameters.Add("Qty", SqlDbType.Int).Value = tb_New_Stock_Quantity.Text;
                    Cmd2.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Import_Date.Text;

                    Cmd2.ExecuteNonQuery();

                    MessageBox.Show("Record Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
            }
            else
            {
                MessageBox.Show("First Fill all Fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Class_File.Code_Class.Con_Close();
        }

        private void cmb_Subcategory_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            SqlCommand cmd = new SqlCommand();

            String Query = "Select Stock_Quantity from tbl_Stock_Details where Product_Name='" + cmb_Product_Name.Text + "'and Category_Name='" + cmb_Category_Name.Text + "'and Subcategory_Name='" + cmb_Subcategory_Name.Text + "'";
            cmd = new SqlCommand(Query, Class_File.Code_Class.Con);
            SqlDataReader Dr = cmd.ExecuteReader();

            if (Dr.Read())
            {
                Dr.Close();
                tb_Remaining_Stock_Quantity.Text = Convert.ToString(cmd.ExecuteScalar());
            }
            else
            {
                tb_Remaining_Stock_Quantity.Text = "0";
            }
            Class_File.Code_Class.Con_Close();
        }
    }
}
