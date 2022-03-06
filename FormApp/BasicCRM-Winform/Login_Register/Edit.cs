using Login_Register.Client;
using Login_Register.Database;
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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void Edit_Save_Click(object sender, EventArgs e)
        {
            foreach (Users item in Lists.Userlist)
            {
                if (item.Name=="Serxan")
                {
                    item.Name = Edit_Mail.Text;
                }
            }
        }
    }
}
