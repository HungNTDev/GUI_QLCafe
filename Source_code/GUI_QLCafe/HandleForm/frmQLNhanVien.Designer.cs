﻿namespace GUI_QLCafe
{
    partial class frmQLNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLNhanVien));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDanhSachNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IdStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoleStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbTrangThai = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoHoatDong = new System.Windows.Forms.RadioButton();
            this.rdoNgungHoatDong = new System.Windows.Forms.RadioButton();
            this.gbVaiTro = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rdoChuSoHuu = new System.Windows.Forms.RadioButton();
            this.rdoQuanTri = new System.Windows.Forms.RadioButton();
            this.rdoNhanVien = new System.Windows.Forms.RadioButton();
            this.picNhanVien = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtDuongDan = new Guna.UI2.WinForms.Guna2TextBox();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnThe = new Guna.UI2.WinForms.Guna2Button();
            this.btnSu = new Guna.UI2.WinForms.Guna2Button();
            this.btnLamMo = new Guna.UI2.WinForms.Guna2Button();
            this.btnMoHinh = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.gbTrangThai.SuspendLayout();
            this.gbVaiTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shapeLine
            // 
            this.shapeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.shapeLine.Location = new System.Drawing.Point(-129, 382);
            this.shapeLine.Margin = new System.Windows.Forms.Padding(4);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1852, 33);
            this.shapeLine.TabIndex = 1;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.Zoom = 80;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Silver;
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Location = new System.Drawing.Point(795, 422);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(245, 44);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(1049, 422);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnTimKiem.Size = new System.Drawing.Size(208, 44);
            this.btnTimKiem.TabIndex = 14;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvDanhSachNhanVien
            // 
            this.dgvDanhSachNhanVien.AllowUserToAddRows = false;
            this.dgvDanhSachNhanVien.AllowUserToDeleteRows = false;
            this.dgvDanhSachNhanVien.AllowUserToResizeColumns = false;
            this.dgvDanhSachNhanVien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDanhSachNhanVien.ColumnHeadersHeight = 45;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdStaff,
            this.Email,
            this.FullName,
            this.RoleStaff,
            this.ImageStaff,
            this.StatusStaff});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(57, 474);
            this.dgvDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachNhanVien.RowHeadersVisible = false;
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 24;
            this.dgvDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(1479, 501);
            this.dgvDanhSachNhanVien.TabIndex = 15;
            this.dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachNhanVien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDanhSachNhanVien.ThemeStyle.ReadOnly = true;
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachNhanVien_CellClick);
            // 
            // IdStaff
            // 
            this.IdStaff.DataPropertyName = "IdStaff";
            this.IdStaff.HeaderText = "Mã nhân viên";
            this.IdStaff.MinimumWidth = 6;
            this.IdStaff.Name = "IdStaff";
            this.IdStaff.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.FillWeight = 51.13974F;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 300;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FullName.DataPropertyName = "FullName";
            this.FullName.FillWeight = 116.545F;
            this.FullName.HeaderText = "Tên nhân viên";
            this.FullName.MinimumWidth = 200;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // RoleStaff
            // 
            this.RoleStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RoleStaff.DataPropertyName = "RoleStaff";
            this.RoleStaff.FillWeight = 89.62247F;
            this.RoleStaff.HeaderText = "Vai trò";
            this.RoleStaff.MinimumWidth = 100;
            this.RoleStaff.Name = "RoleStaff";
            this.RoleStaff.ReadOnly = true;
            // 
            // ImageStaff
            // 
            this.ImageStaff.DataPropertyName = "ImageStaff";
            this.ImageStaff.HeaderText = "Hình ảnh";
            this.ImageStaff.MinimumWidth = 6;
            this.ImageStaff.Name = "ImageStaff";
            this.ImageStaff.ReadOnly = true;
            this.ImageStaff.Visible = false;
            // 
            // StatusStaff
            // 
            this.StatusStaff.DataPropertyName = "StatusStaff";
            this.StatusStaff.HeaderText = "Trạng thái";
            this.StatusStaff.MinimumWidth = 6;
            this.StatusStaff.Name = "StatusStaff";
            this.StatusStaff.ReadOnly = true;
            this.StatusStaff.Visible = false;
            // 
            // cboTim
            // 
            this.cboTim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTim.AutoRoundedCorners = true;
            this.cboTim.BackColor = System.Drawing.Color.Transparent;
            this.cboTim.BorderRadius = 17;
            this.cboTim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboTim.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboTim.ItemHeight = 30;
            this.cboTim.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Email",
            "Tên nhân viên",
            "Vai trò"});
            this.cboTim.Location = new System.Drawing.Point(563, 423);
            this.cboTim.Margin = new System.Windows.Forms.Padding(4);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(223, 36);
            this.cboTim.TabIndex = 16;
            this.cboTim.SelectedIndexChanged += new System.EventHandler(this.cboTim_SelectedIndexChanged);
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
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(361, 171);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(343, 39);
            this.txtEmail.TabIndex = 0;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.lblEmail.Location = new System.Drawing.Point(87, 171);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(87, 37);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.BackColor = System.Drawing.Color.Transparent;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 15.70909F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.lblTen.Location = new System.Drawing.Point(87, 335);
            this.lblTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(193, 37);
            this.lblTen.TabIndex = 22;
            this.lblTen.Text = "Tên nhân viên";
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.Transparent;
            this.txtTen.BorderColor = System.Drawing.Color.Silver;
            this.txtTen.BorderRadius = 5;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.DefaultText = "";
            this.txtTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTen.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtTen.ForeColor = System.Drawing.Color.Black;
            this.txtTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTen.Location = new System.Drawing.Point(361, 335);
            this.txtTen.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.PasswordChar = '\0';
            this.txtTen.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTen.PlaceholderText = "";
            this.txtTen.SelectedText = "";
            this.txtTen.Size = new System.Drawing.Size(343, 39);
            this.txtTen.TabIndex = 1;
            // 
            // gbTrangThai
            // 
            this.gbTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTrangThai.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.gbTrangThai.BorderRadius = 5;
            this.gbTrangThai.Controls.Add(this.rdoHoatDong);
            this.gbTrangThai.Controls.Add(this.rdoNgungHoatDong);
            this.gbTrangThai.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.gbTrangThai.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTrangThai.ForeColor = System.Drawing.Color.White;
            this.gbTrangThai.Location = new System.Drawing.Point(989, 171);
            this.gbTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.gbTrangThai.Name = "gbTrangThai";
            this.gbTrangThai.Size = new System.Drawing.Size(268, 154);
            this.gbTrangThai.TabIndex = 25;
            this.gbTrangThai.Text = "Trạng thái";
            // 
            // rdoHoatDong
            // 
            this.rdoHoatDong.AutoSize = true;
            this.rdoHoatDong.BackColor = System.Drawing.Color.White;
            this.rdoHoatDong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoHoatDong.ForeColor = System.Drawing.Color.Black;
            this.rdoHoatDong.Location = new System.Drawing.Point(11, 58);
            this.rdoHoatDong.Margin = new System.Windows.Forms.Padding(4);
            this.rdoHoatDong.Name = "rdoHoatDong";
            this.rdoHoatDong.Size = new System.Drawing.Size(113, 27);
            this.rdoHoatDong.TabIndex = 5;
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
            this.rdoNgungHoatDong.Location = new System.Drawing.Point(11, 105);
            this.rdoNgungHoatDong.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNgungHoatDong.Name = "rdoNgungHoatDong";
            this.rdoNgungHoatDong.Size = new System.Drawing.Size(169, 27);
            this.rdoNgungHoatDong.TabIndex = 6;
            this.rdoNgungHoatDong.TabStop = true;
            this.rdoNgungHoatDong.Text = "Ngừng hoạt động";
            this.rdoNgungHoatDong.UseVisualStyleBackColor = false;
            // 
            // gbVaiTro
            // 
            this.gbVaiTro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbVaiTro.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.gbVaiTro.BorderRadius = 5;
            this.gbVaiTro.Controls.Add(this.rdoChuSoHuu);
            this.gbVaiTro.Controls.Add(this.rdoQuanTri);
            this.gbVaiTro.Controls.Add(this.rdoNhanVien);
            this.gbVaiTro.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.gbVaiTro.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbVaiTro.ForeColor = System.Drawing.Color.White;
            this.gbVaiTro.Location = new System.Drawing.Point(713, 170);
            this.gbVaiTro.Margin = new System.Windows.Forms.Padding(4);
            this.gbVaiTro.Name = "gbVaiTro";
            this.gbVaiTro.Size = new System.Drawing.Size(268, 204);
            this.gbVaiTro.TabIndex = 26;
            this.gbVaiTro.Text = "Vai trò";
            // 
            // rdoChuSoHuu
            // 
            this.rdoChuSoHuu.AutoSize = true;
            this.rdoChuSoHuu.BackColor = System.Drawing.Color.White;
            this.rdoChuSoHuu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoChuSoHuu.ForeColor = System.Drawing.Color.Black;
            this.rdoChuSoHuu.Location = new System.Drawing.Point(11, 59);
            this.rdoChuSoHuu.Margin = new System.Windows.Forms.Padding(4);
            this.rdoChuSoHuu.Name = "rdoChuSoHuu";
            this.rdoChuSoHuu.Size = new System.Drawing.Size(119, 27);
            this.rdoChuSoHuu.TabIndex = 5;
            this.rdoChuSoHuu.TabStop = true;
            this.rdoChuSoHuu.Text = "Chủ sở hữu";
            this.rdoChuSoHuu.UseVisualStyleBackColor = false;
            // 
            // rdoQuanTri
            // 
            this.rdoQuanTri.AutoSize = true;
            this.rdoQuanTri.BackColor = System.Drawing.Color.White;
            this.rdoQuanTri.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoQuanTri.ForeColor = System.Drawing.Color.Black;
            this.rdoQuanTri.Location = new System.Drawing.Point(11, 108);
            this.rdoQuanTri.Margin = new System.Windows.Forms.Padding(4);
            this.rdoQuanTri.Name = "rdoQuanTri";
            this.rdoQuanTri.Size = new System.Drawing.Size(94, 27);
            this.rdoQuanTri.TabIndex = 3;
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
            this.rdoNhanVien.Location = new System.Drawing.Point(11, 161);
            this.rdoNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.rdoNhanVien.Name = "rdoNhanVien";
            this.rdoNhanVien.Size = new System.Drawing.Size(109, 27);
            this.rdoNhanVien.TabIndex = 4;
            this.rdoNhanVien.TabStop = true;
            this.rdoNhanVien.Text = "Nhân viên";
            this.rdoNhanVien.UseVisualStyleBackColor = false;
            // 
            // picNhanVien
            // 
            this.picNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNhanVien.BorderRadius = 5;
            this.picNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNhanVien.FillColor = System.Drawing.Color.Transparent;
            this.picNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("picNhanVien.Image")));
            this.picNhanVien.ImageRotate = 0F;
            this.picNhanVien.Location = new System.Drawing.Point(1265, 112);
            this.picNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(230, 262);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 28;
            this.picNhanVien.TabStop = false;
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtDuongDan.Location = new System.Drawing.Point(1000, 114);
            this.txtDuongDan.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.PasswordChar = '*';
            this.txtDuongDan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtDuongDan.PlaceholderText = "";
            this.txtDuongDan.ReadOnly = true;
            this.txtDuongDan.SelectedText = "";
            this.txtDuongDan.Size = new System.Drawing.Size(231, 41);
            this.txtDuongDan.TabIndex = 27;
            this.txtDuongDan.Visible = false;
            // 
            // messageDialog
            // 
            this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDialog.Caption = null;
            this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.messageDialog.Parent = null;
            this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.messageDialog.Text = null;
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboStatus.BackColor = System.Drawing.Color.Transparent;
            this.cboStatus.BorderRadius = 5;
            this.cboStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboStatus.ItemHeight = 30;
            this.cboStatus.Location = new System.Drawing.Point(1280, 422);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(255, 36);
            this.cboStatus.TabIndex = 30;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // btnThe
            // 
            this.btnThe.BorderRadius = 5;
            this.btnThe.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThe.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThe.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnThe.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThe.ForeColor = System.Drawing.Color.White;
            this.btnThe.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnThe.Location = new System.Drawing.Point(59, 411);
            this.btnThe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThe.Name = "btnThe";
            this.btnThe.Size = new System.Drawing.Size(149, 55);
            this.btnThe.TabIndex = 31;
            this.btnThe.Text = "Thêm";
            this.btnThe.Click += new System.EventHandler(this.btnThe_Click);
            // 
            // btnSu
            // 
            this.btnSu.BorderRadius = 5;
            this.btnSu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSu.Enabled = false;
            this.btnSu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnSu.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSu.ForeColor = System.Drawing.Color.White;
            this.btnSu.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnSu.Location = new System.Drawing.Point(216, 411);
            this.btnSu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSu.Name = "btnSu";
            this.btnSu.Size = new System.Drawing.Size(149, 55);
            this.btnSu.TabIndex = 32;
            this.btnSu.Text = "Sửa";
            this.btnSu.Click += new System.EventHandler(this.btnSu_Click);
            // 
            // btnLamMo
            // 
            this.btnLamMo.BorderRadius = 5;
            this.btnLamMo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnLamMo.Font = new System.Drawing.Font("Segoe UI", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMo.ForeColor = System.Drawing.Color.White;
            this.btnLamMo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
            this.btnLamMo.Location = new System.Drawing.Point(373, 411);
            this.btnLamMo.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMo.Name = "btnLamMo";
            this.btnLamMo.Size = new System.Drawing.Size(149, 55);
            this.btnLamMo.TabIndex = 33;
            this.btnLamMo.Text = "Làm mới";
            this.btnLamMo.Click += new System.EventHandler(this.btnLamMo_Click);
            // 
            // btnMoHinh
            // 
            this.btnMoHinh.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.btnMoHinh.Location = new System.Drawing.Point(989, 331);
            this.btnMoHinh.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoHinh.Name = "btnMoHinh";
            this.btnMoHinh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnMoHinh.Size = new System.Drawing.Size(268, 43);
            this.btnMoHinh.TabIndex = 35;
            this.btnMoHinh.Text = "Mở hình";
            this.btnMoHinh.Click += new System.EventHandler(this.btnMoHinh_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.lblHeaderText);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1587, 105);
            this.panelHeader.TabIndex = 36;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(516, 23);
            this.lblHeaderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(498, 54);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Controls.Add(this.lbTotal);
            this.guna2Panel1.Controls.Add(this.btnNext);
            this.guna2Panel1.Controls.Add(this.btnFirstPage);
            this.guna2Panel1.Controls.Add(this.lbTotalPage);
            this.guna2Panel1.Controls.Add(this.lbCurrentPage);
            this.guna2Panel1.Controls.Add(this.btnPrev);
            this.guna2Panel1.Controls.Add(this.lbPageLine);
            this.guna2Panel1.Controls.Add(this.btnLastPage);
            this.guna2Panel1.Controls.Add(this.lbTotalRows);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 998);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1587, 91);
            this.guna2Panel1.TabIndex = 34;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotal.Location = new System.Drawing.Point(672, 50);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(171, 31);
            this.lbTotal.TabIndex = 37;
            this.lbTotal.Text = "Tổng số dòng: ";
            this.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNext
            // 
            this.btnNext.BorderRadius = 5;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(838, 8);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 36);
            this.btnNext.TabIndex = 35;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BorderRadius = 5;
            this.btnFirstPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFirstPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFirstPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFirstPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFirstPage.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFirstPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFirstPage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFirstPage.Location = new System.Drawing.Point(502, 8);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Size = new System.Drawing.Size(162, 36);
            this.btnFirstPage.TabIndex = 29;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(799, 8);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(33, 38);
            this.lbTotalPage.TabIndex = 31;
            this.lbTotalPage.Text = "0";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(754, 8);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(33, 38);
            this.lbCurrentPage.TabIndex = 32;
            this.lbCurrentPage.Text = "0";
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 5;
            this.btnPrev.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrev.Location = new System.Drawing.Point(670, 8);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.White;
            this.btnPrev.Size = new System.Drawing.Size(78, 36);
            this.btnPrev.TabIndex = 36;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lbPageLine
            // 
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(779, 8);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(29, 38);
            this.lbPageLine.TabIndex = 33;
            this.lbPageLine.Text = "/";
            // 
            // btnLastPage
            // 
            this.btnLastPage.BorderRadius = 5;
            this.btnLastPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLastPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLastPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLastPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLastPage.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.Location = new System.Drawing.Point(922, 8);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Size = new System.Drawing.Size(162, 36);
            this.btnLastPage.TabIndex = 30;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // lbTotalRows
            // 
            this.lbTotalRows.AutoSize = true;
            this.lbTotalRows.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRows.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalRows.Location = new System.Drawing.Point(849, 50);
            this.lbTotalRows.Name = "lbTotalRows";
            this.lbTotalRows.Size = new System.Drawing.Size(30, 31);
            this.lbTotalRows.TabIndex = 34;
            this.lbTotalRows.Text = "+";
            this.lbTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1587, 1088);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnMoHinh);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnLamMo);
            this.Controls.Add(this.btnSu);
            this.Controls.Add(this.btnThe);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.txtDuongDan);
            this.Controls.Add(this.gbTrangThai);
            this.Controls.Add(this.gbVaiTro);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.cboTim);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.shapeLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.gbTrangThai.ResumeLayout(false);
            this.gbTrangThai.PerformLayout();
            this.gbVaiTro.ResumeLayout(false);
            this.gbVaiTro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachNhanVien;
        public Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboTim;
        public Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTen;
        public Guna.UI2.WinForms.Guna2TextBox txtTen;
        private Guna.UI2.WinForms.Guna2GroupBox gbTrangThai;
        private System.Windows.Forms.RadioButton rdoHoatDong;
        private System.Windows.Forms.RadioButton rdoNgungHoatDong;
        private Guna.UI2.WinForms.Guna2GroupBox gbVaiTro;
        private System.Windows.Forms.RadioButton rdoQuanTri;
        private System.Windows.Forms.RadioButton rdoNhanVien;
        private Guna.UI2.WinForms.Guna2PictureBox picNhanVien;
        private Guna.UI2.WinForms.Guna2TextBox txtDuongDan;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoleStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusStaff;
        private Guna.UI2.WinForms.Guna2Button btnThe;
        private Guna.UI2.WinForms.Guna2Button btnSu;
        private Guna.UI2.WinForms.Guna2Button btnLamMo;
        private Guna.UI2.WinForms.Guna2Button btnMoHinh;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.RadioButton rdoChuSoHuu;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Label lbPageLine;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private System.Windows.Forms.Label lbTotalRows;
        private System.Windows.Forms.Label lbTotal;
    }
}