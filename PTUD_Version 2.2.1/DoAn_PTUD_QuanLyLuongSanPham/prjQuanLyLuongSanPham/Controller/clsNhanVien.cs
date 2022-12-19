using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsNhanVien : clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsNhanVien()
        {
            dt = getDataContext();
        }

        #region Trường
        public string getTenTheoMaNV(string maNV)
        {
            var q = (from n in dt.tblNhanViens
                     where n.maNV.Equals(maNV)
                     select n.hoTen);
            return q.FirstOrDefault();
        }
        public string getMaChucVu(string strMaNV)
        {
            var q = from n in dt.tblNhanViens
                    where n.maNV.Equals(strMaNV)
                    select n.maCV;
            return Convert.ToString(q.FirstOrDefault());
        }
        public string getMaQDTL(string strMaNV)
        {
            var q = from n in dt.tblNhanViens
                    where n.maNV.Equals(strMaNV)
                    select n.maQDTL;
            return Convert.ToString(q.FirstOrDefault());
        }
        public void updateLuongTheoMaNV(string strMaNV, string strMaCV, string strMaQDTL)
        {
            tblNhanVien objNV = dt.tblNhanViens.Single(p => p.maNV == strMaNV);
            objNV.maQDTL = strMaQDTL;
            objNV.maCV = strMaCV;
            dt.SubmitChanges();
        }
        #endregion

        #region Nguyên
        public IEnumerable<tblNhanVien> getAllCongNhan()
        {
            IEnumerable<tblNhanVien> q= from n in dt.tblNhanViens
                                        where n.loaiNV.Equals("Công nhân")
                                        select n;
            return q;
        }
        public IEnumerable<tblNhanVien> getAllNhanVienHanhChinh()
        {
            IEnumerable<tblNhanVien> q = from n in dt.tblNhanViens
                                         where n.loaiNV.Equals("Nhân viên hành chính")
                                         select n;
            return q;
        }
        #endregion

        #region Tuấn
        public IEnumerable<dynamic> getAllNhanvien()
        {
            var q = from n in dt.tblNhanViens
                    select new { n.maNV, n.hoTen, n.gioiTinh, n.ngaySinh, n.email, n.soDienThoai, n.donViQuanLy, n.loaiNV };
            return q;
        }
        public string getTenTheoTenNV(string tenNV)
        {
            var q = (from n in dt.tblNhanViens
                     where n.maNV.Contains(tenNV)
                     select n.hoTen);
            return q.FirstOrDefault();
        }
        public tblNhanVien CheckIfExist(string strMaNv)
        {
            tblNhanVien nvtemp = (from n in dt.tblNhanViens
                                  where n.maNV.Equals(strMaNv)
                                  select n).FirstOrDefault();
            if (nvtemp != null)
                return nvtemp;
            else
                return null;
        }
        public int insertNhanVien(tblNhanVien n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maNV) != null)
                    return 0;
                else
                {
                    dt.tblNhanViens.InsertOnSubmit(n);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không thêm được " + ex.Message);
            }
        }
        public bool UpdateNhanVien(tblNhanVien nvSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblNhanVien> tam = (from n in dt.tblNhanViens
                                               where n.maNV.Equals(nvSua.maNV)
                                               select n);
                tam.First().maNV = nvSua.maNV;
                tam.First().hoTen = nvSua.hoTen;
                tam.First().gioiTinh = nvSua.gioiTinh;
                tam.First().ngaySinh = nvSua.ngaySinh;
                tam.First().email = nvSua.email;
                tam.First().soDienThoai = nvSua.soDienThoai;
                tam.First().donViQuanLy = nvSua.donViQuanLy;
                tam.First().loaiNV = nvSua.loaiNV;

                dt.SubmitChanges();
                dt.Transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không sữa được " + ex.Message);
            }
        }
        #endregion
    }
}
