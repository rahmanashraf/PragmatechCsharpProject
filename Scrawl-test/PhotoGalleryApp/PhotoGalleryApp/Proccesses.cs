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
    public class Proccesses:Form
    {
        GalleryEntities db = new GalleryEntities();
        List<string> categorydata = new List<string>();
        List<int> silinesiphoto = new List<int>();
        string path = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).ToString()).ToString();
        int selectedID;
        int defa = 30;
        int defb = 30;
        //private void AddPhotoToPanel(PhotoGallery item)
        //{
        //    var picBox = new PictureBox();
        //    picBox.Name = item.id.ToString();
        //    int origHeight = Image.FromFile($"{path}/{item.fileLocation}").Height;
        //    int origWidth = Image.FromFile($"{path}/{item.fileLocation}").Width;
        //    picBox.Height = origHeight / 10;
        //    picBox.Width = origWidth / 10;
        //    picBox.Image = Image.FromFile($"{path}/{item.fileLocation}");
        //    picBox.Top = defb + 30;
        //    picBox.Left += defa;
        //    picBox.Click += getPicData;
        //    defa += picBox.Width + 20;
        //    picBox.SizeMode = PictureBoxSizeMode.StretchImage;
        //    if (defa > 700)
        //    {
        //        defb = picBox.Top * 2 + 30;
        //        defa = 20;
        //    }
        //    this.Controls.Add(picBox);
        //}
    }
}
