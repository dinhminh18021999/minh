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
    public partial class uctDanhSachTD : UserControl
    {
        public uctDanhSachTD()
        {
            InitializeComponent();
        }
        public void HienThiDanhSachTD()
        {
            dgvDanhsachTD.DataSource = Models.ThucDonMod.FillDataSetThucDonNotTTT().Tables[0];
            dgvDanhsachTD.Dock = DockStyle.Fill;
            dgvDanhsachTD.RowHeadersVisible = false;
            dgvDanhsachTD.BorderStyle = BorderStyle.Fixed3D;
        }
        private void uctDanhSachTD_Load(object sender, EventArgs e)
        {
            HienThiDanhSachTD();

        }
    }
}
