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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private clsNhanVien nv; 
        

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dateTimengaysinh.Format = DateTimePickerFormat.Custom;
            dateTimengaysinh.CustomFormat = "dd/MM/yyyy";
            nv = new clsNhanVien();
            dgrnhanvien.DataSource = nv.getAllNhanvien();
            dgrnhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgrnhanvien.Columns[1].HeaderText = "Tên nhân viên";
            dgrnhanvien.Columns[2].HeaderText = "Giới tính";
            dgrnhanvien.Columns[3].HeaderText = "Ngày sinh";
            dgrnhanvien.Columns[4].HeaderText = "Email";
            dgrnhanvien.Columns[5].HeaderText = "Số điện thoại";
            dgrnhanvien.Columns[6].HeaderText = "Đơn vị quản lý";
            dgrnhanvien.Columns[7].HeaderText = "Loại nhân viên";
        }

        

        private void dgrnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgrnhanvien.Rows[e.RowIndex];

                tbxmanv.Text = row.Cells[0].Value.ToString();
                tbxtennv.Text = row.Cells[1].Value.ToString();
                tbxgioitinh.Text = row.Cells[2].Value.ToString();
                dateTimengaysinh.Text = row.Cells[3].Value.ToString();
                tbxemail.Text = row.Cells[4].Value.ToString();
                tbxsdt.Text = row.Cells[5].Value.ToString();
                tbxdonviquanly.Text = row.Cells[6].Value.ToString();
                cbxloainhanvien.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblNhanVien n = TaoNhanVien();
                if (nv.CheckIfExist(n.maNV) != null)
                    MessageBox.Show("Mã Nhân viên đã tồn tại", "Thông báo");
                else
                {
                    nv.insertNhanVien(n);
                    MessageBox.Show("Nhân viên đã thêm thành công", "Thông báo");
                    dgrnhanvien.DataSource = nv.getAllNhanvien();
                    ClearTexbox();
                   
                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }

        
        public bool KTDLRong()
        {
            if ((tbxmanv.Text.Equals("") || tbxtennv.Text.Equals("") || tbxgioitinh.Text.Equals("") || dateTimengaysinh.Text.Equals("") || tbxemail.Text.Equals("") || tbxsdt.Text.Equals("") || tbxdonviquanly.Text.Equals("") || cbxloainhanvien.Text.Equals("")))
                return true;
            else
                return false;
        }
        
        tblNhanVien TaoNhanVien()
        {
            tblNhanVien n = new tblNhanVien();
            n.maNV = tbxmanv.Text;
            n.hoTen= tbxtennv.Text;
            n.gioiTinh = tbxgioitinh.Text;
            n.ngaySinh = dateTimengaysinh.Value;
            n.email = tbxemail.Text;
            n.soDienThoai = tbxsdt.Text;
            n.donViQuanLy = tbxdonviquanly.Text;
            n.loaiNV = cbxloainhanvien.Text;
            return n;
        }
        private void ClearTexbox()
        {
            tbxmanv.Text = null;
            tbxtennv.Text = null;
            tbxsdt.Text = null;
            tbxgioitinh.Text = null;
            tbxemail.Text = null;
            tbxdonviquanly.Text = null;
            cbxloainhanvien.Text = null;
            dateTimengaysinh.Value = DateTime.Now;

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           nv = new clsNhanVien();
            if (KTDLRong() == false)
            {
                tblNhanVien n = TaoNhanVien();
                nv.UpdateNhanVien(n);
                MessageBox.Show("Cập nhập thông tin Nhân viên thành công", "Thông báo");
                dgrnhanvien.DataSource = nv.getAllNhanvien();
                ClearTexbox();
                
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }

        
    }
}
