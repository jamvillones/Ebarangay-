using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace E_Barangay.Forms
{
    public partial class CaptureImageForm : Form
    {
        public event EventHandler<Image> OnSave;

        //Interface.IImageAcceptor acceptor;
        FilterInfoCollection fic;
        VideoCaptureDevice vcd;
        //public void GetAcceptor(Interface.IImageAcceptor i)
        //{
        //    acceptor = i;
        //}
        public CaptureImageForm()
        {
            InitializeComponent();

        }
        private Image cropImage(Image img, Rectangle cropArea)
        {
            Bitmap bmpImage = new Bitmap(img);
            Bitmap bmpCrop = bmpImage.Clone(cropArea,
            bmpImage.PixelFormat);
            return (Image)(bmpCrop);
        }


        private void CaptureImageForm_Load(object sender, EventArgs e)
        {
            fic = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in fic)
                DeviceOption.Items.Add(device.Name);

            if (DeviceOption.Items.Count == 0)
            {
                MessageBox.Show("no camera detected");
                CaptureBtn.Enabled = false;
                SaveBtn.Enabled = false;
                return;
            }

            DeviceOption.SelectedIndex = 0;
            vcd = new VideoCaptureDevice(fic[DeviceOption.SelectedIndex].MonikerString);
            vcd.NewFrame += new NewFrameEventHandler(Vcd_NewFrame);
            vcd.Start();
            this.FormClosing += CaptureImageForm_FormClosing;
            Application.ApplicationExit += Application_ApplicationExit;
        }

        private void Application_ApplicationExit(object sender, EventArgs e)
        {
            if (vcd.IsRunning)
                vcd.Stop();
        }

        private void CaptureImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ApplicationExit -= Application_ApplicationExit;
            if (vcd.IsRunning)
                vcd.Stop();
        }

        private void Vcd_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            PreviewImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void CaptureBtn_Click(object sender, EventArgs e)
        {
            //int dimension = 380;
            //Console.WriteLine(PreviewImage.Image.Size.Width);
            //Console.WriteLine(PreviewImage.Image.Size.Height);
            //var rect = new Rectangle();
            //rect.Width = rect.Height = dimension;
            //rect.X = PreviewImage.Image.Size.Width / 5 + 6;
            //rect.Y = PreviewImage.Image.Size.Height / 6 - 23;
            ////rect.X = PreviewImage.Image.Size.Width / 2 - (dimension / 2);
            ////rect.X = PreviewImage.Image.Size.Height / 2 - (dimension / 2);

            //var im = cropImage(PreviewImage.Image, rect);
            ////var im = cropAtRect(PreviewImage.Image as Bitmap, rect);
            CaptureImage.Image = PreviewImage.Image;
            SaveBtn.Enabled = true;
        }

        private void DeviceOption_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            OnSave?.Invoke(this, (Bitmap)CaptureImage.Image.Clone());
            this.Close();
        }
    }
}
