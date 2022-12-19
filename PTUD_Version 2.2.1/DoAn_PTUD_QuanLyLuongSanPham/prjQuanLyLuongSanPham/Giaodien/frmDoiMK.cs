using prjQuanLyLuongSanPham.Model;
using prjQuanLyLuongSanPham.Method;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static prjQuanLyLuongSanPham.frmLogin;

namespace prjQuanLyLuongSanPham.GUI
{
    public partial class frmDoiMK : Form
    {
        public frmDoiMK()
        {
            InitializeComponent();
        }
        clsAccount Account;

        private void frmDoiMK_Load(object sender, EventArgs e)
        {
            Account = new clsAccount();
            txtTenDangNhap.Text = bientoancuc.TDN;
            if (chkHienThiMK.Checked == true)
            {
                txtMKHT.UseSystemPasswordChar = true;
                txtMKM.UseSystemPasswordChar = true;
                txtNLMKM.UseSystemPasswordChar = true;
            }
            else
            {
                txtMKHT.UseSystemPasswordChar = false;
                txtMKM.UseSystemPasswordChar = false;
                txtNLMKM.UseSystemPasswordChar = false;
            }

        }
        bool KTDLRong()
        {
            if (txtMKHT.Text.Equals("")|| txtMKM.Text.Equals("")|| txtNLMKM.Text.Equals(""))
                return true;
            else
                return false;
        }
        tblAccount TaoAccount()
        {
            tblAccount n = new tblAccount();
            n.userName = txtTenDangNhap.Text;
            n.passWord = txtMKM.Text;
            return n;
        }
        private void btnLuuTD_Click(object sender, EventArgs e)
        {
            if(KTDLRong()==true)
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            }    
            else
                if (txtMKHT.Text.Equals(Account.getMKTheoTDN(txtTenDangNhap.Text))==false)
                {
                    MessageBox.Show("Mật khẩu hiện tại không chính xác", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1);
                }
                else
                    if (txtMKM.Text.Equals(txtNLMKM.Text)==false)
                    {
                        MessageBox.Show("Nhập lại mật khẩu Không khớp", "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        tblAccount n = TaoAccount();
                        Account.UpdateMK(n);
                        MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo");
                         this.Close();
                    }
        }

        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
            {
                txtMKHT.UseSystemPasswordChar = true;
                txtMKM.UseSystemPasswordChar = true;
                txtNLMKM.UseSystemPasswordChar = true;
            }
            else
            {
                txtMKHT.UseSystemPasswordChar = false;
                txtMKM.UseSystemPasswordChar = false;
                txtNLMKM.UseSystemPasswordChar = false;
            }
        }
    }
}
