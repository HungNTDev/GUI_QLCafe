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
            this.btnLuu = new Guna.UI2.WinForms.Guna2Button();
            this.bfAddBan = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnThoat = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.picLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbHeaderText = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
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
            this.btnLuu.Location = new System.Drawing.Point(44, 283);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnLuu.Size = new System.Drawing.Size(460, 57);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
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
            this.btnThoat.Location = new System.Drawing.Point(44, 371);
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
            this.panelHeader.Controls.Add(this.picLogo);
            this.panelHeader.Controls.Add(this.lbHeaderText);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(547, 81);
            this.panelHeader.TabIndex = 33;
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.ImageRotate = 0F;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(103, 81);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 47;
            this.picLogo.TabStop = false;
            // 
            // lbHeaderText
            // 
            this.lbHeaderText.AutoSize = true;
            this.lbHeaderText.BackColor = System.Drawing.Color.Transparent;
            this.lbHeaderText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeaderText.ForeColor = System.Drawing.Color.White;
            this.lbHeaderText.Location = new System.Drawing.Point(109, 19);
            this.lbHeaderText.Name = "lbHeaderText";
            this.lbHeaderText.Size = new System.Drawing.Size(90, 45);
            this.lbHeaderText.TabIndex = 10;
            this.lbHeaderText.Text = "BÀN";
            // 
            // frmAddBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 464);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLuu);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbMaBan;
        private System.Windows.Forms.Label lbTenBan;
        private Guna.UI2.WinForms.Guna2Button btnLuu;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfAddBan;
        private Guna.UI2.WinForms.Guna2Button btnThoat;
        public Guna.UI2.WinForms.Guna2TextBox txtMaBan;
        public Guna.UI2.WinForms.Guna2TextBox txtTenBan;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox picLogo;
        private System.Windows.Forms.Label lbHeaderText;
    }
}