namespace GUI_QLCafe
{
    partial class frmAddNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNhanVien));
            this.bfAddNhanVien = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.lbEmailNhanVien = new System.Windows.Forms.Label();
            this.lbTenNhanVien = new System.Windows.Forms.Label();
            this.rdoQuanTri = new System.Windows.Forms.RadioButton();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.rdoHoatDong = new System.Windows.Forms.RadioButton();
            this.rdoNgungHoatDong = new System.Windows.Forms.RadioButton();
            this.gbVaiTro = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoChuSoHuu = new System.Windows.Forms.RadioButton();
            this.gbTrangThai = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.picNhanVien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMoHinh = new Guna.UI2.WinForms.Guna2Button();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.gbVaiTro.SuspendLayout();
            this.gbTrangThai.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // bfAddNhanVien
            // 
            this.bfAddNhanVien.AnimateWindow = true;
            this.bfAddNhanVien.AnimationInterval = 250;
            this.bfAddNhanVien.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.bfAddNhanVien.BorderRadius = 10;
            this.bfAddNhanVien.ContainerControl = this;
            this.bfAddNhanVien.DockIndicatorTransparencyValue = 0.6D;
            this.bfAddNhanVien.TransparentWhileDrag = true;
            // 
            // lbEmailNhanVien
            // 
            this.lbEmailNhanVien.AutoSize = true;
            this.lbEmailNhanVien.BackColor = System.Drawing.Color.White;
            this.lbEmailNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbEmailNhanVien.Location = new System.Drawing.Point(39, 111);
            this.lbEmailNhanVien.Name = "lbEmailNhanVien";
            this.lbEmailNhanVien.Size = new System.Drawing.Size(59, 28);
            this.lbEmailNhanVien.TabIndex = 2;
            this.lbEmailNhanVien.Text = "Email";
            // 
            // lbTenNhanVien
            // 
            this.lbTenNhanVien.AutoSize = true;
            this.lbTenNhanVien.BackColor = System.Drawing.Color.White;
            this.lbTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.lbTenNhanVien.Location = new System.Drawing.Point(39, 187);
            this.lbTenNhanVien.Name = "lbTenNhanVien";
            this.lbTenNhanVien.Size = new System.Drawing.Size(130, 28);
            this.lbTenNhanVien.TabIndex = 3;
            this.lbTenNhanVien.Text = "Tên nhân viên";
            // 
            // rdoQuanTri
            // 
            this.rdoQuanTri.AutoSize = true;
            this.rdoQuanTri.BackColor = System.Drawing.Color.White;
            this.rdoQuanTri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuanTri.ForeColor = System.Drawing.Color.Black;
            this.rdoQuanTri.Location = new System.Drawing.Point(14, 49);
            this.rdoQuanTri.Name = "rdoQuanTri";
            this.rdoQuanTri.Size = new System.Drawing.Size(94, 27);
            this.rdoQuanTri.TabIndex = 2;
            this.rdoQuanTri.TabStop = true;
            this.rdoQuanTri.Text = "Quản trị";
            this.rdoQuanTri.UseVisualStyleBackColor = false;
            // 
            // rdoNhanVien
            // 
            this.rdoNhanVien.AutoSize = true;
            this.rdoNhanVien.BackColor = System.Drawing.Color.White;
            this.rdoNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNhanVien.ForeColor = System.Drawing.Color.Black;
            this.rdoNhanVien.Location = new System.Drawing.Point(14, 87);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(109, 27);
            this.rdoNhanVien.TabIndex = 2;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân viên";
            this.rdoNhanVien.UseVisualStyleBackColor = false;
            // 
            // rdoHoatDong
            // 
            this.rdoHoatDong.AutoSize = true;
            this.rdoHoatDong.BackColor = System.Drawing.Color.White;
            this.rdoHoatDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHoatDong.ForeColor = System.Drawing.Color.Black;
            this.rdoHoatDong.Location = new System.Drawing.Point(8, 47);
            this.rdoHoatDong.Name = "rdoHoatDong";
            this.rdoHoatDong.Size = new System.Drawing.Size(113, 27);
            this.rdoHoatDong.TabIndex = 2;
            this.rdoHoatDong.TabStop = true;
            this.rdoHoatDong.Text = "Hoạt động";
            this.rdoHoatDong.UseVisualStyleBackColor = false;
            // 
            // rdoNgungHoatDong
            // 
            this.rdoNgungHoatDong.AutoSize = true;
            this.rdoNgungHoatDong.BackColor = System.Drawing.Color.White;
            this.rdoNgungHoatDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNgungHoatDong.ForeColor = System.Drawing.Color.Black;
            this.rdoNgungHoatDong.Location = new System.Drawing.Point(8, 85);
            this.rdoNgungHoatDong.Name = "rdoNgungHoatDong";
            this.rdoNgungHoatDong.Size = new System.Drawing.Size(169, 27);
            this.rdoNgungHoatDong.TabIndex = 2;
            this.rdoNgungHoatDong.TabStop = true;
            this.rdoNgungHoatDong.Text = "Ngừng hoạt động";
            this.rdoNgungHoatDong.UseVisualStyleBackColor = false;
            // 
            // gbVaiTro
            // 
            this.gbVaiTro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.gbVaiTro.BorderRadius = 5;
            this.gbVaiTro.Controls.Add(this.rdoChuSoHuu);
            this.gbVaiTro.Controls.Add(this.rdoQuanTri);
            this.gbVaiTro.Controls.Add(this.rdoNhanVien);
            this.gbVaiTro.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.gbVaiTro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVaiTro.ForeColor = System.Drawing.Color.White;
            this.gbVaiTro.Location = new System.Drawing.Point(44, 268);
            this.gbVaiTro.Name = "gbVaiTro";
            this.gbVaiTro.Size = new System.Drawing.Size(201, 125);
            this.gbVaiTro.TabIndex = 8;
            this.gbVaiTro.Text = "Vai trò";
            // 
            // rdoChuSoHuu
            // 
            this.rdoChuSoHuu.AutoSize = true;
            this.rdoChuSoHuu.BackColor = System.Drawing.Color.White;
            this.rdoChuSoHuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuSoHuu.ForeColor = System.Drawing.Color.Black;
            this.rdoChuSoHuu.Location = new System.Drawing.Point(117, 85);
            this.rdoChuSoHuu.Name = "rdoChuSoHuu";
            this.rdoChuSoHuu.Size = new System.Drawing.Size(119, 27);
            this.rdoChuSoHuu.TabIndex = 6;
            this.rdoChuSoHuu.TabStop = true;
            this.rdoChuSoHuu.Text = "Chủ sở hữu";
            this.rdoChuSoHuu.UseVisualStyleBackColor = false;
            this.rdoChuSoHuu.Visible = false;
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.gbTrangThai.BorderRadius = 5;
            this.gbTrangThai.Controls.Add(this.rdoHoatDong);
            this.gbTrangThai.Controls.Add(this.rdoNgungHoatDong);
            this.gbTrangThai.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.gbTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrangThai.ForeColor = System.Drawing.Color.White;
            this.gbTrangThai.Location = new System.Drawing.Point(267, 268);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Size = new System.Drawing.Size(201, 125);
            this.gbTrangThai.TabIndex = 8;
            this.gbTrangThai.Text = "Trạng thái";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(44, 144);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(424, 34);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txtTenNhanVien.BorderColor = System.Drawing.Color.Silver;
            this.txtTenNhanVien.BorderRadius = 5;
            this.txtTenNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNhanVien.DefaultText = "";
            this.txtTenNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtTenNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenNhanVien.Location = new System.Drawing.Point(44, 221);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.PasswordChar = '\0';
            this.txtTenNhanVien.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenNhanVien.PlaceholderText = "";
            this.txtTenNhanVien.SelectedText = "";
            this.txtTenNhanVien.Size = new System.Drawing.Size(424, 34);
            this.txtTenNhanVien.TabIndex = 9;
            // 
            // picNhanVien
            // 
            this.picNhanVien.BorderRadius = 5;
            this.picNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNhanVien.FillColor = System.Drawing.Color.DodgerBlue;
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.ImageRotate = 0F;
            this.picNhanVien.Location = new System.Drawing.Point(497, 144);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(173, 198);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 10;
            this.picNhanVien.TabStop = false;
            // 
            // btnMoHinh
            // 
            this.btnMoHinh.BorderRadius = 5;
            this.btnMoHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoHinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnMoHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoHinh.ForeColor = System.Drawing.Color.White;
            this.btnMoHinh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnMoHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnMoHinh.Image")));
            this.btnMoHinh.Location = new System.Drawing.Point(497, 348);
            this.btnMoHinh.Name = "btnMoHinh";
            this.btnMoHinh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnMoHinh.Size = new System.Drawing.Size(173, 42);
            this.btnMoHinh.TabIndex = 11;
            this.btnMoHinh.Text = "Mở hình";
            this.btnMoHinh.Click += new System.EventHandler(this.btnMoHinh_Click);
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.AutoScroll = true;
            this.txtDuongDan.BackColor = System.Drawing.Color.Transparent;
            this.txtDuongDan.BorderColor = System.Drawing.Color.Silver;
            this.txtDuongDan.BorderRadius = 5;
            this.txtDuongDan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDuongDan.DefaultText = "";
            this.txtDuongDan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDuongDan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDuongDan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDuongDan.FillColor = System.Drawing.Color.Gainsboro;
            this.txtDuongDan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtDuongDan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongDan.ForeColor = System.Drawing.Color.Black;
            this.txtDuongDan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtDuongDan.Location = new System.Drawing.Point(497, 398);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '*';
            this.txtDuongDan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDuongDan.PlaceholderText = "";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(173, 33);
            this.txtDuongDan.TabIndex = 9;
            this.txtDuongDan.Visible = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
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
            this.btnLuu.Location = new System.Drawing.Point(44, 438);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLuu.Size = new System.Drawing.Size(626, 57);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // messageDialog
            // 
            this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDialog.Caption = null;
            this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageDialog.Parent = this;
            this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageDialog.Text = null;
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
            this.btnThoat.Location = new System.Drawing.Point(44, 537);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(626, 57);
            this.btnThoat.TabIndex = 31;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lbHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(714, 81);
            this.panelHeader.TabIndex = 32;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(103, 81);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 47;
            this.picLogo.TabStop = false;
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.AutoSize = true;
            this.lbHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lbHeaderText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderText.ForeColor = System.Drawing.Color.White;
            this.lbHeaderText.Location = new System.Drawing.Point(109, 18);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(205, 45);
            this.lbHeaderText.TabIndex = 10;
            this.lbHeaderText.Text = "NHÂN VIÊN";
            // 
            // frmAddNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 631);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnMoHinh);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenNhanVien);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.gbTrangThai);
            this.Controls.Add(this.gbVaiTro);
            this.Controls.Add(this.lbEmailNhanVien);
            this.Controls.Add(this.lbTenNhanVien);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmAddNhanVien_Load);
            this.gbVaiTro.ResumeLayout(false);
            this.gbVaiTro.PerformLayout();
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddNhanVien;
        private System.Windows.Forms.RadioButton rdoQuanTri;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private System.Windows.Forms.RadioButton rdoHoatDong;
        private System.Windows.Forms.RadioButton rdoNgungHoatDong;
        private System.Windows.Forms.Label lbEmailNhanVien;
        private System.Windows.Forms.Label lbTenNhanVien;
        private Guna.UI2.WinForms.Guna2GroupBox gbVaiTro;
        private Guna.UI2.WinForms.Guna2GroupBox gbTrangThai;
        private Guna.UI2.WinForms.Guna2TextBox txtTenNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2PictureBox picNhanVien;
        private Guna.UI2.WinForms.Guna2Button btnMoHinh;
        private Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label lbHeaderText;
        private System.Windows.Forms.RadioButton rdoChuSoHuu;
    }
}