using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prjQuanLyLuongSanPham.Model;

namespace prjQuanLyLuongSanPham.Method
{
    public class clsKetNoi
    {
        DataLuongSanPhamDataContext dt;
        public DataLuongSanPhamDataContext getDataContext()
        {
            // str của Nguyên
            //string str = @"Data Source=ASUS;Initial Catalog=QuanLyLuongSanPham;Persist Security Info=True;User ID=sa;Password=sapassword";
            // str của a Tuấn
            string str = @"Data Source=TUANDOGDIE;Initial Catalog=QuanLyLuongSanPham;Integrated Security=True";
            // str của Trường
            //string str = @"Data Source=LAPTOP-0MQ8VURE\MSSQLSERVER2017;Initial Catalog=QuanLyLuongSanPham;Integrated Security=True";
            dt = new DataLuongSanPhamDataContext(str);
            dt.Connection.Open();
            return dt;
        }
    }
}
