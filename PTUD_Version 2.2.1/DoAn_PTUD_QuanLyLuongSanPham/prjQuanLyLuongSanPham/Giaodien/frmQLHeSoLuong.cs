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
    public partial class frmQLHeSoLuong : Form
    {
        public frmQLHeSoLuong()
        {
            InitializeComponent();
        }

        clsMultiClass Multiclass;
        clsHeSoLuong HeSoLuong;
        clsNhanVien NhanVien;

        private void frmQLHeSoLuong_Load(object sender, EventArgs e)
        {
            Multiclass = new clsMultiClass();
            HeSoLuong = new clsHeSoLuong();
            NhanVien = new clsNhanVien();

            IEnumerable<tblHeSoLuong> dsHSL=HeSoLuong.getALLHSL();
            UpdateAllTNCT(dsHSL);
            UpdateAllHSLC(dsHSL);

            txtNgayBDCT.Format = DateTimePickerFormat.Custom;
            txtNgayBDCT.CustomFormat = "dd/MM/yyyy";

            dgvHSL.DataSource = Multiclass.GetTTHSL();
            NameColumn();

            LoadNhanVienToCbo();
        }
        private void NameColumn()
        {
            dgvHSL.Columns[0].HeaderText = "Mã nhân viên";
            dgvHSL.Columns[1].HeaderText = "Tên nhân viên";
            dgvHSL.Columns[2].HeaderText = "Mã Hệ số lương";
            dgvHSL.Columns[3].HeaderText = "Hệ số lương cơ bản";
            dgvHSL.Columns[4].HeaderText = "Hệ số lương chính";
            dgvHSL.Columns[5].HeaderText = "Trình độ học vấn";
            dgvHSL.Columns[6].HeaderText = "Ngoại ngữ";
            dgvHSL.Columns[7].HeaderText = "Thăm niên công tác";
            dgvHSL.Columns[8].HeaderText = "Ngày bắt đầu công tác";
        }
        private void UpdateAllTNCT(IEnumerable<tblHeSoLuong> dsHSL)
        {
            foreach (tblHeSoLuong hsl in dsHSL)
                HeSoLuong.UpdateTNCT(HeSoLuong.getTTHSLTheoMa(hsl.maHSL));
        }
        private void UpdateAllHSLC(IEnumerable<tblHeSoLuong> dsHSL)
        {
            foreach (tblHeSoLuong hsl in dsHSL)
                HeSoLuong.UpdateHSLC(HeSoLuong.getTTHSLTheoMa(hsl.maHSL));
        }
        public void LoadNhanVienToCbo()
        {
            IEnumerable<tblNhanVien> dsCN = NhanVien.getAllNhanVienHanhChinh();
            cboMaNV.DisplayMember = "maNV";
            cboMaNV.ValueMember = "maNV";
            cboMaNV.DataSource = dsCN;
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblHeSoLuong n =TaoHeSoLuong();
                HeSoLuong.UpdateHeSoLuong(n);
                HeSoLuong.UpdateTNCT(HeSoLuong.getTTHSLTheoMa(n.maHSL));
                MessageBox.Show("Cập nhập thông tin hệ số lương thành công", "Thông báo");
                dgvHSL.DataSource = Multiclass.GetTTHSL();
                txtTuKhoa.Text = null;
                cboMaNV.SelectedIndex = 0;
            }
             else
                 MessageBox.Show("Bạn chưa nhập đủ thông tin", "Thông báo");
        }
        tblHeSoLuong TaoHeSoLuong()
        {
            tblHeSoLuong n = new tblHeSoLuong();
            n.maNV = cboMaNV.SelectedValue.ToString();
            n.maHSL = txtMaHSL.Text;
            n.heSoLuongCB = double.Parse(txtHSLCB.Text);
            n.heSoLuongChinh = double.Parse(txtHSLC.Text);
            n.trinhDoHocVan = cboTDHV.Text;
            n.ngoaiNgu = cboNgoaiNgu.Text;
            DateTime d= DateTime.Parse(txtNgayBDCT.Text);
            n.ngayBatDauThamGiaCongTac = DateTime.Parse(d.ToShortDateString());
            return n;
        }
        bool KTDLRong()
        {
            if (txtHSLCB.Text.Equals(""))
                return true;
            else
                return false;
        }
        private void txtTK__TextChanged(object sender, EventArgs e)
        {
            if (radTheoMaNV.Checked == true)
                dgvHSL.DataSource = Multiclass.GetTimKiemTTHSLTheoMaNV(txtTuKhoa.Text);
            else
                dgvHSL.DataSource = Multiclass.GetTimKiemTTHSLTheoTenNV(txtTuKhoa.Text);

        }

        private void radTheoMaNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoMaNV.Checked==true)
                dgvHSL.DataSource = Multiclass.GetTimKiemTTHSLTheoMaNV(txtTuKhoa.Text);
        }

        private void radTheoTenNV_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTuKhoa.Text != null && radTheoTenNV.Checked == true)
                dgvHSL.DataSource = Multiclass.GetTimKiemTTHSLTheoTenNV(txtTuKhoa.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dgvHSL.DataSource = Multiclass.GetTTHSL();
            txtTuKhoa.Text = null;
        }

        private void dgvHSL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHSL.Rows[e.RowIndex];
                cboMaNV.Text = row.Cells[0].Value.ToString();
            }
        }

        private void cboMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtTenNV.Text = NhanVien.getTenTheoMaNV(cboMaNV.Text);
            txtMaHSL.Text = HeSoLuong.getMaHSLTheoMaNV(cboMaNV.Text);
            txtHSLCB.Text = HeSoLuong.getHSLCBTheoMaNV(cboMaNV.Text);
            txtHSLC.Text = HeSoLuong.getHSLCTheoMaNV(cboMaNV.Text);
            cboTDHV.Text = HeSoLuong.getTDHVTheoMaNV(cboMaNV.Text);
            cboNgoaiNgu.Text = HeSoLuong.getNNTheoMaNV(cboMaNV.Text);
            txtTNCT.Text = HeSoLuong.getTNCTTheoMaNV(cboMaNV.Text).ToString();
            txtNgayBDCT.Text = HeSoLuong.getNBDCTTheoMaNV(cboMaNV.Text).ToString(); 
        }

        private void txtNgayBDCT_ValueChanged(object sender, EventArgs e)
        {
            DateTime d = DateTime.Parse(txtNgayBDCT.Text);
            txtTNCT.Text = (DateTime.Now.Year - d.Year + 1).ToString();
            if (DateTime.Now < d)
            {
                MessageBox.Show("Ngày bắt đầu công tác trước ngày hiện tại", "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning,
                            MessageBoxDefaultButton.Button1);
                txtNgayBDCT.Text = DateTime.Now.ToString();
            }
        }

        private void cboTDHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt=0;
            switch (HeSoLuong.getTDHVTheoMaNV(cboMaNV.Text))
            {
                case "Sơ cấp":
                    vt = 1;
                    break;
                case "Trung cấp":
                    vt = 2;
                    break;
                case "Cao đẳng":
                    vt = 3;
                    break;
                case "Cử nhân":
                    vt = 4;
                    break;
                case "Thạch sĩ":
                    vt = 5;
                    break;
            }
            double hslc= double.Parse(HeSoLuong.getHSLCTheoMaNV(cboMaNV.Text))-(vt*0.1)+ ((cboTDHV.SelectedIndex + 1) * 0.1);
            txtHSLC.Text = hslc.ToString();
        }

        private void txtHSLCB__TextChanged(object sender, EventArgs e)
        {
            if (txtHSLCB.Text == "")
                txtHSLC.Text = null;
            else
                txtHSLC.Text = HeSoLuong.getHSLCThayDoiTheoHSL(HeSoLuong.getTTHSLTheoMa(txtMaHSL.Text),double.Parse(txtHSLCB.Text)).ToString();
        }

        private void cboNgoaiNgu_SelectedIndexChanged(object sender, EventArgs e)
        {
            int vt = 0;
            switch (HeSoLuong.getNNTheoMaNV(cboMaNV.Text))
            {
                case "A1":
                    vt = 1;
                    break;
                case "A2":
                    vt = 2;
                    break;
                case "B1":
                    vt = 3;
                    break;
                case "B2":
                    vt = 4;
                    break;
                case "C1":
                    vt = 5;
                    break;
                case "C2":
                    vt = 6;
                    break;

            }
            double hslc = double.Parse(HeSoLuong.getHSLCTheoMaNV(cboMaNV.Text)) - (vt * 0.1) + ((cboNgoaiNgu.SelectedIndex + 1) * 0.1);
            txtHSLC.Text = hslc.ToString();
        }

        private void txtTNCT_TextChanged(object sender, EventArgs e)
        {
            int vt = 0;
            int tnct=int.Parse(txtTNCT.Text);
            if (tnct >= 1 && tnct < 5)
                vt=1;
            else
               if (tnct >= 5 && tnct < 10)
                vt=2;
            else
                vt=3;
            int vt_P = 0;
            int tnct_P = HeSoLuong.getTNCTTheoMaNV(cboMaNV.Text);
            if (tnct_P >= 1 && tnct_P < 5)
                vt_P = 1;
            else
               if (tnct_P >= 5 && tnct_P < 10)
                vt_P = 2;
            else
                vt_P = 3;

            double hslc = double.Parse(HeSoLuong.getHSLCTheoMaNV(cboMaNV.Text)) - (vt_P * 0.1) + (vt * 0.1);
            txtHSLC.Text = hslc.ToString();
        }
    }
}
