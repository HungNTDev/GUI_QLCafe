namespace GUI_QLCafe
{
    partial class frmMenuProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProduct));
            this.flp_NuocEp = new System.Windows.Forms.FlowLayoutPanel();
            this.flp_SinhTo = new System.Windows.Forms.FlowLayoutPanel();
            this.STO = new System.Windows.Forms.TabPage();
            this.flp_Tra = new System.Windows.Forms.FlowLayoutPanel();
            this.TEA = new System.Windows.Forms.TabPage();
            this.flp_CaPhe = new System.Windows.Forms.FlowLayoutPanel();
            this.CFE = new System.Windows.Forms.TabPage();
            this.tc_Menu = new Guna.UI2.WinForms.Guna2TabControl();
            this.JUC = new System.Windows.Forms.TabPage();
            this.ListOrder_dgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelAside = new Guna.UI2.WinForms.Guna2Panel();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.paneText = new Guna.UI2.WinForms.Guna2Panel();
            this.lbText0 = new System.Windows.Forms.Label();
            this.btnDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.STO.SuspendLayout();
            this.TEA.SuspendLayout();
            this.CFE.SuspendLayout();
            this.tc_Menu.SuspendLayout();
            this.JUC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).BeginInit();
            this.panelBody.SuspendLayout();
            this.panelAside.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.paneText.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_NuocEp
            // 
            this.flp_NuocEp.BackColor = System.Drawing.Color.White;
            this.flp_NuocEp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_NuocEp.Location = new System.Drawing.Point(3, 3);
            this.flp_NuocEp.Name = "flp_NuocEp";
            this.flp_NuocEp.Size = new System.Drawing.Size(645, 630);
            this.flp_NuocEp.TabIndex = 0;
            // 
            // flp_SinhTo
            // 
            this.flp_SinhTo.BackColor = System.Drawing.Color.White;
            this.flp_SinhTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_SinhTo.Location = new System.Drawing.Point(3, 3);
            this.flp_SinhTo.Name = "flp_SinhTo";
            this.flp_SinhTo.Size = new System.Drawing.Size(645, 670);
            this.flp_SinhTo.TabIndex = 0;
            // 
            // STO
            // 
            this.STO.BackColor = System.Drawing.SystemColors.Control;
            this.STO.Controls.Add(this.flp_SinhTo);
            this.STO.Location = new System.Drawing.Point(4, 44);
            this.STO.Name = "STO";
            this.STO.Padding = new System.Windows.Forms.Padding(3);
            this.STO.Size = new System.Drawing.Size(651, 676);
            this.STO.TabIndex = 2;
            this.STO.Text = "SINH TỐ";
            // 
            // flp_Tra
            // 
            this.flp_Tra.BackColor = System.Drawing.Color.White;
            this.flp_Tra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Tra.Location = new System.Drawing.Point(3, 3);
            this.flp_Tra.Name = "flp_Tra";
            this.flp_Tra.Size = new System.Drawing.Size(645, 670);
            this.flp_Tra.TabIndex = 0;
            // 
            // TEA
            // 
            this.TEA.BackColor = System.Drawing.SystemColors.Control;
            this.TEA.Controls.Add(this.flp_Tra);
            this.TEA.Location = new System.Drawing.Point(4, 44);
            this.TEA.Name = "TEA";
            this.TEA.Padding = new System.Windows.Forms.Padding(3);
            this.TEA.Size = new System.Drawing.Size(651, 676);
            this.TEA.TabIndex = 1;
            this.TEA.Text = "TRÀ";
            // 
            // flp_CaPhe
            // 
            this.flp_CaPhe.BackColor = System.Drawing.Color.White;
            this.flp_CaPhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_CaPhe.Location = new System.Drawing.Point(3, 3);
            this.flp_CaPhe.Name = "flp_CaPhe";
            this.flp_CaPhe.Size = new System.Drawing.Size(960, 710);
            this.flp_CaPhe.TabIndex = 1;
            // 
            // CFE
            // 
            this.CFE.BackColor = System.Drawing.SystemColors.Control;
            this.CFE.Controls.Add(this.flp_CaPhe);
            this.CFE.Location = new System.Drawing.Point(4, 44);
            this.CFE.Name = "CFE";
            this.CFE.Padding = new System.Windows.Forms.Padding(3);
            this.CFE.Size = new System.Drawing.Size(966, 716);
            this.CFE.TabIndex = 0;
            this.CFE.Text = "CÀ PHÊ";
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
            this.tc_Menu.Size = new System.Drawing.Size(974, 764);
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
            // JUC
            // 
            this.JUC.BackColor = System.Drawing.SystemColors.Control;
            this.JUC.Controls.Add(this.flp_NuocEp);
            this.JUC.Location = new System.Drawing.Point(4, 84);
            this.JUC.Name = "JUC";
            this.JUC.Padding = new System.Windows.Forms.Padding(3);
            this.JUC.Size = new System.Drawing.Size(651, 636);
            this.JUC.TabIndex = 3;
            this.JUC.Text = "NƯỚC ÉP";
            // 
            // ListOrder_dgv
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            this.ListOrder_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.ListOrder_dgv.ColumnHeadersHeight = 40;
            this.ListOrder_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListOrder_dgv.DefaultCellStyle = dataGridViewCellStyle8;
            this.ListOrder_dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOrder_dgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ListOrder_dgv.Location = new System.Drawing.Point(0, 0);
            this.ListOrder_dgv.Name = "ListOrder_dgv";
            this.ListOrder_dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListOrder_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.ListOrder_dgv.RowHeadersVisible = false;
            this.ListOrder_dgv.RowHeadersWidth = 50;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.ListOrder_dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ListOrder_dgv.RowTemplate.Height = 40;
            this.ListOrder_dgv.Size = new System.Drawing.Size(496, 677);
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
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.BorderThickness = 2;
            this.panelBody.Controls.Add(this.tc_Menu);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 58);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(974, 764);
            this.panelBody.TabIndex = 15;
            // 
            // panelAside
            // 
            this.panelAside.Controls.Add(this.ListOrder_dgv);
            this.panelAside.Controls.Add(this.panelFooter);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAside.Location = new System.Drawing.Point(974, 58);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(496, 764);
            this.panelAside.TabIndex = 14;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelFooter.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.BorderThickness = 2;
            this.panelFooter.Controls.Add(this.btnDel);
            this.panelFooter.Controls.Add(this.btnAdd);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 677);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(496, 87);
            this.panelFooter.TabIndex = 3;
            // 
            // paneText
            // 
            this.paneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.paneText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.paneText.BorderThickness = 2;
            this.paneText.Controls.Add(this.lbText0);
            this.paneText.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneText.Location = new System.Drawing.Point(0, 0);
            this.paneText.Name = "paneText";
            this.paneText.Size = new System.Drawing.Size(1470, 58);
            this.paneText.TabIndex = 13;
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
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
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
            this.btnAdd.Text = "Chọn bàn";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmMenuProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1470, 822);
            this.ControlBox = false;
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.paneText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuProduct";
            this.Load += new System.EventHandler(this.frmMenuProduct_Load);
            this.STO.ResumeLayout(false);
            this.TEA.ResumeLayout(false);
            this.CFE.ResumeLayout(false);
            this.tc_Menu.ResumeLayout(false);
            this.JUC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListOrder_dgv)).EndInit();
            this.panelBody.ResumeLayout(false);
            this.panelAside.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.paneText.ResumeLayout(false);
            this.paneText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_NuocEp;
        private System.Windows.Forms.FlowLayoutPanel flp_SinhTo;
        private System.Windows.Forms.TabPage STO;
        private System.Windows.Forms.FlowLayoutPanel flp_Tra;
        private System.Windows.Forms.TabPage TEA;
        private System.Windows.Forms.FlowLayoutPanel flp_CaPhe;
        private System.Windows.Forms.TabPage CFE;
        private Guna.UI2.WinForms.Guna2TabControl tc_Menu;
        private System.Windows.Forms.TabPage JUC;
        private Guna.UI2.WinForms.Guna2DataGridView ListOrder_dgv;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2Panel panelAside;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnDel;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel paneText;
        private System.Windows.Forms.Label lbText0;
    }
}