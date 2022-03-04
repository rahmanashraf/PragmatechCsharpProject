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
    public partial class Register : Form
    {
        public string RegisterName;
        public string RegisterSurname;
        public string RegisterEmail;

        public Register()
        {
            InitializeComponent();
            RegisterName = Registr_Name.Text;
            RegisterSurname = Registr_Surname.Text;
            RegisterEmail = Registr_Email.Text;
        }

        private void Registr_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registr_Name_Enter(object sender, EventArgs e)
        {
            if (Registr_Name.Text == "Name")
            {
                Registr_Name.Text = "";
            }
        }

        private void Registr_Name_Leave(object sender, EventArgs e)
        {
            if (Registr_Name.Text=="")
            {
                Registr_Name.Text = "Name";
                Registr_Name.ForeColor=Color.DarkRed;
            }
        }
        private void Registr_Surname_Enter(object sender, EventArgs e)
        {
            if (Registr_Surname.Text == "Surname")
            {
                Registr_Surname.Text = "";
            }
        }

        private void Registr_Surname_Leave(object sender, EventArgs e)
        {
            if (Registr_Surname.Text == "")
            {
                Registr_Surname.Text = "Surname";
                Registr_Surname.ForeColor = Color.Silver;
            }
        }

        private void Registr_Email_Enter(object sender, EventArgs e)
        {
            if (Registr_Email.Text == "E-mail")
            {
                Registr_Email.Text = "";
            }
        }

        private void Registr_Email_Leave(object sender, EventArgs e)
        {
            if (Registr_Email.Text == "")
            {
                Registr_Email.Text = "E-mail";
                Registr_Email.ForeColor = Color.Silver;
            }
        }

        private void Registr_Signup_Click(object sender, EventArgs e)
        {
            Users userler = new Users();
            //Lists lists = new Lists();
            Lists.Userlist.Add(userler);
                    
        }
    }
}
