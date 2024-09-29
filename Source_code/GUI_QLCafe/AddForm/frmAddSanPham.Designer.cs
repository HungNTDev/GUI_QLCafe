namespace GUI_QLCafe
{
    partial class frmAddSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddSanPham));
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.picSanPham = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.bfAddSanPham = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnMoHinh = new Guna.UI2.WinForms.Guna2Button();
            this.lbGia = new System.Windows.Forms.Label();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbVND = new System.Windows.Forms.Label();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.gbTrangThai = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoCo = new System.Windows.Forms.RadioButton();
            this.rdoKhong = new System.Windows.Forms.RadioButton();
            this.messageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.cbLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbHeaderText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.gbTrangThai.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
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
            this.btnLuu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnLuu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnLuu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnLuu.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Location = new System.Drawing.Point(33, 460);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLuu.Size = new System.Drawing.Size(512, 56);
            this.btnLuu.TabIndex = 25;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // picSanPham
            // 
            this.picSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSanPham.BackgroundImage")));
            this.picSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picSanPham.Image")));
            this.picSanPham.ImageRotate = 0F;
            this.picSanPham.Location = new System.Drawing.Point(342, 89);
            this.picSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(203, 230);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSanPham.TabIndex = 23;
            this.picSanPham.TabStop = false;
            this.picSanPham.Tag = "";
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
            this.txtDuongDan.Location = new System.Drawing.Point(342, 343);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '\0';
            this.txtDuongDan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDuongDan.PlaceholderText = "";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(203, 30);
            this.txtDuongDan.TabIndex = 20;
            this.txtDuongDan.Visible = false;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.BackColor = System.Drawing.Color.Transparent;
            this.txtTenSanPham.BorderColor = System.Drawing.Color.Silver;
            this.txtTenSanPham.BorderRadius = 5;
            this.txtTenSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSanPham.DefaultText = "";
            this.txtTenSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenSanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtTenSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenSanPham.Location = new System.Drawing.Point(33, 177);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenSanPham.PlaceholderText = "";
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.Size = new System.Drawing.Size(275, 29);
            this.txtTenSanPham.TabIndex = 21;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.BackColor = System.Drawing.Color.Transparent;
            this.txtMaSanPham.BorderColor = System.Drawing.Color.Silver;
            this.txtMaSanPham.BorderRadius = 5;
            this.txtMaSanPham.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaSanPham.DefaultText = "";
            this.txtMaSanPham.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaSanPham.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaSanPham.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaSanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.txtMaSanPham.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaSanPham.Location = new System.Drawing.Point(33, 116);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.PasswordChar = '\0';
            this.txtMaSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaSanPham.PlaceholderText = "";
            this.txtMaSanPham.SelectedText = "";
            this.txtMaSanPham.Size = new System.Drawing.Size(275, 29);
            this.txtMaSanPham.TabIndex = 22;
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.BackColor = System.Drawing.Color.White;
            this.lbMaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.lbMaSanPham.Location = new System.Drawing.Point(29, 89);
            this.lbMaSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(104, 21);
            this.lbMaSanPham.TabIndex = 14;
            this.lbMaSanPham.Text = "Mã sản phẩm";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.BackColor = System.Drawing.Color.White;
            this.lbTenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSanPham.ForeColor = System.Drawing.Color.Black;
            this.lbTenSanPham.Location = new System.Drawing.Point(29, 150);
            this.lbTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(105, 21);
            this.lbTenSanPham.TabIndex = 16;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // bfAddSanPham
            // 
            this.bfAddSanPham.AnimateWindow = true;
            this.bfAddSanPham.AnimationInterval = 250;
            this.bfAddSanPham.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.bfAddSanPham.BorderRadius = 10;
            this.bfAddSanPham.ContainerControl = this;
            this.bfAddSanPham.DockIndicatorTransparencyValue = 0.6D;
            this.bfAddSanPham.TransparentWhileDrag = true;
            // 
            // btnMoHinh
            // 
            this.btnMoHinh.BorderRadius = 5;
            this.btnMoHinh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMoHinh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMoHinh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMoHinh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMoHinh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnMoHinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoHinh.ForeColor = System.Drawing.Color.White;
            this.btnMoHinh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnMoHinh.Image = ((System.Drawing.Image)(resources.GetObject("btnMoHinh.Image")));
            this.btnMoHinh.Location = new System.Drawing.Point(342, 392);
            this.btnMoHinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMoHinh.Name = "btnMoHinh";
            this.btnMoHinh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnMoHinh.Size = new System.Drawing.Size(203, 36);
            this.btnMoHinh.TabIndex = 24;
            this.btnMoHinh.Text = "Mở hình";
            this.btnMoHinh.Click += new System.EventHandler(this.btnMoHinh_Click);
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.BackColor = System.Drawing.Color.White;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.Black;
            this.lbGia.Location = new System.Drawing.Point(29, 214);
            this.lbGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(33, 21);
            this.lbGia.TabIndex = 16;
            this.lbGia.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.Transparent;
            this.txtGia.BorderColor = System.Drawing.Color.Silver;
            this.txtGia.BorderRadius = 5;
            this.txtGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGia.DefaultText = "";
            this.txtGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.ForeColor = System.Drawing.Color.Black;
            this.txtGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtGia.Location = new System.Drawing.Point(34, 240);
            this.txtGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(276, 29);
            this.txtGia.TabIndex = 21;
            // 
            // lbVND
            // 
            this.lbVND.AutoSize = true;
            this.lbVND.BackColor = System.Drawing.Color.White;
            this.lbVND.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVND.ForeColor = System.Drawing.Color.Black;
            this.lbVND.Location = new System.Drawing.Point(262, 184);
            this.lbVND.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbVND.Name = "lbVND";
            this.lbVND.Size = new System.Drawing.Size(39, 19);
            this.lbVND.TabIndex = 16;
            this.lbVND.Text = "VND";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(29, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Loại sản phẩm";
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.gbTrangThai.BorderRadius = 5;
            this.gbTrangThai.Controls.Add(this.rdoCo);
            this.gbTrangThai.Controls.Add(this.rdoKhong);
            this.gbTrangThai.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.gbTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrangThai.ForeColor = System.Drawing.Color.White;
            this.gbTrangThai.Location = new System.Drawing.Point(33, 344);
            this.gbTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Size = new System.Drawing.Size(279, 85);
            this.gbTrangThai.TabIndex = 29;
            this.gbTrangThai.Text = "Trạng thái";
            this.gbTrangThai.Click += new System.EventHandler(this.gbTrangThai_Click);
            // 
            // rdoCo
            // 
            this.rdoCo.AutoSize = true;
            this.rdoCo.BackColor = System.Drawing.Color.White;
            this.rdoCo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCo.ForeColor = System.Drawing.Color.Black;
            this.rdoCo.Location = new System.Drawing.Point(45, 48);
            this.rdoCo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoCo.Name = "rdoCo";
            this.rdoCo.Size = new System.Drawing.Size(79, 23);
            this.rdoCo.TabIndex = 2;
            this.rdoCo.TabStop = true;
            this.rdoCo.Text = "Còn Bán";
            this.rdoCo.UseVisualStyleBackColor = false;
            // 
            // rdoKhong
            // 
            this.rdoKhong.AutoSize = true;
            this.rdoKhong.BackColor = System.Drawing.Color.White;
            this.rdoKhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhong.ForeColor = System.Drawing.Color.Black;
            this.rdoKhong.Location = new System.Drawing.Point(134, 48);
            this.rdoKhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoKhong.Name = "rdoKhong";
            this.rdoKhong.Size = new System.Drawing.Size(96, 23);
            this.rdoKhong.TabIndex = 2;
            this.rdoKhong.TabStop = true;
            this.rdoKhong.Text = "Ngưng bán";
            this.rdoKhong.UseVisualStyleBackColor = false;
            // 
            // messageDialog1
            // 
            this.messageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.messageDialog1.Caption = null;
            this.messageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.messageDialog1.Parent = this;
            this.messageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageDialog1.Text = null;
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
            this.btnThoat.Location = new System.Drawing.Point(33, 545);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(512, 53);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbLoaiSanPham
            // 
            this.cbLoaiSanPham.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiSanPham.BorderColor = System.Drawing.Color.Silver;
            this.cbLoaiSanPham.BorderRadius = 5;
            this.cbLoaiSanPham.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiSanPham.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiSanPham.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiSanPham.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoaiSanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbLoaiSanPham.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiSanPham.ItemHeight = 30;
            this.cbLoaiSanPham.Items.AddRange(new object[] {
            "TEA",
            "CFE",
            "STO",
            "JUC"});
            this.cbLoaiSanPham.Location = new System.Drawing.Point(33, 300);
            this.cbLoaiSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(280, 36);
            this.cbLoaiSanPham.TabIndex = 30;
            this.cbLoaiSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lbHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(574, 66);
            this.panelHeader.TabIndex = 34;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(77, 66);
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
            this.lbHeaderText.Location = new System.Drawing.Point(82, 15);
            this.lbHeaderText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(162, 37);
            this.lbHeaderText.TabIndex = 10;
            this.lbHeaderText.Text = "SẢN PHẨM";
            // 
            // frmAddSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 629);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.gbTrangThai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.picSanPham);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lbMaSanPham);
            this.Controls.Add(this.lbVND);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.btnMoHinh);
            this.Controls.Add(this.txtGia);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAddSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddSanPham";
            this.Load += new System.EventHandler(this.frmAddSanPham_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMaSanPham;
        private System.Windows.Forms.Label lbTenSanPham;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddSanPham;
        private Guna.UI2.WinForms.Guna2Button btnMoHinh;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.Label lbVND;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private System.Windows.Forms.Label label1;
        public Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        public Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        public Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        public Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2GroupBox gbTrangThai;
        public System.Windows.Forms.RadioButton rdoCo;
        public System.Windows.Forms.RadioButton rdoKhong;
        public Guna.UI2.WinForms.Guna2MessageDialog messageDialog1;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        public Guna.UI2.WinForms.Guna2ComboBox cbLoaiSanPham;
        public Guna.UI2.WinForms.Guna2PictureBox picSanPham;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label lbHeaderText;
    }
}