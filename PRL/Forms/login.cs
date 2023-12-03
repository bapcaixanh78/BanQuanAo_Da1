﻿using BUS.Services;
using BUS.Utilites;
using DAL.Model;

namespace PRL.Forms
{
    public partial class login : Form
    {
        private StaffSV staffSV = new StaffSV();

        public login(StaffSV staffSV)
        {
            this.staffSV = staffSV;
        }

        public login()
        {
            InitializeComponent();
        }

        private void btn_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            btn_Exit.Font = new Font(btn_Exit.Font.FontFamily, 11);
            btn_Exit.BackColor = Color.Red;
        }

        private void btn_Exit_MouseLeave(object sender, EventArgs e)
        {
            btn_Exit.Font = new Font(btn_Exit.Font.FontFamily, 9);
            btn_Exit.BackColor = Color.Gainsboro;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Check chuỗi rỗng
            if (StaffValidate.CheckEmptyString(txt_Username.Text) == false || StaffValidate.CheckEmptyString(txt_Password.Text) == false)
            {
                MessageBox.Show("Please fill in username and password", "Log into Shirt Haven");
                return;
            }

            //Check xem có tài khoản nào trong database không
            if (StaffValidate.CheckIfAccountListIsEmpty() == true)
            {
                MessageBox.Show("Database doesn't contain any accounts");
                return;
            }

            //Đăng nhập nếu qua được validate
            Nhanvien nhanvien = staffSV.CheckStaffLogin(txt_Username.Text, txt_Password.Text);
            if(nhanvien == null)
            {
                MessageBox.Show("Account doesn't exist");
                return;
            }

            //Kiểm tra trạng thái tài khoaản
            if (nhanvien.Trangthai == "Vô hiệu hóa")
            {
                MessageBox.Show("Account Disabled");
                return;
            }

            //Kiểm tra quyền
            if (nhanvien != null && nhanvien.Quyen == 0)
            {
                MessageBox.Show(" Welcome back, " + nhanvien.Ten + ".", "Log into Shirt Haven");
                this.Hide();
                Main main = new Main()
                {
                    account = nhanvien
                };
                main.ShowDialog();
            }
            else if (nhanvien != null && nhanvien.Quyen == 1)
            {
                MessageBox.Show(" Welcome back, " + nhanvien.Ten + ".", "Log into Shirt Havenogin");
                this.Hide();
                MainNV1 mainNV = new MainNV1()
                {
                    account = nhanvien
                };
                mainNV.ShowDialog();
            }
            else
            {
                MessageBox.Show("The user name or password is incorrect. Try again.", "Log into Shirt Haven", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cb_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_showpass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;
            }
        }
    }
}