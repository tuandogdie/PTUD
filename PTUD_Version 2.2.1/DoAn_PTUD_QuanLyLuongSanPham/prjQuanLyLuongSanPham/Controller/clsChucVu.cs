using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsChucVu:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsChucVu()
        {
            dt = getDataContext();
        }
        public IEnumerable<tblChucVu> getAllChucVu()
        {
            IEnumerable<tblChucVu> q = from n in dt.tblChucVus
                                       select n;
            return q;
        }
        public double getPhuCap(string strMaChucVu)
        {
            var q = from n in dt.tblChucVus
                    where n.maCV.Equals(strMaChucVu)
                    select n.phuCap;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        public string getMaCVTheoTenCV(string tenCV)
        {
            var q = (from n in dt.tblChucVus
                     where n.tenChucVu.Equals(tenCV)
                     select n.maCV).FirstOrDefault();
            return q.ToString();
        }
    }
}
