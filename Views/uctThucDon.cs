using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctThucDon : UserControl
    {
        public uctThucDon()
        {
            InitializeComponent();
        }
        public static uctThucDon uctTD = new uctThucDon();
        int flag = 0;
        private void uctThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTD();
            bingding();
            dis_end(false);
        }
        public void HienThiDanhSachTD()
        {
            dgvDanhsachTD.DataSource = Models.ThucDonMod.FillDataSetThucDon();
            dgvDanhsachTD.RowHeadersVisible = false;
            dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            txtIdTD.DataBindings.Clear();
            txtIdTD.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "IdThucDon");
            cmbTenLTD.DataBindings.Clear();
            cmbTenLTD.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "TenLoaiThucDon");
            txtTenTD.DataBindings.Clear();
            txtTenTD.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "TenThucDon");
            txtDonvitinh.DataBindings.Clear();
            txtDonvitinh.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "DonViTinh");
            txtSoluongton.DataBindings.Clear();
            txtSoluongton.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "SoLuongTon");
            txtDongiaton.DataBindings.Clear();
            txtDongiaton.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "DonGiaTon");
            txtTontoithieu.DataBindings.Clear();
            txtTontoithieu.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "TonToiThieu");
            cmbTrangthai.DataBindings.Clear();
            cmbTrangthai.DataBindings.Add("Text", dgvDanhsachTD.DataSource, "TrangThai");
        }
        void loadcontrol()
        {
            cmbTrangthai.Items.Clear();
            cmbTrangthai.Items.Add("Còn hàng");
            cmbTrangthai.Items.Add("Đã hết");
            cmbTenLTD.DataSource = Models.LoaiThucDonMod.FillDataSet_getTenLoaiThucDon().Tables[0];
            cmbTenLTD.DisplayMember = "TenLoaiThucDon";
            //cmbTenLTD.ValueMember = "IdLoaiThucDon";

        }
        void clearData()
        {
            txtIdTD.Text = Models.connection.ExcuteScalar(String.Format("select IdThucDon= dbo.fcgetIdThucDon()"));
            txtTenTD.Text = "";
            txtDonvitinh.Text = "";
            txtSoluongton.Text = "";
            txtDongiaton.Text = "";
            txtTontoithieu.Text = "";
            loadcontrol();
        }
        void dis_end(bool e)
        {
            cmbTenLTD.Enabled = e;
            txtTenTD.Enabled = e;
            txtDonvitinh.Enabled = e;
            txtSoluongton.Enabled = e;
            txtDongiaton.Enabled = e;
            txtTontoithieu.Enabled = e;
            cmbTrangthai.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idTD = "";
            try
            {
                _idTD = txtIdTD.Text;
            }
            catch { }
            string _tenLTD = "";
            try
            {
                _tenLTD = cmbTenLTD.Text;
            }
            catch { }
            string _tenThucDon = "";
            try
            {
                _tenThucDon = txtTenTD.Text;
            }
            catch { }
            string _donViTinh = "";
            try
            {
                _donViTinh = txtDonvitinh.Text;
            }
            catch { }
            float _soLuongTon = 0;
            try
            {
                _soLuongTon = Convert.ToInt32(txtSoluongton.Text);
            }
            catch { }
            float _donGiaTon = 0;
            try
            {
                _donGiaTon = Convert.ToInt32(txtDongiaton.Text);
            }
            catch { }
            float _tonToiThieu = 0;
            try
            {
                _tonToiThieu = Convert.ToInt32(txtTontoithieu.Text);
            }
            catch { }
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangthai.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_tenThucDon == "")
                    MessageBox.Show("Hãy nhập tên thực đơn");
                else
                {
                    int i = 0;
                    i = Controllers.ThucDonCtrl.InsertThucDon(_idTD, _tenLTD,_tenThucDon,_donViTinh,_soLuongTon,_donGiaTon,_tonToiThieu,_trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachTD();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.ThucDonCtrl.UpdateThucDon(_idTD, _tenLTD, _tenThucDon, _donViTinh, _soLuongTon, _donGiaTon, _tonToiThieu, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachTD();
                    uctThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctThucDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idTD = "";
            try
            {
                _idTD = txtIdTD.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.ThucDonCtrl.DeleteThucDon(_idTD);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachTD();
                    uctThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }
    }
}
