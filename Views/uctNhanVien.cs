using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace SoftQuanLyNhaHang.Views
{
    public partial class uctNhanVien : UserControl 
    {
        public uctNhanVien()
        {
            InitializeComponent();
        }
        public static uctNhanVien uctNV = new uctNhanVien();
        int flag = 0;
        public void HienThiDanhSachNhanVien()
        {
            dgvDanhSachNV.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            dgvDanhSachNV.Dock = DockStyle.Fill;
            dgvDanhSachNV.RowHeadersVisible = false;
            dgvDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
        }
        // Resize the master DataGridView columns to fit the newly loaded data. masterDataGridView.AutoResizeColumns();
        // Configure the details DataGridView so that its columns automatically 
        // adjust their widths when the data changes.
        //private void SizeAllColumns(Object sender, EventArgs e)
        //{
        //    dgvDanhSachNV.AutoResizeColumns(
        //        DataGridViewAutoSizeColumnsMode.AllCells);
        //    dgvDanhSachNV.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);

        //}
        private void uctNhanVien_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachNhanVien();
            bingding();
        }
        public void nhung(Control ctr)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlDanhSachNV.Controls.Add(ctr);
            pnlDanhSachNV.Show();
        }
        void loadcontrol()
        {
            cmbGioiTinhNV.Items.Clear();
            cmbGioiTinhNV.Items.Add("Nam");
            cmbGioiTinhNV.Items.Add("Nữ");
        }
        void bingding()
        {
            txtIdNhanVien.DataBindings.Clear();
            txtIdNhanVien.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "IdNhanVien");
            txtHolotNV.DataBindings.Clear();
            txtHolotNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "HoLot");
            txtTenNV.DataBindings.Clear();
            txtTenNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Ten");
            dtpNgaySinhNV.DataBindings.Clear();
            dtpNgaySinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Ngaysinh");
            cmbGioiTinhNV.DataBindings.Clear();
            cmbGioiTinhNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "GioiTinh");
            txtDienThoaiNV.DataBindings.Clear();
            txtDienThoaiNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DienThoai");
            txtEmailNV.DataBindings.Clear();
            txtEmailNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "Email");
            txtDiaChiNV.DataBindings.Clear();
            txtDiaChiNV.DataBindings.Add("Text", dgvDanhSachNV.DataSource, "DiaChi");

        }
        //private void dgvDanhSachNV_Click(object sender, EventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        //int i = 0;
        //        //i = dgvDanhSachNV.CurrentRow.Index;
        //        //string _idHocVien = dgvDanhSachNV.Rows[i].Cells[0].Value.ToString();
        //        //ds = Controllers.NhanVienCtrl.FillDataSet_getNhanVienByIdNhanVien(_idHocVien);
        //        //txtIdNhanVien.DataBindings.Clear();
        //        //txtIdNhanVien.DataBindings.Add("text", ds.Tables[0], "IdNhanVien");
        //        //txtHolotNV.DataBindings.Clear();
        //        //txtHolotNV.DataBindings.Add("text", ds.Tables[0], "HoLot");
        //        //txtTenNV.DataBindings.Clear();
        //        //txtTenNV.DataBindings.Add("text", ds.Tables[0], "Ten");
        //        //dtpNgaySinhNV.DataBindings.Clear();
        //        //dtpNgaySinhNV.DataBindings.Add("text", ds.Tables[0], "Ngaysinh");
        //        //cmbGioiTinhNV.DataBindings.Clear();
        //        //cmbGioiTinhNV.DataBindings.Add("text", ds.Tables[0], "GioiTinh");
        //        //txtDienThoaiNV.DataBindings.Clear();
        //        //txtDienThoaiNV.DataBindings.Add("text", ds.Tables[0], "DienThoai");
        //        //txtEmailNV.DataBindings.Clear();
        //        //txtEmailNV.DataBindings.Add("text", ds.Tables[0], "Email");
        //        //txtDiaChiNV.DataBindings.Clear();
        //        //txtDiaChiNV.DataBindings.Add("text", ds.Tables[0], "DiaChi");

        //    }
        //    catch { }

        //}
        void clearData()
        {
            txtIdNhanVien.Text = Models.connection.ExcuteScalar(String.Format("select IdNhanVien= dbo.fcgetIdNhanVien()"));
            txtHolotNV.Text = "";
            txtTenNV.Text = "";
            txtDienThoaiNV.Text = "";
            txtEmailNV.Text = "";
            txtDiaChiNV.Text = "";
            loadcontrol();
        }
        void dis_end(bool e)
        {
            //txtIdNhanVien.Enabled = e;
            txtHolotNV.Enabled = e;
            txtTenNV.Enabled = e;
            dtpNgaySinhNV.Enabled = e;
            cmbGioiTinhNV.Enabled = e;
            txtDienThoaiNV.Enabled = e;
            txtEmailNV.Enabled = e;
            txtDiaChiNV.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }
        private void txtDienThoaiNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            uctSearchNhanVien uctS = new uctSearchNhanVien();
            nhung(uctS);
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlDanhSachNV.Controls.Clear();
            pnlDanhSachNV.BorderStyle = BorderStyle.None;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIdNhanVien.Text;
            }
            catch { }

            string _hoNhanVien = "";
            try
            {
                _hoNhanVien = txtHolotNV.Text;
            }
            catch { }
            string _tenNhanVien = "";
            try
            {
                _tenNhanVien = txtTenNV.Text;
            }
            catch { }

            DateTime _ngaysinhNhanVien = dtpNgaySinhNV.Value;

            try { }
            catch { }
            string _giotinhNhanVien = "";
            try
            {
                _giotinhNhanVien = cmbGioiTinhNV.Text;
            }
            catch { }
            string _dienthoaiNhanVien = "";
            try
            {
                _dienthoaiNhanVien = txtDienThoaiNV.Text;
            }
            catch { }
            string _emailNhanVien = "";
            try
            {
                _emailNhanVien = txtEmailNV.Text;
            }
            catch { }
            string _diachiNhanVien = "";
            try
            {
                _diachiNhanVien = txtDiaChiNV.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_idNhanVien == "" || _tenNhanVien == "" || _hoNhanVien == "")
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.NhanVienCtrl.InSertNhanVien(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachNhanVien();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.UpdateNhanVien(_idNhanVien, _hoNhanVien, _tenNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthoaiNhanVien, _emailNhanVien, _diachiNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctNhanVien_Load(sender, e);
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctNhanVien_Load(sender, e);
            dis_end(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idNhanVien = "";
            try
            {
                _idNhanVien = txtIdNhanVien.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.NhanVienCtrl.DeleteNhanVien(_idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachNhanVien();
                    uctNhanVien_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void txtEmailNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
