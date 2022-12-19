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
    public partial class frmPhanCongChoCN : Form
    {
        public frmPhanCongChoCN()
        {
            InitializeComponent();
        }
        clsMultiClass MultiClass;
        clsNhanVien NhanVien;
        clsCongDoan CongDoan;
        clsHopDong HopDong;
        clsSanPham SanPham;
        clsChamCongCN chamCongCN;

        private void frmPhanCongChoCN_Load(object sender, EventArgs e)
        {
            MultiClass = new clsMultiClass();
            NhanVien = new clsNhanVien();
            CongDoan = new clsCongDoan();
            HopDong = new clsHopDong();
            SanPham = new clsSanPham();
            chamCongCN = new clsChamCongCN();

            dgvPhanCongCN.DataSource = MultiClass.GetTTPhanCongCN();
            NameColumn();


            LoadCongNhanToCbo();
            cboMaNV.SelectedIndex = 0;
            cboThang.SelectedIndex = 0;


        }
        private void LoadDL()
        {
            IEnumerable<tblHopDong> dsHD = HopDong.getAllHopDong();
            LoadHopDongToCbo(dsHD);
            IEnumerable<tblSanPham> dsSP = SanPham.getSanPhamTheoHopDong(cboHopDong.SelectedValue.ToString());
            LoadSanPhamToCbo(dsSP);
            IEnumerable<tblCongDoan> dsCD = CongDoan.getCongDoanTheoSanPham(cboSanPham.SelectedValue.ToString());
            LoadCongDoanToCbo(dsCD);
            cboHopDong.SelectedIndex = -1;
            cboSanPham.SelectedIndex = -1;
            cboCongDoan.SelectedIndex = -1;
        }
        private void NameColumn()
        {
            dgvPhanCongCN.Columns[0].HeaderText = "Mã công nhân";
            dgvPhanCongCN.Columns[0].Width = 208;
            dgvPhanCongCN.Columns[1].HeaderText = "Tên công nhân";
            dgvPhanCongCN.Columns[1].Width = 450;
            dgvPhanCongCN.Columns[2].HeaderText = "Tháng";
            dgvPhanCongCN.Columns[2].Width = 100;
            dgvPhanCongCN.Columns[3].HeaderText = "Công đoạn";
            dgvPhanCongCN.Columns[3].Width = 550;

        }
        public void LoadCongDoanToCbo(IEnumerable<tblCongDoan> dsCD)
        {
            cboCongDoan.DisplayMember = "tenCongDoan";
            cboCongDoan.ValueMember = "maCD";
            cboCongDoan.DataSource = dsCD;
        }
        public void LoadCongNhanToCbo()
        {
           IEnumerable<tblNhanVien> dsCN = NhanVien.getAllCongNhan();
           cboMaNV.DisplayMember = "maNV";
           cboMaNV.ValueMember = "maNV";
           cboMaNV.DataSource = dsCN;
        }
        public void LoadHopDongToCbo(IEnumerable<tblHopDong> dsHD)
        {
           cboHopDong.DisplayMember = "tenHopDong";
           cboHopDong.ValueMember = "maHD";
           cboHopDong.DataSource = dsHD;
        }
        public void LoadSanPhamToCbo(IEnumerable<tblSanPham> dsSP)
        {
           cboSanPham.DisplayMember = "tenSanPham";
           cboSanPham.ValueMember = "maSP";
           cboSanPham.DataSource = dsSP;
        }
        private void dgvCongDoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPhanCongCN.Rows[e.RowIndex];
                cboMaNV.Text = row.Cells[0].Value.ToString();
                cboThang.SelectedIndex = int.Parse(row.Cells[2].Value.ToString()) - 1;
            }
        }
        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = NhanVien.getTenTheoMaNV(cboMaNV.Text);
            if (chamCongCN.CheckIfExist(SetMaCong()) != null)
            {
                string ma = CongDoan.getMaSanPhamTheoMaCD(chamCongCN.getMaCDTheoMaCong(SetMaCong()));
                IEnumerable<tblSanPham> dsSP = SanPham.getSanPhamTheoHopDong(SanPham.getMaHopDongTheoMaSP(ma));
                LoadSanPhamToCbo(dsSP);
                IEnumerable<tblCongDoan> dsCD = CongDoan.getCongDoanTheoSanPham(ma);
                LoadCongDoanToCbo(dsCD);
                cboCongDoan.Text = CongDoan.getTenCDTheoMaCD(chamCongCN.getMaCDTheoMaCong(SetMaCong()));
                cboSanPham.Text = SanPham.getTenSanPhamTheoMaSP(ma);
                cboHopDong.Text = HopDong.getTenHopDongTheoMaSP(SanPham.getMaHopDongTheoMaSP(ma));
                btnCapNhat.Enabled = true;
                btnPhanCong.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = false;
                btnPhanCong.Enabled = true;
                LoadDL();
            }
        }
        bool KTDLRong()
        {
            if (cboCongDoan.Text.Equals(""))
                return true;
            else
                return false;
        }
        private void btnCapNhap_Click(object sender, EventArgs e)
        {
            if (CongDoan.getScdCTLTheoCboCongDoan(cboCongDoan.SelectedValue.ToString()) == 0)
            {
                MessageBox.Show("Công đoạn của sản phẩm này đã được phân công hết", "Thông báo");
            }
            else if (KTDLRong() == false)
            {
                tblChamCongCN n = TaoPhanCongCN();
                chamCongCN.UpdatePhanCong(n, int.Parse(cboThang.Text));
                MessageBox.Show("Cập nhập thông tin phân công thành công", "Thông báo");
                dgvPhanCongCN.DataSource = MultiClass.GetTTPhanCongCN();
                txtTuKhoa.Text = null;
                cboMaNV.SelectedIndex = 0;
                cboThang.SelectedIndex = 0;
            }
            else
                MessageBox.Show("Bạn chưa chọn công đoạn", "Thông báo");
        }
        tblChamCongCN TaoPhanCongCN()
        {
            tblChamCongCN n = new tblChamCongCN();
            n.maNV = cboMaNV.SelectedValue.ToString();
            n.thang = int.Parse(cboThang.Text);
            n.maCD = cboCongDoan.SelectedValue.ToString();
            n.maCong = SetMaCong();
            n.ca = "Full ca";
            n.soCongDoan = 0;
            n.soCongDoanThietHai = 0;
            return n;
        }
        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
           if (radTheoMaNV.Checked == true)
               dgvPhanCongCN.DataSource = MultiClass.GetTimKiemTTPhanCongCNTheoMaNV(txtTuKhoa.Text);
           else
               dgvPhanCongCN.DataSource = MultiClass.GetTimKiemTTPhanCongCNTheoTenNV(txtTuKhoa.Text);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
           dgvPhanCongCN.DataSource = MultiClass.GetTTPhanCongCN();
           txtTuKhoa.Text = null;
           cboMaNV.SelectedIndex=0;
        }
        private String SetMaCong()
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
            maC = maC + "2021";
            return maC;
        }
        private void radTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
           if(txtTuKhoa.Text != null&&radTheoMaNV.Checked==true)
               dgvPhanCongCN.DataSource = MultiClass.GetTimKiemTTPhanCongCNTheoMaNV(txtTuKhoa.Text);
        }

        private void radTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
           if (txtTuKhoa.Text != null&&radTheoTenNV.Checked==true)
               dgvPhanCongCN.DataSource = MultiClass.GetTimKiemTTPhanCongCNTheoTenNV(txtTuKhoa.Text);
        }

        private void cboHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
           IEnumerable<tblSanPham> dsSP = SanPham.getSanPhamTheoHopDong(cboHopDong.SelectedValue.ToString());
           LoadSanPhamToCbo(dsSP);
           IEnumerable<tblCongDoan> dsCD = CongDoan.getCongDoanTheoSanPham(null);
           LoadCongDoanToCbo(dsCD);
           cboSanPham.Text = null;
           cboCongDoan.Text = null;
        }

        private void cboSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
           IEnumerable<tblCongDoan> dsCD = CongDoan.getCongDoanTheoSanPham(cboSanPham.SelectedValue.ToString());
           LoadCongDoanToCbo(dsCD);
        }
        

        private void cboCongDoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maCD_D = cboCongDoan.SelectedValue.ToString();
            string ttCD = maCD_D.Substring(maCD_D.Length - 1, 1);
            string maCD_T = maCD_D.Substring(0, maCD_D.Length - 1);
            int tt = int.Parse(ttCD) - 1;
            maCD_T += tt.ToString();
            if (ttCD != "1")
                if (chamCongCN.getCheckCongDoan(maCD_T) == 0)
                {
                    MessageBox.Show("Công đoạn trước vẫn chưa phân công công nhân", "Thông báo");
                    cboCongDoan.Text = null;
                }
        }
        private void cboThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chamCongCN.CheckIfExist(SetMaCong()) != null)
            {
                string ma = CongDoan.getMaSanPhamTheoMaCD(chamCongCN.getMaCDTheoMaCong(SetMaCong()));
                IEnumerable<tblSanPham> dsSP = SanPham.getSanPhamTheoHopDong(SanPham.getMaHopDongTheoMaSP(ma));
                LoadSanPhamToCbo(dsSP);
                IEnumerable<tblCongDoan> dsCD = CongDoan.getCongDoanTheoSanPham(ma);
                LoadCongDoanToCbo(dsCD);
                cboCongDoan.Text = CongDoan.getTenCDTheoMaCD(chamCongCN.getMaCDTheoMaCong(SetMaCong()));
                cboSanPham.Text = SanPham.getTenSanPhamTheoMaSP(ma);
                cboHopDong.Text = HopDong.getTenHopDongTheoMaSP(SanPham.getMaHopDongTheoMaSP(ma));
                btnCapNhat.Enabled = true;
                btnPhanCong.Enabled = false;
            }
            else
            {
                btnCapNhat.Enabled = false;
                btnPhanCong.Enabled = true;
                LoadDL();
            }

        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            tblChamCongCN n = TaoPhanCongCN();
            if (KTDLRong() == false)
            {
                if (chamCongCN.CheckIfExist(n.maCong) != null)
                    MessageBox.Show("Mã chấm công đã tồn tại", "Thông báo");
                else if(CongDoan.getScdCTLTheoCboCongDoan(cboCongDoan.SelectedValue.ToString()) == 0)
                {
                    MessageBox.Show("Công đoạn của sản phẩm này đã được phân công hết", "Thông báo");
                }
                else
                {
                    chamCongCN.insertChamCongCN(n);
                    MessageBox.Show("Đã thêm phân công thành công", "Thông báo");
                    dgvPhanCongCN.DataSource = MultiClass.GetTTPhanCongCN();
                    cboMaNV.SelectedIndex = 0;
                    cboThang.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show("Bạn chưa chọn công đoạn", "Thông báo");
        }
        private void cboThang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }
    }
}
