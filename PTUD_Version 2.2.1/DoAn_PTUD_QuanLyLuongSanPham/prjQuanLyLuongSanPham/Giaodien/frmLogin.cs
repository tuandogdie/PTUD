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

namespace prjQuanLyLuongSanPham
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public class bientoancuc
        {
            public static string TDN;
        }
        clsAccount Account;
        private void chkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMK.Checked == true)
                txtMK.UseSystemPasswordChar = true;
            else
                txtMK.UseSystemPasswordChar = false;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Account = new clsAccount();
             
            txtTenDangNhap.Focus();

            if (txtMK.Text.Trim().Equals("") || txtTenDangNhap.Text.Trim().Equals(""))
                btnDangNhap.Enabled = false;
            else
                btnDangNhap.Enabled = true;
            if (chkHienThiMK.Checked == true)
                txtMK.UseSystemPasswordChar = true;
            else
                txtMK.UseSystemPasswordChar = false;
        }

        private void txtTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim().Equals("") || txtTenDangNhap.Text.Trim().Equals(""))
                btnDangNhap.Enabled = false;
            else
                btnDangNhap.Enabled = true;
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text.Trim().Equals("") || txtTenDangNhap.Text.Trim().Equals(""))
                btnDangNhap.Enabled = false;
            else
                btnDangNhap.Enabled = true;
        }
        private void DangNhap()
        {
            if (Account.CheckIfExist(txtTenDangNhap.Text) == null)
                MessageBox.Show("Tài khoản chưa có trên hệ thống", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
            else
                if (Account.getMKTheoTDN(txtTenDangNhap.Text).Equals(txtMK.Text))
                {     
                MessageBox.Show("Đăng nhập thành công", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
                bientoancuc.TDN=txtTenDangNhap.Text;
                frmTrangChu.frmTrangChuInstace.lblChange.Text = this.txtTenDangNhap.Text.ToString();
                this.Close();
                }
            else
                MessageBox.Show("Mật khẩu không chính xác", "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                DangNhap();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
