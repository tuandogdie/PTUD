namespace prjQuanLyLuongSanPham.GUI
{
    partial class frmQLLuongBHXH
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLLuongBHXH));
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboThang = new System.Windows.Forms.ComboBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaBHYT = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTenNV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenNVMau = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.dgvLuongBHXH = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.radTheoTenNV = new System.Windows.Forms.RadioButton();
            this.btnCapNhat = new prjQuanLyLuongSanPham.Controls.button();
            this.radTheoMaNV = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtTuKhoa = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongBHXH)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(24, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(325, 29);
            this.label12.TabIndex = 12;
            this.label12.Text = "Danh sách bảo hiểm xã hội\r\n";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.cboThang);
            this.panel1.Controls.Add(this.cboMaNV);
            this.panel1.Controls.Add(this.txtMaBHYT);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtTenNV);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtTenNVMau);
            this.panel1.Location = new System.Drawing.Point(29, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 236);
            this.panel1.TabIndex = 14;
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
            this.cboThang.Location = new System.Drawing.Point(700, 84);
            this.cboThang.Name = "cboThang";
            this.cboThang.Size = new System.Drawing.Size(122, 33);
            this.cboThang.TabIndex = 16;
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
            this.cboMaNV.Location = new System.Drawing.Point(176, 87);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(311, 33);
            this.cboMaNV.TabIndex = 16;
            this.cboMaNV.SelectedIndexChanged += new System.EventHandler(this.cboMaNV_SelectedIndexChanged);
            // 
            // txtMaBHYT
            // 
            this.txtMaBHYT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaBHYT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMaBHYT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaBHYT.BorderSize = 2;
            this.txtMaBHYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBHYT.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaBHYT.Location = new System.Drawing.Point(700, 142);
            this.txtMaBHYT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaBHYT.Multiline = false;
            this.txtMaBHYT.Name = "txtMaBHYT";
            this.txtMaBHYT.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaBHYT.Size = new System.Drawing.Size(311, 40);
            this.txtMaBHYT.TabIndex = 6;
            this.txtMaBHYT.UnderlinedStyle = true;
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
            this.panel5.Location = new System.Drawing.Point(1077, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 230);
            this.panel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 230);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 233);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1080, 3);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 95);
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
            this.panel3.Size = new System.Drawing.Size(1080, 3);
            this.panel3.TabIndex = 0;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.White;
            this.txtTenNV.Location = new System.Drawing.Point(171, 142);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(316, 25);
            this.txtTenNV.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(27, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(583, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã BHXH";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(583, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tháng";
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
            this.txtTenNVMau.Location = new System.Drawing.Point(176, 137);
            this.txtTenNVMau.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNVMau.Multiline = false;
            this.txtTenNVMau.Name = "txtTenNVMau";
            this.txtTenNVMau.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNVMau.Size = new System.Drawing.Size(311, 40);
            this.txtTenNVMau.TabIndex = 6;
            this.txtTenNVMau.UnderlinedStyle = true;
            // 
            // dgvLuongBHXH
            // 
            this.dgvLuongBHXH.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLuongBHXH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLuongBHXH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLuongBHXH.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvLuongBHXH.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLuongBHXH.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuongBHXH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLuongBHXH.ColumnHeadersHeight = 33;
            this.dgvLuongBHXH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLuongBHXH.EnableHeadersVisualStyles = false;
            this.dgvLuongBHXH.GridColor = System.Drawing.Color.Black;
            this.dgvLuongBHXH.Location = new System.Drawing.Point(31, 430);
            this.dgvLuongBHXH.Name = "dgvLuongBHXH";
            this.dgvLuongBHXH.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLuongBHXH.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvLuongBHXH.RowHeadersVisible = false;
            this.dgvLuongBHXH.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLuongBHXH.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvLuongBHXH.RowTemplate.Height = 24;
            this.dgvLuongBHXH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLuongBHXH.Size = new System.Drawing.Size(1080, 311);
            this.dgvLuongBHXH.TabIndex = 13;
            this.dgvLuongBHXH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLuongBHXH_CellClick);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.btnCancel);
            this.panel11.Controls.Add(this.radTheoTenNV);
            this.panel11.Controls.Add(this.btnCapNhat);
            this.panel11.Controls.Add(this.radTheoMaNV);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.txtTuKhoa);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(29, 257);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1080, 122);
            this.panel11.TabIndex = 31;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(614, 65);
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
            this.btnCapNhat.Location = new System.Drawing.Point(786, 51);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(180, 49);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, -5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Chức năng";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1077, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 116);
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
            this.txtTuKhoa.Location = new System.Drawing.Point(334, 65);
            this.txtTuKhoa.Margin = new System.Windows.Forms.Padding(4);
            this.txtTuKhoa.Multiline = false;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Padding = new System.Windows.Forms.Padding(7);
            this.txtTuKhoa.Size = new System.Drawing.Size(277, 35);
            this.txtTuKhoa.TabIndex = 10;
            this.txtTuKhoa.UnderlinedStyle = false;
            this.txtTuKhoa._TextChanged += new System.EventHandler(this.txtTuKhoa__TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(395, 34);
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
            this.panel13.Size = new System.Drawing.Size(3, 116);
            this.panel13.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SteelBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 119);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1080, 3);
            this.panel14.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SteelBlue;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1080, 3);
            this.panel15.TabIndex = 0;
            // 
            // frmQLLuongBHXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 763);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLuongBHXH);
            this.Name = "frmQLLuongBHXH";
            this.Text = "Quản lý lương BHXH";
            this.Load += new System.EventHandler(this.frmQLLuongBHXH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLuongBHXH)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel1;
        private Controls.TextBox txtMaBHYT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvLuongBHXH;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton radTheoTenNV;
        private Controls.button btnCapNhat;
        private System.Windows.Forms.RadioButton radTheoMaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private Controls.TextBox txtTuKhoa;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private Controls.TextBox txtTenNVMau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txtTenNV;
    }
}