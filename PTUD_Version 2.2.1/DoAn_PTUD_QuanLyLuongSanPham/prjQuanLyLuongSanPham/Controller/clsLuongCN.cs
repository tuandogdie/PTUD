using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    public class clsLuongCN:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsLuongCN()
        {
            dt = getDataContext();
        }

        public int getSoGioCa12(string strMaLuongCN)
        {
            var q = from n in dt.tblLuongCNs
                    where n.maLuongCN.Equals(strMaLuongCN)
                    select n.soGioLamCa12;
            return Convert.ToInt32(q.FirstOrDefault());
        }

        public int getSoGioCa3(string strMaLuongCN)
        {
            var q = from n in dt.tblLuongCNs
                    where n.maLuongCN.Equals(strMaLuongCN)
                    select n.soGioLamCa3;
            return Convert.ToInt32(q.FirstOrDefault());
        }

        public double getThucLinh(string maLuongCN)
        {
            var q = from n in dt.tblLuongCNs
                    where n.maLuongCN.Equals(maLuongCN)
                    select n.luongChinh;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        public string soSanhMaLuongCN(string strMaLuong)
        {
            var q = from n in dt.tblLuongCNs
                    where n.maLuongCN.Equals(strMaLuong)
                    select n.maLuongCN;
            return q.FirstOrDefault();
        }
        public void addNewLuongCN(string strMaLuongCN, string strMaCN, int thang, int sglCa12, int sglCa3)
        {
            tblLuongCN objLuongCN = new tblLuongCN();
            objLuongCN.maLuongCN = strMaLuongCN;
            objLuongCN.luongChinh = 0;
            objLuongCN.soGioLamCa12 = sglCa12;
            objLuongCN.soGioLamCa3 = sglCa3;
            objLuongCN.maNV = strMaCN;
            clsChamCongCN cc = new clsChamCongCN();
            objLuongCN.maCong = cc.getMaCong(strMaCN, thang);
            dt.tblLuongCNs.InsertOnSubmit(objLuongCN);
            dt.SubmitChanges();
        }
        public IEnumerable<tblLuongCN> getLuongTheoMa(string strMaLuong)
        {
            IEnumerable<tblLuongCN> q = from n in dt.tblLuongCNs
                                        where n.maLuongCN.Equals(strMaLuong)
                                        select n;
            return q;
        }
        public tblLuongCN CheckIfExist(string strMaLuong)
        {
            tblLuongCN luongtemp = (from n in dt.tblLuongCNs
                                 where n.maLuongCN.Equals(strMaLuong)
                                 select n).FirstOrDefault();
            if (luongtemp != null)
                return luongtemp;
            else
                return null;
        }
        public int DeleteLuong(tblLuongCN luong)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(luong.maLuongCN) != null)
                {
                    dt.tblLuongCNs.DeleteOnSubmit(luong);
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
        public bool UpdateLuong(tblLuongCN luongSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblLuongCN> tam = (from n in dt.tblLuongCNs
                                              where n.maLuongCN.Equals(luongSua.maLuongCN)
                                              select n);
                tam.First().soGioLamCa12 = luongSua.soGioLamCa12;
                tam.First().soGioLamCa3 = luongSua.soGioLamCa3;
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
