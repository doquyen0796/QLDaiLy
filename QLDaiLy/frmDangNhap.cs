﻿using System;
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

namespace QLDaiLy
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieu())
            {
                BUS_NguoiDung nd = new BUS_NguoiDung();
                var user = nd.NguoiDung12(txtTenDangNhap.Text, txtMatKhau.Text);
                if (user != null)
                {
                    // Lưu ghi nhớ xuống dữ liệu
                    if (ckbGhiNho.Checked == true)
                    {
                        nd.DangNhapCu();
                        nd.NhoMatKhau(txtTenDangNhap.Text, 2);
                    }
                    else
                    {
                        nd.NhoMatKhau(txtTenDangNhap.Text, 0);
                    }
                    frmMain main = new frmMain();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    var flag = nd.DangNhap(txtTenDangNhap.Text, txtMatKhau.Text);

                    if (flag == false)
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // Lưu ghi nhớ xuống dữ liệu
                        if (ckbGhiNho.Checked == true)
                        {
                            nd.DangNhapCu();
                            nd.NhoMatKhau(txtTenDangNhap.Text, 2);
                        }
                        else
                        {
                            nd.NhoMatKhau(txtTenDangNhap.Text, 0);
                        }
                        frmMain main = new frmMain();
                        this.Hide();
                        main.Show();
                    }
                }

            }
        }


        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy dangky = new frmDangKy();
            this.Hide();
            dangky.Show();
        }


        public bool KiemTraDuLieu()
        {
            ErrorChecker.Clear();  // giả sử ban đầu mọi dữ liệu là đúng
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtTenDangNhap, "Không được để trống.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                ErrorChecker.BlinkRate = 500;
                ErrorChecker.SetError(txtMatKhau, "Không được để trống.");
                return false;
            }
            else
            {
                ErrorChecker.Clear();
            }

            return true;
        }


        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            BUS_NguoiDung nd = new BUS_NguoiDung();
            var user = nd.LayNguoiDung();
            if (user != null)
            {
                txtTenDangNhap.Text = user.TenDangNhap;
                txtMatKhau.Text = user.MatKhau;
                ckbGhiNho.Checked = true;
            }
        }

        private void txtTenDangNhap_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            BUS_NguoiDung nd = new BUS_NguoiDung();
            var user = nd.LayNguoiDungGN(txtTenDangNhap.Text);
            if (user != null)
            {
                txtMatKhau.Text = user.MatKhau;
                ckbGhiNho.Checked = true;
            }
            else
            {
                txtMatKhau.Text = "";
                ckbGhiNho.Checked = false;
            }
        }
    }
}