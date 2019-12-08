namespace SoftQuanLyNhaHang.Views
{
    partial class uctBan
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
            this.grDanhSachBan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBan = new System.Windows.Forms.DataGridView();
            this.IdBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhuVucb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DienGiaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grThongTinBan = new System.Windows.Forms.GroupBox();
            this.cmbTenKhuVuc = new System.Windows.Forms.ComboBox();
            this.cmbTrangThaiBan = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDienGiaiBan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grDanhSachBan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).BeginInit();
            this.grThongTinBan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grDanhSachBan
            // 
            this.grDanhSachBan.Controls.Add(this.dgvDanhSachBan);
            this.grDanhSachBan.Location = new System.Drawing.Point(3, 87);
            this.grDanhSachBan.Name = "grDanhSachBan";
            this.grDanhSachBan.Size = new System.Drawing.Size(543, 449);
            this.grDanhSachBan.TabIndex = 90;
            this.grDanhSachBan.TabStop = false;
            // 
            // dgvDanhSachBan
            // 
            this.dgvDanhSachBan.AllowUserToAddRows = false;
            this.dgvDanhSachBan.AllowUserToDeleteRows = false;
            this.dgvDanhSachBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhSachBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBan,
            this.TenKhuVucb,
            this.TenBan,
            this.DienGiaib,
            this.TrangThaib});
            this.dgvDanhSachBan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhSachBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhSachBan.Location = new System.Drawing.Point(3, 0);
            this.dgvDanhSachBan.Name = "dgvDanhSachBan";
            this.dgvDanhSachBan.ReadOnly = true;
            this.dgvDanhSachBan.Size = new System.Drawing.Size(537, 446);
            this.dgvDanhSachBan.TabIndex = 88;
            // 
            // IdBan
            // 
            this.IdBan.DataPropertyName = "IdBan";
            this.IdBan.HeaderText = "Id bàn";
            this.IdBan.Name = "IdBan";
            this.IdBan.ReadOnly = true;
            // 
            // TenKhuVucb
            // 
            this.TenKhuVucb.DataPropertyName = "TenKhuVuc";
            this.TenKhuVucb.HeaderText = "Tên khu vực";
            this.TenKhuVucb.Name = "TenKhuVucb";
            this.TenKhuVucb.ReadOnly = true;
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên bàn";
            this.TenBan.Name = "TenBan";
            this.TenBan.ReadOnly = true;
            // 
            // DienGiaib
            // 
            this.DienGiaib.DataPropertyName = "DienGiai";
            this.DienGiaib.HeaderText = "Diễn giải";
            this.DienGiaib.Name = "DienGiaib";
            this.DienGiaib.ReadOnly = true;
            // 
            // TrangThaib
            // 
            this.TrangThaib.DataPropertyName = "TrangThai";
            this.TrangThaib.HeaderText = "Trạng thái";
            this.TrangThaib.Name = "TrangThaib";
            this.TrangThaib.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 87;
            this.label1.Text = "DANH SÁCH BÀN";
            // 
            // grThongTinBan
            // 
            this.grThongTinBan.Controls.Add(this.cmbTenKhuVuc);
            this.grThongTinBan.Controls.Add(this.cmbTrangThaiBan);
            this.grThongTinBan.Controls.Add(this.label10);
            this.grThongTinBan.Controls.Add(this.txtDienGiaiBan);
            this.grThongTinBan.Controls.Add(this.label8);
            this.grThongTinBan.Controls.Add(this.txtTenBan);
            this.grThongTinBan.Controls.Add(this.label2);
            this.grThongTinBan.Controls.Add(this.txtIdBan);
            this.grThongTinBan.Controls.Add(this.label3);
            this.grThongTinBan.Controls.Add(this.label6);
            this.grThongTinBan.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinBan.Location = new System.Drawing.Point(579, 87);
            this.grThongTinBan.Name = "grThongTinBan";
            this.grThongTinBan.Size = new System.Drawing.Size(375, 225);
            this.grThongTinBan.TabIndex = 99;
            this.grThongTinBan.TabStop = false;
            // 
            // cmbTenKhuVuc
            // 
            this.cmbTenKhuVuc.FormattingEnabled = true;
            this.cmbTenKhuVuc.Location = new System.Drawing.Point(136, 53);
            this.cmbTenKhuVuc.Name = "cmbTenKhuVuc";
            this.cmbTenKhuVuc.Size = new System.Drawing.Size(109, 23);
            this.cmbTenKhuVuc.TabIndex = 97;
            // 
            // cmbTrangThaiBan
            // 
            this.cmbTrangThaiBan.FormattingEnabled = true;
            this.cmbTrangThaiBan.Location = new System.Drawing.Point(136, 166);
            this.cmbTrangThaiBan.Name = "cmbTrangThaiBan";
            this.cmbTrangThaiBan.Size = new System.Drawing.Size(109, 23);
            this.cmbTrangThaiBan.TabIndex = 96;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 15);
            this.label10.TabIndex = 94;
            this.label10.Text = "Trạng Thái :";
            // 
            // txtDienGiaiBan
            // 
            this.txtDienGiaiBan.Location = new System.Drawing.Point(136, 128);
            this.txtDienGiaiBan.Name = "txtDienGiaiBan";
            this.txtDienGiaiBan.Size = new System.Drawing.Size(109, 22);
            this.txtDienGiaiBan.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 95;
            this.label8.Text = "Diễn Giải :";
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(136, 87);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(109, 22);
            this.txtTenBan.TabIndex = 89;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 91;
            this.label2.Text = "Tên Bàn :";
            // 
            // txtIdBan
            // 
            this.txtIdBan.Enabled = false;
            this.txtIdBan.Location = new System.Drawing.Point(136, 21);
            this.txtIdBan.Name = "txtIdBan";
            this.txtIdBan.Size = new System.Drawing.Size(109, 22);
            this.txtIdBan.TabIndex = 93;
            this.txtIdBan.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Tên Khu Vực :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 92;
            this.label6.Text = "Id Bàn :";
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(579, 328);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 100;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(879, 328);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 104;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(804, 328);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 103;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(654, 328);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 101;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(729, 328);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 102;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(692, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 87;
            this.label4.Text = "THÔNG TIN BÀN";
            // 
            // uctBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.grThongTinBan);
            this.Controls.Add(this.grDanhSachBan);
            this.Name = "uctBan";
            this.Size = new System.Drawing.Size(961, 539);
            this.Load += new System.EventHandler(this.uctBan_Load);
            this.grDanhSachBan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBan)).EndInit();
            this.grThongTinBan.ResumeLayout(false);
            this.grThongTinBan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhSachBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grThongTinBan;
        private System.Windows.Forms.ComboBox cmbTrangThaiBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDienGiaiBan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmbTenKhuVuc;
        private System.Windows.Forms.DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhuVucb;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DienGiaib;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaib;
        private System.Windows.Forms.Label label4;
    }
}
