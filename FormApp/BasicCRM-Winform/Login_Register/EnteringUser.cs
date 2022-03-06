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
        public static string EditingName;
        public EnteringUser()
        {
            InitializeComponent();
            for (int j = 0; j < Lists.Userlist.Count; j++)
            {
                if (Lists.Musterilist.Contains(Lists.Userlist[j].Email))
                {
                    for (int a = -1; a < 5; a++)
                    {

                        Label label = new Label();
                        if (a == -1)
                        {
                            label.Text = Lists.Userlist[j].Id.ToString();
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 0)
                        {
                            label.Text = Lists.Userlist[j].Name;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 1)
                        {
                            label.Text = Lists.Userlist[j].Surname;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 2)
                        {
                            label.Text = Lists.Userlist[j].Email;
                            Tablom.Controls.Add(label, a + 1, 0);
                            EditingName = Lists.Userlist[j].Email;
                        }
                        else if (a == 3)
                        {
                            label.Text = Lists.Userlist[j].Password;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 4)
                        {
                            label.Text = Lists.Userlist[j].date.ToString();
                            Tablom.Controls.Add(label, a + 1, 0);
                        }

                    }
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage lgp= new LoginPage();
            lgp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < Lists.Userlist.Count; j++)
            {
                if (Lists.Musterilist.Contains(Lists.Userlist[j].Email))
                {
                    for (int a = -1; a < 5; a++)
                    {

                        Label label = new Label();
                        if (a == -1)
                        {
                            label.Text = Lists.Userlist[j].Id.ToString();
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 0)
                        {
                            label.Text = Lists.Userlist[j].Name;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 1)
                        {
                            label.Text = Lists.Userlist[j].Surname;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 2)
                        {
                            label.Text = Lists.Userlist[j].Email;
                            Tablom.Controls.Add(label, a + 1, 0);
                            EditingName = Lists.Userlist[j].Email;
                        }
                        else if (a == 3)
                        {
                            label.Text = Lists.Userlist[j].Password;
                            Tablom.Controls.Add(label, a + 1, 0);
                        }
                        else if (a == 4)
                        {
                            label.Text = Lists.Userlist[j].date.ToString();
                            Tablom.Controls.Add(label, a + 1, 0);
                        }

                    }
                }

            }



        }

            
        

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            edit.Show();
        }
    }
}
