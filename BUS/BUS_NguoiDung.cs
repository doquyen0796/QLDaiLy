using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace BUS
{
    public class BUS_NguoiDung
    {
        DAL.QLDaiLyEntities db;

        public static bool isLogin = false;
        public static DAL.NguoiDung CurUser;

        public BUS_NguoiDung()
        {
            db = new DAL.QLDaiLyEntities();
        }


        /// <summary>
        /// Kiểm tra tên đăng nhập đã tồn tại chưa
        /// </summary>
        /// <param name="tendangnhap"></param>
        /// <returns></returns>
        public bool KTTaiKhoanTonTai(string tendangnhap)
        {
            var user = db.NguoiDungs
                         .Where(u => u.TenDangNhap == tendangnhap)
                         .FirstOrDefault();

            if (user != null)  // tên đăng nhập đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Kiểm tra email đã tồn tại chưa
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KTEmailTonTai(int mand, string email)
        {
            var user = db.NguoiDungs
                         .Where(u => u.Email == email && u.MaNguoiDung != mand)
                         .FirstOrDefault();

            if (user != null)  // email đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        /// <summary>
        /// Kiểm tra email đã tồn tại chưa
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool KTEmailTonTai(string email)
        {
            var user = db.NguoiDungs
                         .Where(u => u.Email == email)
                         .FirstOrDefault();

            if (user != null)  // email đã tồn tại
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public void DangKy(string tendangnhap, string matkhau, string email, string sodienthoai, string diachi)
        {
            try
            {
                DAL.NguoiDung u = new DAL.NguoiDung
                {
                    TenDangNhap = tendangnhap,
                    MatKhau = Encrypt(matkhau),
                    Email = email,
                    SoDienThoai = sodienthoai,
                    DiaChi = diachi,
                    Loai = -1   //  nhân viên lúc chưa được admin duyệt
                };

                db.NguoiDungs.Add(u);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool DangNhap(string tendangnhap, string matkhau)
        {
            try
            {
                string mk = Encrypt(matkhau);

                var user = db.NguoiDungs
                             .Where(u => u.TenDangNhap == tendangnhap && u.MatKhau == mk)
                             .FirstOrDefault();

                if (user != null)  // đúng tên đăng nhập và mật khẩu
                {
                    isLogin = true;
                    CurUser = user;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <returns></returns>
        public bool DangXuat()
        {
            try
            {
                isLogin = false;
                CurUser = null;

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public bool DoiThongTin(int mand, string email, string sodienthoai, string diachi)
        {
            try
            {
                if (KTEmailTonTai(mand, email))
                {
                    var user = db.NguoiDungs
                             .Where(u => u.MaNguoiDung == mand)
                             .FirstOrDefault();

                    user.Email = email;
                    user.SoDienThoai = sodienthoai;
                    user.DiaChi = diachi;

                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Mã hóa mật khẩu
        /// </summary>
        /// <param name="matkhau"></param>
        /// <returns></returns>
        public static string Encrypt(string matkhau)
        {
            string hash = "f0xle@rn";

            byte[] data = UTF8Encoding.UTF8.GetBytes(matkhau);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length); // trả về mật khẩu đã được mã hóa
                }
            }
        }
    }
}