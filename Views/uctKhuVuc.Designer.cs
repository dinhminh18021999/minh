namespace SoftQuanLyNhaHang.Views
{
    partial class uctKhuVuc
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
            this.txtDienGiaiKV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grQuanLyNV = new System.Windows.Forms.GroupBox();
            this.cmbTrangThaiKV = new System.Windows.Forms.ComboBox();
            this.txtTenKV = new System.Windows.Forms.TextBox();
            this.txtIdKhuVuc = new System.Windows.Forms.TextBox();
            this.grDanhSachKV = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDanhSachKV = new System.Windows.Forms.DataGridView();
            this.IdKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grQuanLyNV.SuspendLayout();
            this.grDanhSachKV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKV)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDienGiaiKV
            // 
            this.txtDienGiaiKV.Location = new System.Drawing.Point(139, 108);
            this.txtDienGiaiKV.Name = "txtDienGiaiKV";
            this.txtDienGiaiKV.Size = new System.Drawing.Size(122, 20);
            this.txtDienGiaiKV.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(267, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "Trạng Thái :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Diễn Giải :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Tên :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Id Khu Vực :";
            // 
            // grQuanLyNV
            // 
            this.grQuanLyNV.Controls.Add(this.cmbTrangThaiKV);
            this.grQuanLyNV.Controls.Add(this.label10);
            this.grQuanLyNV.Controls.Add(this.txtDienGiaiKV);
            this.grQuanLyNV.Controls.Add(this.label8);
            this.grQuanLyNV.Controls.Add(this.txtTenKV);
            this.grQuanLyNV.Controls.Add(this.label2);
            this.grQuanLyNV.Controls.Add(this.txtIdKhuVuc);
            this.grQuanLyNV.Controls.Add(this.label6);
            this.grQuanLyNV.Location = new System.Drawing.Point(3, 52);
            this.grQuanLyNV.Name = "grQuanLyNV";
            this.grQuanLyNV.Size = new System.Drawing.Size(455, 181);
            this.grQuanLyNV.TabIndex = 87;
            this.grQuanLyNV.TabStop = false;
            // 
            // cmbTrangThaiKV
            // 
            this.cmbTrangThaiKV.FormattingEnabled = true;
            this.cmbTrangThaiKV.Location = new System.Drawing.Point(338, 108);
            this.cmbTrangThaiKV.Name = "cmbTrangThaiKV";
            this.cmbTrangThaiKV.Size = new System.Drawing.Size(94, 21);
            this.cmbTrangThaiKV.TabIndex = 79;
            // 
            // txtTenKV
            // 
            this.txtTenKV.Location = new System.Drawing.Point(267, 72);
            this.txtTenKV.Name = "txtTenKV";
            this.txtTenKV.Size = new System.Drawing.Size(165, 20);
            this.txtTenKV.TabIndex = 0;
            // 
            // txtIdKhuVuc
            // 
            this.txtIdKhuVuc.Enabled = false;
            this.txtIdKhuVuc.Location = new System.Drawing.Point(139, 72);
            this.txtIdKhuVuc.Name = "txtIdKhuVuc";
            this.txtIdKhuVuc.Size = new System.Drawing.Size(68, 20);
            this.txtIdKhuVuc.TabIndex = 73;
            this.txtIdKhuVuc.TabStop = false;
            // 
            // grDanhSachKV
            // 
            this.grDanhSachKV.Controls.Add(this.dgvDanhSachKV);
            this.grDanhSachKV.Location = new System.Drawing.Point(479, 52);
            this.grDanhSachKV.Name = "grDanhSachKV";
            this.grDanhSachKV.Size = new System.Drawing.Size(441, 181);
            this.grDanhSachKV.TabIndex = 88;
            this.grDanhSachKV.TabStop = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(30, 262);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 89;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.Control;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(322, 262);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 93;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.SystemColors.Control;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(249, 262);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 92;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.Control;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(103, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 90;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(176, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 91;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(605, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "DANH SÁCH KHU VỰC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 95;
            this.label1.Text = "QUẢN LÝ  KHU VỰC";
            // 
            // dgvDanhSachKV
            // 
            this.dgvDanhSachKV.AllowUserToAddRows = false;
            this.dgvDanhSachKV.AllowUserToDeleteRows = false;
            this.dgvDanhSachKV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKV.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSachKV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdKhuVuc,
            this.TenKhuVuc,
            this.DienGiai,
            this.TrangThai});
            this.dgvDanhSachKV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachKV.Location = new System.Drawing.Point(3, 0);
            this.dgvDanhSachKV.Name = "dgvDanhSachKV";
            this.dgvDanhSachKV.ReadOnly = true;
            this.dgvDanhSachKV.Size = new System.Drawing.Size(435, 181);
            this.dgvDanhSachKV.TabIndex = 89;
            // 
            // IdKhuVuc
            // 
            this.IdKhuVuc.DataPropertyName = "IdKhuVuc";
            this.IdKhuVuc.HeaderText = "Id Khu Vực";
            this.IdKhuVuc.Name = "IdKhuVuc";
            this.IdKhuVuc.ReadOnly = true;
            // 
            // TenKhuVuc
            // 
            this.TenKhuVuc.DataPropertyName = "TenKhuVuc";
            this.TenKhuVuc.HeaderText = "Tên Khu Vực";
            this.TenKhuVuc.Name = "TenKhuVuc";
            this.TenKhuVuc.ReadOnly = true;
            // 
            // DienGiai
            // 
            this.DienGiai.DataPropertyName = "DienGiai";
            this.DienGiai.HeaderText = "Diễn Giải";
            this.DienGiai.Name = "DienGiai";
            this.DienGiai.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // uctKhuVuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grDanhSachKV);
            this.Controls.Add(this.grQuanLyNV);
            this.Name = "uctKhuVuc";
            this.Size = new System.Drawing.Size(923, 324);
            this.Load += new System.EventHandler(this.uctKhuVuc_Load);
            this.grQuanLyNV.ResumeLayout(false);
            this.grQuanLyNV.PerformLayout();
            this.grDanhSachKV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDienGiaiKV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grQuanLyNV;
        private System.Windows.Forms.TextBox txtTenKV;
        private System.Windows.Forms.TextBox txtIdKhuVuc;
        private System.Windows.Forms.GroupBox grDanhSachKV;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbTrangThaiKV;
        private System.Windows.Forms.DataGridView dgvDanhSachKV;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;

    }
}
