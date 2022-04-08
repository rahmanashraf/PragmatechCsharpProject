using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGalleryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.BackColor = Color.DarkBlue;
            int defX = 70;
            int defY = 50;
            InitializeComponent();
            var db = new GalleryEntities();
            foreach (var item in db.Category)
            {
                var button = new Button();
                button.Text = item.categoryname;
                button.Top = defX;
                button.Left += defY;
                defY += button.Width;


                button.BackColor = Color.White;

                this.Controls.Add(button);

            }

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            var odb = new OpenFileDialog();
            odb.ShowDialog();


            var sourcephoto = odb.FileName;
            PictureBox.ImageLocation = sourcephoto;
            pct.Left += pct.Width;
            pct.Top = 100;
            this.Controls.Add(PictureBox);






        }
    }
}
