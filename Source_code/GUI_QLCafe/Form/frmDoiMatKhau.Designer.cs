namespace GUI_QLCafe
{
    partial class frmDoiMatKhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoiMatKhau));
            this.eDoiMatKhau = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnChangePassword = new Guna.UI2.WinForms.Guna2Button();
            this.picBackground = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.cbMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelDoiMatKhau = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lbRetypePass = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txtRetypePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.panelDoiMatKhau.SuspendLayout();
            this.SuspendLayout();
            // 
            // eDoiMatKhau
            // 
            this.eDoiMatKhau.BorderRadius = 20;
            this.eDoiMatKhau.TargetControl = this;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnChangePassword.BorderRadius = 15;
            this.btnChangePassword.BorderThickness = 1;
            this.btnChangePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnChangePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnChangePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnChangePassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnChangePassword.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnChangePassword.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnChangePassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnChangePassword.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnChangePassword.Location = new System.Drawing.Point(458, 470);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(363, 47);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Thay đổi";
            // 
            // picBackground
            // 
            this.picBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(130)))), ((int)(((byte)(112)))));
            this.picBackground.BorderRadius = 15;
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.ImageRotate = 0F;
            this.picBackground.Location = new System.Drawing.Point(-1, -9);
            this.picBackground.Margin = new System.Windows.Forms.Padding(2);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(400, 574);
            this.picBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackground.TabIndex = 4;
            this.picBackground.TabStop = false;
            // 
            // lbOldPassword
            // 
            this.lbOldPassword.AutoSize = true;
            this.lbOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOldPassword.Location = new System.Drawing.Point(454, 199);
            this.lbOldPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOldPassword.Name = "lbOldPassword";
            this.lbOldPassword.Size = new System.Drawing.Size(95, 21);
            this.lbOldPassword.TabIndex = 6;
            this.lbOldPassword.Text = "Mật khẩu cũ";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtOldPassword.BorderRadius = 10;
            this.txtOldPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOldPassword.DefaultText = "";
            this.txtOldPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOldPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOldPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOldPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtOldPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOldPassword.ForeColor = System.Drawing.Color.Black;
            this.txtOldPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtOldPassword.Location = new System.Drawing.Point(458, 228);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '*';
            this.txtOldPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtOldPassword.PlaceholderText = "Ít nhất 8 ký tự";
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.Size = new System.Drawing.Size(363, 37);
            this.txtOldPassword.TabIndex = 5;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(455, 125);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(48, 21);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(458, 156);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "user@example.com";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(363, 37);
            this.txtEmail.TabIndex = 5;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.lblText.Location = new System.Drawing.Point(452, 56);
            this.lblText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(255, 37);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "Thay đổi mật khẩu";
            // 
            // cbMinimize
            // 
            this.cbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbMinimize.BackColor = System.Drawing.Color.Transparent;
            this.cbMinimize.BorderRadius = 5;
            this.cbMinimize.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.cbMinimize.FillColor = System.Drawing.Color.White;
            this.cbMinimize.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMinimize.HoverState.FillColor = System.Drawing.Color.White;
            this.cbMinimize.IconColor = System.Drawing.Color.Black;
            this.cbMinimize.Location = new System.Drawing.Point(813, 6);
            this.cbMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.cbMinimize.Name = "cbMinimize";
            this.cbMinimize.Size = new System.Drawing.Size(26, 22);
            this.cbMinimize.TabIndex = 3;
            // 
            // cbClose
            // 
            this.cbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbClose.BackColor = System.Drawing.Color.Transparent;
            this.cbClose.BorderRadius = 5;
            this.cbClose.FillColor = System.Drawing.Color.White;
            this.cbClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbClose.HoverState.FillColor = System.Drawing.Color.White;
            this.cbClose.IconColor = System.Drawing.Color.Black;
            this.cbClose.Location = new System.Drawing.Point(844, 6);
            this.cbClose.Margin = new System.Windows.Forms.Padding(2);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(26, 22);
            this.cbClose.TabIndex = 3;
            // 
            // panelDoiMatKhau
            // 
            this.panelDoiMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.panelDoiMatKhau.Controls.Add(this.shapeLine);
            this.panelDoiMatKhau.Controls.Add(this.chkShowPassword);
            this.panelDoiMatKhau.Controls.Add(this.btnChangePassword);
            this.panelDoiMatKhau.Controls.Add(this.lbRetypePass);
            this.panelDoiMatKhau.Controls.Add(this.lbNewPassword);
            this.panelDoiMatKhau.Controls.Add(this.txtRetypePassword);
            this.panelDoiMatKhau.Controls.Add(this.lbOldPassword);
            this.panelDoiMatKhau.Controls.Add(this.txtNewPassword);
            this.panelDoiMatKhau.Controls.Add(this.txtOldPassword);
            this.panelDoiMatKhau.Controls.Add(this.lbEmail);
            this.panelDoiMatKhau.Controls.Add(this.txtEmail);
            this.panelDoiMatKhau.Controls.Add(this.lblText);
            this.panelDoiMatKhau.Controls.Add(this.cbMinimize);
            this.panelDoiMatKhau.Controls.Add(this.cbClose);
            this.panelDoiMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDoiMatKhau.FillColor = System.Drawing.Color.White;
            this.panelDoiMatKhau.FillColor2 = System.Drawing.Color.White;
            this.panelDoiMatKhau.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panelDoiMatKhau.Location = new System.Drawing.Point(0, 0);
            this.panelDoiMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.panelDoiMatKhau.Name = "panelDoiMatKhau";
            this.panelDoiMatKhau.Size = new System.Drawing.Size(878, 556);
            this.panelDoiMatKhau.TabIndex = 5;
            // 
            // shapeLine
            // 
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.shapeLine.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.shapeLine.LineThickness = 1;
            this.shapeLine.Location = new System.Drawing.Point(410, 95);
            this.shapeLine.Margin = new System.Windows.Forms.Padding(2);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(459, 18);
            this.shapeLine.TabIndex = 12;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.UseTransparentBackground = true;
            this.shapeLine.Zoom = 80;
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.Location = new System.Drawing.Point(681, 419);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(124, 24);
            this.chkShowPassword.TabIndex = 11;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            // 
            // lbRetypePass
            // 
            this.lbRetypePass.AutoSize = true;
            this.lbRetypePass.BackColor = System.Drawing.Color.Transparent;
            this.lbRetypePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetypePass.Location = new System.Drawing.Point(455, 345);
            this.lbRetypePass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRetypePass.Name = "lbRetypePass";
            this.lbRetypePass.Size = new System.Drawing.Size(137, 21);
            this.lbRetypePass.TabIndex = 6;
            this.lbRetypePass.Text = "Nhập lại mật khẩu";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(456, 273);
            this.lbNewPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(107, 21);
            this.lbNewPassword.TabIndex = 6;
            this.lbNewPassword.Text = "Mật khẩu mới";
            // 
            // txtRetypePassword
            // 
            this.txtRetypePassword.BackColor = System.Drawing.Color.Transparent;
            this.txtRetypePassword.BorderColor = System.Drawing.Color.Silver;
            this.txtRetypePassword.BorderRadius = 10;
            this.txtRetypePassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRetypePassword.DefaultText = "";
            this.txtRetypePassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRetypePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRetypePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRetypePassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRetypePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtRetypePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.ForeColor = System.Drawing.Color.Black;
            this.txtRetypePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtRetypePassword.Location = new System.Drawing.Point(458, 375);
            this.txtRetypePassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRetypePassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txtRetypePassword.SelectedText = "";
            this.txtRetypePassword.Size = new System.Drawing.Size(363, 37);
            this.txtRetypePassword.TabIndex = 5;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtNewPassword.BorderRadius = 10;
            this.txtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNewPassword.DefaultText = "";
            this.txtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNewPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtNewPassword.Location = new System.Drawing.Point(459, 302);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.PlaceholderText = "Ít nhất 8 ký tự";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(363, 37);
            this.txtNewPassword.TabIndex = 5;
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 556);
            this.Controls.Add(this.picBackground);
            this.Controls.Add(this.panelDoiMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoiMatKhau";
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.panelDoiMatKhau.ResumeLayout(false);
            this.panelDoiMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2PictureBox picBackground;
        private Guna.UI2.WinForms.Guna2GradientPanel panelDoiMatKhau;
        private Guna.UI2.WinForms.Guna2Button btnChangePassword;
        private System.Windows.Forms.Label lbOldPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtOldPassword;
        private System.Windows.Forms.Label lbEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2ControlBox cbMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private Guna.UI2.WinForms.Guna2Elipse eDoiMatKhau;
        private System.Windows.Forms.Label lbNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private System.Windows.Forms.Label lbRetypePass;
        private Guna.UI2.WinForms.Guna2TextBox txtRetypePassword;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
    }
}