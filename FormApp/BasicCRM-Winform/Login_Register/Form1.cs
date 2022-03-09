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
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void UserBox_Enter(object sender, EventArgs e)
        {
            if (UserBox.Text=="Username")
            {
               UserBox.Text = "";
                UserBox.ForeColor = Color.Black;
            }
        }

        private void UserBox_Leave(object sender, EventArgs e)
        {
            if (UserBox.Text=="")
            {
                UserBox.Text = "Username";
                UserBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            
            if (PasswordBox.Text=="Password")
            {                
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
                
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            
            if (PasswordBox.Text=="")
            {
                PasswordBox.Text = "Password";
                PasswordBox.ForeColor = Color.Silver;
                
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registr = new Register();
            registr.Show();

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            int netice = 0;
            foreach (Users item in Lists.Userlist)
            {
                if (UserBox.Text == item.Email && PasswordBox.Text==item.Password)
                {
                    this.Hide();
                    EnteringUser enter = new EnteringUser();
                    enter.Show();
                    Lists.Musterilist.Add(UserBox.Text);
                    netice++;
                    
                }
                
            }
            if (UserBox.Text == Admin.Email && PasswordBox.Text == Admin.Password)
            {
                this.Hide();
                GridView grd = new GridView();
                grd.Show();
                netice++;
            }

            if (netice==0)
            {
                MessageBox.Show("Duzgun daxil etmemisiniz");
            }

        }


    }
}
