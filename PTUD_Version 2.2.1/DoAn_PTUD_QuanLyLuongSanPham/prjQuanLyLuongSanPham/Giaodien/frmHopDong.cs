using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjQuanLyLuongSanPham.Method;
using prjQuanLyLuongSanPham.Model;
using prjQuanLyLuongSanPham.Controls;


namespace prjQuanLyLuongSanPham
{
    public partial class frmHopDong : Form
    {
        clsHopDong hd ;
        
        public frmHopDong()
        {
            InitializeComponent();
        }       

        private void frmHopDong_Load(object sender, EventArgs e)
        {
            dateTimePickerngaybatdau.Format = DateTimePickerFormat.Custom;
            dateTimePickerngaybatdau.CustomFormat = "dd/MM/yyyy";
            dateTimePickerngayketthuc.Format = DateTimePickerFormat.Custom;
            dateTimePickerngayketthuc.CustomFormat = "dd/MM/yyyy";
            hd = new clsHopDong();
            dgrhopdong.DataSource = hd.gethopdong();
            dgrhopdong.Columns[0].HeaderText = "Tên hợp đồng";
            dgrhopdong.Columns[1].HeaderText = "Mã hợp đồng";
            dgrhopdong.Columns[2].HeaderText = "Ngày bắt đầu";
            dgrhopdong.Columns[3].HeaderText = "Ngày kết thúc";
        }

        private void dgrhopdong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = this.dgrhopdong.Rows[e.RowIndex];

                tbxtenhopdong.Text = row.Cells[0].Value.ToString();
                txtMaHD.Text = row.Cells[1].Value.ToString();
                dateTimePickerngaybatdau.Text = row.Cells[2].Value.ToString();
                dateTimePickerngayketthuc.Text = row.Cells[3].Value.ToString();
               
            }
        }

        public bool KTDLRong()
        {

            if ((txtMaHD.Text.Equals("") || tbxtenhopdong.Text.Equals("") || dateTimePickerngaybatdau.Text.Equals("") || dateTimePickerngaybatdau.Text.Equals("")))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin. !", "Thông báo");
                return true;
            }
            else
                return false;
            
        }

        tblHopDong TaoHopDong()
        {
            tblHopDong n = new tblHopDong();
            n.maHD = txtMaHD.Text;
            n.tenHopDong = tbxtenhopdong.Text;
            n.ngayBatDau = dateTimePickerngaybatdau.Value;
            n.ngayKetThuc= dateTimePickerngayketthuc.Value;
           
            return n;
        }
        private void ClearTexbox()
        {
            txtMaHD.Text = null;

            txtMaHD.Text = null;
            dateTimePickerngaybatdau.Value = DateTime.Now;
            dateTimePickerngayketthuc.Value = DateTime.Now;
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (KTDLRong() == false)
            {
                tblHopDong n = TaoHopDong();
                if (hd.CheckIfExist(n.maHD) != null)
                    MessageBox.Show("Mã Hợp đồng đã tồn tại", "Thông báo");
                else
                {
                    hd.insertHopDong(n);
                    MessageBox.Show("Hợp đồng đã thêm thành công", "Thông báo");
                    dgrhopdong.DataSource = hd.gethopdong();
                    ClearTexbox();

                }
            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            hd = new clsHopDong();
            if (KTDLRong() == false)
            {
                tblHopDong n = TaoHopDong();
                hd.UpdateHopDong(n);
                MessageBox.Show("Cập nhập thông tin hợp đồng thành công", "Thông báo");
                dgrhopdong.DataSource = hd.gethopdong();
                ClearTexbox();

            }
            else
                MessageBox.Show("Bạn cần điền đầy đủ thông tin", "Thông báo");
        }
    }
}
