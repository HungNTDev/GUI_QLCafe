namespace GUI_QLCafe
{
    partial class frmQLBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLBan));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbDanhSachSanPham = new System.Windows.Forms.Label();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnThem = new Guna.UI2.WinForms.Guna2ImageButton();
            this.dgvMaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvDSBan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dgvMBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSuaBan = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoaBan = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalRows = new System.Windows.Forms.Label();
            this.btnReload = new Guna.UI2.WinForms.Guna2Button();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbtotalRow = new System.Windows.Forms.Label();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(996, 89);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnTimKiem.Size = new System.Drawing.Size(156, 40);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Location = new System.Drawing.Point(582, 89);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập mã bàn để tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(407, 40);
            this.txtTimKiem.TabIndex = 19;
            // 
            // lbDanhSachSanPham
            // 
            this.lbDanhSachSanPham.AutoSize = true;
            this.lbDanhSachSanPham.BackColor = System.Drawing.Color.Transparent;
            this.lbDanhSachSanPham.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachSanPham.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.lbDanhSachSanPham.Location = new System.Drawing.Point(35, 8);
            this.lbDanhSachSanPham.Name = "lbDanhSachSanPham";
            this.lbDanhSachSanPham.Size = new System.Drawing.Size(299, 54);
            this.lbDanhSachSanPham.TabIndex = 18;
            this.lbDanhSachSanPham.Text = "Danh sách bàn";
            // 
            // shapeLine
            // 
            this.shapeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.Location = new System.Drawing.Point(-99, 141);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1389, 27);
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
            this.btnThem.Location = new System.Drawing.Point(44, 74);
            this.btnThem.Name = "btnThem";
            this.btnThem.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThem.Size = new System.Drawing.Size(55, 55);
            this.btnThem.TabIndex = 16;
            this.btnThem.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvMaBan
            // 
            this.dgvMaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMaBan.DataPropertyName = "IdTable";
            this.dgvMaBan.HeaderText = "Mã bàn";
            this.dgvMaBan.MinimumWidth = 400;
            this.dgvMaBan.Name = "dgvMaBan";
            this.dgvMaBan.ReadOnly = true;
            this.dgvMaBan.Width = 400;
            // 
            // dgvTenBan
            // 
            this.dgvTenBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTenBan.DataPropertyName = "NameTable";
            this.dgvTenBan.HeaderText = "Tên bàn";
            this.dgvTenBan.MinimumWidth = 400;
            this.dgvTenBan.Name = "dgvTenBan";
            this.dgvTenBan.ReadOnly = true;
            this.dgvTenBan.Width = 400;
            // 
            // dgvSua
            // 
            this.dgvSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSua.FillWeight = 50F;
            this.dgvSua.HeaderText = "";
            this.dgvSua.Image = ((System.Drawing.Image)(resources.GetObject("dgvSua.Image")));
            this.dgvSua.MinimumWidth = 90;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            this.dgvSua.Width = 90;
            // 
            // dgvXoa
            // 
            this.dgvXoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvXoa.FillWeight = 50F;
            this.dgvXoa.HeaderText = "";
            this.dgvXoa.Image = ((System.Drawing.Image)(resources.GetObject("dgvXoa.Image")));
            this.dgvXoa.MinimumWidth = 90;
            this.dgvXoa.Name = "dgvXoa";
            this.dgvXoa.ReadOnly = true;
            this.dgvXoa.Width = 90;
            // 
            // dgvDSBan
            // 
            this.dgvDSBan.AllowUserToAddRows = false;
            this.dgvDSBan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSBan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSBan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSBan.ColumnHeadersHeight = 45;
            this.dgvDSBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMBan,
            this.dgvTBan,
            this.dgvSuaBan,
            this.dgvXoaBan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSBan.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSBan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBan.Location = new System.Drawing.Point(43, 159);
            this.dgvDSBan.Name = "dgvDSBan";
            this.dgvDSBan.ReadOnly = true;
            this.dgvDSBan.RowHeadersVisible = false;
            this.dgvDSBan.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDSBan.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSBan.RowTemplate.Height = 35;
            this.dgvDSBan.Size = new System.Drawing.Size(1109, 438);
            this.dgvDSBan.TabIndex = 22;
            this.dgvDSBan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSBan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSBan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSBan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSBan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSBan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSBan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.dgvDSBan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSBan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSBan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSBan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSBan.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDSBan.ThemeStyle.ReadOnly = true;
            this.dgvDSBan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSBan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSBan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSBan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSBan.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDSBan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSBan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBan_CellClick);
            this.dgvDSBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBan_CellContentClick);
            // 
            // dgvMBan
            // 
            this.dgvMBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvMBan.DataPropertyName = "IdTable";
            this.dgvMBan.HeaderText = "Mã bàn";
            this.dgvMBan.MinimumWidth = 300;
            this.dgvMBan.Name = "dgvMBan";
            this.dgvMBan.ReadOnly = true;
            this.dgvMBan.Width = 300;
            // 
            // dgvTBan
            // 
            this.dgvTBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvTBan.DataPropertyName = "NameTable";
            this.dgvTBan.HeaderText = "Tên bàn";
            this.dgvTBan.MinimumWidth = 300;
            this.dgvTBan.Name = "dgvTBan";
            this.dgvTBan.ReadOnly = true;
            this.dgvTBan.Width = 300;
            // 
            // dgvSuaBan
            // 
            this.dgvSuaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvSuaBan.FillWeight = 50F;
            this.dgvSuaBan.HeaderText = "";
            this.dgvSuaBan.Image = ((System.Drawing.Image)(resources.GetObject("dgvSuaBan.Image")));
            this.dgvSuaBan.MinimumWidth = 80;
            this.dgvSuaBan.Name = "dgvSuaBan";
            this.dgvSuaBan.ReadOnly = true;
            this.dgvSuaBan.Width = 80;
            // 
            // dgvXoaBan
            // 
            this.dgvXoaBan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvXoaBan.FillWeight = 50F;
            this.dgvXoaBan.HeaderText = "";
            this.dgvXoaBan.Image = ((System.Drawing.Image)(resources.GetObject("dgvXoaBan.Image")));
            this.dgvXoaBan.MinimumWidth = 80;
            this.dgvXoaBan.Name = "dgvXoaBan";
            this.dgvXoaBan.ReadOnly = true;
            this.dgvXoaBan.Width = 80;
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(612, 44);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(27, 31);
            this.lbTotalPage.TabIndex = 26;
            this.lbTotalPage.Text = "0";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(567, 44);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(27, 31);
            this.lbCurrentPage.TabIndex = 27;
            this.lbCurrentPage.Text = "0";
            // 
            // lbPageLine
            // 
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(592, 44);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(24, 31);
            this.lbPageLine.TabIndex = 28;
            this.lbPageLine.Text = "/";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.lbTotalPage);
            this.guna2Panel1.Controls.Add(this.btnLastPage);
            this.guna2Panel1.Controls.Add(this.lbCurrentPage);
            this.guna2Panel1.Controls.Add(this.lbPageLine);
            this.guna2Panel1.Controls.Add(this.lbTotalRows);
            this.guna2Panel1.Controls.Add(this.btnReload);
            this.guna2Panel1.Controls.Add(this.btnFirstPage);
            this.guna2Panel1.Controls.Add(this.lbtotalRow);
            this.guna2Panel1.Controls.Add(this.btnNext);
            this.guna2Panel1.Controls.Add(this.btnPrev);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 640);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1190, 93);
            this.guna2Panel1.TabIndex = 29;
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
            this.btnLastPage.Size = new System.Drawing.Size(151, 36);
            this.btnLastPage.TabIndex = 22;
            this.btnLastPage.Text = "Trang cuối ";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // lbTotalRows
            // 
            this.lbTotalRows.AutoSize = true;
            this.lbTotalRows.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRows.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalRows.Location = new System.Drawing.Point(198, 8);
            this.lbTotalRows.Name = "lbTotalRows";
            this.lbTotalRows.Size = new System.Drawing.Size(30, 31);
            this.lbTotalRows.TabIndex = 23;
            this.lbTotalRows.Text = "+";
            this.lbTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.btnFirstPage.Location = new System.Drawing.Point(321, 39);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Size = new System.Drawing.Size(145, 36);
            this.btnFirstPage.TabIndex = 22;
            this.btnFirstPage.Text = "Trang đầu ";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
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
            this.lbtotalRow.Click += new System.EventHandler(this.lbtotalRow_Click);
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
            // frmQLBan
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 733);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvDSBan);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbDanhSachSanPham);
            this.Controls.Add(this.shapeLine);
            this.Controls.Add(this.btnThem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLBan";
            this.Text = "frmQLBan";
            this.Load += new System.EventHandler(this.frmQLBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBan)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private System.Windows.Forms.Label lbDanhSachSanPham;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2ImageButton btnThem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTenBan;
        private System.Windows.Forms.DataGridViewImageColumn dgvSua;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoa;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDSBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTBan;
        private System.Windows.Forms.DataGridViewImageColumn dgvSuaBan;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoaBan;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private System.Windows.Forms.Label lbPageLine;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private System.Windows.Forms.Label lbTotalRows;
        private Guna.UI2.WinForms.Guna2Button btnReload;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private System.Windows.Forms.Label lbtotalRow;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
    }
}