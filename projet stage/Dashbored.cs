using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_stage
{
    public partial class Dashbored : UserControl
    {
        public Dashbored()
        {
            InitializeComponent();
            


        }

        private void Dashbored_Load(object sender, EventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
        private void bunifuProgressBar2_progressChanged(object sender, EventArgs e)
        {

        }

        private void bunifuProgressBar2_progressChanged_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.chart1.Series["chartlinea"].Points.AddXY("lindie", 10);
            this.chart1.Series["chartlinea"].Points.AddXY("mardie", 20);
            this.chart1.Series["chartlinea"].Points.AddXY("mercredi", 30);
            this.chart1.Series["chartlinea"].Points.AddXY("jeudi", 49);
            this.chart1.Series["chartlinea"].Points.AddXY("vendredi", 10);
            this.chart1.Series["chartlinea"].Points.AddXY("samedi", 10);
            this.chart1.Series["chartlinea"].Points.AddXY("dimenche", 10);
        }
    }
}
