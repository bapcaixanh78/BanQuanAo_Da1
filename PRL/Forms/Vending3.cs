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
    public partial class Vending3 : Form
    {
        public Vending3()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            using (var Ftmp = new Vending3())
            {
                Ftmp.Size = new System.Drawing.Size(1581, 758);
            }
        }
    }
}
