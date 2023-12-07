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
    public partial class Revenue : Form
    {
        private Button currentButton;
        private Form activeForm;
        public Revenue()
        {
            InitializeComponent();
            btn_Close.Visible = false;
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
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {


                    btn_Close.Visible = true;
                }
            }
        }



        private void Reset()
        {


            currentButton = null;
            btn_Close.Visible = false;
        }



        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Admin_Revenue_By_Staff(), sender);
        }

        private void btn_AllProducts_MouseEnter(object sender, EventArgs e)
        {
            btn_ByStaff.Font = new Font(btn_ByStaff.Font.FontFamily, 14);
        }

        private void btn_AllProducts_MouseLeave(object sender, EventArgs e)
        {
            btn_ByStaff.Font = new Font(btn_ByStaff.Font.FontFamily, 12);
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
    }
}
