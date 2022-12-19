using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsLuongBHXH:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsLuongBHXH()
        {
            dt = getDataContext();
        }

        clsLuongNVHC luong = new clsLuongNVHC();

        public IEnumerable<tblLuongBHXH> getAllLuongBHXH()
        {
            IEnumerable<tblLuongBHXH> q = from n in dt.tblLuongBHXHs
                                          select n;
            return q;
        }

        public void updateTienNopBHXH(string strMaBHXH,string strMaLuong)
        {           
                tblLuongBHXH objBHXH = dt.tblLuongBHXHs.Single(n => n.maBHXH == strMaBHXH);
                double lcb = luong.getLuongCB(strMaLuong);
                double tienNopBHXH = (lcb * 10) / 100;
                objBHXH.tienNopBHXH = tienNopBHXH;
                dt.SubmitChanges();
        }

        public string SoSanhMaBHXH(string strMaBHXH)
        {
            var q = (from n in dt.tblLuongBHXHs
                     where n.maBHXH.Equals(strMaBHXH)
                     select n.maBHXH);
            return q.FirstOrDefault();
        }

        public double getTienNopBHXH(string strMaBHXH)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maBHXH.Equals(strMaBHXH)
                    select n.tienNopBHXH;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        //Nguyen
        public string getMaBHXHTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maNV.Equals(strMaNV)
                    select n.maBHXH;
            return (q.FirstOrDefault());
        }
        public string getThangTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maNV.Equals(strMaNV)
                    select n.thang;
            return (q.FirstOrDefault().ToString());
        }
        public string getSoNgayNghiCPTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maNV.Equals(strMaNV)
                    select n.soNgayNghiCoPhep;
            return (q.FirstOrDefault().ToString());
        }
        public string getTongNNTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maNV.Equals(strMaNV)
                    select n.tongSoNgayNghi;
            return (q.FirstOrDefault().ToString());
        }
        public string getTienNopBHXHTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblLuongBHXHs
                    where n.maNV.Equals(strMaNV)
                    select n.tienNopBHXH;
            return (q.FirstOrDefault().ToString());
        }
        public bool UpdateLuongBHXH(tblLuongBHXH bhSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblLuongBHXH> tam = (from n in dt.tblLuongBHXHs
                                                where n.maBHXH.Equals(bhSua.maBHXH)
                                                select n);
                tam.First().maBHXH = bhSua.maBHXH;
                tam.First().maNV = bhSua.maNV;
                tam.First().thang = bhSua.thang;
                tam.First().soNgayNghiCoPhep = bhSua.soNgayNghiCoPhep;
                tam.First().tongSoNgayNghi = bhSua.tongSoNgayNghi;
                tam.First().tienNopBHXH = bhSua.tienNopBHXH;
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
        //
    }
}
