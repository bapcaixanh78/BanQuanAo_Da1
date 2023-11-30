using BUS.Services;
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
            if (StaffValidate.CheckEmptyString(txt_Username.Text) == false || StaffValidate.CheckEmptyString(txt_Password.Text) == false)
            {
                MessageBox.Show("Please fill in username and password");
            }
            if (StaffValidate.CheckIfAccountListIsEmpty() == true)
            {
                MessageBox.Show("Không có tài khoản nào");
            }
            else if (StaffValidate.CheckEmptyString(txt_Username.Text) && StaffValidate.CheckEmptyString(txt_Password.Text))
            {
                Nhanvien nhanvien = staffSV.CheckStaffLogin(txt_Username.Text, txt_Password.Text);
                if (nhanvien != null && nhanvien.Quyen== 0)
                {
                    MessageBox.Show(" Login succesfully "+ nhanvien.Ten,"Inform");
                    this.Close();
                    Main main = new Main();
                    main.ShowDialog();
                }
                else if (nhanvien != null && nhanvien.Quyen == 1)
                {
                    MessageBox.Show(" Login succesfully " + nhanvien.Ten, "Inform");
                    this.Close();
                    MainNV mainNV = new MainNV();
                    mainNV.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Somthing was wrong");
                    
                }
            }
        }
    }
}