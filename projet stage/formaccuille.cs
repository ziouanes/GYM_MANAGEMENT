using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_stage
{
    public partial class formaccuille : Form
    {
        public formaccuille()
        {
            InitializeComponent();
        }

        Dashbored d;
        accuell a;
        paiment p;
        userRegistration r;
        UserlistClient l;
        userStaffmember s;
        userActivity Activity;
        Userabonement userabonement;

        void move_active(Control c)
        {
            c.Controls.Add(active_btn);
            active_btn.Dock = DockStyle.Left;
        }
        void vis(Control c = null)
        {
            foreach (Control item in body.Controls) item.Visible = false;
            if (c != null) c.Visible = true;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void formaccuille_Load(object sender, EventArgs e)
        {

            d = new Dashbored();
            body.Controls.Add(d);
            d.Dock = DockStyle.Fill;

            a = new accuell();
            body.Controls.Add(a);
            a.Dock = DockStyle.Fill;


            p = new paiment();
            body.Controls.Add(p);
            p.Dock = DockStyle.Fill;

            r = new userRegistration();
            body.Controls.Add(r);
            r.Dock = DockStyle.Fill;

            l = new UserlistClient();
            body.Controls.Add(l);
            l.Dock = DockStyle.Fill;

            s = new userStaffmember();
            body.Controls.Add(s);
            s.Dock = DockStyle.Fill;

            s = new userStaffmember();
            body.Controls.Add(s);
            s.Dock = DockStyle.Fill;

            Activity = new userActivity();
            body.Controls.Add(Activity);
            Activity.Dock = DockStyle.Fill;

            userabonement = new Userabonement();
            body.Controls.Add(userabonement);
            userabonement.Dock = DockStyle.Fill;

            vis(a);
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            move_active(panelAccuel);
            vis(a);

        }

        private void Dash_Click(object sender, EventArgs e)
        {
            vis(d);
            move_active(btn_dash);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            vis(r);
            move_active(panelregistre);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            vis(l);
            move_active(paneladhérents);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            move_active(panelpoint);
        }

        private void pai_Click(object sender, EventArgs e)
        {
            vis(p);
            move_active(btnpaiment);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vis(s);
            move_active(panelstaffclient);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vis(userabonement);
            move_active(panelabonnement);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vis(Activity);
            move_active(panelactivity);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
