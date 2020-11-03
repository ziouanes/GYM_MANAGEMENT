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
    public partial class paiment : UserControl
    {
        public paiment()
        {
            InitializeComponent();
        }

        private void paiment_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "Paiment";
                button.HeaderText = "Paiment";
                button.Text = "paier now";
                button.UseColumnTextForButtonValue = true; //dont forget this line
                this.bunifuCustomDataGrid3.Columns.Add(button);
            }
        }

        private void bunifuCustomDataGrid3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
