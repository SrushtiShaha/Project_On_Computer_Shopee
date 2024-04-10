using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_Customer_Click(object sender, EventArgs e)
        {
            Forms.Customer.frm_Add_New_Customer obj = new Customer.frm_Add_New_Customer() { TopLevel=false,TopMost= true};
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            Forms.Customer.uc_Customer obj1 = new Customer.uc_Customer();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();

        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            Forms.Employee.frm_Add_New_Employee obj = new Employee.frm_Add_New_Employee() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            Employee.uc_Employee obj1 = new Employee.uc_Employee();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Forms.Product.frm_Add_New_Product obj = new Product.frm_Add_New_Product() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            Product.uc_Product obj1 = new Product.uc_Product();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();
        }

        private void btn_Stock_Click(object sender, EventArgs e)
        {
            Forms.Stock.frm_Add_New_Stock obj = new Stock.frm_Add_New_Stock() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            Stock.uc_Stock obj1 = new Stock.uc_Stock();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();
        }

        private void btn_Supplier_Click(object sender, EventArgs e)
        {
            Forms.Supplier.frm_Add_New_Supplier obj = new Supplier.frm_Add_New_Supplier() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            Supplier.uc_Supplier obj1 = new Supplier.uc_Supplier();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Forms.User.frm_Add_New_User obj = new User.frm_Add_New_User() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            User.uc_User obj1 = new User.uc_User();

            pnl_Top.Controls.Clear();
            pnl_Top.Controls.Add(obj1);
            obj1.Show();
        }

        private void pb_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login obj = new frm_Login();
            obj.Show();
            this.Hide();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Welcome.Text = "Welcome " + Class_File.Code_Class.UserName;
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            frm_Report_Options obj = new frm_Report_Options() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            pnl_FormLoader.Controls.Clear();
            pnl_FormLoader.Controls.Add(obj);
            obj.Show();

            lbl_Welcome_to_Shoppe.Text = "Reports";

            //User.uc_User obj1 = new User.uc_User();

            ///pnl_Top.Controls.Clear();
            //pnl_Top.Controls.Add(obj1);
            ///obj1.Show();
        }
    }
}
