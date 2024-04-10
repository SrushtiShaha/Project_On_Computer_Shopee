
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuraj_Computer_Shopee_App.Class_File
{

    class Code_Class
    {
        public static String UserName = "";
        public static String UserRole = "";
        public static SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Ayuraj_Computer_Shopee_App_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }

        public static void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }

        public static int Auto_Incr(String Q1, string Q2)
        {
            Con_Open();

            int Cnt = 0;

            SqlCommand Cmd = new SqlCommand(Q1, Con);

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            if (Cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;
                Cmd.CommandText = Q2;

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 1;
            }

            return Cnt;

            Con_Close();
        }

        public static DataTable GettableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void FillCombo(ComboBox cmb, string sql, string dismemb)
        {
            DataTable dt = GettableData(sql);

            //cmb.ValueMember = val;
            cmb.DisplayMember = dismemb;
            cmb.DataSource = dt;
            cmb.SelectedIndex = -1;
        }

        public static void BindDataGrid(DataGridView Dgv, String Query)
        {
            SqlDataAdapter da = new SqlDataAdapter(Query, Con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            Dgv.DataSource = dt;
        }

        public static void Only_Numeric(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        public static void Only_Text(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}

