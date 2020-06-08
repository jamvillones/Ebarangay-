using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Barangay.Forms
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void cropBtn_Click(object sender, EventArgs e)
        {
            //Rectangle cropRect = new Rectangle(0,0,100,100);
            //Bitmap src = sourceImage.Image as Bitmap;
            //Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            //using (Graphics g = Graphics.FromImage(target))
            //{
            //    g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
            //                     cropRect,
            //                     GraphicsUnit.Pixel);
            //}
            var rect = new Rectangle();
            rect.X = sourceImage.Image.Size.Width / 4;
            rect.Y = sourceImage.Image.Size.Height / 4;
            rect.Width = 200;
            rect.Height = 200;
            resImage.Image = cropImage(sourceImage.Image,rect);

        }
        public static Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }
    }
}
