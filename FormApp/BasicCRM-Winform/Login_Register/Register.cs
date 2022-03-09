using Login_Register.Client;
using Login_Register.Database;
using Login_Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Login_Register.SqlVariables;

namespace Login_Register
{

    public partial class Register : Form
    {
        Lists list = new Lists();

        
        public Register()
        {
            InitializeComponent();

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
                Registr_Name.ForeColor = Color.Black;
            }
        }

        private void Registr_Name_Leave(object sender, EventArgs e)
        {
            if (Registr_Name.Text == "")
            {
                Registr_Name.Text = "Name";
                Registr_Name.ForeColor = Color.Silver;
            }
        }


        

        private void Registr_Signup_Click(object sender, EventArgs e)
        {
            //Users userler = new Users();
            //userler.Name = Registr_Name.Text;
            //userler.Surname = Registr_Surname.Text;
            //userler.Email = Registr_Email.Text;
            Random random = new Random();
            //userler.Id = random.Next(1, 1000);
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            int forum = Rnd.Next(8, 16);
            for (int i = 0; i < forum; i++)
            {
                int ASCII = Rnd.Next(33, 127);  //127
                char Karakter = Convert.ToChar(ASCII);
                StrBuild.Append(Karakter);
            }
            //userler.Password = StrBuild.ToString();
            //userler.date = DateTime.Now;           
            //Lists.Userlist.Add(userler);

            //MessageBox.Show(userler.Password);
            //Passwordunyazisi.Text = "";
            //Passwordunyazisi.Text = userler.Password;

            SqlCommand commandAdd = new SqlCommand("Insert into UserTable (UserID,UserName,UserSurname,UserPassword,UserDate,UserEmail) values (@pid,@pname,@psurname,@ppassword,@pdate,@pemail)",SqlVariable.connection);
            SqlVariable.CheckConnection(SqlVariable.connection);
            commandAdd.Parameters.AddWithValue("pid", random.Next(1, 1000));
            commandAdd.Parameters.AddWithValue("pname", Registr_Name.Text);
            commandAdd.Parameters.AddWithValue("psurname", Registr_Surname.Text); 
            commandAdd.Parameters.AddWithValue("ppassword", StrBuild.ToString());
            commandAdd.Parameters.AddWithValue("pdate", DateTime.Now);
            commandAdd.Parameters.AddWithValue("pemail", Registr_Email.Text);

            commandAdd.ExecuteNonQuery();


        }

        private void Registr_Clear_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lpg = new LoginPage();
            lpg.Show();
        }

        private void Registr_Surname_Enter(object sender, EventArgs e)
        {
            if (Registr_Surname.Text == "Surname")
            {
                Registr_Surname.Text = "";
                Registr_Name.ForeColor = Color.Black;
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
                Registr_Name.ForeColor = Color.Black;
            }
            else
            {
                Registr_Name.ForeColor = Color.Black;
            }



        }

        private void Registr_Email_Leave(object sender, EventArgs e)
        {

            if (Registr_Email.Text == "")
            {
                Registr_Email.Text = "E-mail";
                Registr_Email.ForeColor = Color.Black;
            }
        }

        
    }
}
