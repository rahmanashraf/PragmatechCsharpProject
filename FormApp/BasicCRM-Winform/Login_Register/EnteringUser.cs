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
            for (int i = 0; i < Lists.Musterilist.Count; i++)
            {
                for (int j = 0; j < Lists.Userlist.Count; j++)
                {
                    if (Lists.Userlist[j]==Lists.Musterilist[i])
                    {
                        MessageBox.Show(Lists.Userlist[i].Name);
                    }
                }
            }

            
        }
    }
}
