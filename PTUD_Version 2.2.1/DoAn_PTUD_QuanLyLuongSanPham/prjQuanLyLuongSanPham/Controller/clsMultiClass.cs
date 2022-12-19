using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsMultiClass:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsMultiClass()
        {
            dt = getDataContext();
        }
        clsChamCongNVHC chamCong;
        clsHeSoLuong heSoLuong;
        clsChucVu phuCap;
        clsQuyetDinhTangLuong luongTangQD;
        clsLuongBHXH bhxh;
        clsLuongNVHC luongNVHC;
        clsNhanVien nhanVienHC;
        clsChamCongCN chamCongCN;
        clsCongDoan congDoan;
        clsLuongCN luongCN;

        #region Trường
        public IEnumerable<dynamic> getAllThongTinLuongNVHC()
        {
            var q = from cc in dt.tblChamCongNVHCs
                    join l in dt.tblLuongNVHCs
                    on cc.maCong equals l.maCong
                    join hsl in dt.tblHeSoLuongs
                    on l.maHSL equals hsl.maHSL
                    join bhxh in dt.tblLuongBHXHs
                    on l.maBHXH equals bhxh.maBHXH
                    join nv in dt.tblNhanViens
                    on cc.maNV equals nv.maNV
                    join nv1 in dt.tblNhanViens
                    on new {l.maNV } equals new {nv1.maNV }
                    join nv2 in dt.tblNhanViens
                    on new {hsl.maNV } equals new {nv2.maNV }
                    join nv3 in dt.tblNhanViens
                    on new { bhxh.maNV} equals new {nv3.maNV }
                    join cv in dt.tblChucVus
                    on nv.maCV equals cv.maCV
                    join qd in dt.tblQuyetDinhTangLuongs
                    on nv.maQDTL equals qd.maQD
                    select new
                    {
                        l.maNV,
                        l.maLuongNVHC,
                        nv.hoTen,
                        l.luongCB,
                        qd.luongTangTheoQuyetDinh,
                        cv.phuCap,
                        hsl.heSoLuongChinh,
                        bhxh.tienNopBHXH,
                        l.luongChinh,
                        cc.thang,
                        qd.noiDungQuyetDinh,
                        cv.tenChucVu
                    };
            return q;
        }
        public IEnumerable<dynamic> TimMaHSLCanAdd(string maNV)
        {
            var q = from hsl in dt.tblHeSoLuongs
                    join nv in dt.tblNhanViens
                    on hsl.maNV equals nv.maNV
                    where hsl.maNV.Equals(maNV)
                    select new
                    {
                        HeSoLuongCanAdd = hsl.maHSL
                    };
            return q;
        }
        public IEnumerable<dynamic> TimMaChamCongCanAdd(string maNV, int thang)
        {
            var q = from cc in dt.tblChamCongNVHCs
                    join nv in dt.tblNhanViens
                    on cc.maNV equals nv.maNV
                    where cc.maNV.Equals(maNV) && cc.thang == thang
                    select new
                    {
                        AddChamCong = cc.maCong
                    };
            return q;
        }
        public IEnumerable<dynamic> TimMaBHXHCanAdd(string maNV)
        {
            var q = from bh in dt.tblLuongBHXHs
                    join nv in dt.tblNhanViens
                    on bh.maNV equals nv.maNV
                    where bh.maNV.Equals(maNV)
                    select new
                    {
                        AddMaBHXH = bh.maBHXH
                    };
            return q;
        }
        public void UpdateLuongByHSL(string strMaLuong, string strMaHSL)
        {

            tblLuongNVHC objluong = dt.tblLuongNVHCs.Single(n => n.maLuongNVHC == strMaLuong);
            objluong.maHSL = strMaHSL;
            dt.SubmitChanges();
        }
        public void UpdateLuongByChamCong(string strMaLuong, string strMaCC)
        {

            tblLuongNVHC objluong = dt.tblLuongNVHCs.Single(n => n.maLuongNVHC == strMaLuong);
            objluong.maCong = strMaCC;
            dt.SubmitChanges();
        }
        public void UpdateLuongByBHXH(string strMaLuong, string strMaBHXH)
        {

            tblLuongNVHC objluong = dt.tblLuongNVHCs.Single(n => n.maLuongNVHC == strMaLuong);
            objluong.maBHXH = strMaBHXH;
            dt.SubmitChanges();
        }

        public double tinhLuongTangCa(string strMaCong, string strMaHSL)
        {
            chamCong = new clsChamCongNVHC();
            heSoLuong = new clsHeSoLuong();
            double soNgayCongVuotChuan = Convert.ToDouble(
                chamCong.getSoNgayCongVuotChuan(strMaCong));
            double hsl = Convert.ToDouble(heSoLuong.getHeSoLuongChinh(strMaHSL));
            return soNgayCongVuotChuan * hsl * 1.5 * 120000;
        }

        // truyền vào mã lương thích hợp
        // sẽ truy vấn được 3 mã tương ứng của hsl, bhxh, chamcong
        // truyền vào mã chức vụ và mã tăng lương theo quyết định
        // thông qua 2 combobox tương ứng
        public void tinhThucLinh(string strMaLuong, string strMaNV)
        {
            chamCong = new clsChamCongNVHC();
            heSoLuong = new clsHeSoLuong();
            phuCap = new clsChucVu();
            luongTangQD = new clsQuyetDinhTangLuong();
            bhxh = new clsLuongBHXH();
            luongNVHC = new clsLuongNVHC();
            nhanVienHC = new clsNhanVien();
            double thucLinh;
            double luongCB = luongNVHC.getLuongCB(strMaLuong);
            double hsl = heSoLuong.getHeSoLuongChinh(luongNVHC.getMaHSL(strMaLuong));
            int thucTe = chamCong.getSoNgayLamViecThucTe(luongNVHC.getMaCong(strMaLuong));
            double tienNopBHXH = bhxh.getTienNopBHXH(luongNVHC.getMaBHXH(strMaLuong));
            double chuan = chamCong.getSoNgayCongChuan(luongNVHC.getMaCong(strMaLuong));
            double pc = phuCap.getPhuCap(nhanVienHC.getMaChucVu(strMaNV));
            double luongTangTheoQD = luongTangQD.getLuongTangQD(nhanVienHC.getMaQDTL(strMaNV));
            if (chamCong.getSoNgayCongVuotChuan(luongNVHC.getMaCong(strMaLuong)) > 0) // sai chưa sửa
            {
                thucLinh = luongCB * hsl
                    + tinhLuongTangCa(luongNVHC.getMaCong(strMaLuong), luongNVHC.getMaHSL(strMaLuong))
                    + pc + luongTangTheoQD - tienNopBHXH;
            }
            else
            {
                thucLinh = ((luongCB * hsl * Convert.ToDouble(thucTe)) / Convert.ToDouble(chuan))
                    + pc + luongTangTheoQD - tienNopBHXH;
            }
            tblLuongNVHC objluong = dt.tblLuongNVHCs.Single(n => n.maLuongNVHC == strMaLuong);
            objluong.luongChinh = Math.Round(thucLinh);
            dt.SubmitChanges();
        }
        public IEnumerable<dynamic> getAllThongTinLuongCN()
        {
            var q = from cd in dt.tblCongDoans
                    join cc in dt.tblChamCongCNs
                    on cd.maCD equals cc.maCD
                    join l in dt.tblLuongCNs
                    on cc.maCong equals l.maCong
                    join cn in dt.tblNhanViens
                    on cc.maNV equals cn.maNV
                    join cn2 in dt.tblNhanViens
                    on new { l.maNV } equals new { cn2.maNV }
                    join sp in dt.tblSanPhams
                    on cd.maSP equals sp.maSP
                    select new
                    {
                        l.maLuongCN,
                        cn.maNV,
                        cn.hoTen,
                        sp.tenSanPham,
                        cd.tenCongDoan,
                        cc.soCongDoan,
                        cd.donGia,
                        l.luongChinh,
                        cc.thang,
                        l.soGioLamCa12,
                        l.soGioLamCa3
                    };
            return q;
        }
        public void tinhThucLinhCN(string strMaLuongCN,/* string maCN,*/ string maCD, int scd,
            int soGioCa12, int soGioCa3)
        {
            chamCongCN = new clsChamCongCN();
            congDoan = new clsCongDoan();
            luongCN = new clsLuongCN();
            //int scd = chamCongCN.getSoCongDoan(maCN);
            double donGia = congDoan.getDonGiaCongDoan(maCD);
            //int soGioCa12 = luongCN.getSoGioCa12(strMaLuongCN);
            //int soGioCa3 = luongCN.getSoGioCa3(strMaLuongCN);
            double luong;
            luong = ((scd * donGia) / 208) * soGioCa12 * 1.0 +
                ((scd * donGia) / 208) * soGioCa3 * 1.3;
            tblLuongCN objluong = dt.tblLuongCNs.Single(n => n.maLuongCN == strMaLuongCN);
            objluong.luongChinh = Math.Round(luong);
            dt.SubmitChanges();
        }
        public IEnumerable<dynamic> thongKeLuongNVHC()
        {
            var q = from cc in dt.tblChamCongNVHCs
                    join l in dt.tblLuongNVHCs
                    on cc.maCong equals l.maCong
                    join hsl in dt.tblHeSoLuongs
                    on l.maHSL equals hsl.maHSL
                    join bhxh in dt.tblLuongBHXHs
                    on l.maBHXH equals bhxh.maBHXH
                    join nv in dt.tblNhanViens
                    on cc.maNV equals nv.maNV
                    join nv1 in dt.tblNhanViens
                    on new { l.maNV } equals new { nv1.maNV }
                    join nv2 in dt.tblNhanViens
                    on new { hsl.maNV } equals new { nv2.maNV }
                    join nv3 in dt.tblNhanViens
                    on new { bhxh.maNV } equals new { nv3.maNV }
                    join cv in dt.tblChucVus
                    on nv.maCV equals cv.maCV
                    join qd in dt.tblQuyetDinhTangLuongs
                    on nv.maQDTL equals qd.maQD
                    select new
                    {
                        l.maNV,
                        nv.hoTen,
                        cc.thang,
                        cc.soNgayLamViecThucTe,
                        cc.soNgayCongVuotChuan,
                        l.luongCB,
                        qd.luongTangTheoQuyetDinh,
                        cv.phuCap,
                        hsl.heSoLuongChinh,
                        bhxh.tienNopBHXH,
                        l.luongChinh,
                    };
            return q;
        }
        public IEnumerable<dynamic> thongKeLuongNVHCTheoThang(int thang)
        {
            var q = from cc in dt.tblChamCongNVHCs
                    join l in dt.tblLuongNVHCs
                    on cc.maCong equals l.maCong
                    join hsl in dt.tblHeSoLuongs
                    on l.maHSL equals hsl.maHSL
                    join bhxh in dt.tblLuongBHXHs
                    on l.maBHXH equals bhxh.maBHXH
                    join nv in dt.tblNhanViens
                    on cc.maNV equals nv.maNV
                    join nv1 in dt.tblNhanViens
                    on new { l.maNV } equals new { nv1.maNV }
                    join nv2 in dt.tblNhanViens
                    on new { hsl.maNV } equals new { nv2.maNV }
                    join nv3 in dt.tblNhanViens
                    on new { bhxh.maNV } equals new { nv3.maNV }
                    join cv in dt.tblChucVus
                    on nv.maCV equals cv.maCV
                    join qd in dt.tblQuyetDinhTangLuongs
                    on nv.maQDTL equals qd.maQD
                    where cc.thang == thang
                    select new
                    {
                        l.maNV,
                        nv.hoTen,
                        cc.thang,
                        cc.soNgayLamViecThucTe,
                        cc.soNgayCongVuotChuan,
                        l.luongCB,
                        qd.luongTangTheoQuyetDinh,
                        cv.phuCap,
                        hsl.heSoLuongChinh,
                        bhxh.tienNopBHXH,
                        l.luongChinh,
                    };
            return q;
        }
        public IEnumerable<dynamic> thongKeLuongCN()
        {
            var q = from cd in dt.tblCongDoans
                    join cc in dt.tblChamCongCNs
                    on cd.maCD equals cc.maCD
                    join l in dt.tblLuongCNs
                    on cc.maCong equals l.maCong
                    join cn in dt.tblNhanViens
                    on cc.maNV equals cn.maNV
                    join cn2 in dt.tblNhanViens
                    on new { l.maNV } equals new { cn2.maNV }
                    join sp in dt.tblSanPhams
                    on cd.maSP equals sp.maSP
                    select new
                    {
                        cn.maNV,
                        cn.hoTen,
                        cc.thang,
                        cd.tenCongDoan,
                        sp.tenSanPham,
                        cc.soCongDoan,
                        cd.donGia,
                        l.soGioLamCa12,
                        l.soGioLamCa3,
                        l.luongChinh
                    };
            return q;
        }
        public IEnumerable<dynamic> thongKeLuongCNTheoThang(int thang)
        {
            var q = from cd in dt.tblCongDoans
                    join cc in dt.tblChamCongCNs
                    on cd.maCD equals cc.maCD
                    join l in dt.tblLuongCNs
                    on cc.maCong equals l.maCong
                    join cn in dt.tblNhanViens
                    on cc.maNV equals cn.maNV
                    join cn2 in dt.tblNhanViens
                    on new { l.maNV } equals new { cn2.maNV }
                    join sp in dt.tblSanPhams
                    on cd.maSP equals sp.maSP
                    where cc.thang == thang
                    select new
                    {
                        cn.maNV,
                        cn.hoTen,
                        cc.thang,
                        cd.tenCongDoan,
                        sp.tenSanPham,
                        cc.soCongDoan,
                        cd.donGia,
                        l.soGioLamCa12,
                        l.soGioLamCa3,
                        l.luongChinh
                    };
            return q;
        }
        public IEnumerable<dynamic> getDSchoTinhLuongCN()
        {

            var q1 = from cc in dt.tblChamCongCNs
                     join l in dt.tblLuongCNs
                     on cc.maCong equals l.maCong
                     join cn in dt.tblNhanViens
                     on cc.maNV equals cn.maNV
                     join cn2 in dt.tblNhanViens
                     on new { l.maNV } equals new { cn2.maNV }
                     select new
                     {
                         cc.maCong
                     };

            var q2 = from cc in dt.tblChamCongCNs
                     join cn in dt.tblNhanViens
                     on cc.maNV equals cn.maNV
                     join cd in dt.tblCongDoans
                     on cc.maCD equals cd.maCD
                     join sp in dt.tblSanPhams
                     on cd.maSP equals sp.maSP
                     select new
                     {
                         cn.maNV,
                         cn.hoTen,
                         cc.maCong,
                         cc.thang,
                         cc.soCongDoan,
                         cd.tenCongDoan,
                         sp.tenSanPham
                     };
            var kq = q2.Where(p => !q1.Any(p2 => p2.maCong == p.maCong));
            return kq;
        }
        public IEnumerable<dynamic> getAllThongTinLuongCNTheoThang(int thang)
        {
            var q = from cd in dt.tblCongDoans
                    join cc in dt.tblChamCongCNs
                    on cd.maCD equals cc.maCD
                    join l in dt.tblLuongCNs
                    on cc.maCong equals l.maCong
                    join cn in dt.tblNhanViens
                    on cc.maNV equals cn.maNV
                    join cn2 in dt.tblNhanViens
                    on new { l.maNV } equals new { cn2.maNV }
                    join sp in dt.tblSanPhams
                    on cd.maSP equals sp.maSP
                    where cc.thang == thang
                    select new
                    {
                        l.maLuongCN,
                        cn.maNV,
                        cn.hoTen,
                        sp.tenSanPham,
                        cd.tenCongDoan,
                        cc.soCongDoan,
                        cd.donGia,
                        l.luongChinh,
                        cc.thang,
                        l.soGioLamCa12,
                        l.soGioLamCa3
                    };
            return q;
        }

        public IEnumerable<dynamic> getDanhSachChoTinhLuongNVHC()
        {
            var q1 = from cc in dt.tblChamCongNVHCs
                     join l in dt.tblLuongNVHCs
                     on cc.maCong equals l.maCong
                     select new
                     {
                         cc.maCong
                     };
            var q2 = from cc in dt.tblChamCongNVHCs
                     join nv in dt.tblNhanViens
                     on cc.maNV equals nv.maNV
                     join cv in dt.tblChucVus
                     on nv.maCV equals cv.maCV
                     join qd in dt.tblQuyetDinhTangLuongs
                     on nv.maQDTL equals qd.maQD
                     select new
                     {
                         cc.maCong,
                         nv.maNV,
                         cc.thang,
                         nv.hoTen,
                         qd.noiDungQuyetDinh,
                         cv.tenChucVu
                     };
            var kq = q2.Where(p => !q1.Any(p2 => p2.maCong == p.maCong));
            return kq;
        }

        public IEnumerable<dynamic> getAllThongTinLuongNVHCTheoThang(int thang)
        {
            var q = from cc in dt.tblChamCongNVHCs
                    join l in dt.tblLuongNVHCs
                    on cc.maCong equals l.maCong
                    join hsl in dt.tblHeSoLuongs
                    on l.maHSL equals hsl.maHSL
                    join bhxh in dt.tblLuongBHXHs
                    on l.maBHXH equals bhxh.maBHXH
                    join nv in dt.tblNhanViens
                    on cc.maNV equals nv.maNV
                    join nv1 in dt.tblNhanViens
                    on new { l.maNV } equals new { nv1.maNV }
                    join nv2 in dt.tblNhanViens
                    on new { hsl.maNV } equals new { nv2.maNV }
                    join nv3 in dt.tblNhanViens
                    on new { bhxh.maNV } equals new { nv3.maNV }
                    join cv in dt.tblChucVus
                    on nv.maCV equals cv.maCV
                    join qd in dt.tblQuyetDinhTangLuongs
                    on nv.maQDTL equals qd.maQD
                    where cc.thang == thang
                    select new
                    {
                        l.maNV,
                        l.maLuongNVHC,
                        nv.hoTen,
                        l.luongCB,
                        qd.luongTangTheoQuyetDinh,
                        cv.phuCap,
                        hsl.heSoLuongChinh,
                        bhxh.tienNopBHXH,
                        l.luongChinh,
                        cc.thang,
                        qd.noiDungQuyetDinh,
                        cv.tenChucVu
                    };
            return q;
        }

        
        
        #endregion

        #region Nguyên
        public IEnumerable<dynamic> GetTTHSL()
        {
                var q = from hsl in dt.tblHeSoLuongs
                        join nv in dt.tblNhanViens
                        on hsl.maNV equals nv.maNV
                        select new
                        {
                            nv.maNV,
                            nv.hoTen,
                            hsl.maHSL,
                            hsl.heSoLuongCB,
                            hsl.heSoLuongChinh,
                            hsl.trinhDoHocVan,
                            hsl.ngoaiNgu,
                            hsl.thamNienCongTac,
                            hsl.ngayBatDauThamGiaCongTac,
                        };
                return q;
        }
        public IEnumerable<dynamic> GetTimKiemTTHSLTheoMaNV(String strMaNV)
        {
            var q = from hsl in dt.tblHeSoLuongs
                    join nv in dt.tblNhanViens
                    on hsl.maNV equals nv.maNV
                    where hsl.maNV.Contains(strMaNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        hsl.maHSL,
                        hsl.heSoLuongCB,
                        hsl.heSoLuongChinh,
                        hsl.trinhDoHocVan,
                        hsl.ngoaiNgu,
                        hsl.thamNienCongTac,
                        hsl.ngayBatDauThamGiaCongTac,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTimKiemTTHSLTheoTenNV(String strTenNV)
        {
            var q = from hsl in dt.tblHeSoLuongs
                    join nv in dt.tblNhanViens
                    on hsl.maNV equals nv.maNV
                    where nv.hoTen.Contains(strTenNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        hsl.maHSL,
                        hsl.heSoLuongCB,
                        hsl.heSoLuongChinh,
                        hsl.trinhDoHocVan,
                        hsl.ngoaiNgu,
                        hsl.thamNienCongTac,
                        hsl.ngayBatDauThamGiaCongTac,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTSanPham()
        {
            var q = from sp in dt.tblSanPhams
                    join hd in dt.tblHopDongs
                    on sp.maHD equals hd.maHD
                    select new
                    {
                        sp.maSP,
                        sp.tenSanPham,
                        hd.tenHopDong,
                        sp.loaiSanPham,
                        sp.donViTinh,
                        sp.donGia,
                        sp.soLuong,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTCongDoan()
        {
            var q = from cd in dt.tblCongDoans
                    join sp in dt.tblSanPhams
                    on cd.maSP equals sp.maSP
                    select new
                    {
                        cd.maCD,
                        cd.tenCongDoan,
                        sp.tenSanPham,
                        cd.thuTuCongDoan,
                        cd.donGia,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTPhanCongCN()
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        cccn.thang,
                        cd.tenCongDoan,
                    };

            return q;
        }
        public IEnumerable<dynamic> GetTimKiemTTPhanCongCNTheoMaNV(String maNV)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.maNV.Contains(maNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        cccn.thang,
                        cd.tenCongDoan,
                    };

            return q;
        }
        public IEnumerable<dynamic> GetTimKiemTTPhanCongCNTheoTenNV(String tenNV)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.hoTen.Contains(tenNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        cccn.thang,
                        cd.tenCongDoan,
                    };

            return q;
        }
        public string getCongDoanTheoMaNVThang(string maNV)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.maNV.Equals(maNV) 
                    select cd.maCD;
            return q.FirstOrDefault();
        }
        public IEnumerable<dynamic> GetTTLuongBHXH()
        {
            var q = from nv in dt.tblNhanViens
                    join bh in dt.tblLuongBHXHs
                    on nv.maNV equals bh.maNV
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        bh.maBHXH,
                        bh.thang,
                        //bh.soNgayNghiCoPhep,
                        //bh.tongSoNgayNghi,
                        //bh.tienNopBHXH,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTLuongBHXHTheoMaNV(string strMaNV)
        {
            var q = from nv in dt.tblNhanViens
                    join bh in dt.tblLuongBHXHs
                    on nv.maNV equals bh.maNV
                    where nv.maNV.Contains(strMaNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        bh.maBHXH,
                        bh.thang,
                        bh.soNgayNghiCoPhep,
                        bh.tongSoNgayNghi,
                        bh.tienNopBHXH,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTLuongBHXHTheoTenNV(string strTenNV)
        {
            var q = from nv in dt.tblNhanViens
                    join bh in dt.tblLuongBHXHs
                    on nv.maNV equals bh.maNV
                    where nv.hoTen.Contains(strTenNV)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        bh.maBHXH,
                        bh.thang,
                        bh.soNgayNghiCoPhep,
                        bh.tongSoNgayNghi,
                        bh.tienNopBHXH,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTChamCongNVHC()
        {
            var q = from nv in dt.tblNhanViens
                    join ccnvhc in dt.tblChamCongNVHCs
                    on nv.maNV equals ccnvhc.maNV
                    where nv.loaiNV.Equals("Nhân viên hành chính")
                    select new
                    {
                        ccnvhc.maCong,
                        ccnvhc.maNV,
                        nv.hoTen,
                        ccnvhc.thang,
                        ccnvhc.soNgayLamViecThucTe,
                        ccnvhc.soNgayCongChuan,
                        ccnvhc.soNgayCongVuotChuan,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTChamCongNVHCTheoMaNV(string strMaNV)
        {
            var q = from nv in dt.tblNhanViens
                    join ccnvhc in dt.tblChamCongNVHCs
                    on nv.maNV equals ccnvhc.maNV
                    where (nv.loaiNV.Equals("Nhân viên hành chính")) && (ccnvhc.maNV.Contains(strMaNV))
                    select new
                    {
                        ccnvhc.maCong,
                        ccnvhc.maNV,
                        nv.hoTen,
                        ccnvhc.thang,
                        ccnvhc.soNgayLamViecThucTe,
                        ccnvhc.soNgayCongChuan,
                        ccnvhc.soNgayCongVuotChuan,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTChamCongNVHCTheoTenNV(string strTenNV)
        {
            var q = from nv in dt.tblNhanViens
                    join ccnvhc in dt.tblChamCongNVHCs
                    on nv.maNV equals ccnvhc.maNV
                    where (nv.loaiNV.Equals("Nhân viên hành chính"))&&(nv.hoTen.Contains(strTenNV))
                    select new
                    {
                        ccnvhc.maCong,
                        ccnvhc.maNV,
                        nv.hoTen,
                        ccnvhc.thang,
                        ccnvhc.soNgayLamViecThucTe,
                        ccnvhc.soNgayCongChuan,
                        ccnvhc.soNgayCongVuotChuan,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTChamCongCN()
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân")
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                        cd.soCongDoanCoTheLam
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTChamCongCNTheoMa(string strmaNV)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân")&&nv.maNV.Contains(strmaNV)
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                        cd.soCongDoanCoTheLam
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTChamCongCNTheoTen(string strTenNV)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân") && nv.hoTen.Contains(strTenNV)
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                        cd.soCongDoanCoTheLam
                    };
            return q;
        }
        public string getTenCDTheoMaCong(string strMaCong)
        {
            var q = from cd in dt.tblCongDoans
                     join ccnvcn in dt.tblChamCongCNs
                     on cd.maCD equals ccnvcn.maCD
                     where ccnvcn.maCong.Equals(strMaCong)
                    select cd.tenCongDoan;
            return (q.FirstOrDefault().ToString());
        }
        public IEnumerable<dynamic> GetTKTTChamCongCNTheoMaThang(string strmaNV, int thang)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân") && nv.maNV.Contains(strmaNV) && cccn.thang == thang
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                        cd.soCongDoanCoTheLam
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKTTChamCongCNTheoTenThang(string strTenNV, int thang)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân") && nv.hoTen.Contains(strTenNV) && cccn.thang == thang
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                        cd.soCongDoanCoTheLam
                    };
            return q;
        }
        public string getSCDCTLTheoMaCong(string maCong)
        {
            var q = from n in dt.tblChamCongCNs
                    join cd in dt.tblCongDoans
                    on n.maCD equals cd.maCD
                    where n.maCong.Equals(maCong)
                    select cd.soCongDoanCoTheLam;
            return (q.FirstOrDefault()).ToString();
        }
        public IEnumerable<dynamic> GetTKCN(string maNV, string tenNV, string sdt)
        {
            var q = from nv in dt.tblNhanViens
                    where nv.loaiNV.Equals("Công nhân") && nv.maNV.Contains(maNV) && nv.hoTen.Contains(tenNV) && nv.soDienThoai.Contains(sdt)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        nv.gioiTinh,
                        nv.ngaySinh,
                        nv.soDienThoai,
                        nv.email,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKNVHC(string maNV, string tenNV, string sdt)
        {
            var q = from nv in dt.tblNhanViens
                    join hsl in dt.tblHeSoLuongs
                    on nv.maNV equals hsl.maNV
                    where nv.maNV.Contains(maNV) && nv.hoTen.Contains(tenNV) && nv.soDienThoai.Contains(sdt)
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        nv.gioiTinh,
                        nv.ngaySinh,
                        nv.soDienThoai,
                        nv.email,
                        hsl.trinhDoHocVan,
                        hsl.ngoaiNgu,
                        hsl.ngayBatDauThamGiaCongTac,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKCNFull()
        {
            var q = from nv in dt.tblNhanViens
                    where nv.loaiNV.Equals("Công nhân")
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        nv.gioiTinh,
                        nv.ngaySinh,
                        nv.soDienThoai,
                        nv.email,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTKNVHCFull()
        {
            var q = from nv in dt.tblNhanViens
                    join hsl in dt.tblHeSoLuongs
                    on nv.maNV equals hsl.maNV
                    select new
                    {
                        nv.maNV,
                        nv.hoTen,
                        nv.gioiTinh,
                        nv.ngaySinh,
                        nv.soDienThoai,
                        nv.email,
                        hsl.trinhDoHocVan,
                        hsl.ngoaiNgu,
                        hsl.ngayBatDauThamGiaCongTac,
                    };
            return q;
        }
        public IEnumerable<dynamic> GetTTChamCongCNThang(int thang)
        {
            var q = from nv in dt.tblNhanViens
                    join cccn in dt.tblChamCongCNs
                    on nv.maNV equals cccn.maNV
                    join cd in dt.tblCongDoans
                    on cccn.maCD equals cd.maCD
                    where nv.loaiNV.Equals("Công nhân") && cccn.thang == thang
                    select new
                    {
                        cccn.maCong,
                        nv.maNV,
                        nv.hoTen,
                        cd.tenCongDoan,
                        cccn.thang,
                        cccn.ca,
                        cccn.soCongDoan,
                        cccn.soCongDoanThietHai,
                    };
            return q;
        }
        #endregion
    }
}
