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
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.GoiMon' table. You can move, or remove it, as needed.
            this.goiMonTableAdapter.Fill(this.dataSet1.GoiMon);

            this.reportViewer1.RefreshReport();
        }
    }
}
