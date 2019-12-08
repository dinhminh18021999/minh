using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        internal static List<byte> typePages = new List<byte>();
        public void ThemTabPages(UserControl uct, byte typeControl, string tenTab)
        {
            // Kiểm tra tồn tại trang này chưa
            for (int i = 0; i < TabHienThi.TabPages.Count; i++)
            {
                if (TabHienThi.TabPages[i].Contains(uct) == true)
                {
                    TabHienThi.SelectedTab = TabHienThi.TabPages[i];
                    return;
                }
            }
            TabPage tab = new TabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = TabHienThi.Size;
            tab.Text = tenTab;
            TabHienThi.TabPages.Add(tab);
            TabHienThi.SelectedTab = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();

        }
        public void DongTabHienTai()
        {
            TabHienThi.TabPages.Remove(TabHienThi.SelectedTab);
        }
        public void DongAllTab()
        {
            while (TabHienThi.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctNhanVien.uctNV, 4, "Quản lý nhân viên ");
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhachHang.uctKH, 4, "Quản lý  khách hàng");
        }

        private void menuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTabHienTai();
        }

        private void menuItemDongTrangAll_Click(object sender, EventArgs e)
        {
            DongAllTab();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn thoát ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
            else
                return;
        }

        private void lựaChọnKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctBan.uctban,4,"Quản lý bàn");
        }
        private void hệThốngKhuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctKhuVuc.uctKV, 4, "Hệ thống khu vực");
        }

        private void mónĂnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctLoaiThucDon.uctLTD,4, "Loại thực đơn");
        }


        private void thứcUốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctThucDon.uctTD, 4, "Danh sách thực đơn");
        }

        private void gọiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctGoiMon.uctGM, 4, "Danh mục gọi món ");
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ThemTabPages(Views.uctHoaDon.uctHD, 4, "Hóa đơn");
        }

        private void phânQuyềnSửDụngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTabPages(Views.uctPhanQuyen.uctPQ, 4, "Phân quyền sử dụng ");
        }

        private void ctxtmenuTabBan_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
