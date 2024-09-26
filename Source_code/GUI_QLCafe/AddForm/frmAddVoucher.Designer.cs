namespace GUI_QLCafe
{
    partial class frmAddVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVoucher));
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.lbPhanTramKM = new System.Windows.Forms.Label();
            this.txtPhanTramKM = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTenKhuyenMai = new System.Windows.Forms.Label();
            this.txtTenKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaKhuyenMai = new System.Windows.Forms.Label();
            this.bfAddVoucher = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtMaKhuyenMai = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.BorderColor = System.Drawing.Color.Silver;
            this.cbTrangThai.BorderRadius = 5;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Chưa sử dụng",
            "Đã sử dụng"});
            this.cbTrangThai.Location = new System.Drawing.Point(411, 210);
            this.cbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(345, 36);
            this.cbTrangThai.TabIndex = 50;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.White;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lbTrangThai.Location = new System.Drawing.Point(409, 178);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(98, 28);
            this.lbTrangThai.TabIndex = 43;
            this.lbTrangThai.Text = "Trạng thái";
            // 
            // lbPhanTramKM
            // 
            this.lbPhanTramKM.AutoSize = true;
            this.lbPhanTramKM.BackColor = System.Drawing.Color.White;
            this.lbPhanTramKM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhanTramKM.ForeColor = System.Drawing.Color.Black;
            this.lbPhanTramKM.Location = new System.Drawing.Point(409, 103);
            this.lbPhanTramKM.Name = "lbPhanTramKM";
            this.lbPhanTramKM.Size = new System.Drawing.Size(206, 28);
            this.lbPhanTramKM.TabIndex = 44;
            this.lbPhanTramKM.Text = "Phần trăm khuyến mãi";
            // 
            // txtPhanTramKM
            // 
            this.txtPhanTramKM.BackColor = System.Drawing.Color.Transparent;
            this.txtPhanTramKM.BorderColor = System.Drawing.Color.Silver;
            this.txtPhanTramKM.BorderRadius = 5;
            this.txtPhanTramKM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhanTramKM.DefaultText = "";
            this.txtPhanTramKM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhanTramKM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhanTramKM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanTramKM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhanTramKM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtPhanTramKM.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhanTramKM.ForeColor = System.Drawing.Color.Black;
            this.txtPhanTramKM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtPhanTramKM.Location = new System.Drawing.Point(413, 135);
            this.txtPhanTramKM.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhanTramKM.Name = "txtPhanTramKM";
            this.txtPhanTramKM.PasswordChar = '\0';
            this.txtPhanTramKM.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPhanTramKM.PlaceholderText = "";
            this.txtPhanTramKM.SelectedText = "";
            this.txtPhanTramKM.Size = new System.Drawing.Size(343, 36);
            this.txtPhanTramKM.TabIndex = 46;
            // 
            // lbTenKhuyenMai
            // 
            this.lbTenKhuyenMai.AutoSize = true;
            this.lbTenKhuyenMai.BackColor = System.Drawing.Color.White;
            this.lbTenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.lbTenKhuyenMai.Location = new System.Drawing.Point(39, 178);
            this.lbTenKhuyenMai.Name = "lbTenKhuyenMai";
            this.lbTenKhuyenMai.Size = new System.Drawing.Size(146, 28);
            this.lbTenKhuyenMai.TabIndex = 45;
            this.lbTenKhuyenMai.Text = "Tên khuyến mãi";
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKhuyenMai.BorderColor = System.Drawing.Color.Silver;
            this.txtTenKhuyenMai.BorderRadius = 5;
            this.txtTenKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKhuyenMai.DefaultText = "";
            this.txtTenKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.txtTenKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(44, 213);
            this.txtTenKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.PasswordChar = '\0';
            this.txtTenKhuyenMai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenKhuyenMai.PlaceholderText = "";
            this.txtTenKhuyenMai.SelectedText = "";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(343, 36);
            this.txtTenKhuyenMai.TabIndex = 47;
            // 
            // lbMaKhuyenMai
            // 
            this.lbMaKhuyenMai.AutoSize = true;
            this.lbMaKhuyenMai.BackColor = System.Drawing.Color.White;
            this.lbMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.lbMaKhuyenMai.Location = new System.Drawing.Point(39, 103);
            this.lbMaKhuyenMai.Name = "lbMaKhuyenMai";
            this.lbMaKhuyenMai.Size = new System.Drawing.Size(145, 28);
            this.lbMaKhuyenMai.TabIndex = 42;
            this.lbMaKhuyenMai.Text = "Mã khuyến mãi";
            // 
            // bfAddVoucher
            // 
            this.bfAddVoucher.AnimateWindow = true;
            this.bfAddVoucher.AnimationInterval = 250;
            this.bfAddVoucher.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.bfAddVoucher.BorderRadius = 10;
            this.bfAddVoucher.ContainerControl = this;
            this.bfAddVoucher.DockIndicatorTransparencyValue = 0.6D;
            this.bfAddVoucher.TransparentWhileDrag = true;
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.BackColor = System.Drawing.Color.Transparent;
            this.txtMaKhuyenMai.BorderColor = System.Drawing.Color.Silver;
            this.txtMaKhuyenMai.BorderRadius = 5;
            this.txtMaKhuyenMai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKhuyenMai.DefaultText = "";
            this.txtMaKhuyenMai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaKhuyenMai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaKhuyenMai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhuyenMai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaKhuyenMai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaKhuyenMai.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhuyenMai.ForeColor = System.Drawing.Color.Black;
            this.txtMaKhuyenMai.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(44, 135);
            this.txtMaKhuyenMai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.PasswordChar = '\0';
            this.txtMaKhuyenMai.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaKhuyenMai.PlaceholderText = "";
            this.txtMaKhuyenMai.SelectedText = "";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(343, 36);
            this.txtMaKhuyenMai.TabIndex = 48;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.BorderColor = System.Drawing.Color.Gray;
            this.btnThoat.BorderRadius = 15;
            this.btnThoat.BorderThickness = 1;
            this.btnThoat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThoat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThoat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThoat.FillColor = System.Drawing.Color.White;
            this.btnThoat.FocusedColor = System.Drawing.Color.Black;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Black;
            this.btnThoat.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThoat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btnThoat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(44, 378);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(713, 57);
            this.btnThoat.TabIndex = 51;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.panelHeader.Controls.Add(this.guna2PictureBox1);
            this.panelHeader.Controls.Add(this.lbHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 81);
            this.panelHeader.TabIndex = 52;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(103, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.AutoSize = true;
            this.lbHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lbHeaderText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderText.ForeColor = System.Drawing.Color.White;
            this.lbHeaderText.Location = new System.Drawing.Point(204, 21);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(419, 45);
            this.lbHeaderText.TabIndex = 10;
            this.lbHeaderText.Text = "THÔNG TIN KHUYẾN MÃI";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnLuu.BorderRadius = 15;
            this.btnLuu.BorderThickness = 1;
            this.btnLuu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLuu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLuu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnLuu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(44, 282);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLuu.Size = new System.Drawing.Size(713, 57);
            this.btnLuu.TabIndex = 49;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmAddVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.lbPhanTramKM);
            this.Controls.Add(this.txtPhanTramKM);
            this.Controls.Add(this.lbTenKhuyenMai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtTenKhuyenMai);
            this.Controls.Add(this.lbMaKhuyenMai);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddVoucher";
            this.Load += new System.EventHandler(this.frmAddVoucher_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.Label lbPhanTramKM;
        private System.Windows.Forms.Label lbTenKhuyenMai;
        private System.Windows.Forms.Label lbMaKhuyenMai;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddVoucher;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbHeaderText;
        public Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        public Guna.UI2.WinForms.Guna2TextBox txtPhanTramKM;
        public Guna.UI2.WinForms.Guna2TextBox txtTenKhuyenMai;
        public Guna.UI2.WinForms.Guna2TextBox txtMaKhuyenMai;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
    }
}