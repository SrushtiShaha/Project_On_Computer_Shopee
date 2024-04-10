
namespace Ayuraj_Computer_Shopee_App.Forms.Customer
{
    partial class uc_Customer
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_View_Customer_List = new System.Windows.Forms.Label();
            this.lbl_Add_New_Customer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_View_Customer_List
            // 
            this.lbl_View_Customer_List.AutoSize = true;
            this.lbl_View_Customer_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lbl_View_Customer_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_View_Customer_List.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Customer_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_View_Customer_List.Location = new System.Drawing.Point(509, 25);
            this.lbl_View_Customer_List.Name = "lbl_View_Customer_List";
            this.lbl_View_Customer_List.Size = new System.Drawing.Size(208, 25);
            this.lbl_View_Customer_List.TabIndex = 56;
            this.lbl_View_Customer_List.Text = "View Customer List";
            this.lbl_View_Customer_List.Click += new System.EventHandler(this.lbl_View_Customer_List_Click);
            // 
            // lbl_Add_New_Customer
            // 
            this.lbl_Add_New_Customer.AutoSize = true;
            this.lbl_Add_New_Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lbl_Add_New_Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Add_New_Customer.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Customer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.lbl_Add_New_Customer.Location = new System.Drawing.Point(54, 25);
            this.lbl_Add_New_Customer.Name = "lbl_Add_New_Customer";
            this.lbl_Add_New_Customer.Size = new System.Drawing.Size(210, 25);
            this.lbl_Add_New_Customer.TabIndex = 55;
            this.lbl_Add_New_Customer.Text = "Add New Customer";
            this.lbl_Add_New_Customer.Click += new System.EventHandler(this.lbl_Add_New_Customer_Click);
            // 
            // uc_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.lbl_View_Customer_List);
            this.Controls.Add(this.lbl_Add_New_Customer);
            this.Name = "uc_Customer";
            this.Size = new System.Drawing.Size(801, 74);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Customer_List;
        private System.Windows.Forms.Label lbl_Add_New_Customer;
    }
}
