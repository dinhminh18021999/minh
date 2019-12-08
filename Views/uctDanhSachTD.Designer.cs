namespace SoftQuanLyNhaHang.Views
{
    partial class uctDanhSachTD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grDanhsachTD = new System.Windows.Forms.GroupBox();
            this.dgvDanhsachTD = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.IdThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThucDon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grDanhsachTD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachTD)).BeginInit();
            this.SuspendLayout();
            // 
            // grDanhsachTD
            // 
            this.grDanhsachTD.Controls.Add(this.dgvDanhsachTD);
            this.grDanhsachTD.Location = new System.Drawing.Point(2, 52);
            this.grDanhsachTD.Name = "grDanhsachTD";
            this.grDanhsachTD.Size = new System.Drawing.Size(780, 286);
            this.grDanhsachTD.TabIndex = 113;
            this.grDanhsachTD.TabStop = false;
            // 
            // dgvDanhsachTD
            // 
            this.dgvDanhsachTD.AllowUserToAddRows = false;
            this.dgvDanhsachTD.AllowUserToDeleteRows = false;
            this.dgvDanhsachTD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachTD.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvDanhsachTD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachTD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdThucDon,
            this.TenLoaiThucDon,
            this.TenThucDon,
            this.DonViTinh,
            this.SoLuongTon,
            this.DonGiaTon,
            this.TrangThai});
            this.dgvDanhsachTD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDanhsachTD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgvDanhsachTD.Location = new System.Drawing.Point(3, 1);
            this.dgvDanhsachTD.Name = "dgvDanhsachTD";
            this.dgvDanhsachTD.ReadOnly = true;
            this.dgvDanhsachTD.Size = new System.Drawing.Size(774, 282);
            this.dgvDanhsachTD.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(287, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(190, 17);
            this.label10.TabIndex = 114;
            this.label10.Text = "DANH SÁCH  THỰC ĐƠN";
            // 
            // IdThucDon
            // 
            this.IdThucDon.DataPropertyName = "IdThucDon";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.IdThucDon.DefaultCellStyle = dataGridViewCellStyle1;
            this.IdThucDon.HeaderText = "Id thực đơn";
            this.IdThucDon.Name = "IdThucDon";
            this.IdThucDon.ReadOnly = true;
            // 
            // TenLoaiThucDon
            // 
            this.TenLoaiThucDon.DataPropertyName = "TenLoaiThucDon";
            this.TenLoaiThucDon.HeaderText = "Tên loại thực đơn";
            this.TenLoaiThucDon.Name = "TenLoaiThucDon";
            this.TenLoaiThucDon.ReadOnly = true;
            // 
            // TenThucDon
            // 
            this.TenThucDon.DataPropertyName = "TenThucDon";
            this.TenThucDon.HeaderText = "Tên thực đơn";
            this.TenThucDon.Name = "TenThucDon";
            this.TenThucDon.ReadOnly = true;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            // 
            // SoLuongTon
            // 
            this.SoLuongTon.DataPropertyName = "SoLuongTon";
            this.SoLuongTon.HeaderText = "Số lượng tồn";
            this.SoLuongTon.Name = "SoLuongTon";
            this.SoLuongTon.ReadOnly = true;
            // 
            // DonGiaTon
            // 
            this.DonGiaTon.DataPropertyName = "DonGiaTon";
            this.DonGiaTon.HeaderText = "Đơn giá tồn";
            this.DonGiaTon.Name = "DonGiaTon";
            this.DonGiaTon.ReadOnly = true;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.ReadOnly = true;
            // 
            // uctDanhSachTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.grDanhsachTD);
            this.Name = "uctDanhSachTD";
            this.Size = new System.Drawing.Size(782, 347);
            this.Load += new System.EventHandler(this.uctDanhSachTD_Load);
            this.grDanhsachTD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachTD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grDanhsachTD;
        private System.Windows.Forms.DataGridView dgvDanhsachTD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThucDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}
