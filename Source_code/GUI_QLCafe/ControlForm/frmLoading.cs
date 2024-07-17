using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using KAutoHelper;

namespace GUI_QLCafe
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void time_Loading_Tick(object sender, EventArgs e)
        {
            pbLoading.Width += 3;
            if(pbLoading.Width >= 795)
            {
                time_Loading.Stop();
                frmMainQLCF frmMainQLCF = new frmMainQLCF();
                frmMainQLCF.Show();
                this.Hide();
            }
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {

        }

        //public class ProgressReport
        //{
        //    // Tính phần trăm hoàn thành tiến trình
        //    public int PercentComplete { get; set; }
        //}

        //private Task ProgressData(List<string> list, IProgress<ProgressReport> progress)
        //{
        //    int index = 1;
        //    // Khai báo tổng số lượng phần tử trong danh sách
        //    int totalProgress = list.Count;
        //    // Tạo một đối tượng để báo cáo tiến trình
        //    var progressReport = new ProgressReport(); 
        //    return Task.Run(() => { 
        //        for(int i = 0; i < totalProgress; i++)
        //        {
        //            // Tính toán phần trăm hoàn thành
        //            progressReport.PercentComplete = index++ * 100 / totalProgress;
        //            // Báo cáo tiến trình
        //            progress.Report(progressReport);    
        //            // Giá trị này để thanh ProgressBar chạy nhanh hơn
        //            Thread.Sleep(1);
        //        }
        //    });
        //}

        //private async void frmLoading_Load(object sender, EventArgs e)
        //{
        //    List<string> list = new List<string>();     
        //    for(int i = 0; i < 1000; i++)
        //    {
        //        // Thêm 1000 phần tử vào danh sách để mô phỏng dữ liệu
        //        list.Add(i.ToString()); 
        //    }
        //    var progress = new Progress<ProgressReport>();
        //    progress.ProgressChanged += (o, report) =>
        //    {
        //        // Cập nhật trạng thái với phần trăm hoành thành
        //        lbStatus.Text = string.Format("Đang tải dữ liệu, vui lòng chờ...{0}%", report.PercentComplete);
        //        // Cập nhật giá trị của thanh progressbar
        //        progressBar.Value = report.PercentComplete;
        //        // Yêu cầu cập nhật lại giao diện của thanh progressbar
        //        progressBar.Update();
        //    };
        //    // Bắt đầu tải dữ liệu
        //    await ProgressData(list, progress);
        //    // Hiển thị form chính sau khi quá trình tải dữ liệu hoành thành
        //    frmMainQLCF frmMainQLCF = new frmMainQLCF();
        //    frmMainQLCF.Show();
        //    this.Hide();
        //}


    }
}
