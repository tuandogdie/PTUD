using prjQuanLyLuongSanPham.Model;
using prjQuanLyLuongSanPham.Method;
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
    public partial class frmQLLuongBHXH : Form
    {
        public frmQLLuongBHXH()
        {
            InitializeComponent();
        }
        clsMultiClass MultiClass;
        clsNhanVien NhanVien;
        clsLuongBHXH LuongBHXH;
        private void frmQLLuongBHXH_Load(object sender, EventArgs e)
        {
            MultiClass = new clsMultiClass();
            NhanVien = new clsNhanVien();
            LuongBHXH = new clsLuongBHXH();

            dgvLuongBHXH.DataSource = MultiClass.GetTTLuongBHXH();
            NameColumn();

            LoadNhanVienToCbo();

        }
        private void NameColumn()
        {
            dgvLuongBHXH.Columns[0].HeaderText = "Mã nhân viên";
            dgvLuongBHXH.Columns[0].Width = 150;
            dgvLuongBHXH.Columns[1].HeaderText = "Tên nhân viên";
            dgvLuongBHXH.Columns[1].Width = 500;
            dgvLuongBHXH.Columns[2].HeaderText = "Mã BHXH";
            dgvLuongBHXH.Columns[2].Width = 300;
            dgvLuongBHXH.Columns[3].HeaderText = "Tháng";
            dgvLuongBHXH.Columns[3].Width = 300;
            //dgvLuongBHXH.Columns[4].HeaderText = "Số ngày nghỉ có phép";
            //dgvLuongBHXH.Columns[4].Width = 400;
            //dgvLuongBHXH.Columns[5].HeaderText = "Tổng số ngày nghỉ";
            //dgvLuongBHXH.Columns[5].Width = 400;
            //dgvLuongBHXH.Columns[6].HeaderText = "Tiền nộp BHXH";
            //dgvLuongBHXH.Columns[6].Width = 400;
        }
        public void LoadNhanVienToCbo()
        {
            IEnumerable<tblNhanVien> dsNV = NhanVien.getAllNhanVienHanhChinh();
            cboMaNV.DisplayMember = "maNV";
            cboMaNV.ValueMember = "maNV";
            cboMaNV.DataSource = dsNV;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cboMaNV.Text;
            txtTenNV.Text=NhanVien.getTenTheoMaNV(maNV).ToString();
            txtMaBHYT.Text = LuongBHXH.getMaBHXHTheoMaNV(maNV);
            cboThang.Text=LuongBHXH.getThangTheoMaNV(maNV);
            //txtSoNgayNghiCoPhep.Text = LuongBHXH.getSoNgayNghiCPTheoMaNV(maNV);
            //txtTongNgayNghi.Text = LuongBHXH.getTongNNTheoMaNV(maNV);
            //txtTienNopBHXH.Text = LuongBHXH.getTienNopBHXHTheoMaNV(maNV);
        }
        private void dgvLuongBHXH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvLuongBHXH.Rows[e.RowIndex];
                cboMaNV.Text = row.Cells[0].Value.ToString();
            }
        }

        private void txtTuKhoa__TextChanged(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                dgvLuongBHXH.DataSource = MultiClass.GetTKTTLuongBHXHTheoMaNV(txtTuKhoa.Text);
            else
                dgvLuongBHXH.DataSource = MultiClass.GetTKTTLuongBHXHTheoTenNV(txtTuKhoa.Text);
        }
        private void radTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoMaNV.Checked == true)
                dgvLuongBHXH.DataSource = MultiClass.GetTKTTLuongBHXHTheoMaNV(txtTuKhoa.Text);
        }

        private void radTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoTenNV.Checked == true)
                dgvLuongBHXH.DataSource = MultiClass.GetTKTTLuongBHXHTheoTenNV(txtTuKhoa.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvLuongBHXH.DataSource = MultiClass.GetTTLuongBHXH();
            txtTuKhoa.Text = null;
            cboMaNV.SelectedIndex = 0;
        }
        bool KTDLRong()
        {
            if (txtMaBHYT.Text.Equals("")/* || txtSoNgayNghiCoPhep.Text.Equals("") || txtTongNgayNghi.Text.Equals("") || txtTienNopBHXH.Text.Equals("")*/)
                return true;
            else
                return false;
        }
        tblLuongBHXH TaoLuongBHXH()
        {
            tblLuongBHXH n = new tblLuongBHXH();
            n.maNV = cboMaNV.SelectedValue.ToString();
            n.maBHXH = txtMaBHYT.Text;
            n.thang = int.Parse(cboThang.Text);
            //n.soNgayNghiCoPhep = int.Parse(txtSoNgayNghiCoPhep.Text);
            //n.tongSoNgayNghi = int.Parse(txtTongNgayNghi.Text);
            //n.tienNopBHXH = double.Parse(txtTienNopBHXH.Text);
            return n;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblLuongBHXH n = TaoLuongBHXH();
                LuongBHXH.UpdateLuongBHXH(n);
                MessageBox.Show("Cập nhập thông tin phân công thành công", "Thông báo");
                dgvLuongBHXH.DataSource = MultiClass.GetTTLuongBHXH();
                txtTuKhoa.Text = null;
                cboMaNV.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Bạn chưa nhập thông tin đầy đủ", "Thông báo");
        }
    }
}
