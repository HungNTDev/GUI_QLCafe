namespace GUI_QLCafe
{
    partial class frmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
            this.panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.cbPhuongThucTT = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbVoucher = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbVoucher = new System.Windows.Forms.Label();
            this.lbPhuongThucTT = new System.Windows.Forms.Label();
            this.lbTextVoucher = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbTongHoaDon = new System.Windows.Forms.Label();
            this.panel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lbText = new System.Windows.Forms.Label();
            this.panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbThuNgan = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.lbGioRa = new System.Windows.Forms.Label();
            this.lbGioVao = new System.Windows.Forms.Label();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.chTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3.Controls.Add(this.btnHuy);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Controls.Add(this.cbPhuongThucTT);
            this.panel3.Controls.Add(this.cbVoucher);
            this.panel3.Controls.Add(this.lbVoucher);
            this.panel3.Controls.Add(this.lbPhuongThucTT);
            this.panel3.Controls.Add(this.lbTextVoucher);
            this.panel3.Controls.Add(this.lbTongTien);
            this.panel3.Controls.Add(this.lbTongHoaDon);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 710);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 298);
            this.panel3.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.BorderColor = System.Drawing.Color.White;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.BorderThickness = 1;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnHuy.HoverState.FillColor = System.Drawing.Color.White;
            this.btnHuy.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnHuy.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHuy.Location = new System.Drawing.Point(354, 225);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnHuy.Size = new System.Drawing.Size(317, 50);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.BorderThickness = 1;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageSize = new System.Drawing.Size(30, 30);
            this.btnThanhToan.Location = new System.Drawing.Point(18, 225);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnThanhToan.Size = new System.Drawing.Size(317, 50);
            this.btnThanhToan.TabIndex = 5;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // cbPhuongThucTT
            // 
            this.cbPhuongThucTT.BackColor = System.Drawing.Color.Transparent;
            this.cbPhuongThucTT.BorderRadius = 5;
            this.cbPhuongThucTT.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPhuongThucTT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhuongThucTT.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhuongThucTT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPhuongThucTT.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbPhuongThucTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPhuongThucTT.ItemHeight = 30;
            this.cbPhuongThucTT.Items.AddRange(new object[] {
            "Tiền mặt",
            "MoMo"});
            this.cbPhuongThucTT.Location = new System.Drawing.Point(296, 109);
            this.cbPhuongThucTT.Name = "cbPhuongThucTT";
            this.cbPhuongThucTT.Size = new System.Drawing.Size(164, 36);
            this.cbPhuongThucTT.TabIndex = 4;
            // 
            // cbVoucher
            // 
            this.cbVoucher.BackColor = System.Drawing.Color.Transparent;
            this.cbVoucher.BorderRadius = 5;
            this.cbVoucher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbVoucher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVoucher.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVoucher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbVoucher.ItemHeight = 30;
            this.cbVoucher.Location = new System.Drawing.Point(120, 61);
            this.cbVoucher.Name = "cbVoucher";
            this.cbVoucher.Size = new System.Drawing.Size(164, 36);
            this.cbVoucher.TabIndex = 4;
            // 
            // lbVoucher
            // 
            this.lbVoucher.AutoSize = true;
            this.lbVoucher.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVoucher.ForeColor = System.Drawing.Color.White;
            this.lbVoucher.Location = new System.Drawing.Point(290, 66);
            this.lbVoucher.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbVoucher.Name = "lbVoucher";
            this.lbVoucher.Size = new System.Drawing.Size(75, 31);
            this.lbVoucher.TabIndex = 3;
            this.lbVoucher.Text = "(0%) :";
            // 
            // lbPhuongThucTT
            // 
            this.lbPhuongThucTT.AutoSize = true;
            this.lbPhuongThucTT.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhuongThucTT.ForeColor = System.Drawing.Color.White;
            this.lbPhuongThucTT.Location = new System.Drawing.Point(11, 109);
            this.lbPhuongThucTT.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbPhuongThucTT.Name = "lbPhuongThucTT";
            this.lbPhuongThucTT.Size = new System.Drawing.Size(284, 31);
            this.lbPhuongThucTT.TabIndex = 3;
            this.lbPhuongThucTT.Text = "Phương thức thanh toán:";
            // 
            // lbTextVoucher
            // 
            this.lbTextVoucher.AutoSize = true;
            this.lbTextVoucher.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTextVoucher.ForeColor = System.Drawing.Color.White;
            this.lbTextVoucher.Location = new System.Drawing.Point(12, 61);
            this.lbTextVoucher.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTextVoucher.Name = "lbTextVoucher";
            this.lbTextVoucher.Size = new System.Drawing.Size(102, 31);
            this.lbTextVoucher.TabIndex = 3;
            this.lbTextVoucher.Text = "Voucher";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.ForeColor = System.Drawing.Color.White;
            this.lbTongTien.Location = new System.Drawing.Point(11, 165);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(176, 41);
            this.lbTongTien.TabIndex = 3;
            this.lbTongTien.Text = "Tổng cộng:";
            // 
            // lbTongHoaDon
            // 
            this.lbTongHoaDon.AutoSize = true;
            this.lbTongHoaDon.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongHoaDon.ForeColor = System.Drawing.Color.White;
            this.lbTongHoaDon.Location = new System.Drawing.Point(12, 11);
            this.lbTongHoaDon.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTongHoaDon.Name = "lbTongHoaDon";
            this.lbTongHoaDon.Size = new System.Drawing.Size(170, 31);
            this.lbTongHoaDon.TabIndex = 3;
            this.lbTongHoaDon.Text = "Tổng hóa đơn:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.lbText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 51);
            this.panel1.TabIndex = 0;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(221, 2);
            this.lbText.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(239, 45);
            this.lbText.TabIndex = 2;
            this.lbText.Text = "THANH TOÁN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.lbThuNgan);
            this.panel2.Controls.Add(this.lbTen);
            this.panel2.Controls.Add(this.lbGioRa);
            this.panel2.Controls.Add(this.lbGioVao);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(683, 176);
            this.panel2.TabIndex = 2;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(447, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(236, 176);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbThuNgan
            // 
            this.lbThuNgan.AutoSize = true;
            this.lbThuNgan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThuNgan.ForeColor = System.Drawing.Color.White;
            this.lbThuNgan.Location = new System.Drawing.Point(12, 131);
            this.lbThuNgan.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbThuNgan.Name = "lbThuNgan";
            this.lbThuNgan.Size = new System.Drawing.Size(127, 31);
            this.lbThuNgan.TabIndex = 5;
            this.lbThuNgan.Text = "Thu ngân: ";
            // 
            // lbTen
            // 
            this.lbTen.AutoSize = true;
            this.lbTen.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTen.ForeColor = System.Drawing.Color.White;
            this.lbTen.Location = new System.Drawing.Point(12, 10);
            this.lbTen.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTen.Name = "lbTen";
            this.lbTen.Size = new System.Drawing.Size(57, 31);
            this.lbTen.TabIndex = 2;
            this.lbTen.Text = "Tên:";
            // 
            // lbGioRa
            // 
            this.lbGioRa.AutoSize = true;
            this.lbGioRa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioRa.ForeColor = System.Drawing.Color.White;
            this.lbGioRa.Location = new System.Drawing.Point(12, 90);
            this.lbGioRa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioRa.Name = "lbGioRa";
            this.lbGioRa.Size = new System.Drawing.Size(84, 31);
            this.lbGioRa.TabIndex = 3;
            this.lbGioRa.Text = "Giờ ra:";
            // 
            // lbGioVao
            // 
            this.lbGioVao.AutoSize = true;
            this.lbGioVao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioVao.ForeColor = System.Drawing.Color.White;
            this.lbGioVao.Location = new System.Drawing.Point(11, 52);
            this.lbGioVao.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioVao.Name = "lbGioVao";
            this.lbGioVao.Size = new System.Drawing.Size(101, 31);
            this.lbGioVao.TabIndex = 4;
            this.lbGioVao.Text = "Giờ vào:";
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BackColor = System.Drawing.Color.White;
            this.lvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenMon,
            this.chSoLuong,
            this.chDonGia,
            this.chThanhTien});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(0, 227);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(683, 483);
            this.lvHoaDon.TabIndex = 5;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // chTenMon
            // 
            this.chTenMon.Text = "Tên món";
            this.chTenMon.Width = 200;
            // 
            // chSoLuong
            // 
            this.chSoLuong.Text = "Số lượng";
            this.chSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSoLuong.Width = 120;
            // 
            // chDonGia
            // 
            this.chDonGia.Text = "Đơn giá";
            this.chDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDonGia.Width = 160;
            // 
            // chThanhTien
            // 
            this.chThanhTien.Text = "Thành tiền";
            this.chThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chThanhTien.Width = 200;
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(683, 1008);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPayment";
            this.Text = "frmPayment";
            this.Load += new System.EventHandler(this.frmPayment_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panel3;
        private Guna.UI2.WinForms.Guna2GradientPanel panel1;
        private Guna.UI2.WinForms.Guna2Panel panel2;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader chTenMon;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.ColumnHeader chDonGia;
        private System.Windows.Forms.ColumnHeader chThanhTien;
        private System.Windows.Forms.Label lbText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbThuNgan;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label lbGioRa;
        private System.Windows.Forms.Label lbGioVao;
        private Guna.UI2.WinForms.Guna2ComboBox cbVoucher;
        private System.Windows.Forms.Label lbTongHoaDon;
        private System.Windows.Forms.Label lbVoucher;
        private System.Windows.Forms.Label lbPhuongThucTT;
        private System.Windows.Forms.Label lbTextVoucher;
        private Guna.UI2.WinForms.Guna2ComboBox cbPhuongThucTT;
        private System.Windows.Forms.Label lbTongTien;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}