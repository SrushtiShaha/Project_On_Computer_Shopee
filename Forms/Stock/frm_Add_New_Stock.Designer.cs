
namespace Ayuraj_Computer_Shopee_App.Forms.Stock
{
    partial class frm_Add_New_Stock
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
            this.btn_Save = new System.Windows.Forms.Button();
            this.cmb_Product_Name = new System.Windows.Forms.ComboBox();
            this.cmb_Category_Name = new System.Windows.Forms.ComboBox();
            this.lbl_Category_Name = new System.Windows.Forms.Label();
            this.dtp_Import_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Import_Date = new System.Windows.Forms.Label();
            this.lbl_New_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_New_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Remaining_Stock_Quantity = new System.Windows.Forms.Label();
            this.tb_Remaining_Stock_Quantity = new System.Windows.Forms.TextBox();
            this.lbl_Product_Name = new System.Windows.Forms.Label();
            this.lbl_Subcategory_Name = new System.Windows.Forms.Label();
            this.lbl_Stock_ID = new System.Windows.Forms.Label();
            this.tb_Stock_ID = new System.Windows.Forms.TextBox();
            this.cmb_Subcategory_Name = new System.Windows.Forms.ComboBox();
            this.gb_Stock_Details = new System.Windows.Forms.GroupBox();
            this.pb_Refresh = new System.Windows.Forms.PictureBox();
            this.gb_Stock_Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(417, 406);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(97, 35);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cmb_Product_Name
            // 
            this.cmb_Product_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.cmb_Product_Name.FormattingEnabled = true;
            this.cmb_Product_Name.Location = new System.Drawing.Point(367, 61);
            this.cmb_Product_Name.Name = "cmb_Product_Name";
            this.cmb_Product_Name.Size = new System.Drawing.Size(215, 26);
            this.cmb_Product_Name.TabIndex = 2;
            this.cmb_Product_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // cmb_Category_Name
            // 
            this.cmb_Category_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Category_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Category_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.cmb_Category_Name.FormattingEnabled = true;
            this.cmb_Category_Name.Location = new System.Drawing.Point(367, 108);
            this.cmb_Category_Name.Name = "cmb_Category_Name";
            this.cmb_Category_Name.Size = new System.Drawing.Size(215, 26);
            this.cmb_Category_Name.TabIndex = 3;
            this.cmb_Category_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // lbl_Category_Name
            // 
            this.lbl_Category_Name.AutoSize = true;
            this.lbl_Category_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Category_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Category_Name.Location = new System.Drawing.Point(130, 115);
            this.lbl_Category_Name.Name = "lbl_Category_Name";
            this.lbl_Category_Name.Size = new System.Drawing.Size(132, 18);
            this.lbl_Category_Name.TabIndex = 57;
            this.lbl_Category_Name.Text = "Category Name";
            // 
            // dtp_Import_Date
            // 
            this.dtp_Import_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Import_Date.Location = new System.Drawing.Point(367, 297);
            this.dtp_Import_Date.Name = "dtp_Import_Date";
            this.dtp_Import_Date.Size = new System.Drawing.Size(215, 26);
            this.dtp_Import_Date.TabIndex = 7;
            // 
            // lbl_Import_Date
            // 
            this.lbl_Import_Date.AutoSize = true;
            this.lbl_Import_Date.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Import_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Import_Date.Location = new System.Drawing.Point(130, 303);
            this.lbl_Import_Date.Name = "lbl_Import_Date";
            this.lbl_Import_Date.Size = new System.Drawing.Size(102, 18);
            this.lbl_Import_Date.TabIndex = 46;
            this.lbl_Import_Date.Text = "Import Date";
            // 
            // lbl_New_Stock_Quantity
            // 
            this.lbl_New_Stock_Quantity.AutoSize = true;
            this.lbl_New_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_New_Stock_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_New_Stock_Quantity.Location = new System.Drawing.Point(130, 255);
            this.lbl_New_Stock_Quantity.Name = "lbl_New_Stock_Quantity";
            this.lbl_New_Stock_Quantity.Size = new System.Drawing.Size(165, 18);
            this.lbl_New_Stock_Quantity.TabIndex = 55;
            this.lbl_New_Stock_Quantity.Text = "New Stock Quantity";
            // 
            // tb_New_Stock_Quantity
            // 
            this.tb_New_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_New_Stock_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.tb_New_Stock_Quantity.Location = new System.Drawing.Point(367, 252);
            this.tb_New_Stock_Quantity.MaxLength = 4;
            this.tb_New_Stock_Quantity.Name = "tb_New_Stock_Quantity";
            this.tb_New_Stock_Quantity.Size = new System.Drawing.Size(215, 26);
            this.tb_New_Stock_Quantity.TabIndex = 6;
            this.tb_New_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Remaining_Stock_Quantity
            // 
            this.lbl_Remaining_Stock_Quantity.AutoSize = true;
            this.lbl_Remaining_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Remaining_Stock_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Remaining_Stock_Quantity.Location = new System.Drawing.Point(130, 209);
            this.lbl_Remaining_Stock_Quantity.Name = "lbl_Remaining_Stock_Quantity";
            this.lbl_Remaining_Stock_Quantity.Size = new System.Drawing.Size(214, 18);
            this.lbl_Remaining_Stock_Quantity.TabIndex = 53;
            this.lbl_Remaining_Stock_Quantity.Text = "Remaining Stock Quantity";
            // 
            // tb_Remaining_Stock_Quantity
            // 
            this.tb_Remaining_Stock_Quantity.Enabled = false;
            this.tb_Remaining_Stock_Quantity.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Remaining_Stock_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.tb_Remaining_Stock_Quantity.Location = new System.Drawing.Point(367, 204);
            this.tb_Remaining_Stock_Quantity.MaxLength = 4;
            this.tb_Remaining_Stock_Quantity.Name = "tb_Remaining_Stock_Quantity";
            this.tb_Remaining_Stock_Quantity.Size = new System.Drawing.Size(215, 26);
            this.tb_Remaining_Stock_Quantity.TabIndex = 5;
            this.tb_Remaining_Stock_Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Product_Name
            // 
            this.lbl_Product_Name.AutoSize = true;
            this.lbl_Product_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Product_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Product_Name.Location = new System.Drawing.Point(130, 69);
            this.lbl_Product_Name.Name = "lbl_Product_Name";
            this.lbl_Product_Name.Size = new System.Drawing.Size(122, 18);
            this.lbl_Product_Name.TabIndex = 51;
            this.lbl_Product_Name.Text = "Product Name";
            // 
            // lbl_Subcategory_Name
            // 
            this.lbl_Subcategory_Name.AutoSize = true;
            this.lbl_Subcategory_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subcategory_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Subcategory_Name.Location = new System.Drawing.Point(130, 160);
            this.lbl_Subcategory_Name.Name = "lbl_Subcategory_Name";
            this.lbl_Subcategory_Name.Size = new System.Drawing.Size(161, 18);
            this.lbl_Subcategory_Name.TabIndex = 49;
            this.lbl_Subcategory_Name.Text = "Subcategory Name";
            // 
            // lbl_Stock_ID
            // 
            this.lbl_Stock_ID.AutoSize = true;
            this.lbl_Stock_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.lbl_Stock_ID.Location = new System.Drawing.Point(130, 25);
            this.lbl_Stock_ID.Name = "lbl_Stock_ID";
            this.lbl_Stock_ID.Size = new System.Drawing.Size(75, 18);
            this.lbl_Stock_ID.TabIndex = 45;
            this.lbl_Stock_ID.Text = "Stock ID";
            // 
            // tb_Stock_ID
            // 
            this.tb_Stock_ID.Enabled = false;
            this.tb_Stock_ID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Stock_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.tb_Stock_ID.Location = new System.Drawing.Point(367, 15);
            this.tb_Stock_ID.Name = "tb_Stock_ID";
            this.tb_Stock_ID.Size = new System.Drawing.Size(215, 26);
            this.tb_Stock_ID.TabIndex = 1;
            this.tb_Stock_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Subcategory_Name
            // 
            this.cmb_Subcategory_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Subcategory_Name.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Subcategory_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.cmb_Subcategory_Name.FormattingEnabled = true;
            this.cmb_Subcategory_Name.Location = new System.Drawing.Point(367, 155);
            this.cmb_Subcategory_Name.Name = "cmb_Subcategory_Name";
            this.cmb_Subcategory_Name.Size = new System.Drawing.Size(215, 26);
            this.cmb_Subcategory_Name.TabIndex = 4;
            this.cmb_Subcategory_Name.SelectionChangeCommitted += new System.EventHandler(this.cmb_Subcategory_Name_SelectionChangeCommitted);
            this.cmb_Subcategory_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // gb_Stock_Details
            // 
            this.gb_Stock_Details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(226)))), ((int)(((byte)(230)))));
            this.gb_Stock_Details.Controls.Add(this.cmb_Product_Name);
            this.gb_Stock_Details.Controls.Add(this.cmb_Category_Name);
            this.gb_Stock_Details.Controls.Add(this.lbl_Category_Name);
            this.gb_Stock_Details.Controls.Add(this.dtp_Import_Date);
            this.gb_Stock_Details.Controls.Add(this.lbl_Import_Date);
            this.gb_Stock_Details.Controls.Add(this.lbl_New_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.tb_New_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.lbl_Remaining_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.tb_Remaining_Stock_Quantity);
            this.gb_Stock_Details.Controls.Add(this.lbl_Product_Name);
            this.gb_Stock_Details.Controls.Add(this.cmb_Subcategory_Name);
            this.gb_Stock_Details.Controls.Add(this.lbl_Subcategory_Name);
            this.gb_Stock_Details.Controls.Add(this.lbl_Stock_ID);
            this.gb_Stock_Details.Controls.Add(this.tb_Stock_ID);
            this.gb_Stock_Details.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Stock_Details.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gb_Stock_Details.Location = new System.Drawing.Point(117, 40);
            this.gb_Stock_Details.Name = "gb_Stock_Details";
            this.gb_Stock_Details.Size = new System.Drawing.Size(697, 344);
            this.gb_Stock_Details.TabIndex = 68;
            this.gb_Stock_Details.TabStop = false;
            this.gb_Stock_Details.Text = "STOCK DETAILS";
            // 
            // pb_Refresh
            // 
            this.pb_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Refresh.Image = global::Ayuraj_Computer_Shopee_App.Properties.Resources.Refresh;
            this.pb_Refresh.Location = new System.Drawing.Point(458, 2);
            this.pb_Refresh.Name = "pb_Refresh";
            this.pb_Refresh.Size = new System.Drawing.Size(30, 30);
            this.pb_Refresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Refresh.TabIndex = 74;
            this.pb_Refresh.TabStop = false;
            this.pb_Refresh.Click += new System.EventHandler(this.pb_Refresh_Click);
            // 
            // frm_Add_New_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.pb_Refresh);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.gb_Stock_Details);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Stock";
            this.Load += new System.EventHandler(this.frm_Add_New_Stock_Load);
            this.gb_Stock_Details.ResumeLayout(false);
            this.gb_Stock_Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Refresh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmb_Product_Name;
        private System.Windows.Forms.ComboBox cmb_Category_Name;
        private System.Windows.Forms.Label lbl_Category_Name;
        private System.Windows.Forms.DateTimePicker dtp_Import_Date;
        private System.Windows.Forms.Label lbl_Import_Date;
        private System.Windows.Forms.Label lbl_New_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_New_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Remaining_Stock_Quantity;
        private System.Windows.Forms.TextBox tb_Remaining_Stock_Quantity;
        private System.Windows.Forms.Label lbl_Product_Name;
        private System.Windows.Forms.Label lbl_Subcategory_Name;
        private System.Windows.Forms.Label lbl_Stock_ID;
        private System.Windows.Forms.TextBox tb_Stock_ID;
        private System.Windows.Forms.ComboBox cmb_Subcategory_Name;
        private System.Windows.Forms.GroupBox gb_Stock_Details;
        private System.Windows.Forms.PictureBox pb_Refresh;
    }
}