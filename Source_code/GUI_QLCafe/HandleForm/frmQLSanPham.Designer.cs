namespace GUI_QLCafe
{
    partial class frmQLSanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle33 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle34 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle35 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.dgvDanhSachSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXem = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbTotalRows = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.panelFooter.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AllowUserToAddRows = false;
            this.dgvDanhSachSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle33.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle33;
            this.dgvDanhSachSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle34.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle34.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle34.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle34.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle34.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle34.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle34;
            this.dgvDanhSachSanPham.ColumnHeadersHeight = 45;
            this.dgvDanhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaSanPham,
            this.dgvTenSanPham,
            this.dgvGia,
            this.dgvDuongDan,
            this.dgvTrangThai,
            this.dgvMaLoai,
            this.dgvSua,
            this.dgvXem,
            this.dgvXoa});
            dataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle35.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle35.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle35.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle35.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle35;
            this.dgvDanhSachSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(44, 210);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.dgvDanhSachSanPham.RowHeadersVisible = false;
            this.dgvDanhSachSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvDanhSachSanPham.RowTemplate.Height = 35;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(1109, 438);
            this.dgvDanhSachSanPham.TabIndex = 21;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachSanPham.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDanhSachSanPham.ThemeStyle.ReadOnly = true;
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachSanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachSanPham_CellClick);
            this.dgvDanhSachSanPham.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDanhSachSanPham_DataError);
            // 
            // dgvMaSanPham
            // 
            this.dgvMaSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaSanPham.DataPropertyName = "IdProduct";
            this.dgvMaSanPham.HeaderText = "Mã sản phẩm";
            this.dgvMaSanPham.MinimumWidth = 170;
            this.dgvMaSanPham.Name = "dgvMaSanPham";
            this.dgvMaSanPham.ReadOnly = true;
            this.dgvMaSanPham.Width = 170;
            // 
            // dgvTenSanPham
            // 
            this.dgvTenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTenSanPham.DataPropertyName = "NameProduct";
            this.dgvTenSanPham.HeaderText = "Tên sản phẩm";
            this.dgvTenSanPham.MinimumWidth = 200;
            this.dgvTenSanPham.Name = "dgvTenSanPham";
            this.dgvTenSanPham.ReadOnly = true;
            this.dgvTenSanPham.Width = 200;
            // 
            // dgvGia
            // 
            this.dgvGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvGia.DataPropertyName = "Price";
            this.dgvGia.HeaderText = "Giá";
            this.dgvGia.MinimumWidth = 150;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            this.dgvGia.Width = 150;
            // 
            // dgvDuongDan
            // 
            this.dgvDuongDan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvDuongDan.DataPropertyName = "ImageProduct";
            this.dgvDuongDan.HeaderText = "Đường dẫn";
            this.dgvDuongDan.MinimumWidth = 200;
            this.dgvDuongDan.Name = "dgvDuongDan";
            this.dgvDuongDan.ReadOnly = true;
            this.dgvDuongDan.Width = 200;
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTrangThai.DataPropertyName = "StatusProduct";
            this.dgvTrangThai.HeaderText = "Trạng thái";
            this.dgvTrangThai.MinimumWidth = 150;
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.ReadOnly = true;
            this.dgvTrangThai.Width = 150;
            // 
            // dgvMaLoai
            // 
            this.dgvMaLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaLoai.DataPropertyName = "IdPT";
            this.dgvMaLoai.HeaderText = "Mã loại";
            this.dgvMaLoai.MinimumWidth = 100;
            this.dgvMaLoai.Name = "dgvMaLoai";
            this.dgvMaLoai.ReadOnly = true;
            this.dgvMaLoai.Width = 125;
            // 
            // dgvSua
            // 
            this.dgvSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSua.FillWeight = 50F;
            this.dgvSua.HeaderText = "";
            this.dgvSua.Image = ((System.Drawing.Image)(resources.GetObject("dgvSua.Image")));
            this.dgvSua.MinimumWidth = 60;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.Width = 60;
            // 
            // dgvXem
            // 
            this.dgvXem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvXem.HeaderText = "";
            this.dgvXem.Image = ((System.Drawing.Image)(resources.GetObject("dgvXem.Image")));
            this.dgvXem.MinimumWidth = 60;
            this.dgvXem.Name = "dgvXem";
            this.dgvXem.ReadOnly = true;
            this.dgvXem.Width = 60;
            // 
            // dgvXoa
            // 
            this.dgvXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvXoa.FillWeight = 50F;
            this.dgvXoa.HeaderText = "";
            this.dgvXoa.Image = ((System.Drawing.Image)(resources.GetObject("dgvXoa.Image")));
            this.dgvXoa.MinimumWidth = 60;
            this.dgvXoa.Name = "dgvXoa";
            this.dgvXoa.ReadOnly = true;
            this.dgvXoa.Width = 60;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.BorderRadius = 5;
            this.btnTimKiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(997, 123);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnTimKiem.Size = new System.Drawing.Size(156, 40);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.txtTimKiem.BorderColor = System.Drawing.Color.Silver;
            this.txtTimKiem.BorderRadius = 5;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Location = new System.Drawing.Point(517, 123);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập tên sản phẩm để tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(412, 40);
            this.txtTimKiem.TabIndex = 19;
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.AutoSize = true;
            this.lbHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lbHeaderText.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderText.ForeColor = System.Drawing.Color.White;
            this.lbHeaderText.Location = new System.Drawing.Point(375, 10);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(569, 62);
            this.lbHeaderText.TabIndex = 18;
            this.lbHeaderText.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // shapeLine
            // 
            this.shapeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.Location = new System.Drawing.Point(-99, 164);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1389, 49);
            this.shapeLine.TabIndex = 17;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.Zoom = 80;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThem.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThem.ImageRotate = 0F;
            this.btnThem.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.IndicateFocus = true;
            this.btnThem.Location = new System.Drawing.Point(44, 108);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 16;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lbTotalRows
            // 
            this.lbTotalRows.AutoSize = true;
            this.lbTotalRows.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRows.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalRows.Location = new System.Drawing.Point(517, 62);
            this.lbTotalRows.Name = "lbTotalRows";
            this.lbTotalRows.Size = new System.Drawing.Size(171, 31);
            this.lbTotalRows.TabIndex = 23;
            this.lbTotalRows.Text = "Tổng số dòng: ";
            this.lbTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(564, 741);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(33, 38);
            this.lbCurrentPage.TabIndex = 23;
            this.lbCurrentPage.Text = "0";
            // 
            // lbPageLine
            // 
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(589, 741);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(29, 38);
            this.lbPageLine.TabIndex = 23;
            this.lbPageLine.Text = "/";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(609, 741);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(33, 38);
            this.lbTotalPage.TabIndex = 23;
            this.lbTotalPage.Text = "0";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.BorderRadius = 5;
            this.panelFooter.BorderThickness = 1;
            this.panelFooter.Controls.Add(this.btnNext);
            this.panelFooter.Controls.Add(this.btnFirstPage);
            this.panelFooter.Controls.Add(this.btnPrev);
            this.panelFooter.Controls.Add(this.btnLastPage);
            this.panelFooter.Controls.Add(this.lbTotalRows);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 712);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1190, 93);
            this.panelFooter.TabIndex = 25;
            this.panelFooter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFooter_Paint);
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
            this.btnNext.Location = new System.Drawing.Point(652, 18);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 36);
            this.btnNext.TabIndex = 27;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
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
            this.btnFirstPage.Location = new System.Drawing.Point(312, 18);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Size = new System.Drawing.Size(162, 36);
            this.btnFirstPage.TabIndex = 22;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BorderRadius = 5;
            this.btnPrev.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrev.Location = new System.Drawing.Point(480, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(78, 36);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click_1);
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
            this.btnLastPage.Location = new System.Drawing.Point(736, 18);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Size = new System.Drawing.Size(162, 36);
            this.btnLastPage.TabIndex = 22;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Tag";
            this.dataGridViewTextBoxColumn1.HeaderText = "Tag";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 6;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.lblHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1190, 75);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(402, 16);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(486, 54);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "DANH SÁCH SẢN PHẨM";
            // 
            // btnRefesh
            // 
            this.btnRefesh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefesh.BorderRadius = 5;
            this.btnRefesh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefesh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefesh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefesh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.btnRefesh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRefesh.ForeColor = System.Drawing.Color.White;
            this.btnRefesh.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnRefesh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.Image")));
            this.btnRefesh.ImageSize = new System.Drawing.Size(30, 30);
            this.btnRefesh.Location = new System.Drawing.Point(937, 123);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnRefesh.Size = new System.Drawing.Size(54, 40);
            this.btnRefesh.TabIndex = 20;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // frmQLSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 805);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.lbPageLine);
            this.Controls.Add(this.dgvDanhSachSanPham);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.shapeLine);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panelFooter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSanPham";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lbHeaderText;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2ImageButton btnThem;
        private System.Windows.Forms.Label lbTotalRows;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbPageLine;
        private System.Windows.Forms.Label lbTotalPage;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        public Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachSanPham;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLoai;
        private System.Windows.Forms.DataGridViewImageColumn dgvSua;
        private System.Windows.Forms.DataGridViewImageColumn dgvXem;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoa;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
    }
}