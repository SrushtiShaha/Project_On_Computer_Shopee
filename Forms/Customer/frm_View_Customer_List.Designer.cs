
//namespace Ayuraj_Computer_Shopee_App.Forms.Customer
//{
//    partial class frm_View_Customer_List
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.dgv_Customer_Personal_Details = new System.Windows.Forms.DataGridView();
//            this.lbl_Search_Customer_Bills = new System.Windows.Forms.Label();
//            this.cmb_Year = new System.Windows.Forms.ComboBox();
//            this.cmb_Month = new System.Windows.Forms.ComboBox();
//            this.lbl_Month = new System.Windows.Forms.Label();
//            this.lbl_Year = new System.Windows.Forms.Label();
//            this.dgv_Customer_Purchase_Details = new System.Windows.Forms.DataGridView();
//            this.pb_Refresh = new System.Windows.Forms.PictureBox();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Personal_Details)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Purchase_Details)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // dgv_Customer_Personal_Details
//            // 
//            this.dgv_Customer_Personal_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
//            this.dgv_Customer_Personal_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgv_Customer_Personal_Details.Location = new System.Drawing.Point(18, 72);
//            this.dgv_Customer_Personal_Details.Name = "dgv_Customer_Personal_Details";
//            this.dgv_Customer_Personal_Details.Size = new System.Drawing.Size(436, 377);
//            this.dgv_Customer_Personal_Details.TabIndex = 3;
//            // 
//            // lbl_Search_Customer_Bills
//            // 
//            this.lbl_Search_Customer_Bills.AutoSize = true;
//            this.lbl_Search_Customer_Bills.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbl_Search_Customer_Bills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
//            this.lbl_Search_Customer_Bills.Location = new System.Drawing.Point(142, 32);
//            this.lbl_Search_Customer_Bills.Name = "lbl_Search_Customer_Bills";
//            this.lbl_Search_Customer_Bills.Size = new System.Drawing.Size(185, 18);
//            this.lbl_Search_Customer_Bills.TabIndex = 47;
//            this.lbl_Search_Customer_Bills.Text = "Search Customer Bills";
//            // 
//            // cmb_Year
//            // 
//            this.cmb_Year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cmb_Year.ForeColor = System.Drawing.Color.DimGray;
//            this.cmb_Year.FormattingEnabled = true;
//            this.cmb_Year.Location = new System.Drawing.Point(577, 29);
//            this.cmb_Year.Name = "cmb_Year";
//            this.cmb_Year.Size = new System.Drawing.Size(196, 26);
//            this.cmb_Year.TabIndex = 2;
//            // 
//            // cmb_Month
//            // 
//            this.cmb_Month.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.cmb_Month.ForeColor = System.Drawing.Color.DimGray;
//            this.cmb_Month.FormattingEnabled = true;
//            this.cmb_Month.Location = new System.Drawing.Point(339, 28);
//            this.cmb_Month.Name = "cmb_Month";
//            this.cmb_Month.Size = new System.Drawing.Size(196, 26);
//            this.cmb_Month.TabIndex = 1;
//            // 
//            // lbl_Month
//            // 
//            this.lbl_Month.AutoSize = true;
//            this.lbl_Month.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbl_Month.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
//            this.lbl_Month.Location = new System.Drawing.Point(493, 13);
//            this.lbl_Month.Name = "lbl_Month";
//            this.lbl_Month.Size = new System.Drawing.Size(39, 12);
//            this.lbl_Month.TabIndex = 54;
//            this.lbl_Month.Text = "Month";
//            // 
//            // lbl_Year
//            // 
//            this.lbl_Year.AutoSize = true;
//            this.lbl_Year.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.lbl_Year.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
//            this.lbl_Year.Location = new System.Drawing.Point(738, 14);
//            this.lbl_Year.Name = "lbl_Year";
//            this.lbl_Year.Size = new System.Drawing.Size(31, 12);
//            this.lbl_Year.TabIndex = 55;
//            this.lbl_Year.Text = "Year";
//            // 
//            // dgv_Customer_Purchase_Details
//            // 
//            this.dgv_Customer_Purchase_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
//            this.dgv_Customer_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dgv_Customer_Purchase_Details.Location = new System.Drawing.Point(477, 72);
//            this.dgv_Customer_Purchase_Details.Name = "dgv_Customer_Purchase_Details";
//            this.dgv_Customer_Purchase_Details.Size = new System.Drawing.Size(436, 377);
//            this.dgv_Customer_Purchase_Details.TabIndex = 4;
//            // 
//            // pb_Refresh
//            // 
//            this.pb_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
//            this.pb_Refresh.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Refresh;
//            this.pb_Refresh.Location = new System.Drawing.Point(869, 25);
//            this.pb_Refresh.Name = "pb_Refresh";
//            this.pb_Refresh.Size = new System.Drawing.Size(30, 30);
//            this.pb_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
//            this.pb_Refresh.TabIndex = 74;
//            this.pb_Refresh.TabStop = false;
//            this.pb_Refresh.Click += new System.EventHandler(this.pb_Refresh_Click);
//            // 
//            // frm_View_Customer_List
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
//            this.ClientSize = new System.Drawing.Size(934, 461);
//            this.Controls.Add(this.pb_Refresh);
//            this.Controls.Add(this.dgv_Customer_Purchase_Details);
//            this.Controls.Add(this.lbl_Year);
//            this.Controls.Add(this.lbl_Month);
//            this.Controls.Add(this.cmb_Month);
//            this.Controls.Add(this.cmb_Year);
//            this.Controls.Add(this.lbl_Search_Customer_Bills);
//            this.Controls.Add(this.dgv_Customer_Personal_Details);
//            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.MaximizeBox = false;
//            this.MinimizeBox = false;
//            this.Name = "frm_View_Customer_List";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "View All Customer Details";
//            this.Load += new System.EventHandler(this.frm_View_Customer_List_Load);
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Personal_Details)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Purchase_Details)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion
//        private System.Windows.Forms.DataGridView dgv_Customer_Personal_Details;
//        private System.Windows.Forms.Label lbl_Search_Customer_Bills;
//        private System.Windows.Forms.ComboBox cmb_Year;
//        private System.Windows.Forms.ComboBox cmb_Month;
//        private System.Windows.Forms.Label lbl_Month;
//        private System.Windows.Forms.Label lbl_Year;
//        private System.Windows.Forms.DataGridView dgv_Customer_Purchase_Details;
//        private System.Windows.Forms.PictureBox pb_Refresh;
//    }
//}
namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    partial class frm_View_Customer_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_Customer_Personal_Details = new System.Windows.Forms.DataGridView();
            this.dgv_Customer_Purchase_Details = new System.Windows.Forms.DataGridView();
            this.lbl_Customer_Personal_Details = new System.Windows.Forms.Label();
            this.lbl_Customer_Purchase_Details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Personal_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Purchase_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Customer_Personal_Details
            // 
            this.dgv_Customer_Personal_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgv_Customer_Personal_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Personal_Details.Location = new System.Drawing.Point(19, 26);
            this.dgv_Customer_Personal_Details.Name = "dgv_Customer_Personal_Details";
            this.dgv_Customer_Personal_Details.Size = new System.Drawing.Size(895, 235);
            this.dgv_Customer_Personal_Details.TabIndex = 3;
            this.dgv_Customer_Personal_Details.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgv_Customer_Personal_Details_MouseClick);
            // 
            // dgv_Customer_Purchase_Details
            // 
            this.dgv_Customer_Purchase_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgv_Customer_Purchase_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Customer_Purchase_Details.Location = new System.Drawing.Point(18, 285);
            this.dgv_Customer_Purchase_Details.Name = "dgv_Customer_Purchase_Details";
            this.dgv_Customer_Purchase_Details.Size = new System.Drawing.Size(895, 164);
            this.dgv_Customer_Purchase_Details.TabIndex = 4;
            // 
            // lbl_Customer_Personal_Details
            // 
            this.lbl_Customer_Personal_Details.AutoSize = true;
            this.lbl_Customer_Personal_Details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Personal_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Customer_Personal_Details.Location = new System.Drawing.Point(21, 5);
            this.lbl_Customer_Personal_Details.Name = "lbl_Customer_Personal_Details";
            this.lbl_Customer_Personal_Details.Size = new System.Drawing.Size(220, 18);
            this.lbl_Customer_Personal_Details.TabIndex = 75;
            this.lbl_Customer_Personal_Details.Text = "Customer Personal Details";
            // 
            // lbl_Customer_Purchase_Details
            // 
            this.lbl_Customer_Purchase_Details.AutoSize = true;
            this.lbl_Customer_Purchase_Details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Customer_Purchase_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Customer_Purchase_Details.Location = new System.Drawing.Point(21, 264);
            this.lbl_Customer_Purchase_Details.Name = "lbl_Customer_Purchase_Details";
            this.lbl_Customer_Purchase_Details.Size = new System.Drawing.Size(226, 18);
            this.lbl_Customer_Purchase_Details.TabIndex = 76;
            this.lbl_Customer_Purchase_Details.Text = "Customer Purchase Details";
            // 
            // frm_View_Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.lbl_Customer_Purchase_Details);
            this.Controls.Add(this.lbl_Customer_Personal_Details);
            this.Controls.Add(this.dgv_Customer_Purchase_Details);
            this.Controls.Add(this.dgv_Customer_Personal_Details);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Customer_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Customer Details";
            this.Load += new System.EventHandler(this.frm_View_Customer_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Personal_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Customer_Purchase_Details)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Customer_Personal_Details;
        private System.Windows.Forms.DataGridView dgv_Customer_Purchase_Details;
        private System.Windows.Forms.Label lbl_Customer_Personal_Details;
        private System.Windows.Forms.Label lbl_Customer_Purchase_Details;
    }
}