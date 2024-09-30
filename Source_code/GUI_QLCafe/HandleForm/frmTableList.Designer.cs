namespace GUI_QLCafe
{
    partial class frmTableList
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
            this.panelBody = new Guna.UI2.WinForms.Guna2Panel();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.lbText0 = new System.Windows.Forms.Label();
            this.paneText = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelBody.SuspendLayout();
            this.paneText.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBody
            // 
            this.panelBody.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.panelBody.BorderThickness = 2;
            this.panelBody.Controls.Add(this.flpTable);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 51);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(755, 739);
            this.panelBody.TabIndex = 12;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.BackColor = System.Drawing.SystemColors.Control;
            this.flpTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpTable.Location = new System.Drawing.Point(0, 0);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(755, 739);
            this.flpTable.TabIndex = 6;
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
            // paneText
            // 
            this.paneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(74)))));
            this.paneText.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.paneText.BorderThickness = 2;
            this.paneText.Controls.Add(this.guna2ControlBox1);
            this.paneText.Controls.Add(this.lbText0);
            this.paneText.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneText.Location = new System.Drawing.Point(0, 0);
            this.paneText.Name = "paneText";
            this.paneText.Size = new System.Drawing.Size(755, 51);
            this.paneText.TabIndex = 10;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(672, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(83, 51);
            this.guna2ControlBox1.TabIndex = 12;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // frmTableList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 790);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.paneText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTableList_Load);
            this.panelBody.ResumeLayout(false);
            this.paneText.ResumeLayout(false);
            this.paneText.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelBody;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.Label lbText0;
        private Guna.UI2.WinForms.Guna2Panel paneText;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}