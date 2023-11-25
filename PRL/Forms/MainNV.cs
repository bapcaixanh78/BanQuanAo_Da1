using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRL.Forms
{
    public partial class MainNV : Form
    {
        private Button currentButton;
        private Form activeForm;
        public MainNV()
        {
            InitializeComponent();
            btnCloseChildForm.Visible = false;

        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pn_ChucNang.Controls.Add(childForm);
            this.pn_ChucNang.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {

                    btnCloseChildForm.Visible = true;

                }
            }
        }



        private void Reset()
        {


            currentButton = null;
            btnCloseChildForm.Visible = false;

        }

        private void btn_HoaDon_MouseEnter(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 14);
        }

        private void btn_HoaDon_MouseLeave(object sender, EventArgs e)
        {
            btn_HoaDon.Font = new Font(btn_HoaDon.Font.FontFamily, 12);
        }

        private void btn_BanHang_MouseEnter(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 14);
        }

        private void btn_BanHang_MouseLeave(object sender, EventArgs e)
        {
            btn_BanHang.Font = new Font(btn_BanHang.Font.FontFamily, 12);
        }

        private void btn_ThongKe_MouseEnter(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 14);
        }

        private void btn_ThongKe_MouseLeave(object sender, EventArgs e)
        {
            btn_ThongKe.Font = new Font(btn_ThongKe.Font.FontFamily, 12);
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Bill(), sender);
        }

        private void btn_BanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Vending2(), sender);
        }

        

        private void btn_DangXuat_Click(object sender, EventArgs e)
        {
            var option = MessageBox.Show("Confirm logout", "Confirm", MessageBoxButtons.YesNo);
            if (option == DialogResult.Yes)
            {
                login login = new login();
                login.Show();
                this.Hide();


            }
            else
            {
                return;
            }
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void btn_ThongKe_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Statistics(), sender);
        }
    }
}
