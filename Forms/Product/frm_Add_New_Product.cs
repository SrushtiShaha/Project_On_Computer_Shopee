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
    public partial class frm_Add_New_Product : Form
    {
        public frm_Add_New_Product()
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
            tb_Product_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Product_Details", "Select Max(Product_ID) from tbl_Product_Details"));

            tb_Product_Name.Clear();
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            dtp_Import_Date.Value = DateTime.Now;
            tb_Purchase_Price.Clear();
            tb_Note.Clear();
        }
        private void lbl_Add_category_Click(object sender, EventArgs e)
        {
            frm_Add_New_Category obj = new frm_Add_New_Category() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Add_Subcategory_Click(object sender, EventArgs e)
        {
            frm_Add_New_Subcategory obj = new frm_Add_New_Subcategory() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void frm_Add_New_Product_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select * from tbl_Category_Details", "Subcategory_Name");
            Class_File.Code_Class.FillCombo(cmb_Category_Name, "Select * from tbl_Category_Details", "Category_Name");
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (tb_Product_ID.Text != "" && tb_Product_Name.Text != "" && cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && tb_Purchase_Price.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Product_Details(Product_ID,Product_Name,Category_Name,Subcategory_Name,Import_Date,Purchase_Price,Note) " +
                    "Values(@PID,@PNm,@CNm,@SCNm,@Date,@PPrice,@Note)";

                Cmd.Parameters.Add("PID", SqlDbType.Int).Value = tb_Product_ID.Text;
                Cmd.Parameters.Add("PNm", SqlDbType.VarChar).Value = tb_Product_Name.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                Cmd.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Import_Date.Text;
                Cmd.Parameters.Add("PPrice", SqlDbType.Money).Value = tb_Purchase_Price.Text;
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
