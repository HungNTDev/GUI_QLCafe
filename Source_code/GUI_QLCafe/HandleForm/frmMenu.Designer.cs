namespace GUI_QLCafe
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbText0 = new System.Windows.Forms.Label();
            this.paneText = new Guna.UI2.WinForms.Guna2Panel();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.lbNameTable = new System.Windows.Forms.Label();
            this.panelAside = new Guna.UI2.WinForms.Guna2Panel();
            this.ListOrder_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.tc_Menu = new Guna.UI2.WinForms.Guna2TabControl();
            this.CFE = new System.Windows.Forms.TabPage();
            this.flp_CaPhe = new System.Windows.Forms.FlowLayoutPanel();
            this.TEA = new System.Windows.Forms.TabPage();
            this.flp_Tra = new System.Windows.Forms.FlowLayoutPanel();
            this.STO = new System.Windows.Forms.TabPage();
            this.flp_SinhTo = new System.Windows.Forms.FlowLayoutPanel();
            this.JUC = new System.Windows.Forms.TabPage();
            this.flp_NuocEp = new System.Windows.Forms.FlowLayoutPanel();
            this.paneText.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelAside.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tc_Menu.SuspendLayout();
            this.CFE.SuspendLayout();
            this.TEA.SuspendLayout();
            this.STO.SuspendLayout();
            this.JUC.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbText0
            // 
            this.lbText0.AutoSize = true;
            this.lbText0.BackColor = System.Drawing.Color.Transparent;
            this.lbText0.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText0.ForeColor = System.Drawing.Color.White;
            this.lbText0.Location = new System.Drawing.Point(61, 9);
            this.lbText0.Name = "lbText0";
            this.lbText0.Size = new System.Drawing.Size(1073, 100);
            this.lbText0.TabIndex = 11;
            this.lbText0.Text = "SPECIAL MENU FOR YOU - FRESHLY BREWED, JUST FOR YOU\r\n\r\n";
            // 
            // paneText
            // 
            this.paneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.paneText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.paneText.BorderThickness = 2;
            this.paneText.Controls.Add(this.cbClose);
            this.paneText.Controls.Add(this.lbText0);
            this.paneText.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneText.Location = new System.Drawing.Point(0, 0);
            this.paneText.Name = "paneText";
            this.paneText.Size = new System.Drawing.Size(1383, 58);
            this.paneText.TabIndex = 10;
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.BorderRadius = 5;
            this.cbClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.cbClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClose.HoverState.FillColor = System.Drawing.Color.Red;
            this.cbClose.IconColor = System.Drawing.Color.White;
            this.cbClose.Location = new System.Drawing.Point(1288, 8);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(88, 39);
            this.cbClose.TabIndex = 13;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelFooter.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.BorderThickness = 2;
            this.panelFooter.Controls.Add(this.btnDel);
            this.panelFooter.Controls.Add(this.btnAdd);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 670);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(496, 87);
            this.panelFooter.TabIndex = 3;
            // 
            // btnDel
            // 
            this.btnDel.BorderColor = System.Drawing.Color.White;
            this.btnDel.BorderRadius = 10;
            this.btnDel.BorderThickness = 1;
            this.btnDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnDel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnDel.HoverState.FillColor = System.Drawing.Color.White;
            this.btnDel.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnDel.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.Location = new System.Drawing.Point(255, 27);
            this.btnDel.Name = "btnDel";
            this.btnDel.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnDel.Size = new System.Drawing.Size(220, 48);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa món";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.White;
            this.btnAdd.BorderRadius = 10;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnAdd.HoverState.FillColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnAdd.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(22, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnAdd.Size = new System.Drawing.Size(220, 48);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm món";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbNameTable
            // 
            this.lbNameTable.AutoSize = true;
            this.lbNameTable.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameTable.ForeColor = System.Drawing.Color.White;
            this.lbNameTable.Location = new System.Drawing.Point(6, 12);
            this.lbNameTable.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbNameTable.Name = "lbNameTable";
            this.lbNameTable.Size = new System.Drawing.Size(168, 50);
            this.lbNameTable.TabIndex = 0;
            this.lbNameTable.Text = "Tên bàn:";
            // 
            // panelAside
            // 
            this.panelAside.Controls.Add(this.ListOrder_dgv);
            this.panelAside.Controls.Add(this.panelHeader);
            this.panelAside.Controls.Add(this.panelFooter);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAside.Location = new System.Drawing.Point(887, 58);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(496, 757);
            this.panelAside.TabIndex = 11;
            // 
            // ListOrder_dgv
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ListOrder_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListOrder_dgv.ColumnHeadersHeight = 40;
            this.ListOrder_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOrder_dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListOrder_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOrder_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOrder_dgv.Location = new System.Drawing.Point(0, 66);
            this.ListOrder_dgv.Name = "ListOrder_dgv";
            this.ListOrder_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListOrder_dgv.RowHeadersVisible = false;
            this.ListOrder_dgv.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.ListOrder_dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ListOrder_dgv.RowTemplate.Height = 40;
            this.ListOrder_dgv.Size = new System.Drawing.Size(496, 604);
            this.ListOrder_dgv.TabIndex = 4;
            this.ListOrder_dgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ListOrder_dgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ListOrder_dgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ListOrder_dgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ListOrder_dgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ListOrder_dgv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ListOrder_dgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ListOrder_dgv.ThemeStyle.HeaderStyle.Height = 40;
            this.ListOrder_dgv.ThemeStyle.ReadOnly = false;
            this.ListOrder_dgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListOrder_dgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListOrder_dgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListOrder_dgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ListOrder_dgv.ThemeStyle.RowsStyle.Height = 40;
            this.ListOrder_dgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOrder_dgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.lbNameTable);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(496, 66);
            this.panelHeader.TabIndex = 2;
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.BorderThickness = 2;
            this.panelBody.Controls.Add(this.tc_Menu);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 58);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(887, 757);
            this.panelBody.TabIndex = 12;
            // 
            // tc_Menu
            // 
            this.tc_Menu.Controls.Add(this.CFE);
            this.tc_Menu.Controls.Add(this.TEA);
            this.tc_Menu.Controls.Add(this.STO);
            this.tc_Menu.Controls.Add(this.JUC);
            this.tc_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_Menu.ItemSize = new System.Drawing.Size(180, 40);
            this.tc_Menu.Location = new System.Drawing.Point(0, 0);
            this.tc_Menu.Name = "tc_Menu";
            this.tc_Menu.SelectedIndex = 0;
            this.tc_Menu.Size = new System.Drawing.Size(887, 757);
            this.tc_Menu.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.tc_Menu.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.tc_Menu.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc_Menu.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.tc_Menu.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.tc_Menu.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.tc_Menu.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tc_Menu.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.tc_Menu.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.tc_Menu.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tc_Menu.TabButtonSelectedState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.tc_Menu.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(85)))), ((int)(((byte)(126)))));
            this.tc_Menu.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tc_Menu.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.tc_Menu.TabButtonSelectedState.InnerColor = System.Drawing.Color.Transparent;
            this.tc_Menu.TabButtonSize = new System.Drawing.Size(180, 40);
            this.tc_Menu.TabIndex = 0;
            this.tc_Menu.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tc_Menu.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.tc_Menu.Click += new System.EventHandler(this.tc_Menu_Click);
            // 
            // CFE
            // 
            this.CFE.BackColor = System.Drawing.SystemColors.Control;
            this.CFE.Controls.Add(this.flp_CaPhe);
            this.CFE.Location = new System.Drawing.Point(4, 44);
            this.CFE.Name = "CFE";
            this.CFE.Padding = new System.Windows.Forms.Padding(3);
            this.CFE.Size = new System.Drawing.Size(879, 709);
            this.CFE.TabIndex = 0;
            this.CFE.Text = "CÀ PHÊ";
            // 
            // flp_CaPhe
            // 
            this.flp_CaPhe.BackColor = System.Drawing.Color.White;
            this.flp_CaPhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_CaPhe.Location = new System.Drawing.Point(3, 3);
            this.flp_CaPhe.Name = "flp_CaPhe";
            this.flp_CaPhe.Size = new System.Drawing.Size(873, 703);
            this.flp_CaPhe.TabIndex = 1;
            // 
            // TEA
            // 
            this.TEA.BackColor = System.Drawing.SystemColors.Control;
            this.TEA.Controls.Add(this.flp_Tra);
            this.TEA.Location = new System.Drawing.Point(4, 44);
            this.TEA.Name = "TEA";
            this.TEA.Padding = new System.Windows.Forms.Padding(3);
            this.TEA.Size = new System.Drawing.Size(879, 709);
            this.TEA.TabIndex = 1;
            this.TEA.Text = "TRÀ";
            // 
            // flp_Tra
            // 
            this.flp_Tra.BackColor = System.Drawing.Color.White;
            this.flp_Tra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Tra.Location = new System.Drawing.Point(3, 3);
            this.flp_Tra.Name = "flp_Tra";
            this.flp_Tra.Size = new System.Drawing.Size(873, 703);
            this.flp_Tra.TabIndex = 0;
            // 
            // STO
            // 
            this.STO.BackColor = System.Drawing.SystemColors.Control;
            this.STO.Controls.Add(this.flp_SinhTo);
            this.STO.Location = new System.Drawing.Point(4, 44);
            this.STO.Name = "STO";
            this.STO.Padding = new System.Windows.Forms.Padding(3);
            this.STO.Size = new System.Drawing.Size(879, 709);
            this.STO.TabIndex = 2;
            this.STO.Text = "SINH TỐ";
            // 
            // flp_SinhTo
            // 
            this.flp_SinhTo.BackColor = System.Drawing.Color.White;
            this.flp_SinhTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_SinhTo.Location = new System.Drawing.Point(3, 3);
            this.flp_SinhTo.Name = "flp_SinhTo";
            this.flp_SinhTo.Size = new System.Drawing.Size(873, 703);
            this.flp_SinhTo.TabIndex = 0;
            // 
            // JUC
            // 
            this.JUC.BackColor = System.Drawing.SystemColors.Control;
            this.JUC.Controls.Add(this.flp_NuocEp);
            this.JUC.Location = new System.Drawing.Point(4, 44);
            this.JUC.Name = "JUC";
            this.JUC.Padding = new System.Windows.Forms.Padding(3);
            this.JUC.Size = new System.Drawing.Size(879, 709);
            this.JUC.TabIndex = 3;
            this.JUC.Text = "NƯỚC ÉP";
            // 
            // flp_NuocEp
            // 
            this.flp_NuocEp.BackColor = System.Drawing.Color.White;
            this.flp_NuocEp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_NuocEp.Location = new System.Drawing.Point(3, 3);
            this.flp_NuocEp.Name = "flp_NuocEp";
            this.flp_NuocEp.Size = new System.Drawing.Size(873, 703);
            this.flp_NuocEp.TabIndex = 0;
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1383, 815);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.paneText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.paneText.ResumeLayout(false);
            this.paneText.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelAside.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tc_Menu.ResumeLayout(false);
            this.CFE.ResumeLayout(false);
            this.TEA.ResumeLayout(false);
            this.STO.ResumeLayout(false);
            this.JUC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbText0;
        private Guna.UI2.WinForms.Guna2Panel paneText;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label lbNameTable;
        private Guna.UI2.WinForms.Guna2Panel panelAside;
        private Guna.UI2.WinForms.Guna2DataGridView ListOrder_dgv;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2TabControl tc_Menu;
        private System.Windows.Forms.TabPage CFE;
        private System.Windows.Forms.TabPage TEA;
        private System.Windows.Forms.TabPage STO;
        private System.Windows.Forms.TabPage JUC;
        private System.Windows.Forms.FlowLayoutPanel flp_CaPhe;
        private System.Windows.Forms.FlowLayoutPanel flp_Tra;
        private System.Windows.Forms.FlowLayoutPanel flp_SinhTo;
        private System.Windows.Forms.FlowLayoutPanel flp_NuocEp;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
    }
}