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
using prjQuanLyLuongSanPham.Model;
using prjQuanLyLuongSanPham.Controls;

namespace prjQuanLyLuongSanPham
{
    public partial class frmCongDoan : Form
    {
        public frmCongDoan()
        {
            InitializeComponent();
        }
        clsMultiClass MultiClass;
        clsCongDoan CongDoan;
        clsSanPham SanPham;
        private void frmCongDoan_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;

            MultiClass = new clsMultiClass();
            CongDoan = new clsCongDoan();
            SanPham = new clsSanPham();

            LoadSanPhamToCbo();

            dgvCongDoan.DataSource = MultiClass.GetTTCongDoan();
            NameColumn();
        }
        private void NameColumn()
        {
            dgvCongDoan.Columns[0].HeaderText = "Mã công đoạn";
            dgvCongDoan.Columns[1].HeaderText = "Tên công đoạn";
            dgvCongDoan.Columns[2].HeaderText = "Sản phẩm";
            dgvCongDoan.Columns[3].HeaderText = "Thứ tự công đoạn";
            dgvCongDoan.Columns[4].HeaderText = "Đơn giá";
        }
        public void LoadSanPhamToCbo()
        {
            IEnumerable<tblSanPham> dsSP = SanPham.getAllSanPham();
            cboSanPham.DisplayMember = "tenSanPham";
            cboSanPham.ValueMember = "maSP";
            cboSanPham.DataSource = dsSP;
        }
        private void dgvCongDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCongDoan.Rows[e.RowIndex];
                txtMaCD.Text = row.Cells[0].Value.ToString();
                txtTenCD.Text = row.Cells[1].Value.ToString();
                cboSanPham.Text = row.Cells[2].Value.ToString();
                txtThuTuCD.Text = row.Cells[3].Value.ToString();
                txtDonGia.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblCongDoan n = TaoCongDoan();
                if (SanPham.CheckIfExist(n.maCD) != null)
                    MessageBox.Show("Mã công đoạn đã tồn tại", "Thông báo");
                else
                {
                    CongDoan.insertCongDoan(n);
                    MessageBox.Show("Công đoạn đã thêm thành công", "Thông báo");
                    dgvCongDoan.DataSource = MultiClass.GetTTCongDoan();
                    ClearTexbox();
                    btnXoa.Enabled = false;
                    btnCapNhat.Enabled = false;
                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }
        bool KTDLRong()
        {
            if ((txtMaCD.Text.Equals("") || txtTenCD.Text.Equals("") || txtThuTuCD.Text.Equals("") || txtDonGia.Text.Equals("")))
                return true;
            else
                return false;
        }
        void ClearTexbox()
        {
            txtMaCD.Text = null;
            txtTenCD.Text = null;
            txtThuTuCD.Text = null;
            txtDonGia.Text = null;
            cboSanPham.SelectedIndex = 0;
        }
        tblCongDoan TaoCongDoan()
        {
            tblCongDoan n = new tblCongDoan();
            n.maCD = txtMaCD.Text;
            n.tenCongDoan = txtTenCD.Text;
            n.maSP = cboSanPham.SelectedValue.ToString();
            n.thuTuCongDoan = int.Parse(txtThuTuCD.Text);
            n.donGia = double.Parse(txtDonGia.Text);
            n.soCongDoanCoTheLam = SanPham.getSoLuongSPTheoMa(cboSanPham.SelectedValue.ToString());
            return n;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblCongDoan n = TaoCongDoan();
                CongDoan.UpdateCongDoan(n);
                MessageBox.Show("Cập nhập thông tin công đoạn thành công", "Thông báo");
                dgvCongDoan.DataSource = MultiClass.GetTTCongDoan();
                ClearTexbox();
                btnXoa.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn chắc chắn xóa?", "Hỏi xóa",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                IEnumerable<tblCongDoan> cD = CongDoan.getCongDoanTheoMa(txtMaCD.Text);
                int check = CongDoan.DeleteCongDoan(cD.First());
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvCongDoan.DataSource = MultiClass.GetTTCongDoan();
                    ClearTexbox();
                    btnXoa.Enabled = false;
                    btnCapNhat.Enabled = false;
                }
                else
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
            }
        }

        private void txtMaCD__TextChanged(object sender, EventArgs e)
        {
            if (CongDoan.CheckIfExist(txtMaCD.Text) == null)
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

    }
}
