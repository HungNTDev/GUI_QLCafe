namespace GUI_QLCafe
{
    partial class frmQLHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQLHoaDon));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalRows = new System.Windows.Forms.Label();
            this.dgvDSHD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnRefesh = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.panelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            this.panelHeader.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(1350, 111);
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
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.Black;
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTimKiem.Location = new System.Drawing.Point(871, 111);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập mã hóa đơn để tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(412, 40);
            this.txtTimKiem.TabIndex = 19;
            // 
            // shapeLine
            // 
            this.shapeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.Location = new System.Drawing.Point(-134, 157);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1813, 43);
            this.shapeLine.TabIndex = 17;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.Zoom = 80;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.BorderRadius = 5;
            this.panelFooter.BorderThickness = 1;
            this.panelFooter.Controls.Add(this.btnNext);
            this.panelFooter.Controls.Add(this.btnFirstPage);
            this.panelFooter.Controls.Add(this.lbTotalPage);
            this.panelFooter.Controls.Add(this.lbCurrentPage);
            this.panelFooter.Controls.Add(this.btnPrev);
            this.panelFooter.Controls.Add(this.lbPageLine);
            this.panelFooter.Controls.Add(this.btnLastPage);
            this.panelFooter.Controls.Add(this.lbTotalRows);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 799);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1537, 93);
            this.panelFooter.TabIndex = 26;
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
            this.btnFirstPage.Location = new System.Drawing.Point(316, 18);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnFirstPage.Size = new System.Drawing.Size(162, 36);
            this.btnFirstPage.TabIndex = 22;
            this.btnFirstPage.Text = "Trang đầu";
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // lbTotalPage
            // 
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(613, 18);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(33, 38);
            this.lbTotalPage.TabIndex = 23;
            this.lbTotalPage.Text = "0";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(568, 18);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(33, 38);
            this.lbCurrentPage.TabIndex = 23;
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
            this.btnPrev.Location = new System.Drawing.Point(484, 18);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.PressedColor = System.Drawing.Color.White;
            this.btnPrev.Size = new System.Drawing.Size(78, 36);
            this.btnPrev.TabIndex = 28;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // lbPageLine
            // 
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(593, 18);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(29, 38);
            this.lbPageLine.TabIndex = 23;
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
            this.btnLastPage.Location = new System.Drawing.Point(736, 18);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.PressedColor = System.Drawing.Color.Transparent;
            this.btnLastPage.Size = new System.Drawing.Size(162, 36);
            this.btnLastPage.TabIndex = 22;
            this.btnLastPage.Text = "Trang cuối";
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
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
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.AllowUserToDeleteRows = false;
            this.dgvDSHD.AllowUserToResizeColumns = false;
            this.dgvDSHD.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSHD.ColumnHeadersHeight = 45;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSHD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDSHD.Location = new System.Drawing.Point(37, 206);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersVisible = false;
            this.dgvDSHD.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dgvDSHD.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSHD.RowTemplate.Height = 35;
            this.dgvDSHD.Size = new System.Drawing.Size(1456, 556);
            this.dgvDSHD.TabIndex = 27;
            this.dgvDSHD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSHD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSHD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSHD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSHD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSHD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSHD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDSHD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.dgvDSHD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSHD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSHD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSHD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSHD.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvDSHD.ThemeStyle.ReadOnly = true;
            this.dgvDSHD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSHD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSHD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSHD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDSHD.ThemeStyle.RowsStyle.Height = 35;
            this.dgvDSHD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSHD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnRefesh.Location = new System.Drawing.Point(1290, 111);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnRefesh.Size = new System.Drawing.Size(54, 40);
            this.btnRefesh.TabIndex = 33;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click_1);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.Controls.Add(this.lblHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1537, 85);
            this.panelHeader.TabIndex = 34;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(570, 19);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(463, 54);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "DANH SÁCH HÓA ĐƠN";
            // 
            // frmQLHoaDon
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1537, 892);
            this.Controls.Add(this.dgvDSHD);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRefesh);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.shapeLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLHoaDon";
            this.Load += new System.EventHandler(this.frmQLHoaDon_Load_1);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        public Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Label lbPageLine;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private System.Windows.Forms.Label lbTotalRows;
        public Guna.UI2.WinForms.Guna2DataGridView dgvDSHD;
        private Guna.UI2.WinForms.Guna2Button btnRefesh;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderText;
    }
}