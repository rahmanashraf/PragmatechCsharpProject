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
        private bool PasswordCheck()
        {
            bool result = false;
            string boyukherf = Edit_Pass.Text;
            int netice = 0;
            int esasnetice = 0;
            boyukherf.ToUpper();    
            if (Edit_Pass.Text.Length>8&&Edit_Pass.Text.Length<16)
            {
                for (int i = 0; i < Edit_Pass.Text.Length; i++)
                {
                    if (Edit_Pass.Text[i]==boyukherf[i])
                    {
                        netice++;
                    }
                    if (netice>0 && char.IsDigit(Edit_Pass.Text[i]))
                    {
                        esasnetice++;
                    }
                }
            }
            if (esasnetice>0)
            {
                result = true;
            }
            return result;
        }
        private void Edit_Save_Click(object sender, EventArgs e)
        {
            foreach (Users item in Lists.Userlist)
            {
                if (EnteringUser.EditingName==item.Email)
                {
                    item.Email = Edit_Mail.Text;
                    if (PasswordCheck())
                    {
                        item.Password = Edit_Pass.Text;
                    }
                    else
                    {
                        MessageBox.Show("Parolu duzgun daxil edin");
                    }
                    
                }
                              
            }
        }
    }
}
