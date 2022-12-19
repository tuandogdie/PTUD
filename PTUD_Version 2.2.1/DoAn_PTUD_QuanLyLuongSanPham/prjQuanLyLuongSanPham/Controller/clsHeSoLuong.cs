using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    class clsHeSoLuong:clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public clsHeSoLuong()
        {
            dt = getDataContext();
        }
        public double getHeSoLuongChinh(string strMaHSL)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maHSL.Equals(strMaHSL)
                    select n.heSoLuongChinh;
            return Convert.ToDouble(q.FirstOrDefault());
        }
        //nguyen
        public IEnumerable<tblHeSoLuong> getALLHSL()
        {
            IEnumerable<tblHeSoLuong> q = from n in dt.tblHeSoLuongs
                                          select n;
            return q;
        }
        public tblHeSoLuong getTTHSLTheoMa(String strMaHSL)
        {
            IEnumerable<tblHeSoLuong> q = from n in dt.tblHeSoLuongs
                                          where n.maHSL.Equals(strMaHSL)
                                          select n;
            return q.FirstOrDefault();
        }
        public void UpdateTNCT(tblHeSoLuong hsl)
        {
            IQueryable<tblHeSoLuong> tam = (from n in dt.tblHeSoLuongs
                                         where n.maNV.Equals(hsl.maNV)
                                         select n);
            System.Data.Common.DbTransaction myTran= dt.Connection.BeginTransaction();
            dt.Transaction = myTran;
            DateTime d = (DateTime)hsl.ngayBatDauThamGiaCongTac;
            tam.First().thamNienCongTac = DateTime.Now.Year - d.Year + 1;
            dt.SubmitChanges();
            dt.Transaction.Commit();
        }
        public void UpdateHSLC(tblHeSoLuong hsl)
        {
            IQueryable<tblHeSoLuong> tam = (from n in dt.tblHeSoLuongs
                                            where n.maNV.Equals(hsl.maNV)
                                            select n);
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            dt.Transaction = myTran;
            double hslc = double.Parse(getHSLCBTheoMaNV(hsl.maNV));
            switch(hsl.trinhDoHocVan)
            {
                case "Sơ cấp":
                    hslc +=0.1;
                    break;
                case "Trung cấp":
                    hslc += 0.2;
                    break;
                case "Cao đẳng":
                    hslc += 0.3;
                    break;
                case "Cử nhân":
                    hslc += 0.4;
                    break;
                case "Thạch sĩ":
                    hslc += 0.5;
                    break;
            }
            switch(hsl.ngoaiNgu)
            {
                case "A1":
                    hslc += 0.1;
                    break;
                case "A2":
                    hslc += 0.2;
                    break;
                case "B1":
                    hslc += 0.3;
                    break;
                case "B2":
                    hslc += 0.4;
                    break;
                case "C1":
                    hslc += 0.5;
                    break;
                case "C2":
                    hslc += 0.6;
                    break;
            }
            if (hsl.thamNienCongTac >= 1 && hsl.thamNienCongTac < 5)
                hslc += 0.1;
            else
                if (hsl.thamNienCongTac >= 5 && hsl.thamNienCongTac < 10)
                hslc += 0.2;
            else
                hslc += 0.3;
            hslc = Math.Round(hslc, 2);
            tam.First().heSoLuongChinh = hslc;
            dt.SubmitChanges();
            dt.Transaction.Commit();
        }
        public double getHSLCThayDoiTheoHSL(tblHeSoLuong hsl,Double hslcb)
        {
            double hslc = hslcb;
            switch (hsl.trinhDoHocVan)
            {
                case "Sơ cấp":
                    hslc += 0.1;
                    break;
                case "Trung cấp":
                    hslc += 0.2;
                    break;
                case "Cao đẳng":
                    hslc += 0.3;
                    break;
                case "Cử nhân":
                    hslc += 0.4;
                    break;
                case "Thạch sĩ":
                    hslc += 0.5;
                    break;
            }
            switch (hsl.ngoaiNgu)
            {
                case "A1":
                    hslc += 0.1;
                    break;
                case "A2":
                    hslc += 0.2;
                    break;
                case "B1":
                    hslc += 0.3;
                    break;
                case "B2":
                    hslc += 0.4;
                    break;
                case "C1":
                    hslc += 0.5;
                    break;
                case "C2":
                    hslc += 0.6;
                    break;
            }
            if (hsl.thamNienCongTac >= 1 && hsl.thamNienCongTac < 5)
                hslc += 0.1;
            else
                if (hsl.thamNienCongTac >= 5 && hsl.thamNienCongTac < 10)
                hslc += 0.2;
            else
                hslc += 0.3;
            hslc = Math.Round(hslc, 2);
            return hslc;
        }
        public DateTime getngayTheoMaHSL(String strMaHSL)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maHSL.Equals(strMaHSL)
                    select n.ngayBatDauThamGiaCongTac;
            return (DateTime)q.FirstOrDefault();
        }
        public String getMaHSLTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.maHSL;
            return q.FirstOrDefault();
        }
        public String getHSLCBTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.heSoLuongCB;
            return q.FirstOrDefault().ToString();
        }
        public String getHSLCTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.heSoLuongChinh;
            return q.FirstOrDefault().ToString();
        }
        public String getTDHVTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.trinhDoHocVan;
            return q.FirstOrDefault();
        }
        public String getNNTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.ngoaiNgu;
            return q.FirstOrDefault();
        }
        public int getTNCTTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.thamNienCongTac;
            return (int)q.FirstOrDefault();
        }
        public DateTime getNBDCTTheoMaNV(String strMaNV)
        {
            var q = from n in dt.tblHeSoLuongs
                    where n.maNV.Equals(strMaNV)
                    select n.ngayBatDauThamGiaCongTac;
            return (DateTime)q.FirstOrDefault();
        }
        public bool  UpdateHeSoLuong(tblHeSoLuong hslSua)
        {
            System.Data.Common.DbTransaction myTran = dt.Connection.BeginTransaction();
            try
            {
                dt.Transaction = myTran;
                IQueryable<tblHeSoLuong> tam = (from n in dt.tblHeSoLuongs
                                               where n.maHSL.Equals(hslSua.maHSL)
                                               select n);
                tam.First().maHSL = hslSua.maHSL;
                tam.First().heSoLuongCB = hslSua.heSoLuongCB;
                tam.First().heSoLuongChinh = hslSua.heSoLuongChinh;
                tam.First().trinhDoHocVan = hslSua.trinhDoHocVan;
                tam.First().ngoaiNgu = hslSua .ngoaiNgu;
                tam.First().thamNienCongTac = hslSua.thamNienCongTac;
                tam.First().ngayBatDauThamGiaCongTac = hslSua.ngayBatDauThamGiaCongTac;
                tam.First().maNV=hslSua.maNV;
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
