using prjQuanLyLuongSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQuanLyLuongSanPham.Method
{
    class clsSanPham:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsSanPham()
        {
            dt=getDataContext();
        }
        public IEnumerable<tblSanPham> getAllSanPham()
        {
            IEnumerable<tblSanPham> q = from n in dt.tblSanPhams
                                             select n;
            return q;
        }
        public IEnumerable<tblSanPham> getSanPhamTheoMa(String strMaSP)
        {
            IEnumerable<tblSanPham> q = from n in dt.tblSanPhams
                                        where n.maSP.Equals(strMaSP)
                                        select n;
            return q;
        }
        public int getSoLuongSPTheoMa(string strMaSP)
        {
            var q = (from n in dt.tblSanPhams
                     where n.maSP.Equals(strMaSP)
                     select n.soLuong).FirstOrDefault();
            return Convert.ToInt32(q);
        }
        public IEnumerable<tblSanPham> getSanPhamTheoHopDong(String strMaHD)
        {
            IEnumerable<tblSanPham> q = from n in dt.tblSanPhams
                                        where n.maHD.Equals(strMaHD)
                                        select n;
            return q;
        }
        public String getTenSanPhamTheoMaSP(String strMaSP)
        {
            var q = from n in dt.tblSanPhams
                                        where n.maSP.Equals(strMaSP)
                                        select n.tenSanPham;
            return q.FirstOrDefault();
        }
        public String getMaHopDongTheoMaSP(String strMaSP)
        {
            var q = from n in dt.tblSanPhams
                    where n.maSP.Equals(strMaSP)
                    select n.maHD;
            return q.FirstOrDefault();
        }
        public tblSanPham CheckIfExist(string strMaSP)
        {
            tblSanPham sptemp = (from n in dt.tblSanPhams
                                  where n.maSP.Equals(strMaSP)
                                  select n).FirstOrDefault();
            if (sptemp != null)
                return sptemp;
            else
                return null;
        }
        public int insertSanPham(tblSanPham n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maSP) != null)
                    return 0;
                else
                {
                    dt.tblSanPhams.InsertOnSubmit(n);
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
        public bool UpdateSanPham(tblSanPham spSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblSanPham> tam = (from n in dt.tblSanPhams
                                               where n.maSP.Equals(spSua.maSP)
                                               select n);
                tam.First().maSP = spSua.maSP;
                tam.First().tenSanPham = spSua.tenSanPham;
                tam.First().maHD = spSua.maHD;
                tam.First().loaiSanPham = spSua.loaiSanPham;
                tam.First().donViTinh = spSua.donViTinh;
                tam.First().donGia = spSua.donGia;
                tam.First().soLuong = spSua.soLuong;
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
        public int DeleteSanPham(tblSanPham sP)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(sP.maSP) != null)  
                {
                    dt.tblSanPhams.DeleteOnSubmit(sP);
                    dt.SubmitChanges();
                    dt.Transaction.Commit();
                    return 1;
                }
                return 0;
            }
            catch (Exception ex)
            {
                dt.Transaction.Rollback();
                throw new Exception("Lỗi không xóa được " + ex.Message);
            }
        }
    }
}
