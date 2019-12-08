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
    public partial class uctKhuVuc : UserControl
    {
        public uctKhuVuc()
        {
            InitializeComponent();
        }
        public static uctKhuVuc uctKV = new uctKhuVuc();
        int flag = 0;
        private void uctKhuVuc_Load(object sender, EventArgs e)
        {
            dis_end(false);
            HienThiDanhSachKhuVuc();
            bingding();
        }

        //private void dgvDanhSachKV_Click(object sender, EventArgs e)
        //{
        //    DataSet ds = new DataSet();
        //    try
        //    {
        //        //int i = 0;
        //        //i = dgvDanhSachKV.CurrentRow.Index;
        //        //string _idKhuVuc = dgvDanhSachKV.Rows[i].Cells[0].Value.ToString();
        //        //ds = Controllers.KhuVucCtrl.FillDataSet_getKhuVucByIdKhuVuc(_idKhuVuc);
        //        //txtIdKhuVuc.DataBindings.Clear();
        //        //txtIdKhuVuc.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "IdKhuVuc");
        //        //txtTenKV.DataBindings.Clear();
        //        //txtTenKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "TenKhuVuc");
        //        //txtDienGiaiKV.DataBindings.Clear();
        //        //txtDienGiaiKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "DienGiai");
        //        //cmbTrangThaiKV.DataBindings.Clear();
        //        //cmbTrangThaiKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "TrangThai");

        //    }
        //    catch { }
        //}
        public void HienThiDanhSachKhuVuc()
        {
            dgvDanhSachKV.DataSource = Models.KhuVucMod.FillDataSetKhuVuc().Tables[0];
            dgvDanhSachKV.Dock = DockStyle.Fill;
            dgvDanhSachKV.RowHeadersVisible = false;
            dgvDanhSachKV.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            txtIdKhuVuc.DataBindings.Clear();
            txtIdKhuVuc.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "IdKhuVuc");
            txtTenKV.DataBindings.Clear();
            txtTenKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "TenKhuVuc");
            txtDienGiaiKV.DataBindings.Clear();
            txtDienGiaiKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "DienGiai");
            cmbTrangThaiKV.DataBindings.Clear();
            cmbTrangThaiKV.DataBindings.Add("Text", dgvDanhSachKV.DataSource, "TrangThai");

        }
        void loadcontrol()
        {
            cmbTrangThaiKV.Items.Clear();
            cmbTrangThaiKV.Items.Add("Hoạt động");
            cmbTrangThaiKV.Items.Add("Ngừng hoạt động");
            cmbTrangThaiKV.Items.Add("Đang nâng cấp");
        }
        void clearData()
        {
            txtIdKhuVuc.Text = Models.connection.ExcuteScalar(String.Format("select IdKhuVuc= dbo.fcgetIdKhuVuc()"));
            txtTenKV.Text = "";
            txtDienGiaiKV.Text = "";
            loadcontrol();
        }
        void dis_end(bool e)
        {
            //txtIdKhachHang.Enabled = e;
            txtTenKV.Enabled = e;
            txtDienGiaiKV.Enabled = e;
            cmbTrangThaiKV.Enabled = e;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idKhuVuc = "";
            try
            {
                _idKhuVuc = txtIdKhuVuc.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.KhuVucCtrl.DeleteKhuVuc(_idKhuVuc);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachKhuVuc();
                    uctKhuVuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idKhuVuc = "";
            try
            {
                _idKhuVuc = txtIdKhuVuc.Text;
            }
            catch { }

            string _tenKhuVuc = "";
            try
            {
                _tenKhuVuc = txtTenKV.Text;
            }
            catch { }
            string _dienGiai = "";
            try
            {
                _dienGiai = txtDienGiaiKV.Text;
            }
            catch { }
            string _trangThai = "";
            try
            {
                _trangThai = cmbTrangThaiKV.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (_tenKhuVuc =="")
                    MessageBox.Show("Hãy nhập tên khu vực");
                else
                {
                    int i = 0;
                    i = Controllers.KhuVucCtrl.InSertKhuVuc(_idKhuVuc,_tenKhuVuc,_dienGiai,_trangThai);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachKhuVuc();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.KhuVucCtrl.UpdateKhuVuc(_idKhuVuc, _tenKhuVuc, _dienGiai, _trangThai);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachKhuVuc();
                    uctKhuVuc_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctKhuVuc_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctKhuVuc_Load(sender, e);
            dis_end(false);
        }
       

    }
}
