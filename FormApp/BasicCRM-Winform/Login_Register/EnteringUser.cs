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
            string name = "";
            string id = "";
            string surname = "";
            string date = "";
            string pass = "";
            string email = "";
            for (int i = 0; i < Lists.Musterilist.Count; i++)
            {           
            for (int j = 0; j < Lists.Userlist.Count; j++)
            {
                if (Lists.Userlist[j].Email == Lists.Musterilist[i])
                {
                        name += Lists.Userlist[j].Name;
                        id+=Lists.Userlist[j].Id;
                        surname+=Lists.Userlist[j].Surname;
                        date += Lists.Userlist[j].date;
                        pass += Lists.Userlist[j].Password;
                        email += Lists.Userlist[j].Email;
                }

            }
                for (int a = -1; a < 5; a++)
                {
                    
                        Label label = new Label();
                        if (a == -1)
                        {
                            label.Text = id;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 0)
                        {
                            label.Text = name;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a== 1)
                        {
                            label.Text = surname;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 2)
                        {
                            label.Text = email;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a== 3)
                        {
                            label.Text = pass;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 4)
                        {
                            label.Text = date;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }

                    


                }
                name = "";
                id = "";
                surname = "";
                date = "";
                pass = "";
                email = "";
                Lists.Musterilist.Clear();
        }

            
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
