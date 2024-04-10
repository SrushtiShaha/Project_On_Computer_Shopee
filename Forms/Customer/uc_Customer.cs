using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    public partial class uc_Customer : UserControl
    {
        public uc_Customer()
        {
            InitializeComponent();
        }

        private void lbl_View_Customer_List_Click(object sender, EventArgs e)
        {
            frm_View_Customer_List obj = new frm_View_Customer_List() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }

        private void lbl_Add_New_Customer_Click(object sender, EventArgs e)
        {
            frm_Add_New_Customer obj = new frm_Add_New_Customer() { TopLevel = false, TopMost = true };
            obj.FormBorderStyle = FormBorderStyle.None;

            Forms.frm_Main.pnl_FormLoader.Controls.Clear();
            Forms.frm_Main.pnl_FormLoader.Controls.Add(obj);
            obj.Show();
        }
    }
}
