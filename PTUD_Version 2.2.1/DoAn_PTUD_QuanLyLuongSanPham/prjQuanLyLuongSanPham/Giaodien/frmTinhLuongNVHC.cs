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
    public partial class frmTinhLuongNVHC : Form
    {
        public frmTinhLuongNVHC()
        {
            InitializeComponent();
        }

        clsMultiClass Multiclass;
        clsChamCongNVHC ChamCong;
        clsQuyetDinhTangLuong qdtl;
        clsChucVu PhuCapCV;
        clsNhanVien NhanVien;
        clsLuongNVHC luong;
        clsHeSoLuong HeSoLg;
        clsLuongBHXH bhxh;

        private void frmTinhLuongNVHC_Load(object sender, EventArgs e)
        {
            Multiclass = new clsMultiClass();
            ChamCong = new clsChamCongNVHC();
            qdtl = new clsQuyetDinhTangLuong();
            PhuCapCV = new clsChucVu();
            NhanVien = new clsNhanVien();
            luong = new clsLuongNVHC();
            HeSoLg = new clsHeSoLuong();
            bhxh = new clsLuongBHXH();
            LocThang();
            LocMaNV();
            LoadQDTLtoComboBox();
            LoadChucVutoComboBox();
            loadLuongBHXH();
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHC();
            dgrDSChoLuongNVHC.DataSource = Multiclass.getDanhSachChoTinhLuongNVHC();
            this.dgrLuongNVHC.Columns["thang"].Visible = false;
            this.dgrLuongNVHC.Columns["tenChucVu"].Visible = false;
            this.dgrLuongNVHC.Columns["noiDungQuyetDinh"].Visible = false;
            //txtNhapLuongCB.Text = "4000000";
            txtLuongCB.Text = "4000000";
            txtLuongTCMotNgay.Text = "120000";
            txtHSLTC.Text = "1.5";
            dgrLuongNVHC.Columns[0].HeaderText = "Mã nhân viên";
            dgrLuongNVHC.Columns[1].HeaderText = "Mã lương";
            dgrLuongNVHC.Columns[2].HeaderText = "Tên nhân viên";
            dgrLuongNVHC.Columns[3].HeaderText = "Lương cơ bản";
            dgrLuongNVHC.Columns[4].HeaderText = "Lương tăng theo quyết định";
            dgrLuongNVHC.Columns[5].HeaderText = "Phụ cấp";
            dgrLuongNVHC.Columns[6].HeaderText = "Hệ số lương";
            dgrLuongNVHC.Columns[7].HeaderText = "Tiền nộp bảo hiểm xã hội";
            dgrLuongNVHC.Columns[8].HeaderText = "Thực lĩnh";
            this.dgrDSChoLuongNVHC.Columns["maCong"].Visible = false;
            this.dgrDSChoLuongNVHC.Columns["hoTen"].Visible = false;
            this.dgrDSChoLuongNVHC.Columns["noiDungQuyetDinh"].Visible = false;
            this.dgrDSChoLuongNVHC.Columns["tenChucVu"].Visible = false;
            dgrDSChoLuongNVHC.Columns[1].HeaderText = "Mã NV";
            dgrDSChoLuongNVHC.Columns[2].HeaderText = "Tháng";
        }

        #region Load các tháng đã chấm công to combobox
        bool SoSanhThang(int thang)
        {
            for (int i = 0; i < cboLocThang.Items.Count; i++)
            {
                if (cboLocThang.Items[i].Equals(thang))
                    return true;
            }
            return false;
        }
        void LocThang()
        {
            IEnumerable<tblChamCongNVHC> thang;
            thang = ChamCong.getAllChamCongNVHC();
            foreach (tblChamCongNVHC thangCon in thang)
            {
                if (SoSanhThang(Convert.ToInt32(thangCon.thang)) == false)
                {
                    cboLocThang.Items.Add(thangCon.thang);
                }
            }
        }
        #endregion

        #region load mã nhân viên to cbo
        bool SoSanhMaNV(string maNV)
        {
            for (int i = 0; i < cboMaNhanVien.Items.Count; i++)
            {
                if (cboMaNhanVien.Items[i].Equals(maNV))
                    return true;
            }
            return false;
        }
        void LocMaNV()
        {
            IEnumerable<tblChamCongNVHC> maNV;
            maNV = ChamCong.getAllChamCongNVHC();
            foreach (tblChamCongNVHC maNVcon in maNV)
            {
                if (SoSanhMaNV(maNVcon.maNV) == false)
                {
                    cboMaNhanVien.Items.Add(maNVcon.maNV);
                }
            }
        }
        #endregion

        #region Load lên comboboxQDTL
        bool SoSanhQDTL(string qdtl)
        {
            for (int i = 0; i < cboQuyetDinhTangLuong.Items.Count; i++)
            {
                if (cboQuyetDinhTangLuong.Items[i].Equals(qdtl))
                    return true;
            }
            return false;
        }
        void LoadQDTLtoComboBox()
        {
            IEnumerable<tblQuyetDinhTangLuong> qd;
            qd = qdtl.getAllQuyetDinhTL();
            foreach (tblQuyetDinhTangLuong noiDungQD in qd)
            {
                if (SoSanhQDTL(noiDungQD.noiDungQuyetDinh) == false)
                {
                    cboQuyetDinhTangLuong.Items.Add(noiDungQD.noiDungQuyetDinh);
                }
            }
        }
        #endregion

        #region Load lên comboboxChucVu
        bool SoSanhCV(string cv)
        {
            for (int i = 0; i < cboChucVu.Items.Count; i++)
            {
                if (cboChucVu.Items[i].Equals(cv))
                    return true;
            }
            return false;
        }
        void LoadChucVutoComboBox()
        {

            IEnumerable<tblChucVu> cv;
            cv = PhuCapCV.getAllChucVu();
            foreach (tblChucVu cvCon in cv)
            {
                if (SoSanhCV(cvCon.tenChucVu) == false)
                {
                    cboChucVu.Items.Add(cvCon.tenChucVu);
                }
            }
        }
        #endregion

        private void cboLocThang_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txtMaLuong__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cboMaNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maNV = cboMaNhanVien.SelectedItem.ToString();
            string nv;
            nv = NhanVien.getTenTheoMaNV(maNV);
            txtTenNV.Text = nv;
        }

        private void loadLuongBHXH()
        {
            IEnumerable<tblLuongNVHC> maLuongCha;
            maLuongCha = luong.getAllLuongNVHC();
            IEnumerable<tblLuongBHXH> maBHXHCha;
            maBHXHCha = bhxh.getAllLuongBHXH();
            foreach (tblLuongBHXH bhxhCon in maBHXHCha)
            {

                foreach (tblLuongNVHC maLCon in maLuongCha)
                {
                    bhxh.updateTienNopBHXH(bhxhCon.maBHXH, maLCon.maLuongNVHC);
                }
            }
        }

        private void dgrLuongNVHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgrLuongNVHC.Rows[e.RowIndex];
                txtMaLuongNV.Text = row.Cells[1].Value.ToString();
                txtTenNV.Text = row.Cells[2].Value.ToString();
                //noNameLCB.Text = row.Cells[3].Value.ToString();
                cboMaNhanVien.Text = row.Cells[0].Value.ToString();
                cboLocThang.Text = row.Cells[9].Value.ToString();
                cboQuyetDinhTangLuong.Text = row.Cells[10].Value.ToString();
                cboChucVu.Text = row.Cells[11].Value.ToString();
                txtThucLinh.Text = row.Cells[8].Value.ToString();
            }
        }



        private void btnThemTinhLuong_Click(object sender, EventArgs e)
        {
            string maLuongDeSoSanh = txtMaLuongNV.Text.ToString();
            string maluong;
            string maNV = cboMaNhanVien.SelectedItem.ToString().Trim();
            int thang = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
            IEnumerable<dynamic> hslCha = Multiclass.TimMaHSLCanAdd(maNV);
            IEnumerable<dynamic> ccCha = Multiclass.TimMaChamCongCanAdd(maNV,thang);
            IEnumerable<dynamic> bhxhCha = Multiclass.TimMaBHXHCanAdd(maNV);
            maluong = luong.SoSanhMaLuong(maLuongDeSoSanh);
            if (maluong != null)
            {
                MessageBox.Show("Mã lương đã tồn tại!!", "Thông báo");
                return;
            }
            else
            {
                string ml = txtMaLuongNV.Text.ToString();
                luong.addNewLuong(ml, maNV);
                foreach (dynamic hslCon in hslCha)
                {
                    Multiclass.UpdateLuongByHSL(ml, hslCon.HeSoLuongCanAdd);
                }
                foreach (dynamic ccCon in ccCha)
                {
                    Multiclass.UpdateLuongByChamCong(ml, ccCon.AddChamCong);
                }
                foreach (dynamic bhxhCon in bhxhCha)
                {
                    Multiclass.UpdateLuongByBHXH(ml, bhxhCon.AddMaBHXH);
                }
            }
            loadLuongBHXH();
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHC();
            dgrDSChoLuongNVHC.DataSource = Multiclass.getDanhSachChoTinhLuongNVHC();
            MessageBox.Show("Thêm vào danh sách tính lương thành công", "Thông báo");
        }

        private void btnTinhLuongNVHC_Click(object sender, EventArgs e)
        {
            string maLuong = txtMaLuongNV.Text.ToString();
            string maNhanVien = cboMaNhanVien.SelectedItem.ToString();
            Multiclass.tinhThucLinh(maLuong, maNhanVien);
            txtThucLinh.Text = luong.getThucLinh(maLuong);
            int t;
            t = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHCTheoThang(t);
        }

        private void dgrDSChoLuongNVHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgrDSChoLuongNVHC.Rows[e.RowIndex];
                cboLocThang.Text = row.Cells[2].Value.ToString();
                cboMaNhanVien.Text = row.Cells[1].Value.ToString();
                txtTenNV.Text = row.Cells[3].Value.ToString();
                cboQuyetDinhTangLuong.Text = row.Cells[4].Value.ToString();
                cboChucVu.Text = row.Cells[5].Value.ToString();
                txtMaLuongNV.Text = taoMaLuongNVMoi();
                txtThucLinh.Text = "";
            }
        }

        private void cboQuyetDinhTangLuong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private string taoMaLuongNVMoi()
        {
            ChamCong = new clsChamCongNVHC();
            string maNV = cboMaNhanVien.SelectedItem.ToString();
            int thang = Convert.ToInt32(cboLocThang.SelectedItem);
            string maLuongNVMoi = "2021T" + thang.ToString() + "_" + ChamCong.getChuoiMaNV(maNV,thang) + "LG";
            //2021T1_0001LG
            return maLuongNVMoi;
        }

        private void btnXoaThongTinLuong_Click(object sender, EventArgs e)
        {
            //DialogResult dlgHoiXoa;
            //if(dgrLuongNVHC.SelectedRows.Count > 0)
            //{
            //    dlgHoiXoa = MessageBox.Show("Bạn có chắc muốn xóa ??", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            //        MessageBoxDefaultButton.Button1);
            //    if(dlgHoiXoa == DialogResult.Yes)
            //    {
            //        luong.DeleteLuongTheoMaLuong(this.txtMaLuongNV.Text.ToString());  
            //    }
            //}
            //dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHC();
            //dgrDSChoLuongNVHC.DataSource = Multiclass.getDanhSachChoTinhLuongNVHC();
            DialogResult r;
            r = MessageBox.Show("Bạn có chắc chắn muốn xóa lương nhân viên này?", "Cảnh báo",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button1);
            if (r == DialogResult.Yes)
            {
                IEnumerable<tblLuongNVHC> luongNVHC = luong.getLuongTheoMa(txtMaLuongNV.Text);
                int check = luong.DeleteLuong(luongNVHC.First());
                if (check == 1)
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHC();
                    dgrDSChoLuongNVHC.DataSource = Multiclass.getDanhSachChoTinhLuongNVHC();
                }
                else
                    MessageBox.Show("Không tìm thấy đối tượng xóa", "Thông báo");
            }
        }

        private void cboLocThang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int t;
            t = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHCTheoThang(t);
            if(t != 12)
            {
                btnTinhLuongNVHC.Enabled = false;
                btnCapNhatTTLuong.Enabled = false;
                btnXoaThongTinLuong.Enabled = false;
            }
            else
            {
                btnTinhLuongNVHC.Enabled = true;
                btnCapNhatTTLuong.Enabled = true;
                btnXoaThongTinLuong.Enabled = true;
            }
        }

        private void btnLoaiLaiDanhSach_Click(object sender, EventArgs e)
        {
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHC();
            dgrDSChoLuongNVHC.DataSource = Multiclass.getDanhSachChoTinhLuongNVHC();
        }

        private void btnCapNhatTTLuong_Click(object sender, EventArgs e)
        {
            string strNDQDTL = cboQuyetDinhTangLuong.SelectedItem.ToString();
            string strTenChucVu = cboChucVu.SelectedItem.ToString();
            string strMaQDTL = qdtl.getMaQDTLTheoNoiDung(strNDQDTL);
            string strMaChucVu = PhuCapCV.getMaCVTheoTenCV(strTenChucVu);
            string strMaNV = cboMaNhanVien.SelectedItem.ToString();
            NhanVien.updateLuongTheoMaNV(strMaNV, strMaChucVu, strMaQDTL);
            int t;
            t = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
            dgrLuongNVHC.DataSource = Multiclass.getAllThongTinLuongNVHCTheoThang(t);
            MessageBox.Show("Cập nhật thông tin thành công", "Thông báo");
        }
    }
}
