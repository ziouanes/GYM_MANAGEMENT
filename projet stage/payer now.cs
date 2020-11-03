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
    public partial class payer_now : Form
    {
        public payer_now()
        {
            InitializeComponent();
        }

        private void payer_now_Load(object sender, EventArgs e)
        {
            //xuiButton1.BackColor = Color.FromArgb(20,Color.Gray);

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void xuiButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
