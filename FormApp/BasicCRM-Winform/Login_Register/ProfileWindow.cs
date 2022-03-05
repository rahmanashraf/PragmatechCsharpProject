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
                    label.Text = Lists.Userlist[j].Name;    
                    Tablom.Controls.Add(label, i + 1, j);
                   
                }
                              
                
            }
            
            
        }


    }
}
