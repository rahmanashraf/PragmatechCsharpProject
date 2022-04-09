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
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
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
            

          
                string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();

                //PictureBox pct = new PictureBox();
                //pct.Image = Image.FromFile($"{path}/{item}");
                ////pct.Height = 200;
                //pct.Top = 100;
                //pct.Left += 150;
                //pct.SizeMode = PictureBoxSizeMode.Normal;
                //this.Controls.Add(pct);
            

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();

            var source = ofd.FileName;
            var targetpath = $"{path}/Uploads";
            var newName=$"{new Random().Next(0,1999)}{Path.GetExtension(source)}";
            var fullfilesource = $"{targetpath}/{newName}";
            File.Copy(source,fullfilesource);
            int origHeight = Image.FromFile(fullfilesource).Height;
            int origWidth = Image.FromFile(fullfilesource).Width;
            pctbox.Height = origHeight/10;
            pctbox.Width=origWidth/10;
            pctbox.SizeMode = PictureBoxSizeMode.StretchImage;
            pctbox.Image = Image.FromFile(fullfilesource);
           
            
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
