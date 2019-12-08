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
    public partial class uctMonDaGoi : UserControl
    {
        public uctMonDaGoi()
        {
            InitializeComponent();
        }
        int flag = 0;
        private void uctMonDaGoi_Load(object sender, EventArgs e)
        {
            HienThiDanhSachGM();
            bingding();
            dis_end(false);
        }
        public void HienThiDanhSachGM()
        {
            dgvGoiMon.DataSource = Models.GoiMonMod.FillDataSetGoiMon().Tables[0];
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            cmbIdBan.DataBindings.Clear();
            cmbIdBan.DataBindings.Add("Text", dgvGoiMon.DataSource, "IdBan");
            cmbTenThucDon.DataBindings.Clear();
            cmbTenThucDon.DataBindings.Add("Text", dgvGoiMon.DataSource, "TenThucDon");
            txtDonGia.DataBindings.Clear();
            txtDonGia.DataBindings.Add("Text", dgvGoiMon.DataSource, "DonGiaTon");
            txtSoLuong.DataBindings.Clear();
            txtSoLuong.DataBindings.Add("Text", dgvGoiMon.DataSource, "SoLuong");
            dtpThoiGian.DataBindings.Clear();
            dtpThoiGian.DataBindings.Add("Text", dgvGoiMon.DataSource, "ThoiGian");

        }
        void loadcontrolBan()
        {
            cmbIdBan.DataSource = Models.GoiMonMod.FillDataSet_getIdBan().Tables[0];
            cmbIdBan.DisplayMember = "IdBan";
            cmbIdBan.ValueMember = "IdBan";
          
        }
        void loadcontroThucDon()
        {
            
            cmbTenThucDon.DataSource = Models.GoiMonMod.FillDataSet_getDonGiaThucDon().Tables[0];
            cmbTenThucDon.DisplayMember = "TenThucDon";
            cmbTenThucDon.ValueMember = "DonGiaTon";


        }
        void clearData()
        {

            loadcontrolBan();
            loadcontroThucDon();
            txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();
            txtSoLuong.Text = "";
        }
        void dis_end(bool e)
        {
            cmbIdBan.Enabled = e;
            cmbTenThucDon.Enabled = e;
            txtDonGia.Enabled = e;
            txtSoLuong.Enabled = e;
            dtpThoiGian.Enabled = e;
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = cmbIdBan.Text;
            }
            catch { }

            string _tenThucDon = "";
            try
            {
                _tenThucDon = cmbTenThucDon.Text;
            }
            catch { }
            decimal _donGia = 0;
            try
            {
                _donGia = Convert.ToInt32(txtDonGia.Text);
            }
            catch { }
            int _soLuong = 0;
            try
            {
                _soLuong = Convert.ToInt32(txtSoLuong.Text);
            }
            catch { }
            DateTime _ThoiGian = DateTime.Now;

            try { }
            catch { }
            decimal _thanhTien = 0;
            try
            {
                _thanhTien = Convert.ToInt32(txtDonGia.Text);
            }
            catch { }
            if (flag == 0)
            {


                if (_soLuong == 0 || _donGia == 0)
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                else
                {
                    int i = 0;
                    i = Controllers.GoiMonCtrl.InSertGoiMon(_idBan, _tenThucDon, _donGia, _soLuong, _ThoiGian,_thanhTien);
                    if (i > 0)
                    {
                        MessageBox.Show("Gọi món thành công");
                        HienThiDanhSachGM();
                    }
                    else
                        MessageBox.Show("Gọi món không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.UpdateGoiMon(_idBan, _tenThucDon, _donGia, _soLuong, _ThoiGian, _thanhTien);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachGM();
                    uctMonDaGoi_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctMonDaGoi_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            flag = 1;
            dis_end(true);
            loadcontroThucDon();
            loadcontrolBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = cmbIdBan.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.GoiMonCtrl.DeleteGoiMon(_idBan);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachGM();
                    uctMonDaGoi_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctMonDaGoi_Load(sender, e);
            dis_end(false);
        }

        private void cmbTenThucDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDonGia.Text = cmbTenThucDon.SelectedValue.ToString();
        }

        private void btnLuu_MouseEnter(object sender, EventArgs e)
        {
            btnLuu.ForeColor = Color.Blue;
        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            btnLuu.ForeColor = SystemColors.ControlText;
        }

        private void dgvGoiMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvGoiMon.CurrentRow.Index;
            cmbIdBan.Text = dgvGoiMon[0, row].Value.ToString();
            cmbTenThucDon.Text = dgvGoiMon[1, row].Value.ToString();
            txtSoLuong.Text = dgvGoiMon[2, row].Value.ToString();
            txtDonGia.Text = dgvGoiMon[3, row].Value.ToString();
            dtpThoiGian.Text = dgvGoiMon[4, row].Value.ToString();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
