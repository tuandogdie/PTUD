using prjQuanLyLuongSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQuanLyLuongSanPham.Method
{
    class clsCongDoan : clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsCongDoan()
        {
            dt = getDataContext();
        }

        public void updateSCDCTLTheoMaCD(string maCD, int newSCD)
        {
            tblCongDoan objCongDoan = (from n in dt.tblCongDoans
                                       where n.maCD.Equals(maCD)
                                       select n).Single();
            objCongDoan.soCongDoanCoTheLam = newSCD;
            dt.SubmitChanges();
        }
        public string getScdTCTLheoMaCD(string maCong)
        {
            var q = (from n in dt.tblChamCongCNs
                     where n.maCong.Equals(maCong)
                     select n.maCD).FirstOrDefault();
            var q2 = (from n in dt.tblCongDoans
                     where n.maCD.Equals(q.ToString())
                     select n.soCongDoanCoTheLam).FirstOrDefault();
            return q2.ToString();
        }
        public int getScdCTLTheoCboCongDoan(string strMaCD)
        {
            var q = (from n in dt.tblCongDoans
                      where n.maCD.Equals(strMaCD.ToString())
                      select n.soCongDoanCoTheLam).FirstOrDefault();
            return Convert.ToInt32(q);
        }
        public IEnumerable<tblCongDoan> getAllCongDoan()
        {
            IEnumerable<tblCongDoan> q = from n in dt.tblCongDoans
                                         select n;
            return q;
        }
        public IEnumerable<tblCongDoan> getCongDoanTheoMa(String strMaCD)
        {
            IEnumerable<tblCongDoan> q = from n in dt.tblCongDoans
                                         where n.maCD.Equals(strMaCD)
                                         select n;
            return q;
        }
        public string getTenCDTheoMaCD(string maCD)
        {
            var q = (from n in dt.tblCongDoans
                     where n.maCD.Equals(maCD)
                     select n.tenCongDoan);
            return q.FirstOrDefault();
        }
        public IEnumerable<tblCongDoan> getCongDoanTheoSanPham(String strMaSP)
        {
            IEnumerable<tblCongDoan> q = from n in dt.tblCongDoans
                                         where n.maSP.Equals(strMaSP)
                                         select n;
            return q;
        }
        public string getMaSanPhamTheoMaCD(string maCD)
        {
            var q = (from n in dt.tblCongDoans
                     where n.maCD.Equals(maCD)
                     select n.maSP);
            return q.FirstOrDefault();
        }
        public tblCongDoan CheckIfExist(string strMaCD)
        {
            tblCongDoan cdtemp = (from n in dt.tblCongDoans
                                  where n.maCD.Equals(strMaCD)
                                  select n).FirstOrDefault();
            if (cdtemp != null)
                return cdtemp;
            else
                return null;
        }
        public int insertCongDoan(tblCongDoan n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maCD) != null)
                    return 0;
                else
                {
                    dt.tblCongDoans.InsertOnSubmit(n);
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
        public bool UpdateCongDoan(tblCongDoan cdSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblCongDoan> tam = (from n in dt.tblCongDoans
                                               where n.maCD.Equals(cdSua.maCD)
                                               select n);
                tam.First().maCD = cdSua.maCD;
                tam.First().tenCongDoan = cdSua.tenCongDoan;
                tam.First().maSP = cdSua.maSP;
                tam.First().thuTuCongDoan = cdSua.thuTuCongDoan;
                tam.First().donGia = cdSua.donGia;
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
        public int DeleteCongDoan(tblCongDoan cD)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(cD.maCD) != null)
                {
                    dt.tblCongDoans.DeleteOnSubmit(cD);
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
        public double getDonGiaCongDoan(string strMaCD)
        {
            var q = from n in dt.tblCongDoans
                    where n.maCD.Equals(strMaCD)
                    select n.donGia;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        
    }
}
