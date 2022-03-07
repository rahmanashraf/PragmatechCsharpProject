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
    public partial class ProfileWindow : Form
    {
        public ProfileWindow()
        {
            InitializeComponent();
            for (int i = -1; i < 5; i++)
            {
                for (int j = 0; j < Lists.Userlist.Count; j++)
                {
                    Label label = new Label();
                    if (i==-1)
                    {
                        label.Text = Lists.Userlist[j].Id.ToString();
                        Tablom.Controls.Add(label, i + 1, j);
                    }
                    else if (i==0)
                    {
                        label.Text = Lists.Userlist[j].Name;
                        Tablom.Controls.Add(label, i + 1, j);
                    }else if (i==1)
                    {
                        label.Text = Lists.Userlist[j].Surname;
                        Tablom.Controls.Add(label, i + 1, j);
                    }else if (i==2)
                    {
                        label.Text = Lists.Userlist[j].Email;
                        Tablom.Controls.Add(label, i + 1, j);
                    }else if (i==3)
                    {
                        label.Text = Lists.Userlist[j].Password;
                        Tablom.Controls.Add(label, i + 1, j);
                    }else if (i==4)
                    {
                        label.Text = Lists.Userlist[j].date.ToString();
                        Tablom.Controls.Add(label, i + 1, j);
                    }
                   
                }
                              
                
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lists.Userlist.Count; i++)
            {
                if (textBox1.Text==Lists.Userlist[i].Id.ToString())
                {
                    Lists.Userlist.RemoveAt(i);
                    

                }
            }
        }


    }
}
