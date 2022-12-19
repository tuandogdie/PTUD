namespace prjQuanLyLuongSanPham.GUI
{
    partial class frmTimKiemNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimKiemNhanVien));
            this.label12 = new System.Windows.Forms.Label();
            this.dgvTK = new System.Windows.Forms.DataGridView();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cboLoaiNV = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new prjQuanLyLuongSanPham.Controls.button();
            this.txtSDT = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.txtTenNV = new prjQuanLyLuongSanPham.Controls.TextBox();
            this.txtMaNV = new prjQuanLyLuongSanPham.Controls.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(35, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(239, 29);
            this.label12.TabIndex = 6;
            this.label12.Text = "Danh sách tìm kiếm";
            // 
            // dgvTK
            // 
            this.dgvTK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTK.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.dgvTK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTK.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTK.ColumnHeadersHeight = 33;
            this.dgvTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTK.EnableHeadersVisualStyles = false;
            this.dgvTK.GridColor = System.Drawing.Color.Black;
            this.dgvTK.Location = new System.Drawing.Point(35, 368);
            this.dgvTK.Name = "dgvTK";
            this.dgvTK.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTK.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTK.RowHeadersVisible = false;
            this.dgvTK.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTK.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTK.RowTemplate.Height = 24;
            this.dgvTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTK.Size = new System.Drawing.Size(1067, 315);
            this.dgvTK.TabIndex = 7;
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.AutoSize = true;
            this.panel11.Controls.Add(this.txtSDT);
            this.panel11.Controls.Add(this.label2);
            this.panel11.Controls.Add(this.txtTenNV);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.txtMaNV);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.cboLoaiNV);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel13);
            this.panel11.Controls.Add(this.panel14);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Location = new System.Drawing.Point(35, 44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1072, 173);
            this.panel11.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(552, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Tên nhân viên";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(18, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Mã nhân viên";
            // 
            // cboLoaiNV
            // 
            this.cboLoaiNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboLoaiNV.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cboLoaiNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoaiNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLoaiNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLoaiNV.ForeColor = System.Drawing.Color.White;
            this.cboLoaiNV.FormattingEnabled = true;
            this.cboLoaiNV.Items.AddRange(new object[] {
            "Công nhân",
            "Nhân viên hành chính"});
            this.cboLoaiNV.Location = new System.Drawing.Point(171, 52);
            this.cboLoaiNV.Name = "cboLoaiNV";
            this.cboLoaiNV.Size = new System.Drawing.Size(335, 33);
            this.cboLoaiNV.TabIndex = 20;
            this.cboLoaiNV.SelectedIndexChanged += new System.EventHandler(this.cboLoaiNV_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Loại nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, -5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tìm kiếm";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.SteelBlue;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel12.Location = new System.Drawing.Point(1069, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(3, 167);
            this.panel12.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.SteelBlue;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel13.Location = new System.Drawing.Point(0, 3);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(3, 167);
            this.panel13.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.SteelBlue;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 170);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1072, 3);
            this.panel14.TabIndex = 0;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.SteelBlue;
            this.panel15.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1072, 3);
            this.panel15.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(552, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số điện thoại";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(904, 243);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(203, 53);
            this.btnReset.TabIndex = 18;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtSDT.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSDT.BorderSize = 2;
            this.txtSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.ForeColor = System.Drawing.Color.DimGray;
            this.txtSDT.Location = new System.Drawing.Point(696, 99);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Multiline = false;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Padding = new System.Windows.Forms.Padding(7);
            this.txtSDT.Size = new System.Drawing.Size(335, 40);
            this.txtSDT.TabIndex = 22;
            this.txtSDT.UnderlinedStyle = true;
            this.txtSDT._TextChanged += new System.EventHandler(this.txttenNV__TextChanged);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtTenNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTenNV.BorderSize = 2;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.ForeColor = System.Drawing.Color.DimGray;
            this.txtTenNV.Location = new System.Drawing.Point(696, 45);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNV.Multiline = false;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtTenNV.Size = new System.Drawing.Size(335, 40);
            this.txtTenNV.TabIndex = 22;
            this.txtTenNV.UnderlinedStyle = true;
            this.txtTenNV._TextChanged += new System.EventHandler(this.txttenNV__TextChanged);
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.txtMaNV.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtMaNV.BorderSize = 2;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaNV.Location = new System.Drawing.Point(171, 99);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNV.Multiline = false;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Padding = new System.Windows.Forms.Padding(7);
            this.txtMaNV.Size = new System.Drawing.Size(335, 40);
            this.txtMaNV.TabIndex = 22;
            this.txtMaNV.UnderlinedStyle = true;
            this.txtMaNV._TextChanged += new System.EventHandler(this.txttenNV__TextChanged);
            // 
            // frmTimKiemNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1140, 763);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvTK);
            this.Name = "frmTimKiemNhanVien";
            this.Text = "Tìm kiếm nhân viên";
            this.Load += new System.EventHandler(this.frmTimKiemNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTK)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvTK;
        private System.Windows.Forms.Panel panel11;
        private Controls.button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ComboBox cboLoaiNV;
        private System.Windows.Forms.Label label3;
        private Controls.TextBox txtMaNV;
        private System.Windows.Forms.Label label9;
        private Controls.TextBox txtTenNV;
        private System.Windows.Forms.Label label1;
        private Controls.TextBox txtSDT;
        private System.Windows.Forms.Label label2;
    }
}