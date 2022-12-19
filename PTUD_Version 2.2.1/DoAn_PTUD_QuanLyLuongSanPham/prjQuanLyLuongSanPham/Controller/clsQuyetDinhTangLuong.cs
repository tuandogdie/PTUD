using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    public class clsQuyetDinhTangLuong:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsQuyetDinhTangLuong()
        {
            dt = getDataContext();
        }
        public IEnumerable<tblQuyetDinhTangLuong> getAllQuyetDinhTL()
        {
            IEnumerable<tblQuyetDinhTangLuong> q = from n in dt.tblQuyetDinhTangLuongs
                                                   select n;
            return q;
        }
        public double getLuongTangQD(string strMaQD)
        {
            var q = from n in dt.tblQuyetDinhTangLuongs
                    where n.maQD.Equals(strMaQD)
                    select n.luongTangTheoQuyetDinh;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        public string getMaQDTLTheoNoiDung(string strNoiDungQDTL)
        {
            var q = (from n in dt.tblQuyetDinhTangLuongs
                     where n.noiDungQuyetDinh.Equals(strNoiDungQDTL)
                     select n.maQD).FirstOrDefault();
            return q.ToString();
        }
    }
}
