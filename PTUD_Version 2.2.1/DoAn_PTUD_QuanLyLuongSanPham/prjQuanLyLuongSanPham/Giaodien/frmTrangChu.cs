using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prjQuanLyLuongSanPham.GUI;

namespace prjQuanLyLuongSanPham
{
    public partial class frmTrangChu : Form
    {
        public static frmTrangChu frmTrangChuInstace;
        public Label lblChange;
        private Form activeForm;
        public frmTrangChu()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            setUpPanel();
            btnCloseChildForm.Visible = false;
            frmTrangChuInstace = this;
            lblChange = lblTenDangNhap;           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int LParam);

        private void setUpPanel()
        {
            PanelHeThongSubMenu.Visible = false;
            PanelDanhMucSubMenu.Visible = false;
            PanelQuanLySubMenu.Visible = false;
            PanelXuLySubMenu.Visible = false;
            PanelBaoBieuSubMenu.Visible = false;
            PanelTraCuuSubMenu.Visible = false;
        }

        private void hideSubMenu() // Ẩn menu con đã hiển thị trước đó
        {
            if (PanelHeThongSubMenu.Visible == true)
                PanelHeThongSubMenu.Visible = false;
            if (PanelDanhMucSubMenu.Visible == true)
                PanelDanhMucSubMenu.Visible = false;
            if (PanelQuanLySubMenu.Visible == true)
                PanelQuanLySubMenu.Visible = false;
            if (PanelXuLySubMenu.Visible == true)
                PanelXuLySubMenu.Visible = false;
            if (PanelBaoBieuSubMenu.Visible == true)
                PanelBaoBieuSubMenu.Visible = false;
            if (PanelTraCuuSubMenu.Visible == true)
                PanelTraCuuSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu) //Chỉ định mở menu con nào đó
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(PanelHeThongSubMenu);
        }
        #region HeThongSubMenu
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (btnDangNhap.Text == "Đăng nhập")
            {
                OpenChildForm(new frmLogin());
                ResetBackColor();
                btnDangNhap.BackColor = Color.DarkGray;
                //hideSubMenu();
            }
            else
            {
                lblTenDangNhap.Text = null;
                btnDangNhap.Text = "Đăng nhập";
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                 MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                //add code
                OpenChildForm(new frmDoiMK());
                ResetBackColor();
                btnDoiMatKhau.BackColor = Color.DarkGray;
                //hideSubMenu();
            }

        }

        
        #endregion
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                
                DialogResult r= MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r==DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                showSubMenu(PanelDanhMucSubMenu);
            }
        }
        #region DanhMucSubMenu
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmNhanVien());
            ResetBackColor();
            btnNhanVien.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnHopDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHopDong());
            ResetBackColor();
            btnHopDong.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnDMQuyetDinhTangLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQDTangLuong());
            ResetBackColor();
            btnDMQuyetDinhTangLuong.BackColor = Color.DarkGray;
            //hideSubMenu();
        }

        private void btnDMChucVu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmChucVu());
            ResetBackColor();
            btnDMChucVu.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
     
        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSanPham());
            ResetBackColor();
            btnSanPham.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnCongDoan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCongDoan());
            ResetBackColor();
            btnCongDoan.BackColor = Color.DarkGray;
            //hideSubMenu();
        }

        #endregion
        private void btnQuanLy_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                showSubMenu(PanelQuanLySubMenu);
            }
        }
        #region QuanLySubMenu
        private void btnHeSoLuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHeSoLuong());
            ResetBackColor();
            btnHeSoLuong.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnChamCongCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLChamCongCN());
            ResetBackColor();
            btnChamCongCN.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnChamCongNVHC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLChamCongNVHC());
            ResetBackColor();
            btnOpenChamCongNVHC.BackColor = Color.DarkGray;
            // hideSubMenu();
        }

        private void btnLuongBHXH_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLLuongBHXH());
            ResetBackColor();
            btnLuongBHXH.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        private void btnPhanCongCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmPhanCongChoCN());
            ResetBackColor();
            btnPhanCongCN.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        #endregion
        private void btnXuLy_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                showSubMenu(PanelXuLySubMenu);
            }
        }
        #region XuLySubMenu
        private void btnTinhLuongNVHC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTinhLuongNVHC());
            ResetBackColor();
            btnTinhLuongNVHC.BackColor = Color.DarkGray;
            //hideSubMenu();
        }

        private void btnTinhLuongCN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTinhLuongCN());
            ResetBackColor();
            btnTinhLuongCN.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        #endregion
        private void btnBaoBieu_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                showSubMenu(PanelBaoBieuSubMenu);
            }
        }
        #region BaoBieuSubMenu
        private void btnThongKeLuong_Click(object sender, EventArgs e)
        {
            //add code
            OpenChildForm(new frmThongKeLuong());
            ResetBackColor();
            btnThongKeLuong.BackColor = Color.DarkGray;
            //hideSubMenu();
        }
        #endregion

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void PanelTieuDe_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPhongTo_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text.ToString().Equals(""))
            {
                DialogResult r = MessageBox.Show("Bạn cần đăng nhập để thực hiện chức năng này!!", "Thông báo",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                if (r == DialogResult.OK)
                    OpenChildForm(new frmLogin());
            }
            else
            {
                showSubMenu(PanelTraCuuSubMenu);
            }
        }
        #region TraCuuSubMenu
        private void btnTraCuuNVHC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimKiemNhanVien());
            ResetBackColor();
            btnTraCuuNV.BackColor = Color.DarkGray;
        }

        //private void btnTraCuuCN_Click(object sender, EventArgs e)
        //{
        //    ResetBackColor();
        //    btnTraCuuCN.BackColor = Color.DarkGray;
        //    //hideSubMenu();
        //}

        #endregion

        // hàm set up mở form con
        private void OpenChildForm(Form childForm)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            btnCloseChildForm.Visible = true;
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelDesktop.Controls.Add(childForm);
            this.PanelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text.ToUpper();
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Dock = DockStyle.Fill;
        }
        //--------------------------------
        // Đóng form con
        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            lblTitle.Text = "TRANG CHỦ";
            btnCloseChildForm.Visible = false;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
        }
        //Thay đổi lại màu mặc định
        private void ResetBackColor()
        {
            btnDangNhap.BackColor = Color.DimGray;
            btnDoiMatKhau.BackColor = Color.DimGray;
            btnNhanVien.BackColor = Color.DimGray;
            btnHopDong.BackColor = Color.DimGray;
            btnDMChucVu.BackColor = Color.DimGray;
            btnDMQuyetDinhTangLuong.BackColor = Color.DimGray;
            btnSanPham.BackColor = Color.DimGray;
            btnCongDoan.BackColor = Color.DimGray;
            btnLuongBHXH.BackColor = Color.DimGray;
            btnHeSoLuong.BackColor = Color.DimGray;
            btnPhanCongCN.BackColor = Color.DimGray;
            btnChamCongCN.BackColor = Color.DimGray;
            btnOpenChamCongNVHC.BackColor = Color.DimGray;
            btnTinhLuongCN.BackColor = Color.DimGray;
            btnTinhLuongNVHC.BackColor = Color.DimGray;
            btnThongKeLuong.BackColor = Color.DimGray;
            //btnTraCuuCN.BackColor = Color.DimGray;
            btnTraCuuNV.BackColor = Color.DimGray;
        }

        #region Error
        private void btnDanhMuc_EnabledChanged(object sender, System.EventArgs e)
        {
        }
        private void btnDanhMuc_Paint(object sender, PaintEventArgs e)
        {
        }
        #endregion

        private void lblTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            if (lblTenDangNhap.Text != null)
                btnDangNhap.Text = "Đăng xuất";       
        }
    }
}
