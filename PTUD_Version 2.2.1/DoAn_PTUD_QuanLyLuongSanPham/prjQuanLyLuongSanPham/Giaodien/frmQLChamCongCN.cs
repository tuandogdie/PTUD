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
    public partial class frmQLChamCongCN : Form
    {
        public frmQLChamCongCN()
        {
            InitializeComponent();
        }
        clsNhanVien NhanVien;
        clsMultiClass MultiClass;
        clsChamCongCN chamCongCN;
        clsCongDoan congDoan;

        private void frmQLChamCongCN_Load(object sender, EventArgs e)
        {
            NhanVien = new clsNhanVien();
            MultiClass= new clsMultiClass();
            chamCongCN = new clsChamCongCN();
            
            cboLocThang.SelectedIndex = 0;

            if (cboLocThang.Text == "Full")
                dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCN();
            else
                dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCNThang(int.Parse(cboThang.Text));
            NameColumn();
            LoadNVHCToCbo();
            cboMaNV.SelectedIndex = 0;
            LoadThangToCbo();
            //this.dgvChamCongCN.Columns["soCongDoanThietHai"].Visible = false;
            // this.dgvChamCongCN.Columns["soCongDoanCoTheLam"].Visible = false;
        }
        private void kiemTraThangCu()
        {
            if (cboThang.SelectedItem.ToString() != "12")
            {
                btnChamCong.Enabled = false;
                btnCapNhat.Enabled = false;
            }
            else
            {
                btnChamCong.Enabled = true;
                btnCapNhat.Enabled = true;
            }
        }
        private void NameColumn()
        {
            dgvChamCongCN.Columns[0].HeaderText = "Mã chấm công";
            dgvChamCongCN.Columns[1].HeaderText = "Mã nhân viên";
            dgvChamCongCN.Columns[2].HeaderText = "Tên nhân viên";
            dgvChamCongCN.Columns[3].HeaderText = "Công đoạn";
            dgvChamCongCN.Columns[4].HeaderText = "Tháng";
            dgvChamCongCN.Columns[5].HeaderText = "Ca";
            dgvChamCongCN.Columns[6].HeaderText = "Số công đoạn";
            dgvChamCongCN.Columns[7].HeaderText = "Số công đoạn thiệt hại";
        }

        public void LoadNVHCToCbo()
        {
            IEnumerable<tblNhanVien> dsCN = NhanVien.getAllCongNhan();
            cboMaNV.DisplayMember = "maNV";
            cboMaNV.ValueMember = "maNV";
            cboMaNV.DataSource = dsCN;
        }
        public void LoadThangToCbo()
        {

            IEnumerable<tblChamCongCN> ds = chamCongCN.GetDSThangTheoMaNV(cboMaNV.Text);
            cboThang.DisplayMember = "thang";
            cboThang.ValueMember = "thang";
            cboThang.DataSource = ds;
        }
        private void SetMaCong()
        {
            string maNV = cboMaNV.Text;
            string maNV_Tach = maNV.Substring(2, 4);
            string maC_Tam = "CCCN" + maNV_Tach + "_T";
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
            maC = maC+"2021";
            txtMaCong.Text = maC;
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = NhanVien.getTenTheoMaNV(cboMaNV.Text);
            LoadThangToCbo();
            SetMaCong();
            if(chamCongCN.getSCDTheoMaCong(txtMaCong.Text)==0)
            {
                btnCapNhat.Enabled = false;
                btnChamCong.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnChamCong.Enabled = false;
            }
            
        }

        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetMaCong();
            if (chamCongCN.getSCDTheoMaCong(txtMaCong.Text) == 0)
            {
                btnCapNhat.Enabled = false;
                btnChamCong.Enabled = true;
            }
            else
            {
                btnCapNhat.Enabled = true;
                btnChamCong.Enabled = false;
            }
        }

        private void txtMaCong_TextChanged(object sender, EventArgs e)
        {
            if(chamCongCN.CheckIfExist(txtMaCong.Text)!=null)
            {
                if (MultiClass.getTenCDTheoMaCong(txtMaCong.Text) != null)
                    txtCongDoan.Text = MultiClass.getTenCDTheoMaCong(txtMaCong.Text);
                else
                    txtCongDoan.Text = null;
                if(chamCongCN.getCaTheoMaCong(txtMaCong.Text)!=null)
                    cboCa.Text = chamCongCN.getCaTheoMaCong(txtMaCong.Text);
                else
                    cboCa.Text = null;
                if(chamCongCN.getSoCDTheoMaCong(txtMaCong.Text)!=null)
                    txtSoCongDoan.Text = chamCongCN.getSoCDTheoMaCong(txtMaCong.Text);
                else
                    txtSoCongDoan.Text= null;
                if (chamCongCN.getSCDTHTheoMaCong(txtMaCong.Text) != null)
                    txtSCDThietHai.Text = chamCongCN.getSCDTHTheoMaCong(txtMaCong.Text);
                else
                    txtSCDThietHai.Text = null;
                if (MultiClass.getSCDCTLTheoMaCong(txtMaCong.Text) != null)
                    txtSCDCoTheLam.Text = MultiClass.getSCDCTLTheoMaCong(txtMaCong.Text);
                else
                    txtSCDCoTheLam.Text = null;
                btnCapNhat.Enabled = true;
            }
            else
            {
                txtCongDoan.Text = null;
                cboCa.SelectedIndex = -1;
                txtSoCongDoan.Text = null;
                btnCapNhat.Enabled = false;
            }
        }
        private void dgvChamCongCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvChamCongCN.Rows[e.RowIndex];
                cboMaNV.Text = row.Cells[1].Value.ToString();
                cboThang.Text = row.Cells[4].Value.ToString();
            }
        }
        bool KTDLRong()
        {
            if (txtSoCongDoan.Text.Equals("") )
                return true;
            else
                return false;
        }
        tblChamCongCN TaoChamCongCN()
        {
            tblChamCongCN n = new tblChamCongCN();
            n.maCong = txtMaCong.Text;
            n.maNV = cboMaNV.Text;
            n.maCD = chamCongCN.getMaCDTheoMaCong(txtMaCong.Text);
            n.thang = int.Parse(cboThang.Text);
            n.ca=cboCa.Text;
            n.soCongDoan = int.Parse(txtSoCongDoan.Text);
            n.soCongDoanThietHai = int.Parse(txtSCDThietHai.Text);
            return n;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
           
            if(updateScdCoTheLam() < 0)
            {
                MessageBox.Show("Thông tin nhập chưa chính xác" + "\n Số công đoạn công nhân này đã làm vượt mức số lượng yêu cầu của sản phẩm!!", "Thông báo");
            }
            else if (KTDLRong() == false)
            {
                congDoan = new clsCongDoan();
                tblChamCongCN n = TaoChamCongCN();
                int newSCDCTL = updateScdCoTheLam();
                txtSCDCoTheLam.Text = updateScdCoTheLam().ToString();
                chamCongCN.UpdateChamCongCN(n);               
                string maCD = chamCongCN.getMaCDTheoMaCC(txtMaCong.Text.ToString());
                congDoan.updateSCDCTLTheoMaCD(maCD, newSCDCTL);
                MessageBox.Show("Cập nhập thông tin chấm công thành công", "Thông báo");
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCN();
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCNThang(int.Parse(cboLocThang.Text));
                cboMaNV.SelectedIndex = 0;              
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }
        private int updateScdCoTheLam()
        {
            chamCongCN = new clsChamCongCN();
            int scd = Convert.ToInt32(txtSoCongDoan.Text);
            int scdTH = Convert.ToInt32(txtSCDThietHai.Text);
            int scdCTL = Convert.ToInt32(txtSCDCoTheLam.Text);
            int oldSCD = int.Parse(chamCongCN.getSoCDTheoMaCong(txtMaCong.Text.ToString()));
            return scdCTL - scd + scdTH + oldSCD; 
        }
        private int chamCongScdCoTheLam()
        {
            chamCongCN = new clsChamCongCN();
            int scd = Convert.ToInt32(txtSoCongDoan.Text);
            int scdTH = Convert.ToInt32(txtSCDThietHai.Text);
            int scdCTL = Convert.ToInt32(txtSCDCoTheLam.Text);
            return scdCTL - scd + scdTH;
        }
        private void txtTuKhoa__TextChanged(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMa(txtTuKhoa.Text);
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMaThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
            else
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTen(txtTuKhoa.Text);
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTenThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
        }

        private void radTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoMaNV.Checked == true)
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMa(txtTuKhoa.Text);
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMaThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
        }

        private void radTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoTenNV.Checked == true)
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTen(txtTuKhoa.Text);
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTenThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (cboLocThang.Text == "Full")
                dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCN();
            else
                dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCNThang(int.Parse(cboLocThang.Text));
            txtTuKhoa.Text = null;
            cboMaNV.SelectedIndex = 0;
        }

        private void btnChamCong_Click_1(object sender, EventArgs e)
        {
            if (updateScdCoTheLam() < 0)
            {
                MessageBox.Show("Thông tin nhập chưa chính xác" + "\n Số công đoạn công nhân này đã làm vượt mức số lượng yêu cầu của sản phẩm!!", "Thông báo");
            }
            else if (KTDLRong() == false)
            {
                congDoan = new clsCongDoan();
                tblChamCongCN n = TaoChamCongCN();
                int newSCDCTL = updateScdCoTheLam();
                txtSCDCoTheLam.Text = updateScdCoTheLam().ToString();
                chamCongCN.UpdateThemTTChamCongCN(n);
                string maCD = chamCongCN.getMaCDTheoMaCC(txtMaCong.Text.ToString());
                congDoan.updateSCDCTLTheoMaCD(maCD, newSCDCTL);
                MessageBox.Show("Chấm công thành công", "Thông báo");
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCN();
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTTChamCongCNThang(int.Parse(cboLocThang.Text));
                cboMaNV.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }

        private void cboLocThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (radTheoMaNV.Checked == true)
                if (cboLocThang.Text == "Full")
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMa(txtTuKhoa.Text);
                else
                    dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoMaThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
            else
                if (cboLocThang.Text == "Full")
                dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTen(txtTuKhoa.Text);
            else
                dgvChamCongCN.DataSource = MultiClass.GetTKTTChamCongCNTheoTenThang(txtTuKhoa.Text, int.Parse(cboLocThang.Text));
            
        }

        private void cboLocThang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //kiemTraThangCu();
        }
    }
}
