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
        // Đặt biến xác định trạng thái hành động của thông báo
        private frmNotification.enmAction action;
        // Vị trí thông báo trên màn hình
        private int x, y;

        public frmNotification()
        {
            InitializeComponent();
        }

        // Xác định trạng thái hành động của thông báo
        public enum enmAction
        {
            wait, start, close
        }

        // Phương thức tĩnh để hiển thị thông báo với nội dung truyền vào
        public static void showNotfication(string msg)
        {
            frmNotification notification = new frmNotification();
            notification.Opacity = 0.0;
            notification.StartPosition = FormStartPosition.Manual;
            string fname;

            // Tìm vị trí thông báo trên màn hình
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

        // Sự kiện để điều khiển quá trình hiển thị thông báo
        private void noficationTransition_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case enmAction.wait:
                    noficationTransition.Interval = 3000; // Đợi 3s
                    action = enmAction.close; // Thông báo
                    break;
                case enmAction.start:
                    noficationTransition.Interval = 1;
                    this.Opacity += 0.1; // Tăng dần độ mờ
                    if(this.x < this.Location.X)
                    {
                        this.Left--; // Di chuyển sang trái
                    }
                    else
                    {
                        if(this.Opacity == 1.0)
                        { 
                            // Khi đạt độ mờ tối da, chuyển sang trạng thái đọi
                            action = enmAction.wait;   
                        }
                    }
                    break;
                case enmAction.close:
                    noficationTransition.Interval = 1;
                    this.Opacity -= 0.1; // giảm độ mờ
                    this.Left -= 3; // di chuyển từ trái sang phải
                    if(base.Opacity == 0.0)
                    {
                        base.Close(); // Đóng form khi độ mờ bằng 0
                    }
                    break;
            }
        }


    }
}
