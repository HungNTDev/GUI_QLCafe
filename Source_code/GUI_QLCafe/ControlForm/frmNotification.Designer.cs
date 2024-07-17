namespace GUI_QLCafe
{
    partial class frmNotification
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
            this.lbMsg = new System.Windows.Forms.Label();
            this.noficationTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bfNotfication = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.picNofication = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNofication)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.White;
            this.lbMsg.Location = new System.Drawing.Point(66, 35);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(154, 31);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "Message Text";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noficationTransition
            // 
            this.noficationTransition.Interval = 10;
            this.noficationTransition.Tick += new System.EventHandler(this.noficationTransition_Tick);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(342, 1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.Size = new System.Drawing.Size(54, 37);
            this.guna2ControlBox1.TabIndex = 3;
            // 
            // bfNotfication
            // 
            this.bfNotfication.BorderRadius = 10;
            this.bfNotfication.ContainerControl = this;
            this.bfNotfication.DockIndicatorTransparencyValue = 0.6D;
            this.bfNotfication.ShadowColor = System.Drawing.Color.Transparent;
            this.bfNotfication.TransparentWhileDrag = true;
            // 
            // picNofication
            // 
            this.picNofication.BackColor = System.Drawing.Color.Transparent;
            this.picNofication.Image = global::GUI_QLCafe.Properties.Resources.information;
            this.picNofication.ImageRotate = 0F;
            this.picNofication.Location = new System.Drawing.Point(26, 34);
            this.picNofication.Name = "picNofication";
            this.picNofication.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picNofication.Size = new System.Drawing.Size(34, 32);
            this.picNofication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNofication.TabIndex = 2;
            this.picNofication.TabStop = false;
            this.picNofication.UseTransparentBackground = true;
            // 
            // frmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 100);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.picNofication);
            this.Controls.Add(this.lbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotification";
            this.Text = "frmNotification";
            ((System.ComponentModel.ISupportInitialize)(this.picNofication)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Timer noficationTransition;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        public Guna.UI2.WinForms.Guna2CirclePictureBox picNofication;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfNotfication;
    }
}