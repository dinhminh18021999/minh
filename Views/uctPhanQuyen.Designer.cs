namespace SoftQuanLyNhaHang.Views
{
    partial class uctPhanQuyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.grpThongTinTK = new System.Windows.Forms.GroupBox();
            this.grpPhanQuyen = new System.Windows.Forms.GroupBox();
            this.chkQuanLy = new System.Windows.Forms.CheckBox();
            this.chkKhuVuc = new System.Windows.Forms.CheckBox();
            this.chkThucDon = new System.Windows.Forms.CheckBox();
            this.chkGoiMon = new System.Windows.Forms.CheckBox();
            this.chkHeThong = new System.Windows.Forms.CheckBox();
            this.chkThuChi = new System.Windows.Forms.CheckBox();
            this.chkTroGiup = new System.Windows.Forms.CheckBox();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cmmbIdNhanVien = new System.Windows.Forms.ComboBox();
            this.grpThongTinTK.SuspendLayout();
            this.grpPhanQuyen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Tài Khoản :";
            // 
            // txtMaTK
            // 
            this.txtMaTK.Enabled = false;
            this.txtMaTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaTK.Location = new System.Drawing.Point(131, 25);
            this.txtMaTK.Name = "txtMaTK";
            this.txtMaTK.Size = new System.Drawing.Size(140, 21);
            this.txtMaTK.TabIndex = 1;
            this.txtMaTK.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Id Nhân Viên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(11, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Nhân Viên :";
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Enabled = false;
            this.txtTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenNhanVien.Location = new System.Drawing.Point(131, 103);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(140, 21);
            this.txtTenNhanVien.TabIndex = 1;
            this.txtTenNhanVien.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(11, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu :";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(131, 51);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(140, 21);
            this.txtMatKhau.TabIndex = 0;
            // 
            // grpThongTinTK
            // 
            this.grpThongTinTK.Controls.Add(this.cmmbIdNhanVien);
            this.grpThongTinTK.Controls.Add(this.txtMaTK);
            this.grpThongTinTK.Controls.Add(this.txtTenNhanVien);
            this.grpThongTinTK.Controls.Add(this.label1);
            this.grpThongTinTK.Controls.Add(this.label3);
            this.grpThongTinTK.Controls.Add(this.label2);
            this.grpThongTinTK.Controls.Add(this.txtMatKhau);
            this.grpThongTinTK.Controls.Add(this.label4);
            this.grpThongTinTK.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpThongTinTK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpThongTinTK.Location = new System.Drawing.Point(3, 20);
            this.grpThongTinTK.Name = "grpThongTinTK";
            this.grpThongTinTK.Size = new System.Drawing.Size(321, 137);
            this.grpThongTinTK.TabIndex = 2;
            this.grpThongTinTK.TabStop = false;
            this.grpThongTinTK.Text = "Thông tin tài khoản";
            // 
            // grpPhanQuyen
            // 
            this.grpPhanQuyen.Controls.Add(this.chkTroGiup);
            this.grpPhanQuyen.Controls.Add(this.chkThuChi);
            this.grpPhanQuyen.Controls.Add(this.chkHeThong);
            this.grpPhanQuyen.Controls.Add(this.chkThucDon);
            this.grpPhanQuyen.Controls.Add(this.chkGoiMon);
            this.grpPhanQuyen.Controls.Add(this.chkKhuVuc);
            this.grpPhanQuyen.Controls.Add(this.chkQuanLy);
            this.grpPhanQuyen.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.grpPhanQuyen.Location = new System.Drawing.Point(342, 20);
            this.grpPhanQuyen.Name = "grpPhanQuyen";
            this.grpPhanQuyen.Size = new System.Drawing.Size(219, 137);
            this.grpPhanQuyen.TabIndex = 3;
            this.grpPhanQuyen.TabStop = false;
            this.grpPhanQuyen.Text = "Lựa Chọn Phân Quyền";
            // 
            // chkQuanLy
            // 
            this.chkQuanLy.AutoSize = true;
            this.chkQuanLy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkQuanLy.Location = new System.Drawing.Point(24, 28);
            this.chkQuanLy.Name = "chkQuanLy";
            this.chkQuanLy.Size = new System.Drawing.Size(73, 17);
            this.chkQuanLy.TabIndex = 2;
            this.chkQuanLy.Text = "Quản Lý";
            this.chkQuanLy.UseVisualStyleBackColor = true;
            // 
            // chkKhuVuc
            // 
            this.chkKhuVuc.AutoSize = true;
            this.chkKhuVuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkKhuVuc.Location = new System.Drawing.Point(24, 81);
            this.chkKhuVuc.Name = "chkKhuVuc";
            this.chkKhuVuc.Size = new System.Drawing.Size(74, 17);
            this.chkKhuVuc.TabIndex = 4;
            this.chkKhuVuc.Text = "Khu Vực";
            this.chkKhuVuc.UseVisualStyleBackColor = true;
            // 
            // chkThucDon
            // 
            this.chkThucDon.AutoSize = true;
            this.chkThucDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkThucDon.Location = new System.Drawing.Point(24, 57);
            this.chkThucDon.Name = "chkThucDon";
            this.chkThucDon.Size = new System.Drawing.Size(82, 17);
            this.chkThucDon.TabIndex = 3;
            this.chkThucDon.Text = "Thực Đơn";
            this.chkThucDon.UseVisualStyleBackColor = true;
            // 
            // chkGoiMon
            // 
            this.chkGoiMon.AutoSize = true;
            this.chkGoiMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkGoiMon.Location = new System.Drawing.Point(128, 28);
            this.chkGoiMon.Name = "chkGoiMon";
            this.chkGoiMon.Size = new System.Drawing.Size(73, 17);
            this.chkGoiMon.TabIndex = 6;
            this.chkGoiMon.Text = "Gọi Món";
            this.chkGoiMon.UseVisualStyleBackColor = true;
            // 
            // chkHeThong
            // 
            this.chkHeThong.AutoSize = true;
            this.chkHeThong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkHeThong.Location = new System.Drawing.Point(24, 104);
            this.chkHeThong.Name = "chkHeThong";
            this.chkHeThong.Size = new System.Drawing.Size(82, 17);
            this.chkHeThong.TabIndex = 5;
            this.chkHeThong.Text = "Hệ Thống";
            this.chkHeThong.UseVisualStyleBackColor = true;
            // 
            // chkThuChi
            // 
            this.chkThuChi.AutoSize = true;
            this.chkThuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkThuChi.Location = new System.Drawing.Point(128, 57);
            this.chkThuChi.Name = "chkThuChi";
            this.chkThuChi.Size = new System.Drawing.Size(70, 17);
            this.chkThuChi.TabIndex = 7;
            this.chkThuChi.Text = "Thu Chi";
            this.chkThuChi.UseVisualStyleBackColor = true;
            // 
            // chkTroGiup
            // 
            this.chkTroGiup.AutoSize = true;
            this.chkTroGiup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkTroGiup.Location = new System.Drawing.Point(128, 81);
            this.chkTroGiup.Name = "chkTroGiup";
            this.chkTroGiup.Size = new System.Drawing.Size(75, 17);
            this.chkTroGiup.TabIndex = 8;
            this.chkTroGiup.Text = "Trợ Giúp";
            this.chkTroGiup.UseVisualStyleBackColor = true;
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanQuyen.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dgvPhanQuyen.Location = new System.Drawing.Point(3, 209);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.Size = new System.Drawing.Size(558, 150);
            this.dgvPhanQuyen.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(171, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemMoi);
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Location = new System.Drawing.Point(3, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 46);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(82, 13);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemMoi.TabIndex = 79;
            this.btnThemMoi.Text = "Thêm ";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(384, 13);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(77, 23);
            this.btnHuy.TabIndex = 83;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(307, 13);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(77, 23);
            this.btnLuu.TabIndex = 82;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(157, 13);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 80;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(232, 13);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 81;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cmmbIdNhanVien
            // 
            this.cmmbIdNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmmbIdNhanVien.FormattingEnabled = true;
            this.cmmbIdNhanVien.Location = new System.Drawing.Point(131, 76);
            this.cmmbIdNhanVien.Name = "cmmbIdNhanVien";
            this.cmmbIdNhanVien.Size = new System.Drawing.Size(140, 23);
            this.cmmbIdNhanVien.TabIndex = 1;
            this.cmmbIdNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmmbIdNhanVien_SelectedIndexChanged);
            // 
            // uctPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPhanQuyen);
            this.Controls.Add(this.grpPhanQuyen);
            this.Controls.Add(this.grpThongTinTK);
            this.Name = "uctPhanQuyen";
            this.Size = new System.Drawing.Size(566, 423);
            this.Load += new System.EventHandler(this.uctPhanQuyen_Load);
            this.grpThongTinTK.ResumeLayout(false);
            this.grpThongTinTK.PerformLayout();
            this.grpPhanQuyen.ResumeLayout(false);
            this.grpPhanQuyen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.GroupBox grpThongTinTK;
        private System.Windows.Forms.GroupBox grpPhanQuyen;
        private System.Windows.Forms.CheckBox chkQuanLy;
        private System.Windows.Forms.CheckBox chkKhuVuc;
        private System.Windows.Forms.CheckBox chkThuChi;
        private System.Windows.Forms.CheckBox chkHeThong;
        private System.Windows.Forms.CheckBox chkThucDon;
        private System.Windows.Forms.CheckBox chkGoiMon;
        private System.Windows.Forms.CheckBox chkTroGiup;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cmmbIdNhanVien;
    }
}
