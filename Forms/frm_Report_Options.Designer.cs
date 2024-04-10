
namespace Ayuraj_Computer_Shopee_App.Forms
{
    partial class frm_Report_Options
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
            this.btn_Stock_Report = new System.Windows.Forms.Button();
            this.btn_Supplier_Report = new System.Windows.Forms.Button();
            this.btn_Customer = new System.Windows.Forms.Button();
            this.btn_Employee_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Stock_Report
            // 
            this.btn_Stock_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Stock_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Stock_Report.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stock_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Stock_Report.Location = new System.Drawing.Point(335, 257);
            this.btn_Stock_Report.Name = "btn_Stock_Report";
            this.btn_Stock_Report.Size = new System.Drawing.Size(251, 43);
            this.btn_Stock_Report.TabIndex = 14;
            this.btn_Stock_Report.Text = "Stock Report";
            this.btn_Stock_Report.UseVisualStyleBackColor = false;
            this.btn_Stock_Report.Click += new System.EventHandler(this.btn_Stock_Report_Click);
            // 
            // btn_Supplier_Report
            // 
            this.btn_Supplier_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Supplier_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Supplier_Report.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Supplier_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Supplier_Report.Location = new System.Drawing.Point(335, 162);
            this.btn_Supplier_Report.Name = "btn_Supplier_Report";
            this.btn_Supplier_Report.Size = new System.Drawing.Size(251, 43);
            this.btn_Supplier_Report.TabIndex = 15;
            this.btn_Supplier_Report.Text = "Supplier Report";
            this.btn_Supplier_Report.UseVisualStyleBackColor = false;
            this.btn_Supplier_Report.Click += new System.EventHandler(this.btn_Supplier_Report_Click);
            // 
            // btn_Customer
            // 
            this.btn_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Customer.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Customer.ForeColor = System.Drawing.Color.White;
            this.btn_Customer.Location = new System.Drawing.Point(335, 66);
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.Size = new System.Drawing.Size(251, 43);
            this.btn_Customer.TabIndex = 16;
            this.btn_Customer.Text = "Customer Report";
            this.btn_Customer.UseVisualStyleBackColor = false;
            this.btn_Customer.Click += new System.EventHandler(this.btn_Customer_Click);
            // 
            // btn_Employee_Report
            // 
            this.btn_Employee_Report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.btn_Employee_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Employee_Report.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Employee_Report.ForeColor = System.Drawing.Color.White;
            this.btn_Employee_Report.Location = new System.Drawing.Point(335, 351);
            this.btn_Employee_Report.Name = "btn_Employee_Report";
            this.btn_Employee_Report.Size = new System.Drawing.Size(251, 43);
            this.btn_Employee_Report.TabIndex = 17;
            this.btn_Employee_Report.Text = "Employee Report";
            this.btn_Employee_Report.UseVisualStyleBackColor = false;
            // 
            // frm_Report_Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.btn_Employee_Report);
            this.Controls.Add(this.btn_Customer);
            this.Controls.Add(this.btn_Supplier_Report);
            this.Controls.Add(this.btn_Stock_Report);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Report_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Options";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Stock_Report;
        private System.Windows.Forms.Button btn_Supplier_Report;
        private System.Windows.Forms.Button btn_Customer;
        private System.Windows.Forms.Button btn_Employee_Report;
    }
}