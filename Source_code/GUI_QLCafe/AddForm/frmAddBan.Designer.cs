namespace GUI_QLCafe
{
    partial class frmAddBan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddBan));
            this.txtTenBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaBan = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaBan = new System.Windows.Forms.Label();
            this.lbTenBan = new System.Windows.Forms.Label();
            this.cbTrangThai = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.bfAddBan = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbText0 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTenBan
            // 
            this.txtTenBan.BackColor = System.Drawing.Color.Transparent;
            this.txtTenBan.BorderColor = System.Drawing.Color.Silver;
            this.txtTenBan.BorderRadius = 5;
            this.txtTenBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenBan.DefaultText = "";
            this.txtTenBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenBan.ForeColor = System.Drawing.Color.Black;
            this.txtTenBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtTenBan.Location = new System.Drawing.Point(44, 197);
            this.txtTenBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenBan.Modified = true;
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.PasswordChar = '\0';
            this.txtTenBan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtTenBan.PlaceholderText = "";
            this.txtTenBan.SelectedText = "";
            this.txtTenBan.Size = new System.Drawing.Size(460, 36);
            this.txtTenBan.TabIndex = 25;
            // 
            // txtMaBan
            // 
            this.txtMaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtMaBan.BorderColor = System.Drawing.Color.Silver;
            this.txtMaBan.BorderRadius = 5;
            this.txtMaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaBan.DefaultText = "";
            this.txtMaBan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaBan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaBan.ForeColor = System.Drawing.Color.Black;
            this.txtMaBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaBan.Location = new System.Drawing.Point(44, 120);
            this.txtMaBan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaBan.Modified = true;
            this.txtMaBan.Name = "txtMaBan";
            this.txtMaBan.PasswordChar = '\0';
            this.txtMaBan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaBan.PlaceholderText = "";
            this.txtMaBan.SelectedText = "";
            this.txtMaBan.Size = new System.Drawing.Size(460, 36);
            this.txtMaBan.TabIndex = 26;
            // 
            // lbMaBan
            // 
            this.lbMaBan.AutoSize = true;
            this.lbMaBan.BackColor = System.Drawing.Color.White;
            this.lbMaBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaBan.ForeColor = System.Drawing.Color.Black;
            this.lbMaBan.Location = new System.Drawing.Point(39, 87);
            this.lbMaBan.Name = "lbMaBan";
            this.lbMaBan.Size = new System.Drawing.Size(78, 28);
            this.lbMaBan.TabIndex = 23;
            this.lbMaBan.Text = "Mã bàn";
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.BackColor = System.Drawing.Color.White;
            this.lbTenBan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBan.ForeColor = System.Drawing.Color.Black;
            this.lbTenBan.Location = new System.Drawing.Point(39, 163);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(79, 28);
            this.lbTenBan.TabIndex = 24;
            this.lbTenBan.Text = "Tên bàn";
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.BackColor = System.Drawing.Color.Transparent;
            this.cbTrangThai.BorderColor = System.Drawing.Color.Silver;
            this.cbTrangThai.BorderRadius = 5;
            this.cbTrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTrangThai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTrangThai.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.cbTrangThai.ItemHeight = 30;
            this.cbTrangThai.Items.AddRange(new object[] {
            "Có",
            "Không có"});
            this.cbTrangThai.Location = new System.Drawing.Point(44, 276);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(460, 36);
            this.cbTrangThai.TabIndex = 28;
            // 
            // lbTrangThai
            // 
            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.BackColor = System.Drawing.Color.White;
            this.lbTrangThai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTrangThai.ForeColor = System.Drawing.Color.Black;
            this.lbTrangThai.Location = new System.Drawing.Point(42, 245);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(98, 28);
            this.lbTrangThai.TabIndex = 27;
            this.lbTrangThai.Text = "Trạng thái";
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
            this.btnLuu.Location = new System.Drawing.Point(44, 343);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLuu.Size = new System.Drawing.Size(460, 57);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "LƯU";
            // 
            // bfAddBan
            // 
            this.bfAddBan.AnimateWindow = true;
            this.bfAddBan.AnimationInterval = 250;
            this.bfAddBan.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.bfAddBan.BorderRadius = 10;
            this.bfAddBan.ContainerControl = this;
            this.bfAddBan.DockIndicatorTransparencyValue = 0.6D;
            this.bfAddBan.TransparentWhileDrag = true;
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
            this.btnThoat.Location = new System.Drawing.Point(44, 431);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(460, 57);
            this.btnThoat.TabIndex = 30;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
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
            this.panelHeader.Size = new System.Drawing.Size(547, 81);
            this.panelHeader.TabIndex = 32;
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
            this.lbText0.Location = new System.Drawing.Point(116, 21);
            this.lbText0.Name = "lbText0";
            this.lbText0.Size = new System.Drawing.Size(281, 45);
            this.lbText0.TabIndex = 10;
            this.lbText0.Text = "THÔNG TIN BÀN";
            // 
            // frmAddBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 522);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.cbTrangThai);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.txtTenBan);
            this.Controls.Add(this.txtMaBan);
            this.Controls.Add(this.lbMaBan);
            this.Controls.Add(this.lbTenBan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddBan";
            this.Load += new System.EventHandler(this.frmAddBan_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMaBan;
        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label lbTrangThai;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddBan;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label lbText0;
        public Guna.UI2.WinForms.Guna2ComboBox cbTrangThai;
        public Guna.UI2.WinForms.Guna2TextBox txtMaBan;
        public Guna.UI2.WinForms.Guna2TextBox txtTenBan;
    }
}