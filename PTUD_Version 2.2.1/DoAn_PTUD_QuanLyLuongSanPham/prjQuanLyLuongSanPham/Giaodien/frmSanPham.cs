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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        clsMultiClass MultiClass;
        clsHopDong HopDong;
        clsSanPham SanPham;

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            btnCapNhat.Enabled = false;

            MultiClass = new clsMultiClass();
            HopDong = new clsHopDong();
            SanPham = new clsSanPham();

            LoadHopDongToCbo();

            dgvSanPham.DataSource = MultiClass.GetTTSanPham();
            NameColumn();
        }
        private void NameColumn()
        {
            dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
            dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns[2].HeaderText = "Hợp đồng";
            dgvSanPham.Columns[3].HeaderText = "Loại sản phẩm";
            dgvSanPham.Columns[4].HeaderText = "Đơn vị tính";
            dgvSanPham.Columns[5].HeaderText = "Đơn giá";
            dgvSanPham.Columns[6].HeaderText = "Số lượng";
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnCapNhat.Enabled = true;
            btnXoa.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvSanPham.Rows[e.RowIndex];
                txtMaSP.Text = row.Cells[0].Value.ToString();
                txtTenSP.Text = row.Cells[1].Value.ToString();
                cboHopDong.Text = row.Cells[2].Value.ToString();
                txtLoaiSP.Text = row.Cells[3].Value.ToString();
                txtDonViTinh.Text = row.Cells[4].Value.ToString();
                txtDonGia.Text = row.Cells[5].Value.ToString();
                txtSoLuong.Text=row.Cells[6].Value.ToString();
            }
        }
        public void LoadHopDongToCbo()
        {
            IEnumerable<tblHopDong> dsHP = HopDong.getAllHopDong();
            cboHopDong.DisplayMember = "tenHopDong";
            cboHopDong.ValueMember = "maHD";
            cboHopDong.DataSource = dsHP;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblSanPham n = TaoSanPham();
                if (SanPham.CheckIfExist(n.maSP) != null)
                    MessageBox.Show("Mã sản phẩm đã tồn tại", "Thông báo");
                else
                {
                    SanPham.insertSanPham(n);
                    MessageBox.Show("Sản phẩm đã thêm thành công", "Thông báo");
                    dgvSanPham.DataSource = MultiClass.GetTTSanPham();
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
            if ((txtMaSP.Text.Equals("") || txtTenSP.Text.Equals("") || txtLoaiSP.Text.Equals("") || txtDonViTinh.Text.Equals("") || txtDonGia.Text.Equals("") || txtSoLuong.Text.Equals("")))
                return true;
            else
                return false;
        }
        tblSanPham TaoSanPham()
        {
            tblSanPham n = new tblSanPham();
            n.maSP = txtMaSP.Text;
            n.tenSanPham = txtTenSP.Text;
            n.maHD = cboHopDong.SelectedValue.ToString();
            n.loaiSanPham = txtLoaiSP.Text;
            n.donViTinh = txtDonViTinh.Text;
            n.donGia = double.Parse(txtDonGia.Text);
            n.soLuong = int.Parse(txtSoLuong.Text);
            return n;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblSanPham n = TaoSanPham();
                SanPham.UpdateSanPham(n);
                MessageBox.Show("Cập nhập thông tin sản phẩm thành công", "Thông báo");
                dgvSanPham.DataSource = MultiClass.GetTTSanPham();
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
                IEnumerable<tblSanPham> sP = SanPham.getSanPhamTheoMa(txtMaSP.Text);
                int check = SanPham.DeleteSanPham(sP.First());
                if(check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgvSanPham.DataSource = MultiClass.GetTTSanPham();
                    ClearTexbox();
                    btnXoa.Enabled = false;
                    btnCapNhat.Enabled = false;
                }
                else
                    MessageBox.Show("Không tìm thấy sản phẩm", "Thông báo");
            }
            
        }
        void ClearTexbox()
        {
            txtMaSP.Text=null;
            txtTenSP.Text=null;
            txtLoaiSP.Text=null;    
            txtDonViTinh.Text=null;
            txtDonGia.Text  =null; 
            txtSoLuong.Text=null;
            cboHopDong.SelectedIndex = 0;
        }

        private void txtMaSP__TextChanged(object sender, EventArgs e)
        {
            if(SanPham.CheckIfExist(txtMaSP.Text)==null)
            {
                btnCapNhat.Enabled = false;
                btnXoa.Enabled=false;
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
    }
}
