﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_QLCafe
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }

        public static int Status;
        public static int Amount;

        private void frmDetail_Load(object sender, EventArgs e)
        {
            txtName.Text = frmMenu.nameProduct;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Status = 1;
            Amount = Convert.ToInt32(nudAmount.Value.ToString());
            this.Close();
        }

        
    }
}
