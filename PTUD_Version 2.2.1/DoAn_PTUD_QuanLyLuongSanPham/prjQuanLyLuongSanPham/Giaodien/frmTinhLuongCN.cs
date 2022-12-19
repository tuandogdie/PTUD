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

namespace prjQuanLyLuongSanPham
{
    public partial class frmTinhLuongCN : Form
    {
        public frmTinhLuongCN()
        {
            InitializeComponent();
        }
        clsNhanVien NhanVien;
        clsMultiClass Multicls;
        clsChamCongCN chamCong;
        clsCongDoan congDoan;
        clsLuongCN luongCN;

        private void frmTinhLuongCN_Load(object sender, EventArgs e)
        {
            Multicls = new clsMultiClass();
            chamCong = new clsChamCongCN();
            NhanVien = new clsNhanVien();
            congDoan = new clsCongDoan();
            luongCN = new clsLuongCN();
            LocThang();
            LocMaNV();
            dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
            dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
            this.dgrLuongCN.Columns["thang"].Visible = false;
            this.dgrLuongCN.Columns["soGioLamCa12"].Visible = false;
            this.dgrLuongCN.Columns["soGioLamCa3"].Visible = false;
            dgrLuongCN.Columns[0].HeaderText = "Mã lương CN";
            dgrLuongCN.Columns[1].HeaderText = "Mã công nhân";
            dgrLuongCN.Columns[2].HeaderText = "Họ tên";
            dgrLuongCN.Columns[3].HeaderText = "Tên sản phẩm";
            dgrLuongCN.Columns[4].HeaderText = "Tên công đoạn";
            dgrLuongCN.Columns[5].HeaderText = "Số công đoạn";
            dgrLuongCN.Columns[6].HeaderText = "Đơn giá";
            dgrLuongCN.Columns[7].HeaderText = "Thực lĩnh";
            dgrDSChoLuongCN.Columns[0].HeaderText = "Mã CN";
            dgrDSChoLuongCN.Columns[3].HeaderText = "Tháng";
            this.dgrDSChoLuongCN.Columns["hoTen"].Visible = false;
            this.dgrDSChoLuongCN.Columns["maCong"].Visible = false;
            this.dgrDSChoLuongCN.Columns["soCongDoan"].Visible = false;
            this.dgrDSChoLuongCN.Columns["tenSanPham"].Visible = false;
            this.dgrDSChoLuongCN.Columns["tenCongDoan"].Visible = false;
        }

        #region Load các tháng đã chấm công to combobox
        bool SoSanhThang(int thang)
        {
            for (int i = 0; i < cboThangChamCongCN.Items.Count; i++)
            {
                if (cboThangChamCongCN.Items[i].Equals(thang))
                    return true;
            }
            return false;
        }
        void LocThang()
        {
            IEnumerable<tblChamCongCN> thang;
            thang = chamCong.getAllChamCongCN();
            foreach (tblChamCongCN thangCon in thang)
            {
                if (SoSanhThang(Convert.ToInt32(thangCon.thang)) == false)
                {
                    cboThangChamCongCN.Items.Add(thangCon.thang);
                }
            }
        }
        #endregion

        #region load mã nhân viên to cbo
        bool SoSanhMaCN(string maCN)
        {
            for (int i = 0; i < cboMaCongNhan.Items.Count; i++)
            {
                if (cboMaCongNhan.Items[i].Equals(maCN))
                    return true;
            }
            return false;
        }
        void LocMaNV()
        {
            IEnumerable<tblChamCongCN> maCN;
            maCN = chamCong.getAllChamCongCN();
            foreach (tblChamCongCN maCNcon in maCN)
            {
                if (SoSanhMaCN(maCNcon.maNV) == false)
                {
                    cboMaCongNhan.Items.Add(maCNcon.maNV);
                }
            }
        }
        #endregion

        private void cboMaCongNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maCN = cboMaCongNhan.SelectedItem.ToString();
            string cn;
            cn = NhanVien.getTenTheoMaNV(maCN);
            txtTenCongNhan.Text = cn;
        }

