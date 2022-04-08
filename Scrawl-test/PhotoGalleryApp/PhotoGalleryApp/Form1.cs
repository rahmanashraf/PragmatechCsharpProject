using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


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
            List<string> Photopath = new List<string>()
            {
                "Uploads/05.jpg",
                "Uploads/05.jpg",
                "Uploads/05.jpg",
                "Uploads/04.jpg",
                "Uploads/05.jpg"
            };

            foreach (var item in Photopath)
            {
                string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

                PictureBox pct = new PictureBox();
                pct.Image = Image.FromFile($"{path}/{item}");
                //pct.Height = 200;
                pct.Top = 100;
                pct.Left += 150;
                pct.SizeMode = PictureBoxSizeMode.Normal;
                this.Controls.Add(pct);
            }

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            var odb = new OpenFileDialog();
            odb.ShowDialog();
            
            List<string> Photopath = new List<string>()
            {
                "Uploads/01.jpg",
                "Uploads/02.jpg",
                "Uploads/03.jpg",
                "Uploads/04.jpg",
                "Uploads/05.jpg"
            };

            //foreach (var item in Photopath)
            //{
            //    var sourcephoto = odb.FileName;
            //    PictureBox pct = new PictureBox();
            //    pct.Image = Image.FromFile($"{path}/{item}");
            //    pct.Height = 200;
            //    pct.Top = 100;
            //    pct.Left += 150;
            //    pct.SizeMode = PictureBoxSizeMode.StretchImage;
            //    this.Controls.Add(pct);
            //}
            
           






        }
    }
}
