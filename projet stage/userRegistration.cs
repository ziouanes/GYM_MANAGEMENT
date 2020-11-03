using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace projet_stage
{
    public partial class userRegistration : UserControl
    {
        public userRegistration()
        {
            InitializeComponent();

            
        }

        public static string passinglienpic;

        public static void CleanForm(Control frm)
        {
            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {

                    control.ResetText();
                }
                if (control is ComboBox)
                {
                    control.ResetText();
                }
                if (control is DateTimePicker)
                {
                    control.ResetText();
                }
                if (control is CheckedListBox)
                {
                    control.ResetText();
                }

            }
        }

        string strmode = string.Empty;

        public string Strmode
        {
            get { return strmode; }
            set { strmode = value; }
        }


        

        private void button4_Click(object sender, EventArgs e)
        {
            

            
            takepic t1 = new takepic();

            t1.ShowDialog();

            lien_pic.Text = takepic.save.ToString();
        }

        private void userRegistration_Load(object sender, EventArgs e)
        {

            Random slumpGenerator = new Random();
            int tal = slumpGenerator.Next(0, 100000000);
            txt_id_qrcode.Text = tal.ToString();


            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txt_id_qrcode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQrcode.Image = code.GetGraphic(5);


            lien_pic.Text = takepic.save;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random slumpGenerator = new Random();
            int tal = slumpGenerator.Next(0, 100000000);
            txt_id_qrcode.Text = tal.ToString();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txt_id_qrcode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQrcode.Image = code.GetGraphic(5);





            //if (txtnom.Text == "" || txt_adress.Text == "" || txt_cart.Text == "" || txt_email.Text == "")
            //{
            //    errorProvider1.SetError()
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random slumpGenerator = new Random();
            int tal = slumpGenerator.Next(0, 100000000);
            txt_id_qrcode.Text = tal.ToString();

            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(txt_id_qrcode.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            picQrcode.Image = code.GetGraphic(5);

            CleanForm(groupBox2);
            CleanForm(groupBox3);
            CleanForm(groupBox4);
            CleanForm(groupBox5);

        }

        private void lien_pic_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private bool isCollapsed;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button5.Image = Resource1.collapse_arrow_24px;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button5.Image = Resource1.expand_arrow_24px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