        private void dgrLuongCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgrLuongCN.Rows[e.RowIndex];
                //txtMaLuongNV.Text = row.Cells[1].Value.ToString();
                txtMaLuongCN.Text = row.Cells[0].Value.ToString();
                cboMaCongNhan.Text = row.Cells[1].Value.ToString();
                txtTenCongNhan.Text = row.Cells[2].Value.ToString();
                txtTenSanPham.Text = row.Cells[3].Value.ToString();
                txtTenCongDoan.Text = row.Cells[4].Value.ToString();
                txtSoCongDoan.Text = row.Cells[5].Value.ToString();
                txtThucL.Text = row.Cells[7].Value.ToString();
                cboThangChamCongCN.Text = row.Cells[8].Value.ToString();
                kiemTraCaDaTonTai();
            }
        }

        private void btnTinhLuongCN_Click(object sender, EventArgs e)
        {
            string maLuongCN = txtMaLuongCN.Text.ToString();
            string maCN = cboMaCongNhan.SelectedItem.ToString();
            string maCD = chamCong.getMaCongDoan(maCN,
                Convert.ToInt32(cboThangChamCongCN.SelectedItem));
            int scd = int.Parse(txtSoCongDoan.Text.ToString());
            int soGioCa12 = int.Parse(txtNhapSoGioCa12.Text.ToString());
            int soGioCa3 = int.Parse(txtNhapSoGioCa3.Text.ToString());
            Multicls.tinhThucLinhCN(maLuongCN,maCD,scd,soGioCa12,soGioCa3);
            txtThucL.Text = luongCN.getThucLinh(maLuongCN).ToString();
            //dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
            int t;
            t = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
            dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCNTheoThang(t);
        }

        #region click nhầm, đừng xóa cái này !!!
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dgrDSCho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgrLuongCN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void cboThangChamCongCN_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void cboThangChamCongCN_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void dgrDSCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                chamCong = new clsChamCongCN();
                DataGridViewRow row = this.dgrDSChoLuongCN.Rows[e.RowIndex];
                cboMaCongNhan.Text = row.Cells[0].Value.ToString();
                txtTenCongNhan.Text = row.Cells[1].Value.ToString();
                cboThangChamCongCN.Text = row.Cells[3].Value.ToString();
                txtSoCongDoan.Text = row.Cells[4].Value.ToString();
                //txtMaLuongCN.Text = "";
                txtTenSanPham.Text = row.Cells[6].Value.ToString();
                txtTenCongDoan.Text = row.Cells[5].Value.ToString();
                kiemTraCa();
                txtMaLuongCN.Text = taoMaLuongCnMoi();
                txtThucL.Text = "";
            }
        }

        private void kiemTraCa()
        {
            if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Full ca")
            {
                txtSoGioLamCa12.Visible = false;
                txtSoGioLamCa3.Visible = false;
                txtNhapSoGioCa12.Text = "";
                txtNhapSoGioCa3.Text = "";
            }
            else if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 1,2")
            {
                txtSoGioLamCa3.Visible = true;
                txtSoGioLamCa3.Text = "0";
                txtSoGioLamCa12.Visible = false;
                txtNhapSoGioCa12.Text = "";
                txtNhapSoGioCa3.Text = "";
            }
            else if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 3")
            {
                txtSoGioLamCa12.Visible = true;
                txtSoGioLamCa12.Text = "0";
                txtSoGioLamCa3.Visible = false;
                txtNhapSoGioCa12.Text = "";
                txtNhapSoGioCa3.Text = "";
            }
            else
            {
                MessageBox.Show("Công nhân này vẫn chưa được chấm công!!", "Thông báo");
            }
        }

        private void kiemTraCaDaTonTai()
        {
            if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Full ca")
            {
                txtSoGioLamCa12.Visible = false;
                txtSoGioLamCa3.Visible = false;
                txtNhapSoGioCa12.Text = luongCN.getSoGioCa12(txtMaLuongCN.Text.ToString()).ToString();
                txtNhapSoGioCa3.Text = luongCN.getSoGioCa3(txtMaLuongCN.Text.ToString()).ToString();
            }
            else if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 1,2")
            {
                txtSoGioLamCa3.Visible = true;
                txtSoGioLamCa3.Text = "0";
                txtSoGioLamCa12.Visible = false;
                txtNhapSoGioCa12.Text = luongCN.getSoGioCa12(txtMaLuongCN.Text.ToString()).ToString();
                txtNhapSoGioCa3.Text = "0";
            }
            else if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 3")
            {
                txtSoGioLamCa12.Visible = true;
                txtSoGioLamCa12.Text = "0";
                txtSoGioLamCa3.Visible = false;
                txtNhapSoGioCa3.Text = luongCN.getSoGioCa3(txtMaLuongCN.Text.ToString()).ToString();
                txtNhapSoGioCa12.Text = "0";
            }
            else
            {
                MessageBox.Show("Công nhân này vẫn chưa được chấm công!!", "Thông báo");
            }
        }

        private string taoMaLuongCnMoi()
        {
            chamCong = new clsChamCongCN();
            string maCN = cboMaCongNhan.SelectedItem.ToString();
            int thang = Convert.ToInt32(cboThangChamCongCN.SelectedItem);
            string maLuongCnMoi ="2021T"+chamCong.getThang(maCN,thang)+"_"+chamCong.getChuoiMaNV(maCN, thang)+"LG";
            //2021T1_0001LG
            return maLuongCnMoi;
        }

        private void btnThemVaoDSTinhLuong_Click(object sender, EventArgs e)
        {
            string maLuongDeSoSanh = txtMaLuongCN.Text.ToString();
            string maluong = luongCN.soSanhMaLuongCN(maLuongDeSoSanh);
            if(maluong != null)
            {
                MessageBox.Show("Mã lương đã tồn tại!!", "Thông báo");
                return;
            }
            else if (txtNhapSoGioCa12.Text.ToString() == "" && txtNhapSoGioCa3.Text.ToString() == "")
            {
                MessageBox.Show("Hãy nhập số giờ làm trước khi thêm", "Thông báo");
            }
            else if (chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), 
                Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Full ca" && 
                txtNhapSoGioCa12.Text.ToString() != "" && txtNhapSoGioCa3.Text.ToString() != "")
            {
                string maLuongCN = txtMaLuongCN.Text.ToString();
                int sglCa12 = Convert.ToInt32(txtNhapSoGioCa12.Text.ToString());
                int sglCa3 = Convert.ToInt32(txtNhapSoGioCa3.Text.ToString());
                if(sglCa12 > 112)
                {
                    MessageBox.Show("Số giờ làm ca 1,2 nhiều nhất chỉ có thể là 112 giờ", "Thông báo");
                }
                else if (sglCa3 > 96)
                {
                    MessageBox.Show("Số giờ làm ca 3 nhiều nhất chỉ có thể là 96 giờ", "Thông báo");
                }
                else
                {
                    string maCN = cboMaCongNhan.SelectedItem.ToString();
                    int thang = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
                    luongCN.addNewLuongCN(maLuongCN, maCN, thang, sglCa12, sglCa3);
                    resetThongTinTinhLuong();
                    dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
                    dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
                }
            }
            else if(chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), 
                Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 1,2" && txtNhapSoGioCa12.Text.ToString() != "")
            {
                string maLuongCN = txtMaLuongCN.Text.ToString();
                int sglCa12 = Convert.ToInt32(txtNhapSoGioCa12.Text.ToString());
                int sglCa3 = 0;
                if(sglCa12 > 112)
                {
                    MessageBox.Show("Số giờ làm ca 1,2 nhiều nhất chỉ có thể là 112 giờ", "Thông báo");
                }
                else
                {
                    string maCN = cboMaCongNhan.SelectedItem.ToString();
                    int thang = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
                    luongCN.addNewLuongCN(maLuongCN, maCN, thang, sglCa12, sglCa3);
                    resetThongTinTinhLuong();
                    dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
                    dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
                }
            }
            else if(chamCong.getCa(cboMaCongNhan.SelectedItem.ToString(), 
                Convert.ToInt32(cboThangChamCongCN.SelectedItem)) == "Ca 3" && txtNhapSoGioCa3.Text.ToString() != "")
            {
                string maLuongCN = txtMaLuongCN.Text.ToString();
                int sglCa12 = 0;
                int sglCa3 = Convert.ToInt32(txtNhapSoGioCa3.Text.ToString());
                if (sglCa3 > 96)
                {
                    MessageBox.Show("Số giờ làm ca 3 nhiều nhất chỉ có thể là 96 giờ", "Thông báo");
                }
                else
                {
                    string maCN = cboMaCongNhan.SelectedItem.ToString();
                    int thang = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
                    luongCN.addNewLuongCN(maLuongCN, maCN, thang, sglCa12, sglCa3);
                    resetThongTinTinhLuong();
                    dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
                    dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
                }
            }           
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ thông tin!!", "Warning");
            }
        }
        private void resetThongTinTinhLuong()
        {
            cboThangChamCongCN.ResetText();
            txtMaLuongCN.Text = "";
            txtTenCongDoan.Text = "";
            cboMaCongNhan.ResetText();
            txtSoCongDoan.Text = "";
            txtTenSanPham.Text = "";
            txtTenCongNhan.Text = "";
            txtNhapSoGioCa12.Text = "";
            txtNhapSoGioCa3.Text = "";
            txtThucL.Text = "";
        }
        private void cboThangChamCongCN_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int t;
            t = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
            dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCNTheoThang(t);
            if (cboThangChamCongCN.SelectedItem.ToString() != "12")
            {
                btnCapNhatLuongCN.Enabled = false;
                btnXoaLuongCN.Enabled = false;
                btnTinhLuongCN.Enabled = false;
            }
            else
            {
                btnCapNhatLuongCN.Enabled = true;
                btnXoaLuongCN.Enabled = true;
                btnTinhLuongCN.Enabled = true;
            }
        }

        private void btnLoaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
        }

        private void btnXoaLuongCN_Click(object sender, EventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn xóa lương công nhân này?", "Cảnh báo",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                IEnumerable<tblLuongCN> l = luongCN.getLuongTheoMa(txtMaLuongCN.Text);
                int check = luongCN.DeleteLuong(l.First());
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCN();
                    dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
                }
                else
                    MessageBox.Show("Không tìm thấy đối tượng xóa", "Thông báo");
            }
        }
        bool KTDLRong()
        {
            if ((txtNhapSoGioCa12.Text.Equals("") || txtNhapSoGioCa3.Text.Equals("") 
                || txtMaLuongCN.Text.Equals("")))
                return true;
            else
                return false;
        }
        tblLuongCN TaoLuongCN()
        {
            tblLuongCN n = new tblLuongCN();
            n.maLuongCN = txtMaLuongCN.Text;
            n.soGioLamCa12 = int.Parse(txtNhapSoGioCa12.Text);
            n.soGioLamCa3 = int.Parse(txtNhapSoGioCa3.Text);
            return n;
        }
        private void btnCapNhatLuongCN_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblLuongCN n = TaoLuongCN();
                luongCN.UpdateLuong(n);
                MessageBox.Show("Cập nhập thông tin lương thành công. Hãy chú ý tính lại lương", "Thông báo");
                int t;
                t = Convert.ToInt32(cboThangChamCongCN.SelectedItem.ToString());
                dgrLuongCN.DataSource = Multicls.getAllThongTinLuongCNTheoThang(t);
                dgrDSChoLuongCN.DataSource = Multicls.getDSchoTinhLuongCN();
            }
            else
                MessageBox.Show("Không thể cập nhật. Hãy nhập số giờ làm theo ca thích hợp", "Thông báo");
        }
    }
}
