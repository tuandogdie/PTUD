namespace prjQuanLyLuongSanPham.GUI
{
    partial class frmQLChamCongNVHC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLChamCongNVHC));
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtSoNgayLVTT = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoNgayVCC = new System.Windows.Forms.Label();
            this.txtMaCong = new System.Windows.Forms.Label();
            this.txtSoNgayCC = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenNVMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.txtMaCongMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.txtSoNgayVCCMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.txtSoNgayCCMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.dgvDSChamCong = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnChamCong = new prjQuanLyLuongSanPham.Controls.button();
            this.radTheoTenNV = new System.Windows.Forms.RadioButton();
            this.btnCapNhat = new prjQuanLyLuongSanPham.Controls.button();
            this.radTheoMaNV = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtTuKhoa = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChamCong)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 389);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(267, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "Danh sách chấm công";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.txtSoNgayLVTT);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSoNgayVCC);
            this.panel1.Controls.Add(this.txtMaCong);
            this.panel1.Controls.Add(this.txtSoNgayCC);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtTenNVMau);
            this.panel1.Controls.Add(this.txtMaCongMau);
            this.panel1.Controls.Add(this.txtSoNgayVCCMau);
            this.panel1.Controls.Add(this.txtSoNgayCCMau);
            this.panel1.Location = new System.Drawing.Point(34, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 212);
            this.panel1.TabIndex = 20;
            // 
            // cboThang
            // 
            this.cboThang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboThang.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboThang.ForeColor = System.Drawing.Color.White;
            this.cboThang.FormattingEnabled = true;
            this.cboThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cboThang.Location = new System.Drawing.Point(169, 164);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(306, 33);
            this.cboThang.TabIndex = 8;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboMaNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboMaNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaNV.ForeColor = System.Drawing.Color.White;
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(169, 71);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(306, 33);
            this.cboMaNV.TabIndex = 8;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // txtSoNgayLVTT
            // 
            this.txtSoNgayLVTT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNgayLVTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSoNgayLVTT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoNgayLVTT.BorderSize = 2;
            this.txtSoNgayLVTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayLVTT.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoNgayLVTT.Location = new System.Drawing.Point(736, 27);
            this.txtSoNgayLVTT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgayLVTT.Multiline = false;
            this.txtSoNgayLVTT.Name = "txtSoNgayLVTT";
            this.txtSoNgayLVTT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoNgayLVTT.Size = new System.Drawing.Size(306, 40);
            this.txtSoNgayLVTT.TabIndex = 6;
            this.txtSoNgayLVTT.UnderlinedStyle = true;
            this.txtSoNgayLVTT._TextChanged += new System.EventHandler(this.txtSoNgayLVTT__TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, -5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(123, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thông tin";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1065, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 206);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 206);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 3);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1068, 3);
            this.panel3.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(493, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày làm việc thực tế";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã chấm công";
            // 
            // txtSoNgayVCC
            // 
            this.txtSoNgayVCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNgayVCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayVCC.ForeColor = System.Drawing.Color.White;
            this.txtSoNgayVCC.Location = new System.Drawing.Point(737, 127);
            this.txtSoNgayVCC.Name = "txtSoNgayVCC";
            this.txtSoNgayVCC.Size = new System.Drawing.Size(306, 25);
            this.txtSoNgayVCC.TabIndex = 0;
            // 
            // txtMaCong
            // 
            this.txtMaCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCong.ForeColor = System.Drawing.Color.White;
            this.txtMaCong.Location = new System.Drawing.Point(169, 31);
            this.txtMaCong.Name = "txtMaCong";
            this.txtMaCong.Size = new System.Drawing.Size(306, 25);
            this.txtMaCong.TabIndex = 0;
            this.txtMaCong.TextChanged += new System.EventHandler(this.txtMaCong_TextChanged);
            // 
            // txtSoNgayCC
            // 
            this.txtSoNgayCC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNgayCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayCC.ForeColor = System.Drawing.Color.White;
            this.txtSoNgayCC.Location = new System.Drawing.Point(737, 74);
            this.txtSoNgayCC.Name = "txtSoNgayCC";
            this.txtSoNgayCC.Size = new System.Drawing.Size(306, 25);
            this.txtSoNgayCC.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.White;
            this.txtTenNV.Location = new System.Drawing.Point(169, 119);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(306, 25);
            this.txtTenNV.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên NV";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tháng";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(493, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số ngày công vượt chuẩn";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(493, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ngày công chuẩn";
            // 
            // txtTenNVMau
            // 
            this.txtTenNVMau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNVMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTenNVMau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenNVMau.BorderSize = 2;
            this.txtTenNVMau.Enabled = false;
            this.txtTenNVMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNVMau.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenNVMau.Location = new System.Drawing.Point(169, 114);
            this.txtTenNVMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNVMau.Multiline = false;
            this.txtTenNVMau.Name = "txtTenNVMau";
            this.txtTenNVMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNVMau.Size = new System.Drawing.Size(306, 40);
            this.txtTenNVMau.TabIndex = 6;
            this.txtTenNVMau.UnderlinedStyle = true;
            // 
            // txtMaCongMau
            // 
            this.txtMaCongMau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaCongMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMaCongMau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaCongMau.BorderSize = 2;
            this.txtMaCongMau.Enabled = false;
            this.txtMaCongMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCongMau.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaCongMau.Location = new System.Drawing.Point(169, 23);
            this.txtMaCongMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCongMau.Multiline = false;
            this.txtMaCongMau.Name = "txtMaCongMau";
            this.txtMaCongMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaCongMau.Size = new System.Drawing.Size(306, 40);
            this.txtMaCongMau.TabIndex = 6;
            this.txtMaCongMau.UnderlinedStyle = true;
            // 
            // txtSoNgayVCCMau
            // 
            this.txtSoNgayVCCMau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNgayVCCMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSoNgayVCCMau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoNgayVCCMau.BorderSize = 2;
            this.txtSoNgayVCCMau.Enabled = false;
            this.txtSoNgayVCCMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayVCCMau.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoNgayVCCMau.Location = new System.Drawing.Point(736, 119);
            this.txtSoNgayVCCMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgayVCCMau.Multiline = false;
            this.txtSoNgayVCCMau.Name = "txtSoNgayVCCMau";
            this.txtSoNgayVCCMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoNgayVCCMau.Size = new System.Drawing.Size(306, 40);
            this.txtSoNgayVCCMau.TabIndex = 6;
            this.txtSoNgayVCCMau.UnderlinedStyle = true;
            // 
            // txtSoNgayCCMau
            // 
            this.txtSoNgayCCMau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSoNgayCCMau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSoNgayCCMau.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSoNgayCCMau.BorderSize = 2;
            this.txtSoNgayCCMau.Enabled = false;
            this.txtSoNgayCCMau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoNgayCCMau.ForeColor = System.Drawing.Color.DimGray;
            this.txtSoNgayCCMau.Location = new System.Drawing.Point(736, 69);
            this.txtSoNgayCCMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoNgayCCMau.Multiline = false;
            this.txtSoNgayCCMau.Name = "txtSoNgayCCMau";
            this.txtSoNgayCCMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtSoNgayCCMau.Size = new System.Drawing.Size(306, 40);
            this.txtSoNgayCCMau.TabIndex = 6;
            this.txtSoNgayCCMau.UnderlinedStyle = true;
            // 
            // dgvDSChamCong
            // 
            this.dgvDSChamCong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDSChamCong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSChamCong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvDSChamCong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSChamCong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSChamCong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSChamCong.ColumnHeadersHeight = 33;
            this.dgvDSChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDSChamCong.EnableHeadersVisualStyles = false;
            this.dgvDSChamCong.GridColor = System.Drawing.Color.Black;
            this.dgvDSChamCong.Location = new System.Drawing.Point(34, 429);
            this.dgvDSChamCong.Name = "dgvDSChamCong";
            this.dgvDSChamCong.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSChamCong.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSChamCong.RowHeadersVisible = false;
            this.dgvDSChamCong.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDSChamCong.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSChamCong.RowTemplate.Height = 24;
            this.dgvDSChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSChamCong.Size = new System.Drawing.Size(1072, 306);
            this.dgvDSChamCong.TabIndex = 18;
            this.dgvDSChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSChamCong_CellClick);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.btnCancel);
            this.panel11.Controls.Add(this.btnChamCong);
            this.panel11.Controls.Add(this.radTheoTenNV);
            this.panel11.Controls.Add(this.btnCapNhat);
            this.panel11.Controls.Add(this.radTheoMaNV);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txtTuKhoa);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(34, 251);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1068, 125);
            this.panel11.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(586, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChamCong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Image = ((System.Drawing.Image)(resources.GetObject("btnChamCong.Image")));
            this.btnChamCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChamCong.Location = new System.Drawing.Point(683, 52);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(187, 49);
            this.btnChamCong.TabIndex = 14;
            this.btnChamCong.Text = "Chấm công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // radTheoTenNV
            // 
            this.radTheoTenNV.AutoSize = true;
            this.radTheoTenNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTheoTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoTenNV.ForeColor = System.Drawing.Color.White;
            this.radTheoTenNV.Location = new System.Drawing.Point(26, 80);
            this.radTheoTenNV.Name = "radTheoTenNV";
            this.radTheoTenNV.Size = new System.Drawing.Size(200, 29);
            this.radTheoTenNV.TabIndex = 12;
            this.radTheoTenNV.Text = "Theo tên nhân viên";
            this.radTheoTenNV.UseVisualStyleBackColor = true;
            this.radTheoTenNV.CheckedChanged += new System.EventHandler(this.radTheoTenNV_CheckedChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCapNhat.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhat.Image")));
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(878, 52);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(183, 49);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // radTheoMaNV
            // 
            this.radTheoMaNV.Checked = true;
            this.radTheoMaNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radTheoMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTheoMaNV.ForeColor = System.Drawing.Color.White;
            this.radTheoMaNV.Location = new System.Drawing.Point(29, 40);
            this.radTheoMaNV.Name = "radTheoMaNV";
            this.radTheoMaNV.Size = new System.Drawing.Size(206, 29);
            this.radTheoMaNV.TabIndex = 12;
            this.radTheoMaNV.TabStop = true;
            this.radTheoMaNV.Text = "Theo mã nhân viên";
            this.radTheoMaNV.UseVisualStyleBackColor = true;
            this.radTheoMaNV.CheckedChanged += new System.EventHandler(this.radTheoMaNV_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chức năng";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1065, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 119);
            this.panel12.TabIndex = 0;
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTuKhoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTuKhoa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTuKhoa.BorderSize = 2;
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuKhoa.ForeColor = System.Drawing.Color.DimGray;
            this.txtTuKhoa.Location = new System.Drawing.Point(306, 66);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Multiline = false;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txtTuKhoa.Size = new System.Drawing.Size(277, 35);
            this.txtTuKhoa.TabIndex = 10;
            this.txtTuKhoa.UnderlinedStyle = false;
            this.txtTuKhoa._TextChanged += new System.EventHandler(this.txtTuKhoa__TextChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(367, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhập thông tin";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SteelBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 119);
            this.panel13.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SteelBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 122);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1068, 3);
            this.panel14.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SteelBlue;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1068, 3);
            this.panel15.TabIndex = 0;
            // 
            // frmQLChamCongNVHC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 763);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSChamCong);
            this.Name = "frmQLChamCongNVHC";
            this.Text = "Quản lý chấm công nhân viên hành chính";
            this.Load += new System.EventHandler(this.frmQLChamCongNVHC_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSChamCong)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Controls.TextBox txtMaCongMau;
        private Controls.TextBox txtSoNgayVCCMau;
        private Controls.TextBox txtSoNgayLVTT;
        private Controls.TextBox txtSoNgayCCMau;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDSChamCong;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboMaNV;
        private Controls.button btnChamCong;
        private Controls.TextBox txtTenNVMau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radTheoTenNV;
        private Controls.button btnCapNhat;
        private System.Windows.Forms.RadioButton radTheoMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private Controls.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label txtTenNV;
        private System.Windows.Forms.Label txtSoNgayVCC;
        private System.Windows.Forms.Label txtMaCong;
        private System.Windows.Forms.Label txtSoNgayCC;
    }
}