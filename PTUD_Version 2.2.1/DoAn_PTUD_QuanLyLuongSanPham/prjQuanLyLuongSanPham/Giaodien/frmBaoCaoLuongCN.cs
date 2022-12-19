using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjQuanLyLuongSanPham.GUI
{
    public partial class frmBaoCaoLuongCN : Form
    {
        public frmBaoCaoLuongCN()
        {
            InitializeComponent();
        }

        private void frmBaoCaoLuongCN_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
