using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    public class clsChamCongCN:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsChamCongCN()
        {
            dt = getDataContext();
        }
        #region Trường
        public  IEnumerable<tblChamCongCN> getAllChamCongCN()
        {
            IEnumerable<tblChamCongCN> q = from n in dt.tblChamCongCNs
                                             select n;
            return q;
        }

        public int getSoCongDoan(string maCN)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maCN)
                    select n.soCongDoan;
            return Convert.ToInt32(q.FirstOrDefault());
        }

        public string getMaCongDoan(string maNV, int thang)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maNV) && n.thang == thang
                    select n.maCD;
            return q.FirstOrDefault().ToString();

        }
        public string getCa(string maCN, int thang)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maCN) && n.thang == thang
                    select n.ca;
            return q.FirstOrDefault().ToString();
        }
        public string getThang(string maCN, int thang)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maCN) && n.thang == thang
                    select n.thang;
            return q.FirstOrDefault().ToString();
        }
        public string getChuoiMaNV(string maCN, int thang)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maCN) && n.thang == thang
                    select n.maNV.Substring(2, 4);
            return q.FirstOrDefault().ToString();
        }
        public string getMaCong(string maCN, int thang)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maNV.Equals(maCN) && n.thang == thang
                    select n.maCong;
            return q.FirstOrDefault().ToString();
        }
        public string getMaCDTheoMaCC(string strMaCC)
        {
            var q = (from n in dt.tblChamCongCNs
                     where n.maCong.Equals(strMaCC)
                     select n.maCD).FirstOrDefault();
            return q.ToString();
        }

        #endregion

        #region Nguyên
        public bool UpdateThemTTChamCongCN(tblChamCongCN cdSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblChamCongCN> tam = (from n in dt.tblChamCongCNs
                                                 where n.maCong.Equals(cdSua.maCong)
                                                 select n);
                tam.First().ca = cdSua.ca;
                tam.First().soCongDoan = cdSua.soCongDoan;
                tam.First().soCongDoanThietHai = cdSua.soCongDoanThietHai;
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
        public string getCaTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maCong.Equals(strMaCong)
                    select n.ca;
            return q.FirstOrDefault().ToString();
        }
        public string getSoCDTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maCong.Equals(strMaCong)
                     select n.soCongDoan;
            return q.FirstOrDefault().ToString();
        }
        public string getSoCDTHTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maCong.Equals(strMaCong)
                    select n.soCongDoanThietHai;
            return q.FirstOrDefault().ToString();
        }
        public tblChamCongCN CheckIfExist(string strMaCong)
        {
            tblChamCongCN cdtemp = (from n in dt.tblChamCongCNs
                                      where n.maCong.Equals(strMaCong)
                                      select n).FirstOrDefault();
            if (cdtemp != null)
                return cdtemp;
            else
                return null;
        }
        public int getCheckCongDoan(string strMaCD)
        {
            var q = (from n in dt.tblChamCongCNs
                     where n.maCD.Equals(strMaCD)
                     select n.maCD).Count();
            return q;
        }
        public int getThangTheoMaCN(string strMaNV,int thang)
        {
            var q = (from n in dt.tblChamCongCNs
                     where n.maNV.Equals(strMaNV) && n.thang.Equals(thang)
                     select n.maNV).Count();
            return q;
        }
        public bool UpdatePhanCong(tblChamCongCN nvSua,int thang)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblChamCongCN> tam = (from n in dt.tblChamCongCNs
                                               where n.maNV.Equals(nvSua.maNV) && n.thang == thang
                                               select n);
                tam.First().maCD =nvSua.maCD;
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
        public int insertChamCongCN(tblChamCongCN n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maCong) != null)
                    return 0;
                else
                {
                    dt.tblChamCongCNs.InsertOnSubmit(n);
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
        public bool UpdateChamCongCN(tblChamCongCN cdSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblChamCongCN> tam = (from n in dt.tblChamCongCNs
                                                   where n.maCong.Equals(cdSua.maCong)
                                                   select n);
                tam.First().maCong = cdSua.maCong;
                tam.First().maNV = cdSua.maNV;
                tam.First().maCong = cdSua.maCong;
                tam.First().thang = cdSua.thang;
                tam.First().ca = cdSua.ca;
                tam.First().soCongDoan = cdSua.soCongDoan;
                tam.First().soCongDoanThietHai = cdSua.soCongDoanThietHai;
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
        public string getMaCDTheoMaCong(string strMaCong)
        {
            var q = from ccnvcn in dt.tblChamCongCNs                 
                    where ccnvcn.maCong.Equals(strMaCong)
                    select ccnvcn.maCD;
            return (q.FirstOrDefault().ToString());
        }
        public int getSCDTheoMaCong(string maCong)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maCong.Equals(maCong)
                    select n.soCongDoan;
            return Convert.ToInt32(q.FirstOrDefault());
        }
        public IEnumerable<tblChamCongCN> GetDSThangTheoMaNV(string strMaNV)
        {
            IEnumerable<tblChamCongCN> q = from cccn in dt.tblChamCongCNs
                                           where cccn.maNV.Equals(strMaNV)
                                           select cccn;
            return q;
        }
        public string getSCDTHTheoMaCong(string maCong)
        {
            var q = from n in dt.tblChamCongCNs
                    where n.maCong.Equals(maCong)
                    select n.soCongDoanThietHai;
            return (q.FirstOrDefault()).ToString();
        }
        //
        #endregion
    }
}
