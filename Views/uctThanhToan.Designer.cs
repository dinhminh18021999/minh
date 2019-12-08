namespace SoftQuanLyNhaHang.Views
{
    partial class uctThanhToan
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
            this.RPThanhtoan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RPThanhtoan
            // 
            this.RPThanhtoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RPThanhtoan.LocalReport.ReportEmbeddedResource = "SoftQuanLyNhaHang.Views.Report1.rdlc";
            this.RPThanhtoan.Location = new System.Drawing.Point(0, 0);
            this.RPThanhtoan.Name = "RPThanhtoan";
            this.RPThanhtoan.Size = new System.Drawing.Size(784, 316);
            this.RPThanhtoan.TabIndex = 1;
            // 
            // uctThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RPThanhtoan);
            this.Name = "uctThanhToan";
            this.Size = new System.Drawing.Size(784, 316);
            this.Load += new System.EventHandler(this.uctThanhToan_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RPThanhtoan;

    }
}
