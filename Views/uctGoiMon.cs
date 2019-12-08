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
    public partial class uctGoiMon : UserControl
    {
        public uctGoiMon()
        {
            InitializeComponent();
        }
        
        public static uctGoiMon uctGM = new uctGoiMon();
       
        public DataTable getBan()
        {
            DataTable dt = new DataTable();
            dt = Models.BanMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            return dt;

        }
        public DataTable getBanDaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBan_GoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;

        }
        public DataTable getBanChuaGoi()
        {
            DataTable dt = new DataTable();
            dt = Models.GoiMonMod.FillDataSetDanhSachBan_ChuaGoiMon().Tables[0];
            dgvGoiMon.DataSource = dt;
            return dt;
        }
        private void uctGoiMon_Load(object sender, EventArgs e)
        {
            uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            ShowListView();
            dgvGoiMon.Dock = DockStyle.Fill;
            dgvGoiMon.RowHeadersVisible = false;
            dgvGoiMon.BorderStyle = BorderStyle.Fixed3D;
            lblTongTien.Text = "";
        }
        public void ShowListView()
        {
            lvDanhSachBan.Items.Clear();
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);
            }
            DataTable dt2 = new DataTable();
            dt2 = getBanChuaGoi();
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt2.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt2.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt2.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 0;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);

            }
        }
        public void BanCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanDaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem.ListViewSubItem subItem = new ListViewItem.ListViewSubItem(item, dt.Rows[i][0].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.ImageIndex = 1;
                item.SubItems.Add(subItem);
                lvDanhSachBan.Items.Add(item);

            }
        }
        public void BanChuaCoNguoi()
        {
            DataTable dt = new DataTable();
            dt = getBanChuaGoi();
            dgvGoiMon.DataSource = dt;
            lvDanhSachBan.Items.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem(dt.Rows[i]["Tên Bàn"].ToString());
                ListViewItem Status = new ListViewItem(dt.Rows[i]["Id Bàn"].ToString());
                item.SubItems.Add(dt.Rows[i]["Id Bàn"].ToString());
                lvDanhSachBan.Items.Add(item);
                item.ImageIndex = 0;
            }
        }
        public void ThemBanMoi()
        {
            uctBan uctban = new uctBan();
            uctban.Show();
            
        }
        private void thêmBànMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemBanMoi();
        }

        private void hiểnThịBànChưaCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanChuaCoNguoi();
        }

        private void hiểnThịBànCóNgườiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanCoNguoi();
        }

        private void hiểnThịTấtCảBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            uctGoiMon_Load(sender, e);
        }
        private void lvDanhSachBan_Click(object sender, EventArgs e)
        {
            string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
            dgvGoiMon.DataSource = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan(_IdBan).Tables[0];
            //dgvBanHD.DataSource = Controllers.HoaDonCtrl.FillDataSet_getHoaDonByIdBan(_IdBan).Tables[0];
            string _tenBan = lvDanhSachBan.SelectedItems[0].SubItems[0].Text;
            label1.Text = _tenBan.ToString();
            label1.Hide();
            tinhtien();
        }
        public void tinhtien()
        {
           
            try
            {
                int tien = dgvGoiMon.Rows.Count;
                decimal thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    thanhtien += decimal.Parse(dgvGoiMon.Rows[i].Cells["Thành Tiền"].Value.ToString());
                }
                lblTongTien.Text = thanhtien.ToString("#,###") + " VND";
                lblTongTien.ForeColor = SystemColors.HotTrack;
            }
            catch 
            {
                //MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult ok = new DialogResult();
                ok = MessageBox.Show("Bạn có muốn tính tiền " + label1.Text + " Không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               
                if (ok == DialogResult.Yes)
                {
                    MessageBox.Show("TỔNG SỐ TIỀN THANH TOÁN CỦA " +" [ "+ label1.Text + " ] "+ " LÀ " +lblTongTien.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    tinhtien();
                    uctMonDaGoi uctMDG = new uctMonDaGoi();
                    nhung(uctMDG);
                    string _IdBan = lvDanhSachBan.SelectedItems[0].SubItems[1].Text;
                    dgvGoiMon.DataSource = Controllers.GoiMonCtrl.DeleteGoiMon(_IdBan);
                    uctGoiMon_Load(sender, e);
                }
                else
                {
                    return;
                }
            }
            catch { MessageBox.Show("Bạn chưa chọn bàn thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            uctGoiMon_Load(sender, e);
        }
        public void nhung(Control ctr)
        {
            pnlGoiMon.Controls.Clear();
            pnlGoiMon.BorderStyle = BorderStyle.Fixed3D;
            ctr.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(ctr);
            pnlGoiMon.Show();
        }
        public void nhungFrom(Form frm)
        {
          
            pnlGoiMon.Controls.Clear();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.Dock = DockStyle.Fill;
            pnlGoiMon.Controls.Add(frm);
            pnlGoiMon.Show();
        }
        private void lvDanhSachBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvDanhSachBan.SelectedItems.Count==0)
            {
                return;
            }
            else
            {
                
            }
        }

        private void btnGoimon_Click(object sender, EventArgs e)
        {
            uctMonDaGoi uctMDG = new uctMonDaGoi();
            uctGoiMon_Load(sender, e); 
            nhung(uctMDG);   
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            uctDanhSachTD uctDSTD = new uctDanhSachTD();
            nhung(uctDSTD);
            uctGoiMon_Load(sender, e);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmThanhToan _frmThanhToan = new frmThanhToan();
            nhungFrom(_frmThanhToan);
        }


    }
}
