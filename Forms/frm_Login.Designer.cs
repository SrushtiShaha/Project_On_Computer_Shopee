
namespace Ayuraj_Computer_Shopee_App.Forms
{
    partial class frm_Login
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
            this.pnl_Login = new System.Windows.Forms.Panel();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.cmb_User_Role = new System.Windows.Forms.ComboBox();
            this.lbl_User_Role = new System.Windows.Forms.Label();
            this.lbl_Supplier_Name = new System.Windows.Forms.Label();
            this.lbl_Contact_No = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Login
            // 
            this.pnl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.pnl_Login.Controls.Add(this.tb_Username);
            this.pnl_Login.Controls.Add(this.btn_Submit);
            this.pnl_Login.Controls.Add(this.tb_Password);
            this.pnl_Login.Controls.Add(this.lbl_Login);
            this.pnl_Login.Controls.Add(this.cmb_User_Role);
            this.pnl_Login.Controls.Add(this.lbl_User_Role);
            this.pnl_Login.Controls.Add(this.lbl_Supplier_Name);
            this.pnl_Login.Controls.Add(this.lbl_Contact_No);
            this.pnl_Login.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Login.Location = new System.Drawing.Point(390, 0);
            this.pnl_Login.Name = "pnl_Login";
            this.pnl_Login.Size = new System.Drawing.Size(444, 461);
            this.pnl_Login.TabIndex = 37;
            // 
            // tb_Username
            // 
            this.tb_Username.Enabled = false;
            this.tb_Username.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Username.Location = new System.Drawing.Point(218, 258);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(207, 26);
            this.tb_Username.TabIndex = 2;
            this.tb_Username.TextChanged += new System.EventHandler(this.tb_Username_TextChanged);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.White;
            this.btn_Submit.Location = new System.Drawing.Point(163, 388);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(142, 41);
            this.btn_Submit.TabIndex = 4;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click_1);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.ForeColor = System.Drawing.Color.DimGray;
            this.tb_Password.Location = new System.Drawing.Point(218, 326);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(207, 26);
            this.tb_Password.TabIndex = 3;
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.lbl_Login.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.lbl_Login.Location = new System.Drawing.Point(184, 44);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Padding = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.lbl_Login.Size = new System.Drawing.Size(175, 55);
            this.lbl_Login.TabIndex = 4;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmb_User_Role
            // 
            this.cmb_User_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_User_Role.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_User_Role.ForeColor = System.Drawing.Color.DimGray;
            this.cmb_User_Role.FormattingEnabled = true;
            this.cmb_User_Role.Items.AddRange(new object[] {
            "abc",
            "xyz"});
            this.cmb_User_Role.Location = new System.Drawing.Point(218, 188);
            this.cmb_User_Role.Name = "cmb_User_Role";
            this.cmb_User_Role.Size = new System.Drawing.Size(207, 26);
            this.cmb_User_Role.TabIndex = 1;
            this.cmb_User_Role.SelectionChangeCommitted += new System.EventHandler(this.cmb_User_Role_SelectionChangeCommitted);
            // 
            // lbl_User_Role
            // 
            this.lbl_User_Role.AutoSize = true;
            this.lbl_User_Role.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_User_Role.Location = new System.Drawing.Point(32, 188);
            this.lbl_User_Role.Name = "lbl_User_Role";
            this.lbl_User_Role.Size = new System.Drawing.Size(105, 23);
            this.lbl_User_Role.TabIndex = 3;
            this.lbl_User_Role.Text = "User Role";
            // 
            // lbl_Supplier_Name
            // 
            this.lbl_Supplier_Name.AutoSize = true;
            this.lbl_Supplier_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Supplier_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Supplier_Name.Location = new System.Drawing.Point(32, 261);
            this.lbl_Supplier_Name.Name = "lbl_Supplier_Name";
            this.lbl_Supplier_Name.Size = new System.Drawing.Size(111, 23);
            this.lbl_Supplier_Name.TabIndex = 4;
            this.lbl_Supplier_Name.Text = "Username";
            // 
            // lbl_Contact_No
            // 
            this.lbl_Contact_No.AutoSize = true;
            this.lbl_Contact_No.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact_No.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Contact_No.Location = new System.Drawing.Point(32, 331);
            this.lbl_Contact_No.Name = "lbl_Contact_No";
            this.lbl_Contact_No.Size = new System.Drawing.Size(107, 23);
            this.lbl_Contact_No.TabIndex = 5;
            this.lbl_Contact_No.Text = "Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 461);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnl_Login);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.pnl_Login.ResumeLayout(false);
            this.pnl_Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Login;
        private System.Windows.Forms.Label lbl_User_Role;
        private System.Windows.Forms.Label lbl_Supplier_Name;
        private System.Windows.Forms.Label lbl_Contact_No;
        private System.Windows.Forms.ComboBox cmb_User_Role;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}