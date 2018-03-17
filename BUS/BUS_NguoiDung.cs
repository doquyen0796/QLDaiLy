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

            if (user != null && !string.IsNullOrEmpty(email))  // email đã tồn tại
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
        

        // Lấy user
        public DAL.NguoiDung GetUser(int manguoidung)
        {
            var user = db.NguoiDungs
                         .Where(u => u.MaNguoiDung == manguoidung)
                         .FirstOrDefault();
            return user;
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


        public bool DoiMatKhau(int MaND, string MatKhauCu, string MatKhauMoi)
        {
            try
            {
                string mkcu = Encrypt(MatKhauCu);

                var user = db.NguoiDungs
                             .Where(u => u.MaNguoiDung == MaND && u.MatKhau == mkcu)
                             .FirstOrDefault();

                if (user != null)
                {
                    user.MatKhau = Encrypt(MatKhauMoi);
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
        /// Nhớ mật khẩu
        /// </summary>
        /// <param name="TenDN"></param>
        /// <param name="GN"></param>
        public void NhoMatKhau(string TenDN, int GN)
        {
            try
            {
                var user = db.NguoiDungs
                             .Where(u => u.TenDangNhap == TenDN)
                             .FirstOrDefault();

                user.GhiNho = GN;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        /// <summary>
        /// Kiểm tra xem đã có nhớ người dùng nào đăng nhập trước đó chưa,
        /// nếu có thì cập nhật về 1
        /// </summary>
        public void DangNhapCu()
        {
            try
            {
                var user = db.NguoiDungs
                             .Where(u => u.GhiNho == 2)
                             .FirstOrDefault();

                user.GhiNho = 1;

                isLogin = true;
                CurUser = user;

                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        
        /// <summary>
        /// Lấy người dùng vừa mới đăng nhập
        /// </summary>
        /// <returns></returns>
        public DAL.NguoiDung LayNguoiDung()
        {

            var user = db.NguoiDungs
                         .Where(u => u.GhiNho == 2)
                         .FirstOrDefault();
            return user;
        }


        /// <summary>
        /// Lấy người dùng đã ghi nhớ đăng nhập trước đó
        /// </summary>
        /// <param name="TenDN"></param>
        /// <returns></returns>
        public DAL.NguoiDung LayNguoiDungGN(string TenDN)
        {
            var user = db.NguoiDungs
                         .Where(u => u.GhiNho == 1 && u.TenDangNhap == TenDN)
                         .FirstOrDefault();
            return user;
        }

        
        /// <summary>
        /// Lấy người dùng với mã ghi nhớ là 1 hoặc 2
        /// </summary>
        /// <param name="TenDN"></param>
        /// <param name="MK"></param>
        /// <returns></returns>
        public DAL.NguoiDung NguoiDung12(string TenDN, string MK)
        {
            var user = db.NguoiDungs
                         .Where(u => u.GhiNho == 1 && u.MatKhau == MK || u.GhiNho == 2 && u.MatKhau == MK)
                         .FirstOrDefault();
            return user;
        }
    }
}