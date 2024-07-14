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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotification));
            this.lbMsg = new System.Windows.Forms.Label();
            this.picSuccess = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.noficationTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.bfNotfication = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMsg
            // 
            this.lbMsg.AutoSize = true;
            this.lbMsg.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMsg.ForeColor = System.Drawing.Color.White;
            this.lbMsg.Location = new System.Drawing.Point(66, 37);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(152, 31);
            this.lbMsg.TabIndex = 0;
            this.lbMsg.Text = "Message Text";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picSuccess
            // 
            this.picSuccess.BackColor = System.Drawing.Color.Transparent;
            this.picSuccess.Image = ((System.Drawing.Image)(resources.GetObject("picSuccess.Image")));
            this.picSuccess.ImageRotate = 0F;
            this.picSuccess.Location = new System.Drawing.Point(26, 36);
            this.picSuccess.Name = "picSuccess";
            this.picSuccess.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picSuccess.Size = new System.Drawing.Size(34, 32);
            this.picSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSuccess.TabIndex = 2;
            this.picSuccess.TabStop = false;
            this.picSuccess.UseTransparentBackground = true;
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
            // frmNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(400, 101);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.picSuccess);
            this.Controls.Add(this.lbMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNotification";
            this.Text = "frmNotification";
            ((System.ComponentModel.ISupportInitialize)(this.picSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMsg;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picSuccess;
        private System.Windows.Forms.Timer noficationTransition;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm bfNotfication;
    }
}