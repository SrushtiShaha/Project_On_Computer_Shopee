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

namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    public partial class frm_Add_New_Customer : Form
    {
        public frm_Add_New_Customer()
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
            tb_Customer_ID.Focus();

            tb_Customer_ID.Text = Convert.ToString(Class_File.Code_Class.Auto_Incr("Select Count(*) from tbl_Customer_Personal_Details", "Select Max(Customer_ID) from tbl_Customer_Personal_Details"));

            tb_Customer_Name.Clear();
            tb_Address.Clear();
            tb_Contact_No.Clear();
            dtp_Bill_Date.Value = DateTime.Now;
            tb_Note.Clear();

            cmb_Product_Name.SelectedIndex = -1;
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            tb_Product_Price.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();

            tb_Total_Price.Clear();
            tb_Discount.Clear();
            tb_GST.Clear();
            tb_Total_Bill.Clear();
        }
        private void frm_Add_New_Customer_Load(object sender, EventArgs e)
        {
            Class_File.Code_Class.FillCombo(cmb_Product_Name, "Select distinct Product_Name from tbl_Product_Details", "Product_Name");
            Class_File.Code_Class.FillCombo(cmb_Category_Name, "Select distinct Category_Name from tbl_Category_Details", "Category_Name");
            Class_File.Code_Class.FillCombo(cmb_Subcategory_Name, "Select distinct Subcategory_Name from tbl_Subcategory_Details", "Subcategory_Name");

            Clear_Controls();
            tb_Total_Price.Text = "0";
        }

        private void pb_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void tb_Note_TextChanged(object sender, EventArgs e)
        {
            cmb_Product_Name.Enabled = true;
            cmb_Category_Name.Enabled = true;
            cmb_Subcategory_Name.Enabled = true;
            tb_Quantity.Enabled = true;
            tb_Price.Enabled = true;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (cmb_Product_Name.Text != "" && cmb_Category_Name.Text != "" && cmb_Subcategory_Name.Text != "" && tb_Product_Price.Text != "" && tb_Quantity.Text != "" && tb_Price.Text != "")
            {
                String Query = "Select Quantity,Price From tbl_Customer_Purchase_Details Where Product_Name = @PNm and Category_Name = @CNm and Subcategory_Name = @SNm and Customer_ID = @CID";

                SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

                Cmd.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                Cmd.Parameters.Add("SNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                Cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;

                SqlDataReader Dr = Cmd.ExecuteReader();
                
                if (Dr.Read())
                {
                    Class_File.Code_Class.Con_Open();
                    double Qty = Convert.ToInt32(Dr["Quantity"].ToString()) + Convert.ToInt32(tb_Quantity.Text);
                    double P_Price = Convert.ToInt32(Dr["Price"].ToString()) + Convert.ToInt32(tb_Price.Text);

                   // double p_Price = Convert.ToString(Convert.ToDouble(tb.Text) + Convert.ToDouble(tb_Price.Text));


                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Class_File.Code_Class.Con;

                    Cmd1.CommandText = "Update tbl_Customer_Purchase_Details set Quantity = @Qty, Price = @Price where Product_Name = @PNm and Category_Name = @CNm and Subcategory_Name = @SCNm and Customer_ID = @CID";
                    Cmd1.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd1.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                    Cmd1.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                    Cmd1.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Decimal).Value = Qty;
                    Cmd1.Parameters.Add("Price", SqlDbType.Decimal).Value = P_Price;


                    Dr.Close();
                    Cmd1.ExecuteNonQuery();
                    tb_Total_Price.Text = Convert.ToString(Convert.ToDouble(tb_Total_Price.Text) + Convert.ToDouble(tb_Price.Text));

                    Class_File.Code_Class.BindDataGrid(dgv_Customer_Purchase_Details, "Select Product_Name,Category_Name,Subcategory_Name,Product_Price, Quantity, Price from tbl_Customer_Purchase_Details where Customer_ID = '" + tb_Customer_ID.Text + "'");

                    Class_File.Code_Class.Con_Close();
                }
                else
                {
                    Dr.Close();
                    Class_File.Code_Class.Con_Open();
                    SqlCommand Cmd1 = new SqlCommand();
                    Cmd1.Connection = Class_File.Code_Class.Con;

                    Cmd1.CommandText = "Insert Into tbl_Customer_Purchase_Details (Customer_ID, Product_Name,Category_Name,Subcategory_Name,Product_Price, Quantity, Price) " +
                        "Values(@CID,@PNm,@CNm,@SCNm,@PPrice,@Qty,@Price)";
                    Cmd1.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                    Cmd1.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
                    Cmd1.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
                    Cmd1.Parameters.Add("SCNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;
                    Cmd1.Parameters.Add("PPrice", SqlDbType.Decimal).Value = tb_Product_Price.Text;
                    Cmd1.Parameters.Add("Qty", SqlDbType.Decimal).Value = tb_Quantity.Text;
                    Cmd1.Parameters.Add("Price", SqlDbType.Decimal).Value = tb_Price.Text;

                    ///Total_Bill = Convert.ToDouble(Total_Bill) + Convert.ToDouble(tb_Total_Price.Text);
                    //tb_Total_Bill.Text = Convert.ToString(Total_Bill);

                    Cmd1.ExecuteNonQuery();
                    tb_Total_Price.Text = Convert.ToString(Convert.ToDouble(tb_Total_Price.Text) + Convert.ToDouble(tb_Price.Text));

                    Class_File.Code_Class.BindDataGrid(dgv_Customer_Purchase_Details, "Select Product_Name,Category_Name,Subcategory_Name,Product_Price, Quantity, Price from tbl_Customer_Purchase_Details where Customer_ID = '" + tb_Customer_ID.Text + "'");

                    MessageBox.Show("Purchase Details Inserted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Class_File.Code_Class.Con_Close();
                }
            }
            else
            {
                MessageBox.Show("First Fill Purchase Details", "Incomplete Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cmb_Product_Name.SelectedIndex = -1;
            cmb_Category_Name.SelectedIndex = -1;
            cmb_Subcategory_Name.SelectedIndex = -1;
            tb_Product_Price.Clear();
            tb_Quantity.Clear();
            tb_Price.Clear();
            Class_File.Code_Class.Con_Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();
            if (dgv_Customer_Purchase_Details.Rows.Count > 0)
            {
                int ID = Convert.ToInt32(tb_Customer_ID.Text);
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Class_File.Code_Class.Con;

                Cmd.CommandText = "Insert Into tbl_Customer_Personal_Details (Customer_ID, Customer_Name,Address,Contact_No, Bill_Date, Note,Total_Price,Discount,GST,Total_Bill) " +
                    "Values(@CID,@CNm,@Address,@ContactNo,@BillDate,@Note,@TotalPrice,@Discount,@GST,@TotalBill)";
                Cmd.Parameters.Add("CID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = tb_Customer_Name.Text;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = tb_Address.Text;
                Cmd.Parameters.Add("ContactNo", SqlDbType.Decimal).Value = tb_Contact_No.Text;
                Cmd.Parameters.Add("BillDate", SqlDbType.Date).Value = dtp_Bill_Date.Text;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = tb_Note.Text;
                Cmd.Parameters.Add("TotalPrice", SqlDbType.Money).Value = tb_Total_Price.Text;
                Cmd.Parameters.Add("Discount", SqlDbType.Money).Value = tb_Discount.Text;
                Cmd.Parameters.Add("GST", SqlDbType.Decimal).Value = tb_GST.Text;
                Cmd.Parameters.Add("TotalBill", SqlDbType.Money).Value = tb_Total_Bill.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Record Inserted Successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Cmd.Dispose();

                Cmd.CommandText = "Select * from tbl_Customer_Purchase_Details cp inner join tbl_Customer_Personal_Details pd on cp.Customer_ID=pd.Customer_ID Where cp.Customer_ID= '"+ID+"' ";
                Cmd.Connection = Class_File.Code_Class.Con;
                DataTable Dt = new DataTable();
                SqlDataReader Dr = Cmd.ExecuteReader();

                Dt.Load(Dr);

                if(Dt.Rows.Count > 0)
                {
                    Dr.Close();

                    frm_Report_Viewer Obj = new frm_Report_Viewer();
                    String AppPath = Application.StartupPath;
                    string ReportPath = @"CR_Customer_Report.rpt";
                    String FullPath = System.IO.Path.Combine(AppPath, ReportPath);

                    Obj.ReportName = FullPath;
                    Obj.ReportData = Dt;
                    Obj.Show();
                }
            }
            else
            {
                MessageBox.Show("First Fill All The Fields", "Incomplete Info",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear_Controls();
            Class_File.Code_Class.Con_Close();

            dgv_Customer_Purchase_Details.DataSource = null;
        }

        private void cmb_Subcategory_Name_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Class_File.Code_Class.Con_Open();

            String Query = "Select Purchase_Price From tbl_Product_Details Where Product_Name = @PNm and Category_Name=@CNm and Subcategory_Name=@SNm";

            SqlCommand Cmd = new SqlCommand(Query, Class_File.Code_Class.Con);

            Cmd.Parameters.Add("PNm", SqlDbType.VarChar).Value = cmb_Product_Name.Text;
            Cmd.Parameters.Add("CNm", SqlDbType.VarChar).Value = cmb_Category_Name.Text;
            Cmd.Parameters.Add("SNm", SqlDbType.VarChar).Value = cmb_Subcategory_Name.Text;


            SqlDataReader Dr = Cmd.ExecuteReader();

            if (Dr.Read())
            {
                tb_Product_Price.Text = (Dr["Purchase_Price"].ToString());
            }
            else
            {
                MessageBox.Show("No Record Found", "Invalid Record");
            }

            Class_File.Code_Class.Con_Close();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if(tb_Quantity.Text != "")
            {
                double Qty = Convert.ToDouble(tb_Product_Price.Text) * Convert.ToDouble(tb_Quantity.Text);
                tb_Price.Text = Convert.ToString(Qty);

            }
        }
        private void tb_Customer_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Address.Enabled = true;
        }

        private void tb_Address_TextChanged(object sender, EventArgs e)
        {
            tb_Contact_No.Enabled = true;
        }

        private void tb_Contact_No_TextChanged(object sender, EventArgs e)
        {
            tb_Note.Enabled = true;
        }

        private void tb_GST_TextChanged(object sender, EventArgs e)
        {
            if(tb_GST.Text != "")
            {
                double Bill = Convert.ToDouble(tb_Total_Price.Text) - Convert.ToDouble(tb_Discount.Text) / 100 + Convert.ToDouble(tb_GST.Text) / 100;
                tb_Total_Bill.Text = Convert.ToString(Bill);
            } 
        }
    }
}
