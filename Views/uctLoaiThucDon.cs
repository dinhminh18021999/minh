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
    public partial class uctLoaiThucDon : UserControl
    {
        public uctLoaiThucDon()
        {
            InitializeComponent();
        }
        public static uctLoaiThucDon uctLTD = new uctLoaiThucDon();
        int flag = 0;
        private void uctLoaiThucDon_Load(object sender, EventArgs e)
        {
            HienThiDanhSachLTD();
            bingding();
            dis_end(false);
        }
        public void HienThiDanhSachLTD()
        {
            dgvDanhSachLTD.DataSource = Models.LoaiThucDonMod.FillDataSetLoaiThucDon().Tables[0];
            dgvDanhSachLTD.RowHeadersVisible = false;
            dgvDanhSachLTD.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            txtIdLTDon.DataBindings.Clear();
            txtIdLTDon.DataBindings.Add("Text", dgvDanhSachLTD.DataSource, "IdLoaiThucDon");
            txtTenLTDon.DataBindings.Clear();
            txtTenLTDon.DataBindings.Add("Text", dgvDanhSachLTD.DataSource, "TenLoaiThucDon");
            txtDienGiaiLTDon.DataBindings.Clear();
            txtDienGiaiLTDon.DataBindings.Add("Text", dgvDanhSachLTD.DataSource, "DienGiai");
            cmbTrangThaiLTDon.DataBindings.Clear();
            cmbTrangThaiLTDon.DataBindings.Add("Text", dgvDanhSachLTD.DataSource, "TrangThai");

        }
        void loadcontrol()
        {
            cmbTrangThaiLTDon.Items.Clear();
            cmbTrangThaiLTDon.Items.Add("Còn hàng");
            cmbTrangThaiLTDon.Items.Add("Đã hết");
            cmbTrangThaiLTDon.Items.Add("Sắp hết");

        }
        void clearData()
        {
            txtIdLTDon.Text = Models.connection.ExcuteScalar(String.Format("select IdLoaiThucDon= dbo.fcgetIdLoaiThucDon()"));
            txtTenLTDon.Text = "";
            txtDienGiaiLTDon.Text = "";
            loadcontrol();
        }
        void dis_end(bool e)
        {
            txtTenLTDon.Enabled = e;
            txtDienGiaiLTDon.Enabled = e;
            cmbTrangThaiLTDon.Enabled = e;
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
            uctLoaiThucDon_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idLTD = "";
            try
            {
                _idLTD = txtIdLTDon.Text;
            }
            catch { }
            string _tenLTD = "";
            try
            {
                _tenLTD = txtTenLTDon.Text;
            }
            catch { }
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiaiLTDon.Text;
            }
            catch { }
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangThaiLTDon.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_tenLTD == "")
                    MessageBox.Show("Hãy nhập tên loại thực đơn");
                else
                {
                    int i = 0;
                    i = Controllers.LoaiThucDonCtrl.InsertLoaiThucDon(_idLTD,_tenLTD,_dienGiai,_trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachLTD();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.UpdateLoaiThucDon(_idLTD, _tenLTD, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachLTD();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctLoaiThucDon_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idLTD = "";
            try
            {
                _idLTD = txtIdLTDon.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.LoaiThucDonCtrl.DeleteLoaiThucDon(_idLTD);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachLTD();
                    uctLoaiThucDon_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

    }
}
