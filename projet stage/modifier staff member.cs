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
    public partial class modifier_staff_member : Form
    {
        public modifier_staff_member()
        {
            InitializeComponent();
        }

        private void bunifuSeparator3_Load(object sender, EventArgs e)
        {

        }

        private void btn_cls_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifier_staff_member_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
