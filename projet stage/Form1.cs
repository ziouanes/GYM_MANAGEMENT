using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework;
using System.Runtime.InteropServices;


namespace projet_stage
{
    public partial class body : Form
    {
        static body _obj;

        

        


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );

        public body()
        {
            InitializeComponent();
            //round corner
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

       

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {

        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

          



            // _obj = this;
            //Dashbored d = new Dashbored();
            //d.Dock = DockStyle.Fill;
            // panel.Controls.Add(d);


            //vis(d);

            //p = new paiment();
            //body.Controls.Add(p);
            //p.Dock = DockStyle.Fill;

            // this.Location = Screen.AllScreens[1].WorkingArea.Location;
        }

        

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        //void move_active(Control c)
        //{
        //    c.Left = 0;
        //    active_btn.Top = c.Top;
        //}

        //void vis(Control c = null)
        //{
        //    foreach (Control item in panel1.Controls) item.Visible = false;
        //    if (c != null) c.Visible = true;
        //}

        private void button3_Click(object sender, EventArgs e)
        {
            //move_active(btnAccueil);
            //vis(d);
        }

        
        paiment p;
        
        private void Dash_Click(object sender, EventArgs e)
        {


            //move_active(btn_dash);
            //vis(d);


        }

        private void button10_Click(object sender, EventArgs e)
        {
            //move_active(btnpaiment);
            //vis(p);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
