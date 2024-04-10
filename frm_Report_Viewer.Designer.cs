
namespace Ayuraj_Computer_Shopee_App
{
    partial class frm_Report_Viewer
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
            this.crv_Viewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crv_Viewer
            // 
            this.crv_Viewer.ActiveViewIndex = -1;
            this.crv_Viewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crv_Viewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crv_Viewer.DisplayStatusBar = false;
            this.crv_Viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crv_Viewer.EnableRefresh = false;
            this.crv_Viewer.Location = new System.Drawing.Point(0, 0);
            this.crv_Viewer.Name = "crv_Viewer";
            this.crv_Viewer.Size = new System.Drawing.Size(934, 461);
            this.crv_Viewer.TabIndex = 0;
            this.crv_Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frm_Report_Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(934, 461);
            this.Controls.Add(this.crv_Viewer);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Report_Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Report_Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_Report_Viewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crv_Viewer;
    }
}