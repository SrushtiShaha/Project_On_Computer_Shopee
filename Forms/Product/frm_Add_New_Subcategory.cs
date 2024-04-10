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
    public partial class frm_Add_New_Subcategory : Form
    {
        public frm_Add_New_Subcategory()
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
            tb_Subcategory_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Subcategory_Details", "Select Max(Subcategory_ID) from tbl_Subcategory_Details"));

            tb_Subcategory_Name.Clear();
        }
        private void lbl_Back_Click(object sender, EventArgs e)
        {
            frm_Add_New_Product obj = new frm_Add_New_Product() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void frm_Add_New_Subcategory_Load(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Subcategory_Name.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Subcategory_Details(Subcategory_ID,Subcategory_Name) Values(@SCID,@SCNm)";

                Cmd.Parameters.Add("SCID", SqlDbType.Int).Value = tb_Subcategory_ID.Text;
                Cmd.Parameters.Add("SCNm", SqlDbType.VarChar).Value = tb_Subcategory_Name.Text;

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
