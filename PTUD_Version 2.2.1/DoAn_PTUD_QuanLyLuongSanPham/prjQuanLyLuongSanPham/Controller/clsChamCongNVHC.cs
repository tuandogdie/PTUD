using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsChamCongNVHC:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsChamCongNVHC()
        {
            dt = getDataContext();
        }
        public IEnumerable<tblChamCongNVHC> getAllChamCongNVHC()
        {
            IEnumerable<tblChamCongNVHC> q = from n in dt.tblChamCongNVHCs
                                             select n;
            return q;
        }
        //public void tinhSoNgayCongVuotChuan(string strMaCong)
        //{
        //    var thucTe = from n in dt.tblChamCongNVHCs
        //                 where n.maCong.Equals(strMaCong)
        //                 select n.soNgayLamViecThucTe;
        //    int soNgayLamViecThucTe = Convert.ToInt32(thucTe.FirstOrDefault());
        //    var chuan = from n in dt.tblChamCongNVHCs
        //                select n.soNgayCongChuan;
        //    int soNgayCongChuan = Convert.ToInt32(chuan.FirstOrDefault());
        //    tblChamCongNVHC objChamCong = dt.tblChamCongNVHCs.Single(
        //        n => n.maCong == strMaCong);
        //    objChamCong.soNgayCongVuotChuan = soNgayLamViecThucTe - soNgayCongChuan;
        //    dt.SubmitChanges();
        //}

        public int getSoNgayLamViecThucTe(string strMaCong)
        {
            var thucTe = from n in dt.tblChamCongNVHCs
                         where n.maCong.Equals(strMaCong)
                         select n.soNgayLamViecThucTe;
            return Convert.ToInt32(thucTe.FirstOrDefault());
        }

        public int getSoNgayCongChuan(string strMaCong)
        {
            var chuan = from n in dt.tblChamCongNVHCs
                         where n.maCong.Equals(strMaCong)
                         select n.soNgayCongChuan;
            return Convert.ToInt32(chuan.FirstOrDefault());
        }

        public int getSoNgayCongVuotChuan(string strMaCong)
        {
            var vuotChuan = from n in dt.tblChamCongNVHCs
                            where n.maCong.Equals(strMaCong)
                            select n.soNgayCongVuotChuan;
            return Convert.ToInt32(vuotChuan.FirstOrDefault());
        }
        public string getThang(string maNV, int thang)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maNV.Equals(maNV) && n.thang == thang
                    select n.thang;
            return q.FirstOrDefault().ToString();
        }
        public string getChuoiMaNV(string maNV, int thang)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maNV.Equals(maNV) && n.thang == thang
                    select n.maNV.Substring(4, 4);
            return q.FirstOrDefault().ToString();
        }
        //Nguyen
        public string getMaCongTheoMaNV(string strMaNV)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maNV.Equals(strMaNV)
                    select n.maCong;
            return (q.FirstOrDefault().ToString());
        }
        public string getSoNgayLVTTTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maCong.Equals(strMaCong)
                    select n.soNgayLamViecThucTe;
            return (q.First().ToString());
        }
        public string getSoNgayCCTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maCong.Equals(strMaCong)
                    select n.soNgayCongChuan;
            return (q.FirstOrDefault().ToString());
        }
        public string getSoNgayCVCTheoMaCong(string strMaCong)
        {
            var q = from n in dt.tblChamCongNVHCs
                    where n.maCong.Equals(strMaCong)
                    select n.soNgayCongVuotChuan;
            return (q.FirstOrDefault().ToString());
        }
        public tblChamCongNVHC CheckIfExist(string strMaCong)
        {
            tblChamCongNVHC cdtemp = (from n in dt.tblChamCongNVHCs
                                  where n.maCong.Equals(strMaCong)
                                  select n).FirstOrDefault();
            if (cdtemp != null)
                return cdtemp;
            else
                return null;
        }
        public int insertChamCongNVHC(tblChamCongNVHC n)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                if (CheckIfExist(n.maCong) != null)
                    return 0;
                else
                {
                    dt.tblChamCongNVHCs.InsertOnSubmit(n);
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
        public bool UpdateChamCongNVHC(tblChamCongNVHC cdSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblChamCongNVHC> tam = (from n in dt.tblChamCongNVHCs
                                               where n.maCong.Equals(cdSua.maCong)
                                               select n);
                tam.First().maCong = cdSua.maCong;
                tam.First().maNV = cdSua.maNV;
                tam.First().thang = cdSua.thang;
                tam.First().soNgayLamViecThucTe = cdSua.soNgayLamViecThucTe;
                tam.First().soNgayCongChuan = cdSua.soNgayCongChuan;
                tam.First().soNgayCongVuotChuan = cdSua.soNgayCongVuotChuan;
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
