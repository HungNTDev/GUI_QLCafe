using System;
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
    public partial class frmNotification : Form
    {
        private frmNotification.enmAction action;
        private int x, y;

        public frmNotification()
        {
            InitializeComponent();
        }

        public enum enmAction
        {
            wait, start, close
        }

        public static void showNotfication(string msg)
        {
            frmNotification notification = new frmNotification();
            notification.Opacity = 0.0;
            notification.StartPosition = FormStartPosition.Manual;
            string fname;

            for(int i = 0; i < 10; i++)
            {
                fname = "notfication" + i.ToString();
                frmNotification frmNotification = (frmNotification)Application.OpenForms[fname];
                
                if(frmNotification == null)
                {
                    notification.Name = fname;
                    notification.x = Screen.PrimaryScreen.WorkingArea.Width - notification.Width + 10;
                    notification.y = Screen.PrimaryScreen.WorkingArea.Height - notification.Height * i - 5 * i - 40;
                    notification.Location = new Point(notification.x, notification.y);
                    break;
                }
            }
            notification.x = Screen.PrimaryScreen.WorkingArea.Width - notification.Width - 5;
            notification.lbMsg.Text = msg;
            notification.Show();
            notification.action = enmAction.start;
            notification.noficationTransition.Interval = 1;
            notification.noficationTransition.Start();  
        }

        private void noficationTransition_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    noficationTransition.Interval = 3000;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    noficationTransition.Interval = 1;
                    this.Opacity += 0.1;
                    if(this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        {
                            action = enmAction.wait;   
                        }
                    }
                    break;
                case enmAction.close:
                    noficationTransition.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if(base.Opacity == 0.0)
                    {
                        base.Close();   
                    }
                    break;
            }
        }


    }
}
