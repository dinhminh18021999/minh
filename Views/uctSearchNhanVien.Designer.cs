namespace SoftQuanLyNhaHang.Views
{
    partial class uctSearchNhanVien
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
            this.dgvDanhSachNV = new System.Windows.Forms.DataGridView();
            this.grDanhSachNV = new System.Windows.Forms.GroupBox();
            this.cmbFind = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).BeginInit();
            this.grDanhSachNV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachNV
            // 
            this.dgvDanhSachNV.AllowUserToAddRows = false;
            this.dgvDanhSachNV.AllowUserToDeleteRows = false;
            this.dgvDanhSachNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachNV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachNV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachNV.Location = new System.Drawing.Point(3, 16);
            this.dgvDanhSachNV.Name = "dgvDanhSachNV";
            this.dgvDanhSachNV.ReadOnly = true;
            this.dgvDanhSachNV.Size = new System.Drawing.Size(791, 157);
            this.dgvDanhSachNV.TabIndex = 60;
            // 
            // grDanhSachNV
            // 
            this.grDanhSachNV.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grDanhSachNV.Controls.Add(this.dgvDanhSachNV);
            this.grDanhSachNV.Location = new System.Drawing.Point(9, 94);
            this.grDanhSachNV.Name = "grDanhSachNV";
            this.grDanhSachNV.Size = new System.Drawing.Size(797, 176);
            this.grDanhSachNV.TabIndex = 62;
            this.grDanhSachNV.TabStop = false;
            // 
            // cmbFind
            // 
            this.cmbFind.FormattingEnabled = true;
            this.cmbFind.Location = new System.Drawing.Point(169, 26);
            this.cmbFind.Name = "cmbFind";
            this.cmbFind.Size = new System.Drawing.Size(121, 21);
            this.cmbFind.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "Tìm kiếm theo :";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(312, 26);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(258, 20);
            this.txtFind.TabIndex = 65;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFind.Location = new System.Drawing.Point(617, 25);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 66;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(309, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(160, 17);
            this.label12.TabIndex = 67;
            this.label12.Text = "KẾT QUẢ TÌM KIẾM";
            // 
            // uctSearchNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFind);
            this.Controls.Add(this.grDanhSachNV);
            this.Name = "uctSearchNhanVien";
            this.Size = new System.Drawing.Size(812, 272);
            this.Load += new System.EventHandler(this.uctSearchNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNV)).EndInit();
            this.grDanhSachNV.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDanhSachNV;
        private System.Windows.Forms.GroupBox grDanhSachNV;
        private System.Windows.Forms.ComboBox cmbFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label12;

    }
}
