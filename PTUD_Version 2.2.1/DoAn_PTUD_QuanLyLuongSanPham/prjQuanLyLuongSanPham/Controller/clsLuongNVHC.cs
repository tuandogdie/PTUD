using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsLuongNVHC:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsLuongNVHC()
        {
            dt = getDataContext();
        }
        public IEnumerable<tblLuongNVHC> getAllLuongNVHC()
        {
            IEnumerable<tblLuongNVHC> q = from n in dt.tblLuongNVHCs
                                          select n;
            return q;
        }

        public void addNewLuong(string strMaLuong, string strMaNhanVien)
        {
            tblLuongNVHC objluong = new tblLuongNVHC();
            objluong.maLuongNVHC = strMaLuong;
            objluong.maNV = strMaNhanVien;
            objluong.luongCB = 4000000;
            objluong.luongTangCaMotNgay = 120000;
            objluong.heSoTangCa = 1.5;
            objluong.luongChinh = 0;
            dt.tblLuongNVHCs.InsertOnSubmit(objluong);
            dt.SubmitChanges();
        }

        public string SoSanhMaLuong(string strMaLuong)
        {
            var q = (from n in dt.tblLuongNVHCs
                     where n.maLuongNVHC.Equals(strMaLuong)
                     select n.maLuongNVHC);
            return q.FirstOrDefault();
        }

        public double getLuongCB(string strMaLuong)
        {
            var q = from n in dt.tblLuongNVHCs
                    where n.maLuongNVHC.Equals(strMaLuong)
                    select n.luongCB;
            return Convert.ToDouble(q.FirstOrDefault());
        }

        public string getMaHSL(string strMaLuong)
        {
            var q = from n in dt.tblLuongNVHCs
                    where n.maLuongNVHC.Equals(strMaLuong)
                    select n.maHSL;
            return Convert.ToString(q.FirstOrDefault());
        }

        public string getMaCong(string strMaLuong)
        {
            var q = from n in dt.tblLuongNVHCs
                    where n.maLuongNVHC.Equals(strMaLuong)
                    select n.maCong;
            return Convert.ToString(q.FirstOrDefault());
        }

        public string getMaBHXH(string strMaLuong)
        {
            var q = from n in dt.tblLuongNVHCs
                    where n.maLuongNVHC.Equals(strMaLuong)
                    select n.maBHXH;
            return Convert.ToString(q.FirstOrDefault());
        }

        public string getThucLinh(string strMaLuong)
        {
            var q = from n in dt.tblLuongNVHCs
                    where n.maLuongNVHC.Equals(strMaLuong)
                    select n.luongChinh;
            return Convert.ToString(q.FirstOrDefault());
        }

        //public void DeleteLuongTheoMaLuong(string strMaLuongNVHC)
        //{
        //    //tblLuongNVHC objLuong = (from n in dt.tblLuongNVHCs
        //    //                         where n.maLuongNVHC.Equals(strMaLuongNVHC)
        //    //                         select n).Single();
        //    tblLuongNVHC objluong = dt.tblLuongNVHCs.Where(p => p.maLuongNVHC.Equals(strMaLuongNVHC)).FirstOrDefault();
        //    dt.tblLuongNVHCs.DeleteOnSubmit(objluong);
        //    dt.SubmitChanges();
        //}
        public IEnumerable<tblLuongNVHC> getLuongTheoMa(string strMaLuong)
        {
            IEnumerable<tblLuongNVHC> q = from n in dt.tblLuongNVHCs
                                        where n.maLuongNVHC.Equals(strMaLuong)
                                        select n;
            return q;
        }
        public tblLuongNVHC CheckIfExist(string strMaLuong)
        {
            tblLuongNVHC luongtemp = (from n in dt.tblLuongNVHCs
                                    where n.maLuongNVHC.Equals(strMaLuong)
                                    select n).FirstOrDefault();
            if (luongtemp != null)
                return luongtemp;
            else
                return null;
        }
        public int DeleteLuong(tblLuongNVHC luong)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(luong.maLuongNVHC) != null)
                {
                    dt.tblLuongNVHCs.DeleteOnSubmit(luong);
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
