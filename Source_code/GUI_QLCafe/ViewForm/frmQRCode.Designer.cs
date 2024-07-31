namespace GUI_QLCafe.ViewForm
{
    partial class frmQRCode
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
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.btnThanhToanKhac = new Guna.UI2.WinForms.Guna2Button();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.lbThoiGian = new System.Windows.Forms.Label();
            this.gbQuetMa = new Guna.UI2.WinForms.Guna2GroupBox();
            this.picMoMo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.bfQRCode = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelBody.SuspendLayout();
            this.gbQuetMa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMoMo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.BorderColor = System.Drawing.Color.DarkGray;
            this.panelBody.BorderRadius = 10;
            this.panelBody.BorderThickness = 1;
            this.panelBody.Controls.Add(this.btnThanhToanKhac);
            this.panelBody.Controls.Add(this.lbTongTien);
            this.panelBody.Controls.Add(this.lbThoiGian);
            this.panelBody.Controls.Add(this.gbQuetMa);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.FillColor = System.Drawing.Color.Transparent;
            this.panelBody.Location = new System.Drawing.Point(0, 0);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(522, 711);
            this.panelBody.TabIndex = 2;
            // 
            // btnThanhToanKhac
            // 
            this.btnThanhToanKhac.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToanKhac.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(43)))), ((int)(((byte)(139)))));
            this.btnThanhToanKhac.BorderRadius = 10;
            this.btnThanhToanKhac.BorderThickness = 1;
            this.btnThanhToanKhac.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanKhac.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToanKhac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToanKhac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToanKhac.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(43)))), ((int)(((byte)(139)))));
            this.btnThanhToanKhac.FocusedColor = System.Drawing.Color.Black;
            this.btnThanhToanKhac.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToanKhac.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanKhac.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btnThanhToanKhac.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnThanhToanKhac.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(43)))), ((int)(((byte)(139)))));
            this.btnThanhToanKhac.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnThanhToanKhac.Location = new System.Drawing.Point(39, 622);
            this.btnThanhToanKhac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToanKhac.Name = "btnThanhToanKhac";
            this.btnThanhToanKhac.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(217)))), ((int)(((byte)(132)))));
            this.btnThanhToanKhac.Size = new System.Drawing.Size(446, 60);
            this.btnThanhToanKhac.TabIndex = 27;
            this.btnThanhToanKhac.Text = "CHỌN LOẠI THANH TOÁN KHÁC";
            this.btnThanhToanKhac.Click += new System.EventHandler(this.btnThanhToanKhac_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(39, 469);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(309, 31);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "Số tiền cần phải thanh toán: \r\n";
            // 
            // lbThoiGian
            // 
            this.lbThoiGian.AutoSize = true;
            this.lbThoiGian.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThoiGian.Location = new System.Drawing.Point(33, 418);
            this.lbThoiGian.Name = "lbThoiGian";
            this.lbThoiGian.Size = new System.Drawing.Size(315, 31);
            this.lbThoiGian.TabIndex = 1;
            this.lbThoiGian.Text = "Thời gian thanh toán còn lại: ";
            // 
            // gbQuetMa
            // 
            this.gbQuetMa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(43)))), ((int)(((byte)(139)))));
            this.gbQuetMa.BorderRadius = 10;
            this.gbQuetMa.Controls.Add(this.picMoMo);
            this.gbQuetMa.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(43)))), ((int)(((byte)(139)))));
            this.gbQuetMa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQuetMa.ForeColor = System.Drawing.Color.White;
            this.gbQuetMa.Location = new System.Drawing.Point(39, 40);
            this.gbQuetMa.Name = "gbQuetMa";
            this.gbQuetMa.Size = new System.Drawing.Size(446, 352);
            this.gbQuetMa.TabIndex = 0;
            this.gbQuetMa.Text = "Quét mã tại đây";
            this.gbQuetMa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picMoMo
            // 
            this.picMoMo.BackColor = System.Drawing.Color.White;
            this.picMoMo.FillColor = System.Drawing.Color.Silver;
            this.picMoMo.ImageRotate = 0F;
            this.picMoMo.Location = new System.Drawing.Point(96, 70);
            this.picMoMo.Name = "picMoMo";
            this.picMoMo.Size = new System.Drawing.Size(265, 246);
            this.picMoMo.TabIndex = 0;
            this.picMoMo.TabStop = false;
            // 
            // bfQRCode
            // 
            this.bfQRCode.AnimateWindow = true;
            this.bfQRCode.AnimationInterval = 250;
            this.bfQRCode.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_HOR_POSITIVE;
            this.bfQRCode.BorderRadius = 10;
            this.bfQRCode.ContainerControl = this;
            this.bfQRCode.DockIndicatorTransparencyValue = 0.6D;
            this.bfQRCode.TransparentWhileDrag = true;
            // 
            // frmQRCode
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(522, 711);
            this.Controls.Add(this.panelBody);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQRCode";
            this.Load += new System.EventHandler(this.frmQRCode_Load);
            this.panelBody.ResumeLayout(false);
            this.panelBody.PerformLayout();
            this.gbQuetMa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMoMo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private Guna.UI2.WinForms.Guna2GroupBox gbQuetMa;
        private System.Windows.Forms.Label lbThoiGian;
        private Guna.UI2.WinForms.Guna2Button btnThanhToanKhac;
        private System.Windows.Forms.Label lbTongTien;
        public Guna.UI2.WinForms.Guna2PictureBox picMoMo;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfQRCode;
    }
}