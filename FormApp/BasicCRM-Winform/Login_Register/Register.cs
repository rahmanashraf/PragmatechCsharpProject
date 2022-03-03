using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_EmailBox_Enter(object sender, EventArgs e)
        {
            if (Register_EmailBox.Text=="E-mail")
            {
                Register_EmailBox.Text = "";
            }
        }

        private void Register_EmailBox_Leave(object sender, EventArgs e)
        {
            if (Register_EmailBox.Text=="")
            {
                Register_EmailBox.Text = "E-mail";
            }
        }
    }
}
