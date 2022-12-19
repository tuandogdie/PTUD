using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjQuanLyLuongSanPham.Model;
using prjQuanLyLuongSanPham.Method;

namespace prjQuanLyLuongSanPham.GUI
{
    public partial class frmQDTangLuong : Form
    {
        clsQuyetDinhTangLuong qd = new clsQuyetDinhTangLuong();

        public frmQDTangLuong()
        {
            InitializeComponent();
        }

        private void dgrQdTangLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgrQdTangLuong.Rows[e.RowIndex];
                tbxmaqd.Text = row.Cells[0].Value.ToString();
                tbxluongTangTheoQD.Text = row.Cells[1].Value.ToString();
                tbxnoidungqd.Text = row.Cells[2].Value.ToString();
            }
        }

        private void frmQDTangLuong_Load(object sender, EventArgs e)
        {
            dgrQdTangLuong.DataSource = qd.getAllQuyetDinhTL();
            dgrQdTangLuong.Columns[0].HeaderText = "Mã quuyết định";
            dgrQdTangLuong.Columns[1].HeaderText = "Lương tăng theo quyết định";
            dgrQdTangLuong.Columns[2].HeaderText = "Nội dung quyết định";
        }
    }
}
