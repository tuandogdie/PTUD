using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjQuanLyLuongSanPham.Method;

namespace prjQuanLyLuongSanPham.GUI
{
    public partial class frmChucVu : Form
    {

        clsChucVu chucvu = new clsChucVu();
        public frmChucVu()
        {
            InitializeComponent();
        }

        private void frmChucVu_Load(object sender, EventArgs e)
        {
            dgrPhuCapChucVu.DataSource = chucvu.getAllChucVu();
            dgrPhuCapChucVu.Columns[0].HeaderText = "Mã chức vụ";
            dgrPhuCapChucVu.Columns[1].HeaderText = "Tên chức vụ";
            dgrPhuCapChucVu.Columns[2].HeaderText = "Phụ cấp";
        }

        private void dgrPhuCapChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgrPhuCapChucVu.Rows[e.RowIndex];
                tbxmachucvu.Text = row.Cells[0].Value.ToString();
                tbxtenchucvu.Text = row.Cells[1].Value.ToString();
                tbxphucap.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
