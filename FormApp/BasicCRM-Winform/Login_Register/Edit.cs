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
            EnteringUser enter = new EnteringUser();
            LoginPage login=new LoginPage();
            enter.Hide();
            login.Show();

        }

        private void Edit_Save_Click(object sender, EventArgs e)
        {
            foreach (Users item in Lists.Userlist)
            {
                if (EnteringUser.EditingName==item.Email)
                {
                    item.Email = Edit_Mail.Text;
                    item.Password = Edit_Pass.Text;
                }
                              
            }
        }
    }
}
