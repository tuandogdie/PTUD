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
    public partial class frmQLChamCongNVHC : Form
    {
        public frmQLChamCongNVHC()
        {
            InitializeComponent();
        }
        clsNhanVien NhanVien;
        clsMultiClass MultiClass;
        clsChamCongNVHC chamCongNVHC; 
        private void frmQLChamCongNVHC_Load(object sender, EventArgs e)
        {
            NhanVien = new clsNhanVien();
            MultiClass = new clsMultiClass();  
            chamCongNVHC = new clsChamCongNVHC();

            dgvDSChamCong.DataSource = MultiClass.GetTTChamCongNVHC();
            NameColumn();
            LoadNVHCToCbo();
            cboThang.SelectedIndex = 0;
        }
        private void NameColumn()
        {
            dgvDSChamCong.Columns[0].HeaderText = "Mã chấm công";
            dgvDSChamCong.Columns[1].HeaderText = "Mã nhân viên";
            dgvDSChamCong.Columns[2].HeaderText = "Tên nhân viên";
            dgvDSChamCong.Columns[3].HeaderText = "Tháng";
            dgvDSChamCong.Columns[4].HeaderText = "Số ngày làm việc thực tế";
            dgvDSChamCong.Columns[5].HeaderText = "Số ngày công chuẩn";
            dgvDSChamCong.Columns[6].HeaderText = "Số ngày công vượt chuẩn";
        }

        public void LoadNVHCToCbo()
        {
            IEnumerable<tblNhanVien> dsCN = NhanVien.getAllNhanVienHanhChinh();
            cboMaNV.DisplayMember = "maNV";
            cboMaNV.ValueMember = "maNV";
            cboMaNV.DataSource = dsCN;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = NhanVien.getTenTheoMaNV(cboMaNV.Text);
            SetMaCong();

        }
        private void SetMaCong()
        {
            string maNV = cboMaNV.Text;
            string maNV_Tach = maNV.Substring(4, 4);
            string maC_Tam = maNV_Tach + "_2021T";
            string maC = "";
            switch (cboThang.Text)
            {
                case "1":
                    maC = maC_Tam + "1";
                    break;
                case "2":
                    maC = maC_Tam + "2";
                    break;
                case "3":
                    maC = maC_Tam + "3";
                    break;
                case "4":
                    maC = maC_Tam + "4";
                    break;
                case "5":
                    maC = maC_Tam + "5";
                    break;
                case "6":
                    maC = maC_Tam + "6";
                    break;
                case "7":
                    maC = maC_Tam + "7";
                    break;
                case "8":
                    maC = maC_Tam + "8";
                    break;
                case "9":
                    maC = maC_Tam + "9";
                    break;
                case "10":
                    maC = maC_Tam + "10";
                    break;
                case "11":
                    maC = maC_Tam + "11";
                    break;
                case "12":
                    maC = maC_Tam + "12";
                    break;
            }
            txtMaCong.Text = maC;
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMaCong();
        }

        private void txtMaCong_TextChanged(object sender, EventArgs e)
        {
            if (chamCongNVHC.CheckIfExist(txtMaCong.Text) != null)
            {
                txtSoNgayLVTT.Text = chamCongNVHC.getSoNgayLVTTTheoMaCong(txtMaCong.Text);
                txtSoNgayCC.Text = chamCongNVHC.getSoNgayCCTheoMaCong(txtMaCong.Text);
                txtSoNgayVCC.Text = chamCongNVHC.getSoNgayCVCTheoMaCong(txtMaCong.Text);
                btnChamCong.Enabled = false;
                btnCapNhat.Enabled = true;
            }
            else
            {
                txtSoNgayLVTT.Text = null;
                txtSoNgayCC.Text = "26";
                txtSoNgayVCC.Text = null;
                btnChamCong.Enabled = true;
                btnCapNhat.Enabled = false;
            }
        }

        private void txtSoNgayLVTT__TextChanged(object sender, EventArgs e)
        {
            if (txtSoNgayLVTT.Text == "")
                txtSoNgayVCC.Text = null;
            else
            //txtSoNgayVCC.Text = (int.Parse(txtSoNgayLVTT.Text) - 26).ToString();
            {
                int temp = int.Parse(txtSoNgayLVTT.Text) - 26;
                if (temp > 0)
                {
                    txtSoNgayVCC.Text = temp.ToString();
                }
                else
                    txtSoNgayVCC.Text = "0";
            }    
        }
        private void dgvDSChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvDSChamCong.Rows[e.RowIndex];
                cboMaNV.Text = row.Cells[1].Value.ToString();
                cboThang.Text= row.Cells[3].Value.ToString();
            }
        }
        bool KTDLRong()
        {
            if (txtSoNgayLVTT.Text.Equals("") || txtSoNgayCC.Text.Equals("") || txtSoNgayVCC.Text.Equals(""))
                return true;
            else
                return false;
        }
        tblChamCongNVHC TaoChamCongNVHC()
        {
            tblChamCongNVHC n = new tblChamCongNVHC();
            n.maCong = txtMaCong.Text;
            n.maNV = cboMaNV.Text;
            n.thang = int.Parse(cboThang.Text);
            n.soNgayLamViecThucTe = int.Parse(txtSoNgayLVTT.Text);
            n.soNgayCongChuan = int.Parse(txtSoNgayCC.Text);
            n.soNgayCongVuotChuan = int.Parse(txtSoNgayVCC.Text);
            return n;
        }
        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblChamCongNVHC n = TaoChamCongNVHC();
                if (chamCongNVHC.CheckIfExist(n.maCong) != null)
                    MessageBox.Show("Mã chấm công đã tồn tại", "Thông báo");
                else
                {
                    chamCongNVHC.insertChamCongNVHC(n);
                    MessageBox.Show("Chấm công đã thêm thành công", "Thông báo");
                    dgvDSChamCong.DataSource = MultiClass.GetTTChamCongNVHC();
                    cboMaNV.SelectedIndex = 0;
                    cboThang.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblChamCongNVHC n = TaoChamCongNVHC();
                chamCongNVHC.UpdateChamCongNVHC(n);
                MessageBox.Show("Cập nhập thông tin chấm công thành công", "Thông báo");
                dgvDSChamCong.DataSource = MultiClass.GetTTChamCongNVHC();
                cboMaNV.SelectedIndex = 0;
                cboThang.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }

        private void txtTuKhoa__TextChanged(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                dgvDSChamCong.DataSource = MultiClass.GetTKTTChamCongNVHCTheoMaNV(txtTuKhoa.Text);
            else
                dgvDSChamCong.DataSource = MultiClass.GetTKTTChamCongNVHCTheoTenNV(txtTuKhoa.Text);
        }

        private void radTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoMaNV.Checked == true)
                dgvDSChamCong.DataSource = MultiClass.GetTKTTChamCongNVHCTheoMaNV(txtTuKhoa.Text);
        }

        private void radTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoTenNV.Checked == true)
                dgvDSChamCong.DataSource = MultiClass.GetTKTTChamCongNVHCTheoTenNV(txtTuKhoa.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvDSChamCong.DataSource = MultiClass.GetTTChamCongNVHC();
            txtTuKhoa.Text = null;
            cboMaNV.SelectedIndex = 0;
        }
    }
}
