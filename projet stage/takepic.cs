using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace projet_stage
{
    public partial class takepic : Form
    {
        public takepic()
        {
            InitializeComponent();
        }

        // Create class-level accesible variables
        VideoCapture capture;
        Mat frame;
        Bitmap image;
        private Thread camera;
        bool isCameraRunning = false;


        // Declare required methods
        private void CaptureCamera()
        {
            camera = new Thread(new ThreadStart(CaptureCameraCallback));
            camera.Start();
        }

        private void CaptureCameraCallback()
        {

            frame = new Mat();
            capture = new VideoCapture(0);
            capture.Open(0);

            if (capture.IsOpened())
            {
                while (isCameraRunning)
                {

                    capture.Read(frame);
                    image = BitmapConverter.ToBitmap(frame);
                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose();
                    }
                    pictureBox2.Image = image;
                }
            }
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void takepic_Load(object sender, EventArgs e)
        {

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text.Equals("Start"))
            {
                CaptureCamera();
                button1.Text = "Stop";
                button2.Visible = false;
                isCameraRunning = true;
            }
            else
            {
                capture.Release();
                button1.Text = "Start";
                button2.Visible = true;
                isCameraRunning = false;
            }
        }
        public static string save = "";

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
              if (!isCameraRunning)
            {
                // Take snapshot of the current image generate by OpenCV in the Picture Box
                Bitmap snapshot = new Bitmap(pictureBox2.Image);

                // Save in some directory
                // in this example, we'll generate a random filename e.g 47059681-95ed-4e95-9b50-320092a3d652.png
                // snapshot.Save(@"C:\Users\sdkca\Desktop\mysnapshot.png", ImageFormat.Png);
                //snapshot.Save(string.Format(@"C:\Users\android-00\source\repos\projet stage\projet stage\source_pic\{0}.png", Guid.NewGuid()),ImageFormat.Png);
                //  save = "pic1.jpeg";

                string s = string.Format(@"C:\Users\android-00\source\repos\projet stage\projet stage\source_pic\{0}.png", Guid.NewGuid());
                snapshot.Save(s, ImageFormat.Png);
                save = s;

                this.Close();

            }
            //else
            //{
            //    MessageBox.Show("error");
            //}
        }
    }
}
