using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_stage
{
    public partial class pointage : Form
    {
        public pointage()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        
           

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        
        }

        private void pointage_Load(object sender, EventArgs e)
        {
            var myControl = new Dashbored();
            panel1.Controls.Add(myControl);

        }
    }
}
