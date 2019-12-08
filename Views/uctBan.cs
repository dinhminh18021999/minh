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
    public partial class uctBan : UserControl
    {
        public uctBan()
        {
            InitializeComponent();
        }
        public static uctBan uctban = new uctBan();
        int flag = 0;
        private void uctBan_Load(object sender, EventArgs e)
        {
            HienThiDanhSachBan();
            bingding();
            dis_end(false);
        }
        void bingding()
        {
            txtIdBan.DataBindings.Clear();
            txtIdBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "IdBan");
            //txtIdKhuVuc.DataBindings.Clear();
            //txtIdKhuVuc.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "IdKhuVuc");
            txtTenBan.DataBindings.Clear();
            txtTenBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TenBan");
            txtDienGiaiBan.DataBindings.Clear();
            txtDienGiaiBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "DienGiai");
            cmbTrangThaiBan.DataBindings.Clear();
            cmbTrangThaiBan.DataBindings.Add("Text", dgvDanhSachBan.DataSource, "TrangThai");

        }
        void loadcontrol()
        {
            cmbTrangThaiBan.Items.Clear();
            cmbTrangThaiBan.Items.Add("Bàn trống");
            cmbTrangThaiBan.Items.Add("Bàn có khách");
            cmbTenKhuVuc.DataSource = Models.KhuVucMod.FillDataSet_getTenKhuVuc().Tables[0];
            cmbTenKhuVuc.DisplayMember = "TenKhuVuc";
            
        }
        void clearData()
        {
            txtIdBan.Text = Models.connection.ExcuteScalar(String.Format("select IdBan= dbo.fcgetIdBan()"));
            txtTenBan.Text = "";
            txtDienGiaiBan.Text = "";
            loadcontrol();
        }
        void dis_end(bool e)
        {
            txtTenBan.Enabled = e;
            cmbTenKhuVuc.Enabled = e;
            txtDienGiaiBan.Enabled = e;
            cmbTrangThaiBan.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
        }
        public void HienThiDanhSachBan()
        {
            dgvDanhSachBan.DataSource = Models.BanMod.FillDataSetBan().Tables[0];
            dgvDanhSachBan.Dock = DockStyle.Fill;
            dgvDanhSachBan.RowHeadersVisible = false;
            dgvDanhSachBan.BorderStyle = BorderStyle.Fixed3D;
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            clearData();
            dis_end(true);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctBan_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = txtIdBan.Text;
            }
            catch { }
            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = cmbTenKhuVuc.Text;
            }
            catch { }
            string _tenBan = "";
            try
            {
                _tenBan = txtTenBan.Text;
            }
            catch { }
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiaiBan.Text;
            }
            catch { }
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangThaiBan.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_tenBan == "")
                    MessageBox.Show("Hãy nhập tên bàn");
                else
                {
                    int i = 0;
                    i = Controllers.BanCtrl.InSertBan(_idBan, _tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachBan();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.BanCtrl.UpdateBan(_idBan, _tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachBan();
                    uctBan_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctBan_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idBan = "";
            try
            {
                _idBan = txtIdBan.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.BanCtrl.DeleteBan(_idBan);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachBan();
                    uctBan_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

    }
}
