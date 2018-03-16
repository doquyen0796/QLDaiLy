using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLDaiLy
{
    public partial class frmSplashScreen : DevExpress.XtraEditors.XtraForm
    {
        //  Tạo biến kiểm tra tình trạng connection
        public static bool checkConnection = false;

    
        public frmSplashScreen()
        {
            InitializeComponent();
        }


        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            //  Chạy timer
            timerCheck.Start();

            //  Khởi chạy tiến trình ngầm kiểm tra kết nối dịch vụ
            backgroundWorking.RunWorkerAsync();
        }


        public void CheckConn()
        {
            string connectionString = Connection.GetConnection();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    checkConnection = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void timerCheck_Tick(object sender, EventArgs e)
        {
            if (checkConnection == false)
            {
                if (pgbRunning.Position == 100)
                {
                    timerCheck.Stop();
                    backgroundWorking.WorkerSupportsCancellation = true;
                    backgroundWorking.CancelAsync();
                    MessageBox.Show("Không thể kết nối đến cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                else
                {
                    pgbRunning.Increment(10);
                }
            }
            else
            {
                frmDangNhap frm = new frmDangNhap();
                frm.Show();
                this.Hide();
                timerCheck.Stop();
            }
        }


        private void backgroundWorking_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                CheckConn();
            }
            catch (Exception ex)
            {
                timerCheck.Stop();
                MessageBox.Show(ex.Message);
                Application.Exit();
            }
        }


        private void backgroundWorking_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pgbRunning.Position = pgbRunning.Properties.Maximum;
        }
    }
}