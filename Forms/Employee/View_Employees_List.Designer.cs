
namespace Ayuraj_Computer_Shopee_App.Forms.Employee
{
    partial class frm_View_Employee_List
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
            this.dgv_Employee_Details = new System.Windows.Forms.DataGridView();
            this.cmb_Employee_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Employee_Name = new System.Windows.Forms.Label();
            this.pb_Refresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Employee_Details
            // 
            this.dgv_Employee_Details.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.dgv_Employee_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Employee_Details.Location = new System.Drawing.Point(33, 73);
            this.dgv_Employee_Details.Name = "dgv_Employee_Details";
            this.dgv_Employee_Details.Size = new System.Drawing.Size(862, 366);
            this.dgv_Employee_Details.TabIndex = 2;
            // 
            // cmb_Employee_Name
            // 
            this.cmb_Employee_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Employee_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Employee_Name.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_Employee_Name.FormattingEnabled = true;
            this.cmb_Employee_Name.Location = new System.Drawing.Point(439, 27);
            this.cmb_Employee_Name.Name = "cmb_Employee_Name";
            this.cmb_Employee_Name.Size = new System.Drawing.Size(215, 26);
            this.cmb_Employee_Name.TabIndex = 1;
            this.cmb_Employee_Name.SelectionChangeCommitted += new System.EventHandler(this.cmb_Employee_Name_SelectionChangeCommitted);
            // 
            // lbl_Employee_Name
            // 
            this.lbl_Employee_Name.AutoSize = true;
            this.lbl_Employee_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employee_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Employee_Name.Location = new System.Drawing.Point(294, 30);
            this.lbl_Employee_Name.Name = "lbl_Employee_Name";
            this.lbl_Employee_Name.Size = new System.Drawing.Size(136, 18);
            this.lbl_Employee_Name.TabIndex = 63;
            this.lbl_Employee_Name.Text = "Employee Name";
            // 
            // pb_Refresh
            // 
            this.pb_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Refresh.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Refresh;
            this.pb_Refresh.Location = new System.Drawing.Point(850, 25);
            this.pb_Refresh.Name = "pb_Refresh";
            this.pb_Refresh.Size = new System.Drawing.Size(30, 30);
            this.pb_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Refresh.TabIndex = 74;
            this.pb_Refresh.TabStop = false;
            this.pb_Refresh.Click += new System.EventHandler(this.pb_Refresh_Click);
            // 
            // frm_View_Employee_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.pb_Refresh);
            this.Controls.Add(this.cmb_Employee_Name);
            this.Controls.Add(this.lbl_Employee_Name);
            this.Controls.Add(this.dgv_Employee_Details);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_View_Employee_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Employees Details";
            this.Load += new System.EventHandler(this.frm_View_Employee_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Employee_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Employee_Details;
        private System.Windows.Forms.ComboBox cmb_Employee_Name;
        private System.Windows.Forms.Label lbl_Employee_Name;
        private System.Windows.Forms.PictureBox pb_Refresh;
    }
}