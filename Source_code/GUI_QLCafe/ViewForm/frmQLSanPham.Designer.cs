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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLSanPham));
            this.dgvDanhSachSanPham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.lbtotalRow = new System.Windows.Forms.Label();
            this.lbTotalRows = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.dgvMaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDuongDan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoa = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDanhSachSanPham
            // 
            this.dgvDanhSachSanPham.AllowUserToAddRows = false;
            this.dgvDanhSachSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDanhSachSanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
            this.dgvXoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDanhSachSanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachSanPham.Location = new System.Drawing.Point(44, 170);
            this.dgvDanhSachSanPham.Name = "dgvDanhSachSanPham";
            this.dgvDanhSachSanPham.ReadOnly = true;
            this.dgvDanhSachSanPham.RowHeadersVisible = false;
            this.dgvDanhSachSanPham.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDanhSachSanPham.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDanhSachSanPham.RowTemplate.Height = 35;
            this.dgvDanhSachSanPham.Size = new System.Drawing.Size(1109, 438);
            this.dgvDanhSachSanPham.TabIndex = 21;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhSachSanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachSanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
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
            this.btnTimKiem.Location = new System.Drawing.Point(997, 82);
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
            this.txtTimKiem.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Location = new System.Drawing.Point(502, 82);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập tên sản phẩm để tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(487, 40);
            this.txtTimKiem.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(33, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 62);
            this.label1.TabIndex = 18;
            this.label1.Text = "Danh sách sản phẩm";
            // 
            // shapeLine
            // 
            this.shapeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.Location = new System.Drawing.Point(-99, 123);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1389, 66);
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
            this.btnThem.Location = new System.Drawing.Point(44, 67);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 16;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrev.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderRadius = 5;
            this.btnPrev.BorderThickness = 1;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.FillColor = System.Drawing.Color.Transparent;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.ForeColor = System.Drawing.Color.Black;
            this.btnPrev.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnPrev.Image = ((System.Drawing.Image)(resources.GetObject("btnPrev.Image")));
            this.btnPrev.ImageSize = new System.Drawing.Size(25, 25);
            this.btnPrev.Location = new System.Drawing.Point(472, 39);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.Transparent;
            this.btnPrev.Size = new System.Drawing.Size(78, 36);
            this.btnPrev.TabIndex = 22;
            this.btnPrev.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnNext.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 5;
            this.btnNext.BorderThickness = 1;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnNext.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.btnNext.Location = new System.Drawing.Point(652, 39);
            this.btnNext.Name = "btnNext";
            this.btnNext.PressedColor = System.Drawing.Color.Transparent;
            this.btnNext.Size = new System.Drawing.Size(78, 36);
            this.btnNext.TabIndex = 22;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lbtotalRow
            // 
            this.lbtotalRow.AutoSize = true;
            this.lbtotalRow.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotalRow.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbtotalRow.Location = new System.Drawing.Point(38, 8);
            this.lbtotalRow.Name = "lbtotalRow";
            this.lbtotalRow.Size = new System.Drawing.Size(165, 31);
            this.lbtotalRow.TabIndex = 23;
            this.lbtotalRow.Text = "Tổng số dòng:";
            // 
            // lbTotalRows
            // 
            this.lbTotalRows.AutoSize = true;
            this.lbTotalRows.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRows.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalRows.Location = new System.Drawing.Point(209, 8);
            this.lbTotalRows.Name = "lbTotalRows";
            this.lbTotalRows.Size = new System.Drawing.Size(30, 31);
            this.lbTotalRows.TabIndex = 23;
            this.lbTotalRows.Text = "+";
            this.lbTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(564, 762);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(27, 31);
            this.lbCurrentPage.TabIndex = 23;
            this.lbCurrentPage.Text = "0";
            // 
            // lbPageLine
            // 
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(589, 762);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(24, 31);
            this.lbPageLine.TabIndex = 23;
            this.lbPageLine.Text = "/";
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(609, 762);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(27, 31);
            this.lbTotalPage.TabIndex = 23;
            this.lbTotalPage.Text = "0";
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFirstPage.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.BorderRadius = 5;
            this.btnFirstPage.BorderThickness = 1;
            this.btnFirstPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFirstPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFirstPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFirstPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFirstPage.FillColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnFirstPage.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFirstPage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnFirstPage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnFirstPage.Location = new System.Drawing.Point(341, 39);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Size = new System.Drawing.Size(125, 36);
            this.btnFirstPage.TabIndex = 22;
            this.btnFirstPage.Text = "Trang đầu ";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLastPage.BorderColor = System.Drawing.Color.Transparent;
            this.btnLastPage.BorderRadius = 5;
            this.btnLastPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLastPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLastPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLastPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLastPage.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLastPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnLastPage.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnLastPage.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnLastPage.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnLastPage.ImageSize = new System.Drawing.Size(25, 25);
            this.btnLastPage.Location = new System.Drawing.Point(736, 39);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Size = new System.Drawing.Size(123, 36);
            this.btnLastPage.TabIndex = 22;
            this.btnLastPage.Text = "Trang cuối ";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnLastPage);
            this.guna2Panel1.Controls.Add(this.lbTotalRows);
            this.guna2Panel1.Controls.Add(this.btnReload);
            this.guna2Panel1.Controls.Add(this.btnFirstPage);
            this.guna2Panel1.Controls.Add(this.lbtotalRow);
            this.guna2Panel1.Controls.Add(this.btnNext);
            this.guna2Panel1.Controls.Add(this.btnPrev);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 712);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1190, 93);
            this.guna2Panel1.TabIndex = 25;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReload.BorderColor = System.Drawing.Color.Transparent;
            this.btnReload.BorderRadius = 5;
            this.btnReload.BorderThickness = 1;
            this.btnReload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnReload.ForeColor = System.Drawing.Color.White;
            this.btnReload.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnReload.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.btnReload.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnReload.ImageSize = new System.Drawing.Size(25, 25);
            this.btnReload.Location = new System.Drawing.Point(44, 39);
            this.btnReload.Name = "btnReload";
            this.btnReload.PressedColor = System.Drawing.Color.Transparent;
            this.btnReload.Size = new System.Drawing.Size(138, 36);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.dgvDuongDan.MinimumWidth = 185;
            this.dgvDuongDan.Name = "dgvDuongDan";
            this.dgvDuongDan.ReadOnly = true;
            this.dgvDuongDan.Width = 185;
            // 
            // dgvTrangThai
            // 
            this.dgvTrangThai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTrangThai.DataPropertyName = "StatusProduct";
            this.dgvTrangThai.HeaderText = "Trạng thái";
            this.dgvTrangThai.MinimumWidth = 170;
            this.dgvTrangThai.Name = "dgvTrangThai";
            this.dgvTrangThai.ReadOnly = true;
            this.dgvTrangThai.Width = 170;
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
            this.dgvSua.MinimumWidth = 80;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.Width = 80;
            // 
            // dgvXoa
            // 
            this.dgvXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvXoa.FillWeight = 50F;
            this.dgvXoa.HeaderText = "";
            this.dgvXoa.Image = ((System.Drawing.Image)(resources.GetObject("dgvXoa.Image")));
            this.dgvXoa.MinimumWidth = 80;
            this.dgvXoa.Name = "dgvXoa";
            this.dgvXoa.ReadOnly = true;
            this.dgvXoa.Width = 80;
            // 
            // frmQLSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 805);
            this.Controls.Add(this.lbTotalPage);
            this.Controls.Add(this.lbCurrentPage);
            this.Controls.Add(this.lbPageLine);
            this.Controls.Add(this.dgvDanhSachSanPham);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shapeLine);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLSanPham";
            this.Load += new System.EventHandler(this.frmQLSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachSanPham)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachSanPham;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2ImageButton btnThem;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Label lbtotalRow;
        private System.Windows.Forms.Label lbTotalRows;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbPageLine;
        private System.Windows.Forms.Label lbTotalPage;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDuongDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaLoai;
        private System.Windows.Forms.DataGridViewImageColumn dgvSua;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoa;
    }
}