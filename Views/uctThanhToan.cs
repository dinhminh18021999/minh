using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SoftQuanLyNhaHang.Controllers;
namespace SoftQuanLyNhaHang.Views
{
    public partial class uctThanhToan : UserControl
    {
        public uctThanhToan()
        {
            InitializeComponent();
        }
        public void inHD()
        {
            //DataSet ds = new DataSet();
            //ds = Controllers.GoiMonCtrl.FillDataSet_getGoiMonByIdBan("@IdBan").Tables[0];
            DataTable dt = new DataTable();
            dt = Models.HoaDonMod.FillDataSetHoaDon().Tables[0];
        }

        private void uctThanhToan_Load(object sender, EventArgs e)
        {

        }

        public string _idBan { get; set; }
    }
}
