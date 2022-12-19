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
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Runtime.InteropServices;
//using Microsoft.Reporting.WinForms;
using prjQuanLyLuongSanPham.GUI;
using Microsoft.Reporting.WinForms;

namespace prjQuanLyLuongSanPham
{
    public partial class frmThongKeLuong : Form
    {
        public frmThongKeLuong()
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
            //LocThang();
            addItemThang();
            cboPhongBan.Items.Add("Phòng sản xuất");
            cboPhongBan.Items.Add("Phòng tổ chức hành chính");
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
        private void cboLocThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cboPhongBan.SelectedItem != null)
            //{
            //    int t;
            //    t = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
            //    if (cboPhongBan.SelectedItem.ToString() == "Phòng tổ chức hành chính")
            //        dgrThongKeLuong.DataSource = Multiclass.getAllThongTinLuongNVHCTheoThang(t);
            //    else
            //        dgrThongKeLuong.DataSource = Multiclass.getAllThongTinLuongCNTheoThang(t);
            //}
            //else
            //{
            //    MessageBox.Show("Hãy chọn phòng ban trước", "Thông báo");
            //    cboLocThang.SelectedText = "";
            //}
        }
        private void dgrLuongNVHC_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboLocThang.SelectedIndex = -1;
            if (cboPhongBan.SelectedItem.ToString().Equals("Phòng tổ chức hành chính"))
            {
                dgrThongKeLuong.DataSource = Multiclass.thongKeLuongNVHC();
                dgrThongKeLuong.Columns[0].HeaderText = "Mã nhân viên";
                dgrThongKeLuong.Columns[1].HeaderText = "Họ tên";
                dgrThongKeLuong.Columns[2].HeaderText = "Tháng";
                dgrThongKeLuong.Columns[3].HeaderText = "Số ngày làm theo quy định";
                dgrThongKeLuong.Columns[4].HeaderText = "Số ngày làm thêm";
                dgrThongKeLuong.Columns[5].HeaderText = "Lương cơ bản";
                dgrThongKeLuong.Columns[6].HeaderText = "Lương tăng theo quyết định";
                dgrThongKeLuong.Columns[7].HeaderText = "Phụ cấp chức vụ";
                dgrThongKeLuong.Columns[8].HeaderText = "Hệ số lương";
                dgrThongKeLuong.Columns[9].HeaderText = "Tiền nộp BHXH";
                dgrThongKeLuong.Columns[10].HeaderText = "Thực lĩnh";
            }
            else
            {
                dgrThongKeLuong.DataSource = Multiclass.thongKeLuongCN();
                dgrThongKeLuong.Columns[0].HeaderText = "Mã nhân viên";
                dgrThongKeLuong.Columns[1].HeaderText = "Họ tên";
                dgrThongKeLuong.Columns[2].HeaderText = "Tháng";
                dgrThongKeLuong.Columns[3].HeaderText = "Công đoạn đã thực hiện";
                dgrThongKeLuong.Columns[4].HeaderText = "Sản phẩm";
                dgrThongKeLuong.Columns[5].HeaderText = "Số công đoạn";
                dgrThongKeLuong.Columns[6].HeaderText = "Đơn giá mỗi công đoạn";
                dgrThongKeLuong.Columns[7].HeaderText = "Số giờ làm ca 1,2";
                dgrThongKeLuong.Columns[8].HeaderText = "Số giờ làm ca 3";
                dgrThongKeLuong.Columns[9].HeaderText = "Thực lĩnh";
            }
        }

        //private void btnXuatPDF_Click(object sender, EventArgs e)
        //{
        //    #region nhap 1
        //    //if(dgrThongKeLuong.Rows.Count >0)
        //    //{
        //    //    SaveFileDialog save = new SaveFileDialog();
        //    //    save.Filter = "PDF (*.pdf)|*.pdf";
        //    //    save.FileName = "BangLuong_x_ThangX.pdf";
        //    //    bool ErrorMessage = false;
        //    //    if (save.ShowDialog() == DialogResult.OK)
        //    //    {
        //    //        if (File.Exists(save.FileName)){
        //    //            try
        //    //            {
        //    //                File.Delete(save.FileName);
        //    //            }
        //    //            catch (Exception ex)
        //    //            {
        //    //                ErrorMessage = true;
        //    //                MessageBox.Show("Không thể lưu vào ổ đĩa này" + ex.Message);
        //    //            }
        //    //        }
        //    //        if (!ErrorMessage)
        //    //        {
        //    //            try
        //    //            {
        //    //                PdfPTable pTable = new PdfPTable(dgrThongKeLuong.Columns.Count);
        //    //                pTable.DefaultCell.Padding = 5;
        //    //                pTable.WidthPercentage = 200;
        //    //                pTable.HorizontalAlignment = Element.ALIGN_LEFT;
        //    //                foreach (DataGridViewColumn col in dgrThongKeLuong.Columns)
        //    //                {
        //    //                    PdfPCell pCell = new PdfPCell(new Phrase(col.HeaderText));
        //    //                    pTable.AddCell(pCell);
        //    //                }
        //    //                foreach(DataGridViewRow viewRow in dgrThongKeLuong.Rows)
        //    //                {
        //    //                    foreach(DataGridViewCell dCell in viewRow.Cells)
        //    //                    {
        //    //                        pTable.AddCell(dCell.Value.ToString());
        //    //                    }
        //    //                }
        //    //                using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
        //    //                {
        //    //                    Document dcm = new Document(PageSize.A4,8f,16f,16f,8f);
        //    //                    dcm.Open();
        //    //                    dcm.Add(pTable);
        //    //                    fileStream.Close();
        //    //                    PdfWriter.GetInstance(dcm,fileStream);
        //    //                }
        //    //                ;
        //    //                MessageBox.Show("In bảng lương thành công!!","Thông báo");

        //    //            }
        //    //            catch (Exception ex)
        //    //            {
        //    //                MessageBox.Show("Lỗi trong quá trình xuất dữ liệu"+ ex.Message);
        //    //            }
        //    //        }
        //    //        else
        //    //        {
        //    //            MessageBox.Show("Không tìm thấy dữ liệu để xuất file", "Thông báo");
        //    //        }
        //    //    }
        //    //}
        //    #endregion
        //    #region nhap 2

        //    if (dgrThongKeLuong.Rows.Count > 0)
        //    {
        //        SaveFileDialog sfd = new SaveFileDialog();
        //        sfd.Filter = "PDF (*.pdf)|*.pdf";
        //        sfd.FileName = "Output.pdf";
        //        bool fileError = false;
        //        if (sfd.ShowDialog() == DialogResult.OK)
        //        {
        //            if (File.Exists(sfd.FileName))
        //            {
        //                try
        //                {
        //                    File.Delete(sfd.FileName);
        //                }
        //                catch (IOException ex)
        //                {
        //                    fileError = true;
        //                    MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
        //                }
        //            }
        //            if (!fileError)
        //            {
        //                try
        //                {

        //                    PdfPTable pdfTable = new PdfPTable(dgrThongKeLuong.Columns.Count);
        //                    pdfTable.DefaultCell.Padding = 3;
        //                    pdfTable.WidthPercentage = 100;
        //                    pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;

        //                    foreach (DataGridViewColumn column in dgrThongKeLuong.Columns)
        //                    {
        //                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
        //                        pdfTable.AddCell(cell);
        //                    }

        //                    foreach (DataGridViewRow row in dgrThongKeLuong.Rows)
        //                    {
        //                        foreach (DataGridViewCell cell in row.Cells)
        //                        {
        //                            pdfTable.AddCell(cell.Value.ToString());
        //                        }
        //                    }

        //                    using (FileStream stream = new FileStream(sfd.FileName, FileMode.Create))
        //                    {
        //                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
        //                        PdfWriter.GetInstance(pdfDoc, stream);
        //                        pdfDoc.Open();
        //                        pdfDoc.Add(pdfTable);
        //                        pdfDoc.Close();
        //                        stream.Close();
        //                    }

        //                    MessageBox.Show("Data Exported Successfully !!!", "Info");
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show("Error :" + ex.Message);
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No Record To Export !!!", "Info");
        //    }
        //    #endregion
        //}

        void addItemThang()
        {
            for (int i = 1; i < 13; i++)
            {
                cboLocThang.Items.Add(i);
            }
        }

        private void cboLocThang_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedItem != null)
            {
                int t;
                t = Convert.ToInt32(cboLocThang.SelectedItem.ToString());
                if (cboPhongBan.SelectedItem.ToString() == "Phòng tổ chức hành chính")
                {
                    dgrThongKeLuong.DataSource = Multiclass.thongKeLuongNVHCTheoThang(t);
                }
                else
                    dgrThongKeLuong.DataSource = Multiclass.thongKeLuongCNTheoThang(t);
            }
            else
            {
                MessageBox.Show("Hãy chọn phòng ban trước", "Thông báo");
                cboLocThang.SelectedText = "";
            }
        }

        ReportDataSource rs = new ReportDataSource();
        ReportDataSource rs3 = new ReportDataSource();

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (cboPhongBan.SelectedItem.ToString() == "Phòng tổ chức hành chính")
            {
                #region ReportOfNVHC
                List<luongNVHC> lstNVHC = new List<luongNVHC>();
                lstNVHC.Clear();

                for (int i = 0; i < dgrThongKeLuong.Rows.Count - 1; i++)
                {
                    luongNVHC lnvhc = new luongNVHC
                    {
                        maNV = dgrThongKeLuong.Rows[i].Cells[0].Value.ToString(),
                        hoTen = dgrThongKeLuong.Rows[i].Cells[1].Value.ToString(),
                        thang = int.Parse(dgrThongKeLuong.Rows[i].Cells[2].Value.ToString()),
                        soNgayLamViecThucTe = int.Parse(dgrThongKeLuong.Rows[i].Cells[3].Value.ToString()),
                        soNgayCongVuotChuan = int.Parse(dgrThongKeLuong.Rows[i].Cells[4].Value.ToString()),
                        luongCB = double.Parse(dgrThongKeLuong.Rows[i].Cells[5].Value.ToString()),
                        luongTangTheoQuyetDinh = double.Parse(dgrThongKeLuong.Rows[i].Cells[6].Value.ToString()),
                        phuCap = double.Parse(dgrThongKeLuong.Rows[i].Cells[7].Value.ToString()),
                        heSoLuongChinh = double.Parse(dgrThongKeLuong.Rows[i].Cells[8].Value.ToString()),
                        tienNopBHXH = double.Parse(dgrThongKeLuong.Rows[i].Cells[9].Value.ToString()),
                        luongChinh = double.Parse(dgrThongKeLuong.Rows[i].Cells[10].Value.ToString())
                    };
                    lstNVHC.Add(lnvhc);
                }
                rs.Name = "DataSet1";
                rs.Value = lstNVHC;
                frmBaoCaoLuongNVHC frmReportLNVHC = new frmBaoCaoLuongNVHC();
                frmReportLNVHC.reportViewer1.LocalReport.DataSources.Clear();
                frmReportLNVHC.reportViewer1.LocalReport.DataSources.Add(rs);
                frmReportLNVHC.reportViewer1.LocalReport.ReportEmbeddedResource = "prjQuanLyLuongSanPham.Report1.rdlc";
                frmReportLNVHC.ShowDialog();
                #endregion
            }
            else if (cboPhongBan.SelectedItem.ToString() == "Phòng sản xuất")
            {
                #region ReportOfCN
                List<luongCN> lstCN = new List<luongCN>();
                lstCN.Clear();
                for (int i = 0; i < dgrThongKeLuong.Rows.Count - 1; i++)
                {
                    luongCN lcn = new luongCN
                    {
                        maNV = dgrThongKeLuong.Rows[i].Cells[0].Value.ToString(),
                        hoTen = dgrThongKeLuong.Rows[i].Cells[1].Value.ToString(),
                        thang = int.Parse(dgrThongKeLuong.Rows[i].Cells[2].Value.ToString()),
                        tenCongDoan = dgrThongKeLuong.Rows[i].Cells[3].Value.ToString(),
                        //sanPham = dgrThongKeLuong.Rows[i].Cells[4].Value.ToString(),
                        soCongDoan = int.Parse(dgrThongKeLuong.Rows[i].Cells[5].Value.ToString()),
                        dongGia = double.Parse(dgrThongKeLuong.Rows[i].Cells[6].Value.ToString()),
                        soGioLamCa12 = int.Parse(dgrThongKeLuong.Rows[i].Cells[7].Value.ToString()),
                        soGioLamCa3 = int.Parse(dgrThongKeLuong.Rows[i].Cells[8].Value.ToString()),
                        luongChinh = double.Parse(dgrThongKeLuong.Rows[i].Cells[9].Value.ToString()),
                    };
                    lstCN.Add(lcn);
                }
                rs3.Name = "DataSet3";
                rs3.Value = lstCN;
                frmBaoCaoLuongCN frmReportLCN = new frmBaoCaoLuongCN();
                frmReportLCN.reportViewer2.LocalReport.DataSources.Clear();
                frmReportLCN.reportViewer2.LocalReport.DataSources.Add(rs3);
                frmReportLCN.reportViewer2.LocalReport.ReportEmbeddedResource = "prjQuanLyLuongSanPham.Report2.rdlc";
                frmReportLCN.ShowDialog();
                #endregion
            }
        }
        public class luongNVHC
        {
            public string maNV { get; set; }
            public string hoTen { get; set; }
            public int thang { get; set; }
            public int soNgayLamViecThucTe { get; set; }
            public int soNgayCongVuotChuan { get; set; }
            public double luongCB { get; set; }
            public double luongTangTheoQuyetDinh { get; set; }
            public double phuCap { get; set; }
            public double heSoLuongChinh { get; set; }
            public double tienNopBHXH { get; set; }
            public double luongChinh { get; set; }
        }

        public class luongCN
        {
            public string maNV { get; set; }
            public string hoTen { get; set; }
            public int thang { get; set; }
            public string tenCongDoan { get; set; }
            public int soCongDoan { get; set; }
            public double dongGia { get; set; }
            public int soGioLamCa12 { get; set; }
            public int soGioLamCa3 { get; set; }
            public double luongChinh { get; set; }
            //public string sanPham { get; set; }
        }
    }
}
