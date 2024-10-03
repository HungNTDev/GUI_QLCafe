namespace GUI_QLCafe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnTimKiem = new Guna.UI2.WinForms.Guna2Button();
            this.dgvDanhSachNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.cboTim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.cboStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.dgvMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRoleStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvImageStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatusStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSua = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXem = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvXoa = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnThe = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnLamMo = new Guna.UI2.WinForms.Guna2Button();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.btnFirstPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalPage = new System.Windows.Forms.Label();
            this.lbCurrentPage = new System.Windows.Forms.Label();
            this.btnPrev = new Guna.UI2.WinForms.Guna2Button();
            this.lbPageLine = new System.Windows.Forms.Label();
            this.btnLastPage = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotalRows = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
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
            this.shapeLine.Location = new System.Drawing.Point(-97, 173);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(1389, 25);
            this.shapeLine.TabIndex = 1;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.Zoom = 80;
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
            this.txtTimKiem.Location = new System.Drawing.Point(504, 128);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTimKiem.PlaceholderText = "Nhập nội dung tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(249, 36);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnTimKiem.Location = new System.Drawing.Point(822, 128);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnTimKiem.Size = new System.Drawing.Size(156, 36);
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
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            this.dgvDanhSachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDanhSachNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDanhSachNhanVien.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhSachNhanVien.ColumnHeadersHeight = 45;
            this.dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDanhSachNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaNV,
            this.dgvEmail,
            this.dgvFullName,
            this.dgvRoleStaff,
            this.dgvImageStaff,
            this.dgvStatusStaff,
            this.dgvSua,
            this.dgvXem,
            this.dgvXoa});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvDanhSachNhanVien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhSachNhanVien.Location = new System.Drawing.Point(43, 199);
            this.dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            this.dgvDanhSachNhanVien.ReadOnly = true;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhSachNhanVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvDanhSachNhanVien.RowHeadersVisible = false;
            this.dgvDanhSachNhanVien.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhSachNhanVien.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvDanhSachNhanVien.RowTemplate.Height = 24;
            this.dgvDanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvDanhSachNhanVien.Size = new System.Drawing.Size(1109, 593);
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
            // cboTim
            // 
            this.cboTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.cboTim.Location = new System.Drawing.Point(330, 128);
            this.cboTim.Name = "cboTim";
            this.cboTim.Size = new System.Drawing.Size(168, 36);
            this.cboTim.TabIndex = 16;
            this.cboTim.SelectedIndexChanged += new System.EventHandler(this.cboTim_SelectedIndexChanged);
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
            this.cboStatus.Location = new System.Drawing.Point(984, 128);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(168, 36);
            this.cboStatus.TabIndex = 30;
            this.cboStatus.SelectedIndexChanged += new System.EventHandler(this.cboStatus_SelectedIndexChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.SeaGreen;
            this.panelHeader.Controls.Add(this.lblHeaderText);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1190, 85);
            this.panelHeader.TabIndex = 36;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderText.ForeColor = System.Drawing.Color.White;
            this.lblHeaderText.Location = new System.Drawing.Point(387, 19);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(457, 50);
            this.lblHeaderText.TabIndex = 0;
            this.lblHeaderText.Text = "DANH SÁCH NHÂN VIÊN";
            // 
            // dgvMaNV
            // 
            this.dgvMaNV.DataPropertyName = "IdStaff";
            this.dgvMaNV.HeaderText = "Mã nhân viên";
            this.dgvMaNV.MinimumWidth = 6;
            this.dgvMaNV.Name = "dgvMaNV";
            this.dgvMaNV.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvEmail.DataPropertyName = "Email";
            this.dgvEmail.FillWeight = 51.13974F;
            this.dgvEmail.HeaderText = "Email";
            this.dgvEmail.MinimumWidth = 300;
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvFullName
            // 
            this.dgvFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFullName.DataPropertyName = "FullName";
            this.dgvFullName.FillWeight = 116.545F;
            this.dgvFullName.HeaderText = "Tên nhân viên";
            this.dgvFullName.MinimumWidth = 200;
            this.dgvFullName.Name = "dgvFullName";
            this.dgvFullName.ReadOnly = true;
            // 
            // dgvRoleStaff
            // 
            this.dgvRoleStaff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvRoleStaff.DataPropertyName = "RoleStaff";
            this.dgvRoleStaff.FillWeight = 89.62247F;
            this.dgvRoleStaff.HeaderText = "Vai trò";
            this.dgvRoleStaff.MinimumWidth = 100;
            this.dgvRoleStaff.Name = "dgvRoleStaff";
            this.dgvRoleStaff.ReadOnly = true;
            // 
            // dgvImageStaff
            // 
            this.dgvImageStaff.DataPropertyName = "ImageStaff";
            this.dgvImageStaff.HeaderText = "Hình ảnh";
            this.dgvImageStaff.MinimumWidth = 6;
            this.dgvImageStaff.Name = "dgvImageStaff";
            this.dgvImageStaff.ReadOnly = true;
            this.dgvImageStaff.Visible = false;
            // 
            // dgvStatusStaff
            // 
            this.dgvStatusStaff.DataPropertyName = "StatusStaff";
            this.dgvStatusStaff.HeaderText = "Trạng thái";
            this.dgvStatusStaff.MinimumWidth = 6;
            this.dgvStatusStaff.Name = "dgvStatusStaff";
            this.dgvStatusStaff.ReadOnly = true;
            this.dgvStatusStaff.Visible = false;
            // 
            // dgvSua
            // 
            this.dgvSua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvSua.FillWeight = 50F;
            this.dgvSua.HeaderText = "";
            this.dgvSua.Image = ((System.Drawing.Image)(resources.GetObject("dgvSua.Image")));
            this.dgvSua.MinimumWidth = 60;
            this.dgvSua.Name = "dgvSua";
            this.dgvSua.ReadOnly = true;
            // 
            // dgvXem
            // 
            this.dgvXem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvXem.FillWeight = 50F;
            this.dgvXem.HeaderText = "";
            this.dgvXem.Image = ((System.Drawing.Image)(resources.GetObject("dgvXem.Image")));
            this.dgvXem.MinimumWidth = 60;
            this.dgvXem.Name = "dgvXem";
            this.dgvXem.ReadOnly = true;
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
            this.dgvXoa.Visible = false;
            this.dgvXoa.Width = 60;
            // 
            // btnThe
            // 
            this.btnThe.BackColor = System.Drawing.Color.Transparent;
            this.btnThe.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnThe.HoverState.ImageSize = new System.Drawing.Size(57, 57);
            this.btnThe.Image = ((System.Drawing.Image)(resources.GetObject("btnThe.Image")));
            this.btnThe.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnThe.ImageRotate = 0F;
            this.btnThe.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThe.IndicateFocus = true;
            this.btnThe.Location = new System.Drawing.Point(43, 110);
            this.btnThe.Name = "btnThe";
            this.btnThe.PressedState.ImageSize = new System.Drawing.Size(55, 55);
            this.btnThe.Size = new System.Drawing.Size(55, 55);
            this.btnThe.TabIndex = 37;
            this.btnThe.Click += new System.EventHandler(this.btnThe_Click);
            // 
            // btnLamMo
            // 
            this.btnLamMo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMo.BorderRadius = 5;
            this.btnLamMo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLamMo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLamMo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLamMo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.btnLamMo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLamMo.ForeColor = System.Drawing.Color.White;
            this.btnLamMo.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnLamMo.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMo.Image")));
            this.btnLamMo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLamMo.Location = new System.Drawing.Point(760, 128);
            this.btnLamMo.Name = "btnLamMo";
            this.btnLamMo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLamMo.Size = new System.Drawing.Size(54, 36);
            this.btnLamMo.TabIndex = 38;
            this.btnLamMo.Click += new System.EventHandler(this.btnLamMo_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.panelFooter.Location = new System.Drawing.Point(0, 784);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1190, 100);
            this.panelFooter.TabIndex = 39;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lbTotalPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTotalPage.AutoSize = true;
            this.lbTotalPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalPage.Location = new System.Drawing.Point(613, 18);
            this.lbTotalPage.Name = "lbTotalPage";
            this.lbTotalPage.Size = new System.Drawing.Size(29, 35);
            this.lbTotalPage.TabIndex = 23;
            this.lbTotalPage.Text = "0";
            // 
            // lbCurrentPage
            // 
            this.lbCurrentPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbCurrentPage.AutoSize = true;
            this.lbCurrentPage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCurrentPage.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurrentPage.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbCurrentPage.Location = new System.Drawing.Point(568, 18);
            this.lbCurrentPage.Name = "lbCurrentPage";
            this.lbCurrentPage.Size = new System.Drawing.Size(29, 35);
            this.lbCurrentPage.TabIndex = 23;
            this.lbCurrentPage.Text = "0";
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lbPageLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbPageLine.AutoSize = true;
            this.lbPageLine.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPageLine.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPageLine.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbPageLine.Location = new System.Drawing.Point(593, 18);
            this.lbPageLine.Name = "lbPageLine";
            this.lbPageLine.Size = new System.Drawing.Size(25, 35);
            this.lbPageLine.TabIndex = 23;
            this.lbPageLine.Text = "/";
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.lbTotalRows.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbTotalRows.AutoSize = true;
            this.lbTotalRows.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalRows.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbTotalRows.Location = new System.Drawing.Point(517, 62);
            this.lbTotalRows.Name = "lbTotalRows";
            this.lbTotalRows.Size = new System.Drawing.Size(161, 30);
            this.lbTotalRows.TabIndex = 23;
            this.lbTotalRows.Text = "Tổng số dòng: ";
            this.lbTotalRows.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmQLNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 884);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.btnLamMo);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.btnThe);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.cboTim);
            this.Controls.Add(this.dgvDanhSachNhanVien);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.shapeLine);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQLNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQLNhanVien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQLNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhanVien)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private Guna.UI2.WinForms.Guna2Button btnTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachNhanVien;
        public Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2ComboBox cboTim;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private Guna.UI2.WinForms.Guna2ComboBox cboStatus;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRoleStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvImageStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvStatusStaff;
        private System.Windows.Forms.DataGridViewImageColumn dgvSua;
        private System.Windows.Forms.DataGridViewImageColumn dgvXem;
        private System.Windows.Forms.DataGridViewImageColumn dgvXoa;
        private Guna.UI2.WinForms.Guna2ImageButton btnThe;
        private Guna.UI2.WinForms.Guna2Button btnLamMo;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnFirstPage;
        private System.Windows.Forms.Label lbTotalPage;
        private System.Windows.Forms.Label lbCurrentPage;
        private Guna.UI2.WinForms.Guna2Button btnPrev;
        private System.Windows.Forms.Label lbPageLine;
        private Guna.UI2.WinForms.Guna2Button btnLastPage;
        private System.Windows.Forms.Label lbTotalRows;
    }
}