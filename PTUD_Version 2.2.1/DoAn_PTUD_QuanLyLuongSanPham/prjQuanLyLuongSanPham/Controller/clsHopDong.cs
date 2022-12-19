using prjQuanLyLuongSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQuanLyLuongSanPham.Method
{
    class clsHopDong:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsHopDong()
        {
            dt=getDataContext();
        }
        public IEnumerable<tblHopDong> getAllHopDong()
        {
            IEnumerable<tblHopDong> q = from n in dt.tblHopDongs
                                             select n;
            return q;
        }
        public String getTenHopDongTheoMaSP(String strMaHD)
        {
            var q = from n in dt.tblHopDongs
                    where n.maHD.Equals(strMaHD)
                    select n.tenHopDong;
            return q.FirstOrDefault();
        }
        public IEnumerable<dynamic> gethopdong()
        {
            var q = from n in dt.tblHopDongs
                    select new { n.tenHopDong, n.maHD, n.ngayBatDau, n.ngayKetThuc };
            return q;
        }
        public tblHopDong CheckIfExist(string strMaHd)
        {
            tblHopDong hdtemp = (from n in dt.tblHopDongs
                                 where n.maHD.Equals(strMaHd)
                                 select n).FirstOrDefault();
            if (hdtemp != null)
                return hdtemp;
            else
                return null;
        }
        public int insertHopDong(tblHopDong n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maHD) != null)
                    return 0;
                else
                {
                    dt.tblHopDongs.InsertOnSubmit(n);
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
        public bool UpdateHopDong(tblHopDong hdSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblHopDong> tam = (from n in dt.tblHopDongs
                                              where n.maHD.Equals(hdSua.maHD)
                                              select n);
                tam.First().tenHopDong = hdSua.tenHopDong;
                tam.First().ngayKetThuc = hdSua.ngayKetThuc;
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
    }
}
