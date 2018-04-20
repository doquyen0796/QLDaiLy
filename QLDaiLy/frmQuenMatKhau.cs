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
using BUS;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace QLDaiLy
{
    public partial class frmQuenMatKhau : DevExpress.XtraEditors.XtraForm
    {
        DAL.QLDaiLyEntities db = new DAL.QLDaiLyEntities();


        public frmQuenMatKhau()
        {
            InitializeComponent();
        }


        private bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  //  giả sử ban đầu mọi dữ liệu là đúng

            BUS_NguoiDung nd = new BUS_NguoiDung();
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtEmail, "Không được để trống.");
                return false;
            }


            //  Kiểm tra Email hợp lệ
            //  https://stackoverflow.com/a/19475049/7385686
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
            //  https://docs.microsoft.com/en-us/dotnet/standard/base-types/anchors-in-regular-expressions

            string pattern = @"\A[a-z0-9]+([-._][a-z0-9]+)*@([a-z0-9]+(-[a-z0-9]+)*\.)+[a-z]{2,4}\z";

            if (txtEmail.Text.Length == 0)
            {
                ErrorChecker.Clear();
                return true;
            }
            if (Regex.IsMatch(txtEmail.Text, pattern))
            {
                if (nd.KTEmailTonTai(txtEmail.Text) == true)
                {
                    ErrorChecker.BlinkRate = 500;
                    ErrorChecker.SetError(txtEmail, "Email không tồn tại trong hệ thống.");
                    return false;
                }
            }
            if (Regex.IsMatch(txtEmail.Text, pattern) == false)
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtEmail, "Email không hợp lệ.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar) == true)
            {
                e.Handled = true;
            }
        }


        private void btnGui_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                try
                {
                    var admin = db.NguoiDungs
                              .Where(u => u.TenDangNhap == "admin")
                              .FirstOrDefault();

                    var user = db.NguoiDungs
                                 .Where(u => u.Email == txtEmail.Text)
                                 .FirstOrDefault();

                    MailAddress from = new MailAddress(admin.Email, "Admin");
                    MailAddress to = new MailAddress(txtEmail.Text, user.TenDangNhap);
                    //List<MailAddress> cc = new List<MailAddress>();
                    //cc.Add(new MailAddress("Someone@domain.topleveldomain", "Name and stuff"));

                    SendEmail("Reset mật khẩu phần mềm Quản lý đại lý", from, to);

                    MessageBox.Show(string.Format("Mật khẩu mới đã được gửi về email: \n{0}", txtEmail.Text), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        protected void SendEmail(string _subject, MailAddress _from, MailAddress _to, List<MailAddress> _cc = null, List<MailAddress> _bcc = null)
        {
            //  https://stackoverflow.com/questions/10940732/sending-emails-from-a-windows-forms-application
            //  https://www.c-sharpcorner.com/UploadFile/deepak.sharma00/send-email-from-C-Sharp-windows-application-using-gmail-smtp/

            var user = db.NguoiDungs
                         .Where(u => u.Email == txtEmail.Text)
                         .FirstOrDefault();

            string MatKhauMoi = RandomPassword();

            string Text = string.Format("<html>Xin chào {0},<br/><br/>Mật khẩu mới của bạn là: {1}<br/><br/>Vui lòng không trả lời email này. Cảm ơn.<br/><br/><br/>Phần mềm Quản lý đại lý.</html>", user.TenDangNhap, MatKhauMoi);

            // Create a new Smtp client to send our email.
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");    // smtp.gmail.com // For Gmail
                                                                   // smtp.live.com // Windows live / Hotmail
                                                                   // smtp.mail.yahoo.com // Yahoo
                                                                   // smtp.aim.com // AIM
                                                                   // my.inbox.com // Inbox

            smtp.Port = 25;  // SmtpClient.Port is used to get or set the port number used for this SMTP. It is set to "25", which is the Gmail SMTP port.

            MailMessage msgMail = new MailMessage();  // To send an email we must first create a new mailMessage(an email) to send.
            msgMail.From = _from;  // Sender e-mail address.
            msgMail.To.Add(_to);  // Recipient e-mail address.
            if (_cc != null)
            {
                foreach (MailAddress addr in _cc)
                {
                    msgMail.CC.Add(addr);
                }
            }
            if (_bcc != null)
            {
                foreach (MailAddress addr in _bcc)
                {
                    msgMail.Bcc.Add(addr);
                }
            }

            msgMail.Subject = _subject;   // Assign the subject of our message.
            msgMail.IsBodyHtml = true;
            msgMail.Body = Text;  // Create the content(body) of our message.
            //msgMail.Body = msgMail.Body.Replace(Environment.NewLine, "<br/>");
            smtp.UseDefaultCredentials = false;

            //  http://vn.ultramailer.org/page/104-xu-ly-loi-5-5-1-authentication-required-moi-nhat-khi-gui-email-hang-loat-qua-hom-gmail.html
            var admin = db.NguoiDungs
                          .Where(u => u.TenDangNhap == "admin")
                          .FirstOrDefault();

            BUS_NguoiDung nd = new BUS_NguoiDung();
            string matkhau = nd.Decrypt(admin.MatKhau);

            System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential(admin.Email, matkhau);
            smtp.Credentials = smtpCreds;

            smtp.EnableSsl = true;  // Enabling SSL(Secure Sockets Layer, encyription) is reqiured by most email providers to send mail
            smtp.Send(msgMail);  // Send our email.
            msgMail.Dispose();

            // Cập nhật mật khẩu mới
            nd.ResetMatKhau(user.MaNguoiDung, MatKhauMoi);
        }


        private string RandomPassword()
        {
            //  https://www.youtube.com/watch?v=LD32DvYDTnw

            //  these characters will be use in your random password
            string charAvailable = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            StringBuilder password = new StringBuilder();
            Random rdm = new Random();

            int passwordLength = 8;

            //  add a random character to your password until it reaches its length
            while (passwordLength-- > 0)
            {
                password.Append(charAvailable[rdm.Next(charAvailable.Length)]);
            }

            return password.ToString();
        }
    }
}