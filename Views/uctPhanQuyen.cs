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
    public partial class uctPhanQuyen : UserControl
    {
        public uctPhanQuyen()
        {
            InitializeComponent();
        }
        public static uctPhanQuyen uctPQ = new uctPhanQuyen();
        int flag = 0;
        public void HienThiDanhSachPQ()
        {
            dgvPhanQuyen.DataSource = Models.PhanQuyenMod.FillDataSetPhanQuyen().Tables[0];
            dgvPhanQuyen.RowHeadersVisible = false;
            dgvPhanQuyen.BorderStyle = BorderStyle.Fixed3D;
        }
        void bingding()
        {
            txtMaTK.DataBindings.Clear();
            txtMaTK.DataBindings.Add("Text", dgvPhanQuyen.DataSource, "Id Tài Khoản");
            txtMatKhau.DataBindings.Clear();
            txtMatKhau.DataBindings.Add("Text", dgvPhanQuyen.DataSource, "Mật Khẩu");
            txtTenNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Add("Text", dgvPhanQuyen.DataSource, "Họ Tên");
            

        }
        void loadcontrol()
        {
            cmmbIdNhanVien.DataSource = Models.NhanVienMod.FillDataSetNhanVien().Tables[0];
            cmmbIdNhanVien.DisplayMember = "IdNhanVien";
            cmmbIdNhanVien.ValueMember = "IdNhanVien";

        }
        void clearData()
        {
            txtMaTK.Text = Models.connection.ExcuteScalar(String.Format("select IdTaiKhoan= dbo.fcgetIdPhanQuyen()"));
            loadcontrol();
            txtTenNhanVien.Text = cmmbIdNhanVien.SelectedValue.ToString();
            txtMatKhau.Text = "";
        }
        void dis_end(bool e)
        {
            txtMatKhau.Enabled = e;
            cmmbIdNhanVien.Enabled = e;
            btnLuu.Enabled = e;
            btnHuy.Enabled = e;
            btnThemMoi.Enabled = !e;
            btnXoa.Enabled = !e;
            btnSua.Enabled = !e;
            grpPhanQuyen.Enabled = e;
        }
        private void uctPhanQuyen_Load(object sender, EventArgs e)
        {
            HienThiDanhSachPQ();
            dis_end(false);
            bingding();
        }

        private void cmmbIdNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNhanVien.Text = cmmbIdNhanVien.SelectedValue.ToString();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            flag = 0;
            dis_end(true);
            clearData();
            loadcontrol();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = 1;
            dis_end(true);
            loadcontrol();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            uctPhanQuyen_Load(sender, e);
            dis_end(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string _idTk = "";
            try
            {
                _idTk = txtMaTK.Text;
            }
            catch { }
            string _matKhau = "";
            try
            {
                _matKhau = txtMatKhau.Text;
            }
            catch { }
            string _idNhanVien = "";
            try
            {
                _idNhanVien = cmmbIdNhanVien.Text;
            }
            catch { }
            string _tenNhanVien = "";
            try
            {
                _tenNhanVien = txtTenNhanVien.Text;
            }
            catch { }
            if (flag == 0)
            {


                if (txtMatKhau.Text == "")
                    MessageBox.Show("Hãy nhập mật khẩu");
                else
                {
                    int i = 0;
                    i = Controllers.PhanQuyenCtrl.InsertPhanQuyen(_idTk,_matKhau,_idNhanVien);
                    if (i > 0)
                    {
                        MessageBox.Show("Thêm mới thành công");
                        HienThiDanhSachPQ();
                    }
                    else
                        MessageBox.Show("Thêm mới không thành công");
                }
            }
            else
            {
                int i = 0;
                i = Controllers.PhanQuyenCtrl.UpdatePhanQuyen(_idTk, _matKhau, _idNhanVien);
                if (i > 0)
                {
                    MessageBox.Show(" Sửa thành công");
                    HienThiDanhSachPQ();
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            uctPhanQuyen_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string _idTk = "";
            try
            {
                _idTk = txtMaTK.Text;
            }
            catch { }
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn xóa ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                int i = 0;
                i = Controllers.PhanQuyenCtrl.DeletePhanQuyen(_idTk);
                if (i > 0)
                {
                    MessageBox.Show(" Xóa thành công");
                    HienThiDanhSachPQ();
                    uctPhanQuyen_Load(sender, e);
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
            else
                return;
        }
    }
}
