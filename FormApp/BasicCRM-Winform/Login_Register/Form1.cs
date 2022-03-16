using Login_Register.Client;
using Login_Register.Database;
using Login_Register.SqlVariables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            SqlCommand commandList = new SqlCommand("Select * from UserTable where UserEmail=@pmail,UserPassword=@ppassword", SqlVariable.connection);
            SqlVariable.CheckConnection(SqlVariable.connection);
            commandList.Parameters.AddWithValue("pmail", UserBox.Text);
            commandList.Parameters.AddWithValue("ppassword", PasswordBox.Text);
            SqlDataAdapter dta = new SqlDataAdapter(commandList);
            DataTable dtb = new DataTable();
            dta.Fill(dtb);
            if (dtb.Rows.Count>0)
            {
                this.Hide();
                EnteringUser enter = new EnteringUser();
                enter.Show();
            }
            else if (UserBox.Text == Admin.Email && PasswordBox.Text == Admin.Password)
            {
                this.Hide();
                GridView grd = new GridView();
                grd.Show();

            }
            else
            {
                MessageBox.Show("Duzgun daxil etmemisiniz");
            }



        }


    }
}
