namespace GUI_QLCafe
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.lbTenBan = new System.Windows.Forms.Label();
            this.lbGioVao = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lbGioRa = new System.Windows.Forms.Label();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnBan = new Guna.UI2.WinForms.Guna2Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.chTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bfHoaDon = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBan.ForeColor = System.Drawing.Color.White;
            this.lbTenBan.Location = new System.Drawing.Point(21, 15);
            this.lbTenBan.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(83, 28);
            this.lbTenBan.TabIndex = 0;
            this.lbTenBan.Text = "Tên bàn:";
            // 
            // lbGioVao
            // 
            this.lbGioVao.AutoSize = true;
            this.lbGioVao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioVao.ForeColor = System.Drawing.Color.White;
            this.lbGioVao.Location = new System.Drawing.Point(20, 57);
            this.lbGioVao.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioVao.Name = "lbGioVao";
            this.lbGioVao.Size = new System.Drawing.Size(84, 28);
            this.lbGioVao.TabIndex = 0;
            this.lbGioVao.Text = "Giờ vào:";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.White;
            this.lbThanhTien.Location = new System.Drawing.Point(18, 20);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(158, 38);
            this.lbThanhTien.TabIndex = 0;
            this.lbThanhTien.Text = "Thành tiền:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.lbTenBan);
            this.panelHeader.Controls.Add(this.lbGioRa);
            this.panelHeader.Controls.Add(this.lbGioVao);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(601, 146);
            this.panelHeader.TabIndex = 2;
            // 
            // lbGioRa
            // 
            this.lbGioRa.AutoSize = true;
            this.lbGioRa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioRa.ForeColor = System.Drawing.Color.White;
            this.lbGioRa.Location = new System.Drawing.Point(21, 98);
            this.lbGioRa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioRa.Name = "lbGioRa";
            this.lbGioRa.Size = new System.Drawing.Size(69, 28);
            this.lbGioRa.TabIndex = 0;
            this.lbGioRa.Text = "Giờ ra:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelFooter.Controls.Add(this.btnBan);
            this.panelFooter.Controls.Add(this.btnThemMon);
            this.panelFooter.Controls.Add(this.btnThanhToan);
            this.panelFooter.Controls.Add(this.lbThanhTien);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 571);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(601, 171);
            this.panelFooter.TabIndex = 3;
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
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(25, 97);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnThanhToan.Size = new System.Drawing.Size(172, 48);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnThemMon
            // 
            this.btnThemMon.BorderColor = System.Drawing.Color.White;
            this.btnThemMon.BorderRadius = 10;
            this.btnThemMon.BorderThickness = 1;
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThemMon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(215, 97);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnThemMon.Size = new System.Drawing.Size(172, 48);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm món";
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // btnBan
            // 
            this.btnBan.BorderColor = System.Drawing.Color.White;
            this.btnBan.BorderRadius = 10;
            this.btnBan.BorderThickness = 1;
            this.btnBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnBan.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnBan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBan.Image = ((System.Drawing.Image)(resources.GetObject("btnBan.Image")));
            this.btnBan.Location = new System.Drawing.Point(406, 97);
            this.btnBan.Name = "btnBan";
            this.btnBan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnBan.Size = new System.Drawing.Size(172, 48);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bàn";
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenMon,
            this.chSoLuong,
            this.chDonGia,
            this.chThanhTien});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(0, 146);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(601, 425);
            this.lvHoaDon.TabIndex = 4;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // chTenMon
            // 
            this.chTenMon.Text = "Tên món";
            this.chTenMon.Width = 170;
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
            this.chDonGia.Width = 150;
            // 
            // chThanhTien
            // 
            this.chThanhTien.Text = "Thành tiền";
            this.chThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chThanhTien.Width = 170;
            // 
            // bfHoaDon
            // 
            this.bfHoaDon.ContainerControl = this;
            this.bfHoaDon.DockIndicatorTransparencyValue = 0.6D;
            this.bfHoaDon.TransparentWhileDrag = true;
            // 
            // frmHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(601, 742);
            this.Controls.Add(this.lvHoaDon);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label lbGioVao;
        private System.Windows.Forms.Label lbThanhTien;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lbGioRa;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private Guna.UI2.WinForms.Guna2Button btnBan;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader chTenMon;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.ColumnHeader chDonGia;
        private System.Windows.Forms.ColumnHeader chThanhTien;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfHoaDon;
    }
}