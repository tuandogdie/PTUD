namespace prjQuanLyLuongSanPham.GUI
{
    partial class frmPhanCongChoCN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCongChoCN));
            this.label12 = new System.Windows.Forms.Label();
            this.dgvPhanCongCN = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCongDoan = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboHopDong = new System.Windows.Forms.ComboBox();
            this.cboSanPham = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNVMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnPhanCong = new prjQuanLyLuongSanPham.Controls.button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radTheoTenNV = new System.Windows.Forms.RadioButton();
            this.btnCapNhat = new prjQuanLyLuongSanPham.Controls.button();
            this.radTheoMaNV = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtTuKhoa = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongCN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(31, 469);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(262, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Danh sách phân công";
            // 
            // dgvPhanCongCN
            // 
            this.dgvPhanCongCN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanCongCN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhanCongCN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvPhanCongCN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhanCongCN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCongCN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPhanCongCN.ColumnHeadersHeight = 33;
            this.dgvPhanCongCN.EnableHeadersVisualStyles = false;
            this.dgvPhanCongCN.GridColor = System.Drawing.Color.Black;
            this.dgvPhanCongCN.Location = new System.Drawing.Point(36, 508);
            this.dgvPhanCongCN.Name = "dgvPhanCongCN";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPhanCongCN.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanCongCN.RowHeadersVisible = false;
            this.dgvPhanCongCN.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPhanCongCN.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPhanCongCN.RowTemplate.Height = 24;
            this.dgvPhanCongCN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhanCongCN.Size = new System.Drawing.Size(1068, 224);
            this.dgvPhanCongCN.TabIndex = 1;
            this.dgvPhanCongCN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongDoan_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cboCongDoan);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.cboHopDong);
            this.panel1.Controls.Add(this.cboSanPham);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTenNVMau);
            this.panel1.Location = new System.Drawing.Point(36, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 291);
            this.panel1.TabIndex = 26;
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
            this.cboThang.Location = new System.Drawing.Point(409, 98);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(432, 33);
            this.cboThang.TabIndex = 12;
            this.cboThang.SelectedIndexChanged += new System.EventHandler(this.cboThang_SelectedIndexChanged);
            this.cboThang.SelectionChangeCommitted += new System.EventHandler(this.cboThang_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(253, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tháng";
            // 
            // cboCongDoan
            // 
            this.cboCongDoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboCongDoan.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboCongDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCongDoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCongDoan.ForeColor = System.Drawing.Color.White;
            this.cboCongDoan.FormattingEnabled = true;
            this.cboCongDoan.Location = new System.Drawing.Point(409, 241);
            this.cboCongDoan.Name = "cboCongDoan";
            this.cboCongDoan.Size = new System.Drawing.Size(432, 33);
            this.cboCongDoan.TabIndex = 10;
            this.cboCongDoan.SelectionChangeCommitted += new System.EventHandler(this.cboCongDoan_SelectedIndexChanged);
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
            // cboHopDong
            // 
            this.cboHopDong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboHopDong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboHopDong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHopDong.ForeColor = System.Drawing.Color.White;
            this.cboHopDong.FormattingEnabled = true;
            this.cboHopDong.Location = new System.Drawing.Point(409, 147);
            this.cboHopDong.Name = "cboHopDong";
            this.cboHopDong.Size = new System.Drawing.Size(432, 33);
            this.cboHopDong.TabIndex = 8;
            this.cboHopDong.SelectionChangeCommitted += new System.EventHandler(this.cboHopDong_SelectedIndexChanged);
            // 
            // cboSanPham
            // 
            this.cboSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboSanPham.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSanPham.ForeColor = System.Drawing.Color.White;
            this.cboSanPham.FormattingEnabled = true;
            this.cboSanPham.Location = new System.Drawing.Point(409, 196);
            this.cboSanPham.Name = "cboSanPham";
            this.cboSanPham.Size = new System.Drawing.Size(432, 33);
            this.cboSanPham.TabIndex = 8;
            this.cboSanPham.SelectionChangeCommitted += new System.EventHandler(this.cboSanPham_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1065, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 285);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 285);
            this.panel4.TabIndex = 0;
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
            this.cboMaNV.Location = new System.Drawing.Point(409, 15);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(432, 33);
            this.cboMaNV.TabIndex = 8;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(253, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Công đoạn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 288);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1068, 3);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(253, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sản phẩm";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hợp đồng";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.White;
            this.txtTenNV.Location = new System.Drawing.Point(409, 58);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(436, 25);
            this.txtTenNV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(253, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(253, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
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
            this.txtTenNVMau.Location = new System.Drawing.Point(409, 51);
            this.txtTenNVMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNVMau.Multiline = false;
            this.txtTenNVMau.Name = "txtTenNVMau";
            this.txtTenNVMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNVMau.Size = new System.Drawing.Size(432, 40);
            this.txtTenNVMau.TabIndex = 6;
            this.txtTenNVMau.UnderlinedStyle = true;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.btnPhanCong);
            this.panel11.Controls.Add(this.btnCancel);
            this.panel11.Controls.Add(this.radTheoTenNV);
            this.panel11.Controls.Add(this.btnCapNhat);
            this.panel11.Controls.Add(this.radTheoMaNV);
            this.panel11.Controls.Add(this.label4);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txtTuKhoa);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(36, 324);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1068, 139);
            this.panel11.TabIndex = 30;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPhanCong.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnPhanCong.FlatAppearance.BorderSize = 0;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Image = ((System.Drawing.Image)(resources.GetObject("btnPhanCong.Image")));
            this.btnPhanCong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPhanCong.Location = new System.Drawing.Point(661, 60);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(180, 49);
            this.btnPhanCong.TabIndex = 19;
            this.btnPhanCong.Text = "Phân công";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(608, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(38, 36);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.btnCapNhat.Location = new System.Drawing.Point(852, 59);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(180, 49);
            this.btnCapNhat.TabIndex = 8;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhap_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chức năng";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1065, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 133);
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
            this.txtTuKhoa.Location = new System.Drawing.Point(328, 73);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Multiline = false;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txtTuKhoa.Size = new System.Drawing.Size(277, 35);
            this.txtTuKhoa.TabIndex = 10;
            this.txtTuKhoa.UnderlinedStyle = false;
            this.txtTuKhoa._TextChanged += new System.EventHandler(this.txtTuKhoa_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(389, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Nhập thông tin";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SteelBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 133);
            this.panel13.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SteelBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 136);
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
            // frmPhanCongChoCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 763);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvPhanCongCN);
            this.Name = "frmPhanCongChoCN";
            this.Text = "Phân công cho Công Nhân";
            this.Load += new System.EventHandler(this.frmPhanCongChoCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCongCN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvPhanCongCN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cboMaNV;
        private Controls.TextBox txtTenNVMau;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.RadioButton radTheoTenNV;
        private Controls.button btnCapNhat;
        private System.Windows.Forms.RadioButton radTheoMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel12;
        private Controls.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cboHopDong;
        private System.Windows.Forms.ComboBox cboSanPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCongDoan;
        private System.Windows.Forms.Label txtTenNV;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.Label label7;
        private Controls.button btnPhanCong;
    }
}