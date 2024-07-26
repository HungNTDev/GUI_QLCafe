namespace GUI_QLCafe.ViewForm
{
    partial class frmViewSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewSanPham));
            this.cbLoaiSanPham = new Guna.UI2.WinForms.Guna2ComboBox();
            this.messageDialog1 = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.rdoCo = new System.Windows.Forms.RadioButton();
            this.rdoKhong = new System.Windows.Forms.RadioButton();
            this.gbTrangThai = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lbGia = new System.Windows.Forms.Label();
            this.txtGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbText0 = new System.Windows.Forms.Label();
            this.bfAddSanPham = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTenSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaSanPham = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.picSanPham = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gbTrangThai.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.SuspendLayout();
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
            this.cbLoaiSanPham.Location = new System.Drawing.Point(44, 368);
            this.cbLoaiSanPham.Name = "cbLoaiSanPham";
            this.cbLoaiSanPham.Size = new System.Drawing.Size(372, 36);
            this.cbLoaiSanPham.TabIndex = 46;
            this.cbLoaiSanPham.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // messageDialog1
            // 
            this.messageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OKCancel;
            this.messageDialog1.Caption = null;
            this.messageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.messageDialog1.Parent = null;
            this.messageDialog1.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageDialog1.Text = null;
            // 
            // rdoCo
            // 
            this.rdoCo.AutoSize = true;
            this.rdoCo.BackColor = System.Drawing.Color.White;
            this.rdoCo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoCo.ForeColor = System.Drawing.Color.Black;
            this.rdoCo.Location = new System.Drawing.Point(15, 59);
            this.rdoCo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoCo.Name = "rdoCo";
            this.rdoCo.Size = new System.Drawing.Size(132, 27);
            this.rdoCo.TabIndex = 2;
            this.rdoCo.TabStop = true;
            this.rdoCo.Text = "Có sản phẩm";
            this.rdoCo.UseVisualStyleBackColor = false;
            // 
            // rdoKhong
            // 
            this.rdoKhong.AutoSize = true;
            this.rdoKhong.BackColor = System.Drawing.Color.White;
            this.rdoKhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoKhong.ForeColor = System.Drawing.Color.Black;
            this.rdoKhong.Location = new System.Drawing.Point(179, 59);
            this.rdoKhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdoKhong.Name = "rdoKhong";
            this.rdoKhong.Size = new System.Drawing.Size(162, 27);
            this.rdoKhong.TabIndex = 2;
            this.rdoKhong.TabStop = true;
            this.rdoKhong.Text = "Sản phẩm đã hết";
            this.rdoKhong.UseVisualStyleBackColor = false;
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
            this.gbTrangThai.Location = new System.Drawing.Point(44, 423);
            this.gbTrangThai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Size = new System.Drawing.Size(372, 105);
            this.gbTrangThai.TabIndex = 45;
            this.gbTrangThai.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(39, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 28);
            this.label1.TabIndex = 44;
            this.label1.Text = "Loại sản phẩm";
            // 
            // messageDialog
            // 
            this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDialog.Caption = null;
            this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageDialog.Parent = null;
            this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageDialog.Text = null;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.BackColor = System.Drawing.Color.White;
            this.lbGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGia.ForeColor = System.Drawing.Color.Black;
            this.lbGia.Location = new System.Drawing.Point(39, 263);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(41, 28);
            this.lbGia.TabIndex = 33;
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
            this.txtGia.Location = new System.Drawing.Point(45, 296);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGia.Name = "txtGia";
            this.txtGia.PasswordChar = '\0';
            this.txtGia.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtGia.PlaceholderText = "";
            this.txtGia.SelectedText = "";
            this.txtGia.Size = new System.Drawing.Size(368, 36);
            this.txtGia.TabIndex = 37;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.panelHeader.Controls.Add(this.guna2PictureBox1);
            this.panelHeader.Controls.Add(this.lbText0);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(765, 81);
            this.panelHeader.TabIndex = 31;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(103, 81);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 47;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lbText0
            // 
            this.lbText0.AutoSize = true;
            this.lbText0.BackColor = System.Drawing.Color.Transparent;
            this.lbText0.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText0.ForeColor = System.Drawing.Color.White;
            this.lbText0.Location = new System.Drawing.Point(179, 20);
            this.lbText0.Name = "lbText0";
            this.lbText0.Size = new System.Drawing.Size(388, 45);
            this.lbText0.TabIndex = 10;
            this.lbText0.Text = "THÔNG TIN SẢN PHẨM";
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
            this.btnThoat.Location = new System.Drawing.Point(45, 560);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(683, 65);
            this.btnThoat.TabIndex = 42;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.txtDuongDan.Location = new System.Drawing.Point(456, 422);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '*';
            this.txtDuongDan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDuongDan.PlaceholderText = "";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(271, 37);
            this.txtDuongDan.TabIndex = 36;
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
            this.txtTenSanPham.Location = new System.Drawing.Point(44, 219);
            this.txtTenSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.PasswordChar = '\0';
            this.txtTenSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenSanPham.PlaceholderText = "";
            this.txtTenSanPham.SelectedText = "";
            this.txtTenSanPham.Size = new System.Drawing.Size(367, 36);
            this.txtTenSanPham.TabIndex = 38;
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
            this.txtMaSanPham.Location = new System.Drawing.Point(44, 143);
            this.txtMaSanPham.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.PasswordChar = '\0';
            this.txtMaSanPham.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaSanPham.PlaceholderText = "";
            this.txtMaSanPham.SelectedText = "";
            this.txtMaSanPham.Size = new System.Drawing.Size(367, 36);
            this.txtMaSanPham.TabIndex = 39;
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.BackColor = System.Drawing.Color.White;
            this.lbMaSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSanPham.ForeColor = System.Drawing.Color.Black;
            this.lbMaSanPham.Location = new System.Drawing.Point(39, 110);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(129, 28);
            this.lbMaSanPham.TabIndex = 32;
            this.lbMaSanPham.Text = "Mã sản phẩm";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.BackColor = System.Drawing.Color.White;
            this.lbTenSanPham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSanPham.ForeColor = System.Drawing.Color.Black;
            this.lbTenSanPham.Location = new System.Drawing.Point(39, 184);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(130, 28);
            this.lbTenSanPham.TabIndex = 34;
            this.lbTenSanPham.Text = "Tên sản phẩm";
            // 
            // picSanPham
            // 
            this.picSanPham.BackColor = System.Drawing.Color.Transparent;
            this.picSanPham.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picSanPham.BackgroundImage")));
            this.picSanPham.FillColor = System.Drawing.Color.Transparent;
            this.picSanPham.Image = ((System.Drawing.Image)(resources.GetObject("picSanPham.Image")));
            this.picSanPham.ImageRotate = 0F;
            this.picSanPham.Location = new System.Drawing.Point(456, 110);
            this.picSanPham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(271, 283);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSanPham.TabIndex = 40;
            this.picSanPham.TabStop = false;
            // 
            // frmViewSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(765, 658);
            this.Controls.Add(this.cbLoaiSanPham);
            this.Controls.Add(this.gbTrangThai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.picSanPham);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtMaSanPham);
            this.Controls.Add(this.lbMaSanPham);
            this.Controls.Add(this.lbTenSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmViewSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmViewSanPham";
            this.Load += new System.EventHandler(this.frmViewSanPham_Load);
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2ComboBox cbLoaiSanPham;
        public Guna.UI2.WinForms.Guna2MessageDialog messageDialog1;
        public System.Windows.Forms.RadioButton rdoCo;
        public System.Windows.Forms.RadioButton rdoKhong;
        private Guna.UI2.WinForms.Guna2GroupBox gbTrangThai;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private System.Windows.Forms.Label lbGia;
        public Guna.UI2.WinForms.Guna2TextBox txtGia;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lbText0;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddSanPham;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        public Guna.UI2.WinForms.Guna2PictureBox picSanPham;
        public Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        public Guna.UI2.WinForms.Guna2TextBox txtTenSanPham;
        public Guna.UI2.WinForms.Guna2TextBox txtMaSanPham;
        private System.Windows.Forms.Label lbMaSanPham;
        private System.Windows.Forms.Label lbTenSanPham;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}