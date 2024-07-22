﻿namespace GUI_QLCafe
{
    partial class frmPOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPOS));
            this.lbTenBan = new System.Windows.Forms.Label();
            this.lbGioVao = new System.Windows.Forms.Label();
            this.lbThanhTien = new System.Windows.Forms.Label();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lbGioRa = new System.Windows.Forms.Label();
            this.panelFooter = new Guna.UI2.WinForms.Guna2Panel();
            this.btnBan = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemMon = new Guna.UI2.WinForms.Guna2Button();
            this.btnThanhToan = new Guna.UI2.WinForms.Guna2Button();
            this.lvHoaDon = new System.Windows.Forms.ListView();
            this.chTenMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.paneText = new Guna.UI2.WinForms.Guna2Panel();
            this.lbText0 = new System.Windows.Forms.Label();
            this.panelAside = new Guna.UI2.WinForms.Guna2Panel();
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.paneText.SuspendLayout();
            this.panelAside.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTenBan
            // 
            this.lbTenBan.AutoSize = true;
            this.lbTenBan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenBan.ForeColor = System.Drawing.Color.White;
            this.lbTenBan.Location = new System.Drawing.Point(21, 15);
            this.lbTenBan.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbTenBan.Name = "lbTenBan";
            this.lbTenBan.Size = new System.Drawing.Size(103, 31);
            this.lbTenBan.TabIndex = 0;
            this.lbTenBan.Text = "Tên bàn:";
            // 
            // lbGioVao
            // 
            this.lbGioVao.AutoSize = true;
            this.lbGioVao.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioVao.ForeColor = System.Drawing.Color.White;
            this.lbGioVao.Location = new System.Drawing.Point(20, 57);
            this.lbGioVao.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioVao.Name = "lbGioVao";
            this.lbGioVao.Size = new System.Drawing.Size(101, 31);
            this.lbGioVao.TabIndex = 0;
            this.lbGioVao.Text = "Giờ vào:";
            // 
            // lbThanhTien
            // 
            this.lbThanhTien.AutoSize = true;
            this.lbThanhTien.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThanhTien.ForeColor = System.Drawing.Color.Cyan;
            this.lbThanhTien.Location = new System.Drawing.Point(18, 20);
            this.lbThanhTien.Name = "lbThanhTien";
            this.lbThanhTien.Size = new System.Drawing.Size(187, 45);
            this.lbThanhTien.TabIndex = 0;
            this.lbThanhTien.Text = "Thành tiền:";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelHeader.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelHeader.Controls.Add(this.lbTenBan);
            this.panelHeader.Controls.Add(this.lbGioRa);
            this.panelHeader.Controls.Add(this.lbGioVao);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(595, 146);
            this.panelHeader.TabIndex = 2;
            // 
            // lbGioRa
            // 
            this.lbGioRa.AutoSize = true;
            this.lbGioRa.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioRa.ForeColor = System.Drawing.Color.White;
            this.lbGioRa.Location = new System.Drawing.Point(21, 95);
            this.lbGioRa.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.lbGioRa.Name = "lbGioRa";
            this.lbGioRa.Size = new System.Drawing.Size(84, 31);
            this.lbGioRa.TabIndex = 0;
            this.lbGioRa.Text = "Giờ ra:";
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panelFooter.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.BorderThickness = 2;
            this.panelFooter.Controls.Add(this.btnBan);
            this.panelFooter.Controls.Add(this.btnThemMon);
            this.panelFooter.Controls.Add(this.btnThanhToan);
            this.panelFooter.Controls.Add(this.lbThanhTien);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 580);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(595, 171);
            this.panelFooter.TabIndex = 3;
            // 
            // btnBan
            // 
            this.btnBan.BorderColor = System.Drawing.Color.White;
            this.btnBan.BorderRadius = 10;
            this.btnBan.BorderThickness = 1;
            this.btnBan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnBan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnBan.HoverState.FillColor = System.Drawing.Color.White;
            this.btnBan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnBan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnBan.Image = ((System.Drawing.Image)(resources.GetObject("btnBan.Image")));
            this.btnBan.Location = new System.Drawing.Point(403, 97);
            this.btnBan.Name = "btnBan";
            this.btnBan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnBan.Size = new System.Drawing.Size(178, 48);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bàn";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BorderColor = System.Drawing.Color.White;
            this.btnThemMon.BorderRadius = 10;
            this.btnThemMon.BorderThickness = 1;
            this.btnThemMon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemMon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemMon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemMon.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.ForeColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThemMon.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThemMon.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThemMon.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnThemMon.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMon.Image")));
            this.btnThemMon.Location = new System.Drawing.Point(214, 97);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnThemMon.Size = new System.Drawing.Size(178, 48);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm món";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BorderColor = System.Drawing.Color.White;
            this.btnThanhToan.BorderRadius = 10;
            this.btnThanhToan.BorderThickness = 1;
            this.btnThanhToan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhToan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhToan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhToan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.HoverState.FillColor = System.Drawing.Color.White;
            this.btnThanhToan.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(209)))), ((int)(((byte)(102)))));
            this.btnThanhToan.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(25, 97);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(166)))), ((int)(((byte)(81)))));
            this.btnThanhToan.Size = new System.Drawing.Size(178, 48);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh toán";
            // 
            // lvHoaDon
            // 
            this.lvHoaDon.BackColor = System.Drawing.Color.White;
            this.lvHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvHoaDon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTenMon,
            this.chSoLuong,
            this.chDonGia,
            this.chThanhTien});
            this.lvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvHoaDon.HideSelection = false;
            this.lvHoaDon.Location = new System.Drawing.Point(0, 146);
            this.lvHoaDon.Name = "lvHoaDon";
            this.lvHoaDon.Size = new System.Drawing.Size(595, 434);
            this.lvHoaDon.TabIndex = 4;
            this.lvHoaDon.UseCompatibleStateImageBehavior = false;
            this.lvHoaDon.View = System.Windows.Forms.View.Details;
            // 
            // chTenMon
            // 
            this.chTenMon.Text = "Tên món";
            this.chTenMon.Width = 190;
            // 
            // chSoLuong
            // 
            this.chSoLuong.Text = "Số lượng";
            this.chSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chSoLuong.Width = 120;
            // 
            // chDonGia
            // 
            this.chDonGia.Text = "Đơn giá";
            this.chDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDonGia.Width = 135;
            // 
            // chThanhTien
            // 
            this.chThanhTien.Text = "Thành tiền";
            this.chThanhTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chThanhTien.Width = 155;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.SystemColors.Control;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(595, 751);
            this.flpTable.TabIndex = 6;
            this.flpTable.Paint += new System.Windows.Forms.PaintEventHandler(this.flpTable_Paint);
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
            this.paneText.Size = new System.Drawing.Size(1190, 51);
            this.paneText.TabIndex = 7;
            // 
            // lbText0
            // 
            this.lbText0.AutoSize = true;
            this.lbText0.BackColor = System.Drawing.Color.Transparent;
            this.lbText0.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText0.ForeColor = System.Drawing.Color.White;
            this.lbText0.Location = new System.Drawing.Point(181, 4);
            this.lbText0.Name = "lbText0";
            this.lbText0.Size = new System.Drawing.Size(328, 50);
            this.lbText0.TabIndex = 11;
            this.lbText0.Text = "DANH SÁCH BÀN";
            // 
            // panelAside
            // 
            this.panelAside.Controls.Add(this.lvHoaDon);
            this.panelAside.Controls.Add(this.panelHeader);
            this.panelAside.Controls.Add(this.panelFooter);
            this.panelAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAside.Location = new System.Drawing.Point(595, 51);
            this.panelAside.Name = "panelAside";
            this.panelAside.Size = new System.Drawing.Size(595, 751);
            this.panelAside.TabIndex = 8;
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.BorderThickness = 2;
            this.panelBody.Controls.Add(this.flpTable);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 51);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(595, 751);
            this.panelBody.TabIndex = 9;
            // 
            // frmPOS
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 802);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelAside);
            this.Controls.Add(this.paneText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.paneText.ResumeLayout(false);
            this.paneText.PerformLayout();
            this.panelAside.ResumeLayout(false);
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTenBan;
        private System.Windows.Forms.Label lbGioVao;
        private System.Windows.Forms.Label lbThanhTien;
        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lbGioRa;
        private Guna.UI2.WinForms.Guna2Panel panelFooter;
        private Guna.UI2.WinForms.Guna2Button btnThanhToan;
        private Guna.UI2.WinForms.Guna2Button btnThemMon;
        private Guna.UI2.WinForms.Guna2Button btnBan;
        private System.Windows.Forms.ListView lvHoaDon;
        private System.Windows.Forms.ColumnHeader chTenMon;
        private System.Windows.Forms.ColumnHeader chSoLuong;
        private System.Windows.Forms.ColumnHeader chDonGia;
        private System.Windows.Forms.ColumnHeader chThanhTien;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private Guna.UI2.WinForms.Guna2Panel paneText;
        private System.Windows.Forms.Label lbText0;
        private Guna.UI2.WinForms.Guna2Panel panelAside;
        private Guna.UI2.WinForms.Guna2Panel panelBody;
    }
}