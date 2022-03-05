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
    public partial class EnteringUser : Form
    {
        public EnteringUser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lgp= new LoginPage();
            lgp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Users items in Lists.Musterilist)
            {

                foreach (Users item in Lists.Userlist)
                {

                    if (item.Email == items.Email)
                    {
                        MessageBox.Show(item.Name);

                    }
                }

            }
        }
    }
}
