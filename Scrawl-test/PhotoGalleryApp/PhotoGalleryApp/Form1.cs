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
        GalleryEntities db = new GalleryEntities();
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
        int selectedID;
        int defa = 30;
        int defb = 30;
        string picsize = null;
        public Form1()
        {
            InitializeComponent();
            RefreshPage();
        }
        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.ShowDialog();
            var source = ofd.FileName;
            var targetpath = $"{path}/Uploads";
            var newName = $"{new Random().Next(0, 1999)}{Path.GetExtension(source)}";
            var fileextension = Path.GetExtension(source);
            var fullfilesource = $"{targetpath}/{newName}";
            File.Copy(source, fullfilesource);
            DateTime date = DateTime.Now;
            var size = new FileInfo(ofd.FileName).Length.ToString();
            foreach (var item in db.Category)
            {
                if (item.categoryname == CatComboBox.SelectedItem.ToString())
                {
                    selectedID = item.CategoryID;
                }
            }
            var Photo = new PhotoGallery
            {
                filename = source,
                fileAdddate = date,
                fileExtension = fileextension,
                fileLocation = $"Uploads/{newName}",
                filesize = size,
                Catid = selectedID
            };
            db.PhotoGallery.Add(Photo);
            db.SaveChanges();
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string category = txtbxcateg.Text;
            var CategoryList = new Category
            {
                categoryname = category,
            };
            db.Category.Add(CategoryList);
            db.SaveChanges();
            RefreshPage();
        }
        private void RefreshPage()
        {
            pnlphoto.Controls.Clear();
            int defX = 20;
            int defY = 50;
            foreach (var item in db.Category)
            {
                var button = new Button();
                button.Text = item.categoryname;
                button.Top = defX;
                button.Left += defY;
                defY += button.Width;
                pnlphoto.Controls.Add(button);
                button.Click += WhileButtonClick;
            }
            CatComboBox.Items.Clear();
            foreach (var item in db.Category)
            {
                CatComboBox.Items.Add(item.categoryname);
            }
        }
        private void WhileButtonClick(object sender, EventArgs e)
        {
            var buttn = sender as Button;
            foreach (var item in db.Category)
            {
                if (buttn.Text == item.categoryname)
                {
                    selectedID = item.CategoryID;
                }
            }
            var photogallery = new List<PhotoGallery>();
            foreach (var item in db.PhotoGallery)
            {
                if (item.Catid == selectedID)
                {
                    photogallery.Add(item);
                }
            }
            RefreshPage();
            foreach (var item in photogallery)
            {
                AddPhotoToPanel(item);             
            }
            defa = 20;
            defb = 20;
        }
        private void AddPhotoToPanel(PhotoGallery item)
        {
            var picBox = new PictureBox();
            picBox.Name = item.id.ToString();
            int origHeight = Image.FromFile($"{path}/{item.fileLocation}").Height;
            int origWidth = Image.FromFile($"{path}/{item.fileLocation}").Width;
            picBox.Height = origHeight / 10;
            picBox.Width = origWidth / 10;
            picBox.Image = Image.FromFile($"{path}/{item.fileLocation}");
            picBox.Top = defb + 30;
            picBox.Left += defa;
            picBox.Click += getPicData;
            defa += picBox.Width + 20;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            if (defa > 700)
            {
                defb = picBox.Top * 2 + 30;
                defa = 20;
            }
            pnlphoto.Controls.Add(picBox);
            picsize = picBox.Width.ToString();
        }
        private void getPicData(object sender, EventArgs e)
        {
            MessageBox.Show(picsize);
            //var photo = sender as PictureBox;
            //foreach (var item in db.PhotoGallery)
            //{
            //    if (item.id.ToString() == photo.Name && File.Exists($"{path}/{item.fileLocation}"))
            //    {
            //        try
            //        {
            //            File.Delete($"{path}/{item.fileLocation}");
            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show($"Siz bu erroru aldiniz");
            //        }
            //        db.PhotoGallery.Remove(item);
            //    }
            //}
            //db.SaveChanges();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDeleteCat_Click(object sender, EventArgs e)
        {
        foreach (var item in db.Category)
          {
            if (CatComboBox.SelectedItem.ToString() == item.categoryname)
              {
                int choose = item.CategoryID;
                var mehsul = db.Category.Find(choose);
                db.Category.Remove(mehsul);
                db.SaveChanges();
               }
           }
        }
        
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void lastfive_Click(object sender, EventArgs e)
        {
            RefreshPage();
            List<string> date = new List<string>();
            List<DateTime> datetip = new List<DateTime>();
            List<PhotoGallery>photogallery=new List<PhotoGallery>();
            foreach (var item in db.PhotoGallery)
            {
                datetip.Add((DateTime)item.fileAdddate);
            }
            for (int o = 0; o < 5; o++)
            {
                datetip.Sort();
                datetip.Reverse();

                foreach (var photo in db.PhotoGallery.ToList())
                {

                    if (photo.fileAdddate == datetip[o])
                    {
                        photogallery.Add(photo);
                    }
                }
                foreach (var item in db.PhotoGallery)
                {
                    AddPhotoToPanel(item);
                }
                defa = 20;
                defb = 20;
            }
        }
        private void biggestfive_Click(object sender, EventArgs e)
        {
            RefreshPage();
            List<PhotoGallery> Fromdatabase = new List<PhotoGallery>();
            List<string> sizable = new List<string>();
            foreach (var item in db.PhotoGallery)
            {
                sizable.Add(item.filesize);
            }
            for (int o = 0; o < 5; o++)
            {
                sizable.Sort();
                sizable.Reverse();
                foreach (var photo in db.PhotoGallery)
                {
                    if (photo.filesize == sizable[o])
                    {
                        Fromdatabase.Add(photo);
                    }
                }
                
            }
            foreach (var photo in Fromdatabase)
            {
                AddPhotoToPanel(photo);
            }
            defa = 20;
            defb = 20;
        }

        private void menujpgcaller_Click(object sender, EventArgs e)
        {
            RefreshPage();
            string extension = ".JPG";
            foreach (var item in db.PhotoGallery)
            {
                if (item.fileExtension==extension)
                {
                    AddPhotoToPanel(item);
                }
            }
            defa = 20;
            defb = 20;
        }
        bool move;
        int move_x;
        int move_y;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            move_x = e.X;
            move_y = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - move_x, MousePosition.Y - move_y);
            }
        }
    }
}
