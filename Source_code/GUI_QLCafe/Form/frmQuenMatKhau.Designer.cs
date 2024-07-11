namespace GUI_QLCafe
{
    partial class frmQuenMatKhau
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
            this.cbMinimize = new Guna.UI2.WinForms.Guna2ControlBox();
            this.cbClose = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelQuenMatKhau = new Guna.UI2.WinForms.Guna2Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.lbRetypePass = new System.Windows.Forms.Label();
            this.lbNewPassword = new System.Windows.Forms.Label();
            this.txtRetypePassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbMaXacNhan = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.btnGui = new Guna.UI2.WinForms.Guna2Button();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.txtMaXacNhan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.shapeLine = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblText = new System.Windows.Forms.Label();
            this.bfQuenMatKhau = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.messageDialog = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panelQuenMatKhau.SuspendLayout();
            this.SuspendLayout();
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
            this.cbMinimize.Location = new System.Drawing.Point(576, 6);
            this.cbMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMinimize.Name = "cbMinimize";
            this.cbMinimize.Size = new System.Drawing.Size(35, 27);
            this.cbMinimize.TabIndex = 4;
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
            this.cbClose.Location = new System.Drawing.Point(617, 6);
            this.cbClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbClose.Name = "cbClose";
            this.cbClose.Size = new System.Drawing.Size(35, 27);
            this.cbClose.TabIndex = 5;
            // 
            // panelQuenMatKhau
            // 
            this.panelQuenMatKhau.Controls.Add(this.chkShowPassword);
            this.panelQuenMatKhau.Controls.Add(this.lbRetypePass);
            this.panelQuenMatKhau.Controls.Add(this.lbNewPassword);
            this.panelQuenMatKhau.Controls.Add(this.txtRetypePassword);
            this.panelQuenMatKhau.Controls.Add(this.txtNewPassword);
            this.panelQuenMatKhau.Controls.Add(this.lbMaXacNhan);
            this.panelQuenMatKhau.Controls.Add(this.lbEmail);
            this.panelQuenMatKhau.Controls.Add(this.btnGui);
            this.panelQuenMatKhau.Controls.Add(this.btnCapNhat);
            this.panelQuenMatKhau.Controls.Add(this.txtMaXacNhan);
            this.panelQuenMatKhau.Controls.Add(this.txtEmail);
            this.panelQuenMatKhau.Controls.Add(this.shapeLine);
            this.panelQuenMatKhau.Controls.Add(this.lblText);
            this.panelQuenMatKhau.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuenMatKhau.Location = new System.Drawing.Point(0, 0);
            this.panelQuenMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelQuenMatKhau.Name = "panelQuenMatKhau";
            this.panelQuenMatKhau.Size = new System.Drawing.Size(661, 672);
            this.panelQuenMatKhau.TabIndex = 6;
            this.panelQuenMatKhau.Paint += new System.Windows.Forms.PaintEventHandler(this.panelQuenMatKhau_Paint);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.chkShowPassword.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowPassword.ForeColor = System.Drawing.Color.Black;
            this.chkShowPassword.Location = new System.Drawing.Point(391, 373);
            this.chkShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(149, 29);
            this.chkShowPassword.TabIndex = 23;
            this.chkShowPassword.Text = "Hiện mật khẩu";
            this.chkShowPassword.UseVisualStyleBackColor = false;
            // 
            // lbRetypePass
            // 
            this.lbRetypePass.AutoSize = true;
            this.lbRetypePass.BackColor = System.Drawing.Color.Transparent;
            this.lbRetypePass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetypePass.Location = new System.Drawing.Point(91, 282);
            this.lbRetypePass.Name = "lbRetypePass";
            this.lbRetypePass.Size = new System.Drawing.Size(171, 28);
            this.lbRetypePass.TabIndex = 21;
            this.lbRetypePass.Text = "Nhập lại mật khẩu";
            // 
            // lbNewPassword
            // 
            this.lbNewPassword.AutoSize = true;
            this.lbNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewPassword.Location = new System.Drawing.Point(91, 193);
            this.lbNewPassword.Name = "lbNewPassword";
            this.lbNewPassword.Size = new System.Drawing.Size(133, 28);
            this.lbNewPassword.TabIndex = 22;
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
            this.txtRetypePassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtRetypePassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassword.ForeColor = System.Drawing.Color.Black;
            this.txtRetypePassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtRetypePassword.Location = new System.Drawing.Point(97, 319);
            this.txtRetypePassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtRetypePassword.Name = "txtRetypePassword";
            this.txtRetypePassword.PasswordChar = '*';
            this.txtRetypePassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtRetypePassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txtRetypePassword.SelectedText = "";
            this.txtRetypePassword.Size = new System.Drawing.Size(481, 46);
            this.txtRetypePassword.TabIndex = 19;
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
            this.txtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Black;
            this.txtNewPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtNewPassword.Location = new System.Drawing.Point(99, 230);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtNewPassword.PlaceholderText = "Ít nhất 8 ký tự";
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.Size = new System.Drawing.Size(480, 46);
            this.txtNewPassword.TabIndex = 20;
            // 
            // lbMaXacNhan
            // 
            this.lbMaXacNhan.AutoSize = true;
            this.lbMaXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.lbMaXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaXacNhan.Location = new System.Drawing.Point(91, 375);
            this.lbMaXacNhan.Name = "lbMaXacNhan";
            this.lbMaXacNhan.Size = new System.Drawing.Size(121, 28);
            this.lbMaXacNhan.TabIndex = 18;
            this.lbMaXacNhan.Text = "Mã xác nhận";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(91, 105);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(59, 28);
            this.lbEmail.TabIndex = 18;
            this.lbEmail.Text = "Email";
            // 
            // btnGui
            // 
            this.btnGui.BackColor = System.Drawing.Color.Transparent;
            this.btnGui.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnGui.BorderRadius = 15;
            this.btnGui.BorderThickness = 1;
            this.btnGui.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGui.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGui.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGui.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnGui.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnGui.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGui.ForeColor = System.Drawing.Color.White;
            this.btnGui.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnGui.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnGui.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnGui.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnGui.Location = new System.Drawing.Point(97, 481);
            this.btnGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGui.Name = "btnGui";
            this.btnGui.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnGui.Size = new System.Drawing.Size(481, 58);
            this.btnGui.TabIndex = 17;
            this.btnGui.Text = "GỬI MÃ XÁC NHẬN";
            this.btnGui.Click += new System.EventHandler(this.btnGui_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnCapNhat.BorderRadius = 15;
            this.btnCapNhat.BorderThickness = 1;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnCapNhat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnCapNhat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnCapNhat.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(97, 567);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnCapNhat.Size = new System.Drawing.Size(481, 58);
            this.btnCapNhat.TabIndex = 17;
            this.btnCapNhat.Text = "CẬP NHẬT";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtMaXacNhan
            // 
            this.txtMaXacNhan.BackColor = System.Drawing.Color.Transparent;
            this.txtMaXacNhan.BorderColor = System.Drawing.Color.Silver;
            this.txtMaXacNhan.BorderRadius = 10;
            this.txtMaXacNhan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXacNhan.DefaultText = "";
            this.txtMaXacNhan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaXacNhan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaXacNhan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXacNhan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaXacNhan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaXacNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaXacNhan.ForeColor = System.Drawing.Color.Black;
            this.txtMaXacNhan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtMaXacNhan.Location = new System.Drawing.Point(97, 410);
            this.txtMaXacNhan.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaXacNhan.Name = "txtMaXacNhan";
            this.txtMaXacNhan.PasswordChar = '\0';
            this.txtMaXacNhan.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtMaXacNhan.PlaceholderText = "Nhập mã xác nhận";
            this.txtMaXacNhan.SelectedText = "";
            this.txtMaXacNhan.Size = new System.Drawing.Size(481, 46);
            this.txtMaXacNhan.TabIndex = 16;
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
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.txtEmail.Location = new System.Drawing.Point(99, 142);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtEmail.PlaceholderText = "user@example.com";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(480, 46);
            this.txtEmail.TabIndex = 16;
            // 
            // shapeLine
            // 
            this.shapeLine.BackColor = System.Drawing.Color.Transparent;
            this.shapeLine.BorderThickness = 1;
            this.shapeLine.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.shapeLine.LineEndCap = System.Drawing.Drawing2D.LineCap.Round;
            this.shapeLine.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.shapeLine.LineThickness = 1;
            this.shapeLine.Location = new System.Drawing.Point(29, 80);
            this.shapeLine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.shapeLine.Name = "shapeLine";
            this.shapeLine.PolygonSkip = 1;
            this.shapeLine.Rotate = 0F;
            this.shapeLine.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shapeLine.Size = new System.Drawing.Size(605, 22);
            this.shapeLine.TabIndex = 14;
            this.shapeLine.Text = "guna2Shapes1";
            this.shapeLine.UseTransparentBackground = true;
            this.shapeLine.Zoom = 80;
            this.shapeLine.Click += new System.EventHandler(this.shapeLine_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.lblText.Location = new System.Drawing.Point(169, 26);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(258, 45);
            this.lblText.TabIndex = 13;
            this.lblText.Text = "Quên mật khẩu";
            // 
            // bfQuenMatKhau
            // 
            this.bfQuenMatKhau.AnimateWindow = true;
            this.bfQuenMatKhau.BorderRadius = 20;
            this.bfQuenMatKhau.ContainerControl = this;
            this.bfQuenMatKhau.DockIndicatorTransparencyValue = 0.6D;
            this.bfQuenMatKhau.TransparentWhileDrag = true;
            // 
            // messageDialog
            // 
            this.messageDialog.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.messageDialog.Caption = "Thông báo";
            this.messageDialog.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.messageDialog.Parent = this;
            this.messageDialog.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.messageDialog.Text = null;
            // 
            // frmQuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(661, 672);
            this.Controls.Add(this.cbMinimize);
            this.Controls.Add(this.cbClose);
            this.Controls.Add(this.panelQuenMatKhau);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuenMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuenMatKhau";
            this.panelQuenMatKhau.ResumeLayout(false);
            this.panelQuenMatKhau.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox cbMinimize;
        private Guna.UI2.WinForms.Guna2ControlBox cbClose;
        private Guna.UI2.WinForms.Guna2Panel panelQuenMatKhau;
        private Guna.UI2.WinForms.Guna2Shapes shapeLine;
        private System.Windows.Forms.Label lblText;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private System.Windows.Forms.Label lbEmail;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfQuenMatKhau;
        private Guna.UI2.WinForms.Guna2MessageDialog messageDialog;
        private System.Windows.Forms.Label lbMaXacNhan;
        private Guna.UI2.WinForms.Guna2TextBox txtMaXacNhan;
        private Guna.UI2.WinForms.Guna2Button btnGui;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.Label lbRetypePass;
        private System.Windows.Forms.Label lbNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtRetypePassword;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
    }
}