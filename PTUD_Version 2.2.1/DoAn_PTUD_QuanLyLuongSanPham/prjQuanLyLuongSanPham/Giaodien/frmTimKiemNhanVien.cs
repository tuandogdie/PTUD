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
    public partial class frmTimKiemNhanVien : Form
    {
        public frmTimKiemNhanVien()
        {
            InitializeComponent();
        }
        clsMultiClass Multiclass;
        private void frmTimKiemNhanVien_Load(object sender, EventArgs e)
        {
            Multiclass = new clsMultiClass();
            cboLoaiNV.SelectedIndex = 0;
            
        }
        private void NameColumnCN()
        {
            dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvTK.Columns[0].HeaderText = "Mã nhân viên";
            dgvTK.Columns[1].HeaderText = "Họ tên";
            dgvTK.Columns[2].HeaderText = "Giới tính";
            dgvTK.Columns[3].HeaderText = "Ngày sinh";
            dgvTK.Columns[4].HeaderText = "Số điện thoại";
            dgvTK.Columns[5].HeaderText = "Email";
        }
        private void NameColumnNVHC()
        {
            dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dgvTK.Columns[0].HeaderText = "Mã nhân viên";
            dgvTK.Columns[1].HeaderText = "Họ tên";
            dgvTK.Columns[2].HeaderText = "Giới tính";
            dgvTK.Columns[3].HeaderText = "Ngày sinh";
            dgvTK.Columns[4].HeaderText = "Số điện thoại";
            dgvTK.Columns[5].HeaderText = "Email";
            dgvTK.Columns[6].HeaderText = "Trình độ học vấn";
            dgvTK.Columns[7].HeaderText = "Ngoại ngữ";
            dgvTK.Columns[8].HeaderText = "Ngày bắt đầu tham gia công tác";
        }

        private void txttenNV__TextChanged(object sender, EventArgs e)
        {
            string maNV = "", tenNV = "", sdt = "";
            if (!string.IsNullOrEmpty(txtMaNV.Text))
                maNV = txtMaNV.Text;
            if (!string.IsNullOrEmpty(txtTenNV.Text))
                tenNV = txtTenNV.Text;
            if (!string.IsNullOrEmpty(txtSDT.Text))
                sdt = txtSDT.Text;

            if (cboLoaiNV.SelectedIndex == 0)
            {
                dgvTK.DataSource = Multiclass.GetTKCN(maNV, tenNV, sdt);
                NameColumnCN();
            }
            if (cboLoaiNV.SelectedIndex==1)
            {
                dgvTK.DataSource = Multiclass.GetTKNVHC(maNV, tenNV, sdt);
                NameColumnNVHC();
            }   
        }

        private void cboLoaiNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiNV.SelectedIndex == 0)
            {
                dgvTK.DataSource = Multiclass.GetTKCNFull();
                NameColumnCN();
            }
            if (cboLoaiNV.SelectedIndex == 1)
            {     
                dgvTK.DataSource = Multiclass.GetTKNVHCFull();
                NameColumnNVHC();
            }
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (cboLoaiNV.SelectedIndex == 0)
            {
                dgvTK.DataSource = Multiclass.GetTKCNFull();
                NameColumnCN();
            }
            if (cboLoaiNV.SelectedIndex == 1)
            {
                dgvTK.DataSource = Multiclass.GetTKNVHCFull();
                NameColumnNVHC();
            }
        }
    }
}
