using prjQuanLyLuongSanPham.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjQuanLyLuongSanPham.Method
{
    class clsAccount:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsAccount()
        {
            dt = getDataContext();
        }
        public string getMKTheoTDN(string strUserName)
        {
            var q = (from n in dt.tblAccounts
                     where n.userName.Equals(strUserName)
                     select n.passWord);
            return q.FirstOrDefault();
        }
        public tblAccount CheckIfExist(string strUserName)
        {
            tblAccount actemp = (from n in dt.tblAccounts
                                  where n.userName.Equals(strUserName)
                                  select n).FirstOrDefault();
            if (actemp != null)
                return actemp;
            else
                return null;
        }
        public bool UpdateMK(tblAccount mkSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblAccount> tam = (from n in dt.tblAccounts
                                              where n.userName.Equals(mkSua.userName)
                                              select n);
                tam.First().passWord = mkSua.passWord;
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
